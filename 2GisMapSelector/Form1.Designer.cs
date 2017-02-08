using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GisSelector
{
    partial class Form1
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
            var resources = new ComponentResourceManager(typeof(Form1));
            this.listBox1 = new ListBox();
            this.tbNumber = new TextBox();
            this.btnSearch = new Button();
            this.menuStrip1 = new MenuStrip();
            this.MenuSettings = new ToolStripMenuItem();
            this.MenuSelection = new ToolStripMenuItem();
            this.MenuSelectionColor = new ToolStripMenuItem();
            this.MenuSelectionHouse = new ToolStripMenuItem();
            this.MenuPosition = new ToolStripMenuItem();
            this.слеваВнизуToolStripMenuItem = new ToolStripMenuItem();
            this.справаВнизуToolStripMenuItem = new ToolStripMenuItem();
            this.слеваВверхуToolStripMenuItem = new ToolStripMenuItem();
            this.справаВверхуToolStripMenuItem = new ToolStripMenuItem();
            this.MenuStayOnTop = new ToolStripMenuItem();
            this.MenuDataBase = new ToolStripMenuItem();
            this.MenuDataBaseUpdate = new ToolStripMenuItem();
            this.label1 = new Label();
            this.colorDialog1 = new ColorDialog();
            this.button5 = new Button();
            this.tbStreet = new TextBox();
            this.label2 = new Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.listBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new Point(18, 158);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new Size(208, 204);
            this.listBox1.TabIndex = 4;
            this.listBox1.MouseDoubleClick += new MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.tbNumber.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.tbNumber.Location = new Point(110, 69);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new Size(116, 38);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.KeyUp += new KeyEventHandler(this.textBox1_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new Point(18, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(146, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.MenuSettings,
            this.MenuDataBase});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(239, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuSettings
            // 
            this.MenuSettings.DropDownItems.AddRange(new ToolStripItem[] {
            this.MenuSelection,
            this.MenuPosition,
            this.MenuStayOnTop});
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new Size(78, 20);
            this.MenuSettings.Text = "Настройка";
            // 
            // MenuSelection
            // 
            this.MenuSelection.DropDownItems.AddRange(new ToolStripItem[] {
            this.MenuSelectionColor,
            this.MenuSelectionHouse});
            this.MenuSelection.Name = "MenuSelection";
            this.MenuSelection.Size = new Size(152, 22);
            this.MenuSelection.Text = "Выделение";
            // 
            // MenuSelectionColor
            // 
            this.MenuSelectionColor.Name = "MenuSelectionColor";
            this.MenuSelectionColor.Size = new Size(221, 22);
            this.MenuSelectionColor.Text = "Выбрать цвет";
            this.MenuSelectionColor.Click += new EventHandler(this.MenuSelectionColor_Click);
            // 
            // MenuSelectionHouse
            // 
            this.MenuSelectionHouse.Name = "MenuSelectionHouse";
            this.MenuSelectionHouse.Size = new Size(221, 22);
            this.MenuSelectionHouse.Text = "Выделять найденные дома";
            this.MenuSelectionHouse.Click += new EventHandler(this.MenuSelectionHouse_Click);
            // 
            // MenuPosition
            // 
            this.MenuPosition.DropDownItems.AddRange(new ToolStripItem[] {
            this.слеваВнизуToolStripMenuItem,
            this.справаВнизуToolStripMenuItem,
            this.слеваВверхуToolStripMenuItem,
            this.справаВверхуToolStripMenuItem});
            this.MenuPosition.Name = "MenuPosition";
            this.MenuPosition.Size = new Size(152, 22);
            this.MenuPosition.Text = "Положение";
            // 
            // слеваВнизуToolStripMenuItem
            // 
            this.слеваВнизуToolStripMenuItem.Name = "слеваВнизуToolStripMenuItem";
            this.слеваВнизуToolStripMenuItem.Size = new Size(153, 22);
            this.слеваВнизуToolStripMenuItem.Tag = "0";
            this.слеваВнизуToolStripMenuItem.Text = "Слева внизу";
            this.слеваВнизуToolStripMenuItem.Click += new EventHandler(this.слеваВнизуToolStripMenuItem_Click);
            // 
            // справаВнизуToolStripMenuItem
            // 
            this.справаВнизуToolStripMenuItem.Name = "справаВнизуToolStripMenuItem";
            this.справаВнизуToolStripMenuItem.Size = new Size(153, 22);
            this.справаВнизуToolStripMenuItem.Tag = "1";
            this.справаВнизуToolStripMenuItem.Text = "Справа внизу";
            this.справаВнизуToolStripMenuItem.Click += new EventHandler(this.слеваВнизуToolStripMenuItem_Click);
            // 
            // слеваВверхуToolStripMenuItem
            // 
            this.слеваВверхуToolStripMenuItem.Name = "слеваВверхуToolStripMenuItem";
            this.слеваВверхуToolStripMenuItem.Size = new Size(153, 22);
            this.слеваВверхуToolStripMenuItem.Tag = "2";
            this.слеваВверхуToolStripMenuItem.Text = "Слева вверху";
            this.слеваВверхуToolStripMenuItem.Click += new EventHandler(this.слеваВнизуToolStripMenuItem_Click);
            // 
            // справаВверхуToolStripMenuItem
            // 
            this.справаВверхуToolStripMenuItem.Name = "справаВверхуToolStripMenuItem";
            this.справаВверхуToolStripMenuItem.Size = new Size(153, 22);
            this.справаВверхуToolStripMenuItem.Tag = "3";
            this.справаВверхуToolStripMenuItem.Text = "Справа вверху";
            this.справаВверхуToolStripMenuItem.Click += new EventHandler(this.слеваВнизуToolStripMenuItem_Click);
            // 
            // MenuStayOnTop
            // 
            this.MenuStayOnTop.Checked = true;
            this.MenuStayOnTop.CheckState = CheckState.Checked;
            this.MenuStayOnTop.Name = "MenuStayOnTop";
            this.MenuStayOnTop.Size = new Size(152, 22);
            this.MenuStayOnTop.Text = "Поверх всех";
            this.MenuStayOnTop.Click += new EventHandler(this.MenuStayOnTop_Click);
            // 
            // MenuDataBase
            // 
            this.MenuDataBase.DropDownItems.AddRange(new ToolStripItem[] {
            this.MenuDataBaseUpdate});
            this.MenuDataBase.Name = "MenuDataBase";
            this.MenuDataBase.Size = new Size(86, 20);
            this.MenuDataBase.Text = "База данных";
            // 
            // MenuDataBaseUpdate
            // 
            this.MenuDataBaseUpdate.Name = "MenuDataBaseUpdate";
            this.MenuDataBaseUpdate.Size = new Size(128, 22);
            this.MenuDataBaseUpdate.Text = "Обновить";
            this.MenuDataBaseUpdate.Click += new EventHandler(this.MenuDataBaseUpdate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new Size(98, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = Color.Red;
            this.colorDialog1.FullOpen = true;
            // 
            // button5
            // 
            this.button5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new Point(170, 113);
            this.button5.Name = "button5";
            this.button5.Size = new Size(53, 39);
            this.button5.TabIndex = 3;
            this.button5.Text = "Del";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new EventHandler(this.button5_Click);
            // 
            // tbStreet
            // 
            this.tbStreet.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.tbStreet.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.tbStreet.Location = new Point(110, 23);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new Size(116, 38);
            this.tbStreet.TabIndex = 0;
            this.tbStreet.KeyUp += new KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new Size(92, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Улица";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(239, 373);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(255, 411);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.Manual;
            this.Text = "2GisSelector";
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox tbNumber;
        private Button btnSearch;
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
        private ToolStripMenuItem MenuDataBaseUpdate;
        private Label label1;
        private ColorDialog colorDialog1;
        private Button button5;
        private TextBox tbStreet;
        private Label label2;
    }
}

