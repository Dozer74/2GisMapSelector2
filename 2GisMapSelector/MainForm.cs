using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GisSelector.Properties;
using GrymCore;

namespace GisSelector
{
    public partial class MainForm : Form
    {
        DataBase db = new DataBase();
        static Grym pGrymCore;
        static IBaseReference pBaseRef;
        static IBaseViewThread pBaseView;

        public MainForm()
        {
            InitializeComponent();
        }

        
        private void MainForm_Shown(object sender, EventArgs e)
        {
            Init2Gis();
            LoadSettings();
            db = DeserializeDatabase("data.bin");
            btnSearch.Focus();
        }

        private void LoadSettings()
        {
            ChangePosition(ps.FormPosition);
            TopMost = ps.FormStayOnTop;
            MenuSelectionHouse.Checked = ps.SelectionHouse;
        }

        private void Init2Gis()
        {
            try
            {
                pGrymCore = new Grym();
                pBaseRef = pGrymCore.BaseCollection.FindBase("Челябинск");
                pBaseView = pGrymCore.GetBaseView(pBaseRef, true, false);
                pBaseView.Activate(3);//на весь экран
                Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.InitErrorMsg + ex.Message, 
                    @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DataBase DeserializeDatabase(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show(Resources.BaseNotFoundMsg, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            var bf = new BinaryFormatter();
            Stream stream = File.OpenRead(path);
            var database = (DataBase)bf.Deserialize(stream);
            stream.Close();
            return database;
        }

        void SearchInDataBase()
        {

            if (tbNumber.Text == "" && tbStreet.Text == "")
                return;

            if (db==null)
            {
                MessageBox.Show(Resources.BaseNotFoundMsg,
                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selection = pBaseView.Frame.Map.GetSelection("My_Sel", true);
            selection.Color = ColorToUInt(ps.SelectionColor);
            
            var paternNumber = ConvertToPattern(tbNumber.Text);
            var paternStreet = ConvertToPattern(tbStreet.Text);

            Regex rNum, rStreet;
            try
            {
                rNum = new Regex(paternNumber, RegexOptions.IgnoreCase);
                rStreet = new Regex(paternStreet, RegexOptions.IgnoreCase);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.BadRegexMsg, @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            ClearResults();
            foreach (var city in db.GetCities())
            {
                foreach (var street in city.GetStreets().Where(s => rStreet.IsMatch(s.StreetName)))
                {

                    foreach (var number in street.GetBuildings().Where(n => rNum.IsMatch(n)))
                    {
                        if (city.Name != "Челябинск")
                            lbResult.Items.Add(city.Name + ", " + street.StreetName + ", " + number);
                        else
                            lbResult.Items.Add(street.StreetName + ", " + number);

                        if (!ps.SelectionHouse) 
                            continue;

                        IFeature feature;
                        var query = pBaseView.Database.CreateQuery("map_building");
                        query.AddCriterion("number", number);
                        query.AddCriterion("street", street.StreetName);
                        query.Execute();
                        if ((feature = (IFeature) query.Fetch()) != null)
                        {
                            selection.AddFeature(feature);
                        }
                    }
                }
            }
        }

        private static string ConvertToPattern(string line)
        {
            line = line.Replace("*", ".*").Replace("?", ".?").Replace("+", ".+");

            if (line.Trim() == "")
                line = ".*";
            else
                line = "^.*" + line.Trim();
            return line;
        }


        private void ResultListbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbResult.SelectedItem != null)
            {
                SelectOnMap(lbResult.SelectedItem.ToString());
            }  

        }

        private static void SelectOnMap(string adress)
        {
            var s = adress.Split(',');
            var cmdLineStr = s.Length==3 
                ? $"!find:map_building \"{s[0].Trim()}\" \"{s[1].Trim()}\" \"{s[2].Trim()}\" !select:zoom"
                : $"!find:map_building \"Челябинск\" \"{s[0].Trim()}\" \"{s[1].Trim()}\" !select:zoom";

            var cmdLine = pBaseView.Factory.ParseCommandLine(cmdLineStr);
            pBaseView.ExecuteCommandLine(cmdLine);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchInDataBase();
            tbStreet.Focus();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            ps.Save();
        }

        private static uint ColorToUInt(Color c)
        {
            return (uint)(((c.A << 24) | (c.R) | (c.G << 8) | c.B << 16) & 0xffffffffL);
        }

        private void ClearResults()
        {
            lbResult.Items.Clear();
            var sel = pBaseView.Frame.Map.GetSelection("My_Sel", true);
            sel.RemoveAllFeatures();
        }



        private void DBUpdateMenu_Click(object sender, EventArgs e)
        {
            var ff = new UpdateForm(pBaseView);
            if (ff.ShowDialog() != DialogResult.OK)
                return;
            db = ff.db;
            ff.Dispose();
        }

        #region Menu Code

        readonly Settings ps = Settings.Default;

        private void MenuSelectionColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            ps.SelectionColor = colorDialog1.Color;
        }

        private void MenuSelectionHouse_Click(object sender, EventArgs e)
        {
            ps.SelectionHouse = MenuSelectionHouse.Checked = !MenuSelectionHouse.Checked;
        }

        private void MenuStayOnTop_Click(object sender, EventArgs e)
        {
            TopMost = ps.FormStayOnTop = MenuStayOnTop.Checked = !MenuStayOnTop.Checked;
        }

        private void слеваВнизуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pos = Convert.ToByte(((ToolStripMenuItem)sender).Tag);
            ps.FormPosition = pos;
            ChangePosition(pos);

        }

        private void ChangePosition(byte pos)
        {
            switch (pos)
            {
                case 0://слева внизу
                    {
                        Left = 0;
                        Top = Screen.PrimaryScreen.WorkingArea.Bottom - Height;
                        break;
                    }
                case 1://справа внизу
                    {
                        Left = Screen.PrimaryScreen.WorkingArea.Right - Width;
                        Top = Screen.PrimaryScreen.WorkingArea.Bottom - Height;
                        break;
                    }
                case 2://слева вверху
                    {
                        Left = 0;
                        Top = 0;
                        break;
                    }
                case 3:
                    {
                        Left = Screen.PrimaryScreen.WorkingArea.Right - Width;
                        Top = 0;
                        break;
                    }
            }
        }
        #endregion

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter) return;

            SearchInDataBase();
            tbStreet.Focus();
        }
    }
}
