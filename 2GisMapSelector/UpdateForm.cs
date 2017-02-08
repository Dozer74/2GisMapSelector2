using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using GrymCore;

namespace GisSelector
{
    public partial class UpdateForm : Form
    {

        public DataBase db;
        bool canceled = false;
        IBaseViewThread pBaseView;

        public UpdateForm(IBaseViewThread pBaseView)
        {
            this.pBaseView = pBaseView;
            InitializeComponent();
        }

        private void UpdateDataBaseForm_Shown(object sender, EventArgs e)
        {
            for (var i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Обновить")
            {
                canceled = false;
                bw.RunWorkerAsync();
                progressBar1.Style = ProgressBarStyle.Marquee;
                button3.Text = "Стоп!";
            }
            else if (button3.Text == "Стоп!")
            {
                bw.CancelAsync();
                canceled = true;
                button3.Text = "Обновить";
            }
            else if (button3.Text == "Ок")
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void SerializeDataBase(DataBase db)
        {
            var bf = new BinaryFormatter();
            Stream stream = File.Create("data.bin");
            bf.Serialize(stream, db);
            stream.Close();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var query = pBaseView.Database.CreateQuery("street");
            IDataRow f;
            db = new DataBase();

            foreach (string cityName in checkedListBox1.CheckedItems)
            {
                lbCity.Invoke(new Action(() => 
                {
                    lbCity.Text = cityName;
                }));
                var city = new City(cityName);

                query.AddCriterion("city_name", cityName);
                query.Execute();

                while ((f = query.Fetch()) != null)
                {
                    string streetName;
                    if ((streetName = f.get_Value("name")) != "")
                    {
                        lbStreet.Invoke( new Action( () => lbStreet.Text = streetName));
                        var street = new Street(streetName);
                        var q = pBaseView.Database.CreateQuery("address");
                        q.AddCriterion("street_index", f.Index);
                        q.Execute();

                        IDataRow row;

                        while ((row = q.Fetch()) != null)
                        {
                            if (bw.CancellationPending)
                                return;
                            street.AddBuilding(row.get_Value("number"));
                        }

                        city.AddStreet(street);
                    }
                }
                db.AddCity(city);
            }

            Invoke(new Action(() =>
            {
                lbCity.Text = "Сохранение базы...";
                lbStreet.Text = "";
            }));
            SerializeDataBase(db);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbStreet.Text = "";
            progressBar1.Style = ProgressBarStyle.Blocks;
            if (!canceled)
            {
                lbCity.Text = "Готово!";
                button3.Text = "Ок";
            }
            else lbCity.Text = "Отменено!";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="Выбрать все")
            {
                button1.Text = "Снять все";
                for (var i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            else
            {
                button1.Text = "Выбрать все";
                for (var i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }
       
    }
}
