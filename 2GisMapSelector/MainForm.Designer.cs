using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GisSelector
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbResult = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSelectionColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSelectionHouse = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваВнизуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справаВнизуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваВверхуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справаВверхуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStayOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.DBUpdateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tbNumber = new GisSelector.PlaceHolderTextBox();
            this.tbStreet = new GisSelector.PlaceHolderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 20;
            this.lbResult.Location = new System.Drawing.Point(12, 89);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(296, 284);
            this.lbResult.TabIndex = 4;
            this.lbResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ResultListbox_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettings,
            this.MenuDataBase});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuSettings
            // 
            this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSelection,
            this.MenuPosition,
            this.MenuStayOnTop});
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(78, 20);
            this.MenuSettings.Text = "Настройка";
            // 
            // MenuSelection
            // 
            this.MenuSelection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSelectionColor,
            this.MenuSelectionHouse});
            this.MenuSelection.Name = "MenuSelection";
            this.MenuSelection.Size = new System.Drawing.Size(140, 22);
            this.MenuSelection.Text = "Выделение";
            // 
            // MenuSelectionColor
            // 
            this.MenuSelectionColor.Name = "MenuSelectionColor";
            this.MenuSelectionColor.Size = new System.Drawing.Size(221, 22);
            this.MenuSelectionColor.Text = "Выбрать цвет";
            this.MenuSelectionColor.Click += new System.EventHandler(this.MenuSelectionColor_Click);
            // 
            // MenuSelectionHouse
            // 
            this.MenuSelectionHouse.Name = "MenuSelectionHouse";
            this.MenuSelectionHouse.Size = new System.Drawing.Size(221, 22);
            this.MenuSelectionHouse.Text = "Выделять найденные дома";
            this.MenuSelectionHouse.Click += new System.EventHandler(this.MenuSelectionHouse_Click);
            // 
            // MenuPosition
            // 
            this.MenuPosition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.слеваВнизуToolStripMenuItem,
            this.справаВнизуToolStripMenuItem,
            this.слеваВверхуToolStripMenuItem,
            this.справаВверхуToolStripMenuItem});
            this.MenuPosition.Name = "MenuPosition";
            this.MenuPosition.Size = new System.Drawing.Size(140, 22);
            this.MenuPosition.Text = "Положение";
            // 
            // слеваВнизуToolStripMenuItem
            // 
            this.слеваВнизуToolStripMenuItem.Name = "слеваВнизуToolStripMenuItem";
            this.слеваВнизуToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.слеваВнизуToolStripMenuItem.Tag = "0";
            this.слеваВнизуToolStripMenuItem.Text = "Слева внизу";
            this.слеваВнизуToolStripMenuItem.Click += new System.EventHandler(this.слеваВнизуToolStripMenuItem_Click);
            // 
            // справаВнизуToolStripMenuItem
            // 
            this.справаВнизуToolStripMenuItem.Name = "справаВнизуToolStripMenuItem";
            this.справаВнизуToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.справаВнизуToolStripMenuItem.Tag = "1";
            this.справаВнизуToolStripMenuItem.Text = "Справа внизу";
            this.справаВнизуToolStripMenuItem.Click += new System.EventHandler(this.слеваВнизуToolStripMenuItem_Click);
            // 
            // слеваВверхуToolStripMenuItem
            // 
            this.слеваВверхуToolStripMenuItem.Name = "слеваВверхуToolStripMenuItem";
            this.слеваВверхуToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.слеваВверхуToolStripMenuItem.Tag = "2";
            this.слеваВверхуToolStripMenuItem.Text = "Слева вверху";
            this.слеваВверхуToolStripMenuItem.Click += new System.EventHandler(this.слеваВнизуToolStripMenuItem_Click);
            // 
            // справаВверхуToolStripMenuItem
            // 
            this.справаВверхуToolStripMenuItem.Name = "справаВверхуToolStripMenuItem";
            this.справаВверхуToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.справаВверхуToolStripMenuItem.Tag = "3";
            this.справаВверхуToolStripMenuItem.Text = "Справа вверху";
            this.справаВверхуToolStripMenuItem.Click += new System.EventHandler(this.слеваВнизуToolStripMenuItem_Click);
            // 
            // MenuStayOnTop
            // 
            this.MenuStayOnTop.Checked = true;
            this.MenuStayOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuStayOnTop.Name = "MenuStayOnTop";
            this.MenuStayOnTop.Size = new System.Drawing.Size(140, 22);
            this.MenuStayOnTop.Text = "Поверх всех";
            this.MenuStayOnTop.Click += new System.EventHandler(this.MenuStayOnTop_Click);
            // 
            // MenuDataBase
            // 
            this.MenuDataBase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DBUpdateMenu});
            this.MenuDataBase.Name = "MenuDataBase";
            this.MenuDataBase.Size = new System.Drawing.Size(86, 20);
            this.MenuDataBase.Text = "База данных";
            // 
            // DBUpdateMenu
            // 
            this.DBUpdateMenu.Name = "DBUpdateMenu";
            this.DBUpdateMenu.Size = new System.Drawing.Size(128, 22);
            this.DBUpdateMenu.Text = "Обновить";
            this.DBUpdateMenu.Click += new System.EventHandler(this.DBUpdateMenu_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.Red;
            this.colorDialog1.FullOpen = true;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.imageList;
            this.btnSearch.Location = new System.Drawing.Point(268, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "SearchBtnImg");
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumber.ForeColor = System.Drawing.Color.Gray;
            this.tbNumber.Location = new System.Drawing.Point(156, 49);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.PlaceHolderText = "Номер дома";
            this.tbNumber.Size = new System.Drawing.Size(106, 26);
            this.tbNumber.TabIndex = 2;
            this.tbNumber.Text = "Номер дома";
            this.tbNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStreet.ForeColor = System.Drawing.Color.Gray;
            this.tbStreet.Location = new System.Drawing.Point(12, 49);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.PlaceHolderText = "Улица";
            this.tbStreet.Size = new System.Drawing.Size(138, 26);
            this.tbStreet.TabIndex = 1;
            this.tbStreet.Text = "Улица";
            this.tbStreet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск адреса:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(255, 411);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "2GisSelector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbResult;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuSettings;
        private ToolStripMenuItem MenuSelection;
        private ToolStripMenuItem MenuSelectionColor;
        private ToolStripMenuItem MenuSelectionHouse;
        private ToolStripMenuItem MenuPosition;
        private ToolStripMenuItem слеваВнизуToolStripMenuItem;
        private ToolStripMenuItem справаВнизуToolStripMenuItem;
        private ToolStripMenuItem слеваВверхуToolStripMenuItem;
        private ToolStripMenuItem справаВверхуToolStripMenuItem;
        private ToolStripMenuItem MenuStayOnTop;
        private ToolStripMenuItem MenuDataBase;
        private ToolStripMenuItem DBUpdateMenu;
        private ColorDialog colorDialog1;
        private PlaceHolderTextBox tbStreet;
        private PlaceHolderTextBox tbNumber;
        private Button btnSearch;
        private ImageList imageList;
        private Label label1;
    }
}

