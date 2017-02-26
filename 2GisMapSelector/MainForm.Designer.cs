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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ResultListbox = new System.Windows.Forms.ListBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultListbox
            // 
            this.ResultListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResultListbox.FormattingEnabled = true;
            this.ResultListbox.ItemHeight = 20;
            this.ResultListbox.Location = new System.Drawing.Point(18, 158);
            this.ResultListbox.Name = "ResultListbox";
            this.ResultListbox.Size = new System.Drawing.Size(291, 204);
            this.ResultListbox.TabIndex = 4;
            this.ResultListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ResultListbox_MouseDoubleClick);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumberTextBox.Location = new System.Drawing.Point(110, 69);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(199, 29);
            this.NumberTextBox.TabIndex = 1;
            this.NumberTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumberTextBox_KeyUp);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SearchButton.Location = new System.Drawing.Point(18, 113);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(146, 39);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettings,
            this.MenuDataBase});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(322, 24);
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
            this.DBUpdateMenu.Size = new System.Drawing.Size(152, 22);
            this.DBUpdateMenu.Text = "Обновить";
            this.DBUpdateMenu.Click += new System.EventHandler(this.DBUpdateMenu_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNumber.Location = new System.Drawing.Point(12, 72);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(69, 24);
            this.labelNumber.TabIndex = 10;
            this.labelNumber.Text = "Номер";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.Red;
            this.colorDialog1.FullOpen = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ClearButton.Location = new System.Drawing.Point(170, 113);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(116, 39);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.StreetTextBox.Location = new System.Drawing.Point(110, 34);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(199, 29);
            this.StreetTextBox.TabIndex = 0;
            this.StreetTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumberTextBox_KeyUp);
            // 
            // labelStreet
            // 
            this.labelStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelStreet.Location = new System.Drawing.Point(14, 34);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(64, 24);
            this.labelStreet.TabIndex = 10;
            this.labelStreet.Text = "Улица";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 392);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.ResultListbox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(255, 411);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "2GisSelector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Shown += new System.EventHandler(this.IsMainFormDisplayed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ResultListbox;
        private TextBox NumberTextBox;
        private Button SearchButton;
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
        private Label labelNumber;
        private ColorDialog colorDialog1;
        private Button ClearButton;
        private TextBox StreetTextBox;
        private Label labelStreet;
    }
}

