namespace Управление_проектами
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеПроектамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиПоПроектамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подзадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подзадачиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.рискиПоПроектамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.затратыПоПроектамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.затратыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыПоПроектамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ещеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelClose1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеПроектамиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.ещеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 73);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеПроектамиToolStripMenuItem
            // 
            this.управлениеПроектамиToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.управлениеПроектамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектыToolStripMenuItem});
            this.управлениеПроектамиToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.управлениеПроектамиToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.управлениеПроектамиToolStripMenuItem.Name = "управлениеПроектамиToolStripMenuItem";
            this.управлениеПроектамиToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.управлениеПроектамиToolStripMenuItem.Text = "Управление проектами";
            this.управлениеПроектамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеПроектамиToolStripMenuItem_Click);
            // 
            // проектыToolStripMenuItem
            // 
            this.проектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задачиПоПроектамToolStripMenuItem,
            this.рискиПоПроектамToolStripMenuItem,
            this.затратыПоПроектамToolStripMenuItem});
            this.проектыToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            this.проектыToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.проектыToolStripMenuItem.Text = "Проекты";
            this.проектыToolStripMenuItem.Click += new System.EventHandler(this.проектыToolStripMenuItem_Click);
            // 
            // задачиПоПроектамToolStripMenuItem
            // 
            this.задачиПоПроектамToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задачиToolStripMenuItem});
            this.задачиПоПроектамToolStripMenuItem.Name = "задачиПоПроектамToolStripMenuItem";
            this.задачиПоПроектамToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.задачиПоПроектамToolStripMenuItem.Text = "Задачи по проектам";
            this.задачиПоПроектамToolStripMenuItem.Click += new System.EventHandler(this.задачи_по_проектамToolStripMenuItem_Click);
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подзадачиToolStripMenuItem});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.задачиToolStripMenuItem.Text = "Задачи";
            this.задачиToolStripMenuItem.Click += new System.EventHandler(this.задачиToolStripMenuItem_Click);
            // 
            // подзадачиToolStripMenuItem
            // 
            this.подзадачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подзадачиToolStripMenuItem1});
            this.подзадачиToolStripMenuItem.Name = "подзадачиToolStripMenuItem";
            this.подзадачиToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.подзадачиToolStripMenuItem.Text = "Подзадачи по задачам";
            this.подзадачиToolStripMenuItem.Click += new System.EventHandler(this.подзадачи_по_задачамToolStripMenuItem_Click);
            // 
            // подзадачиToolStripMenuItem1
            // 
            this.подзадачиToolStripMenuItem1.Name = "подзадачиToolStripMenuItem1";
            this.подзадачиToolStripMenuItem1.Size = new System.Drawing.Size(154, 24);
            this.подзадачиToolStripMenuItem1.Text = "Подзадачи";
            this.подзадачиToolStripMenuItem1.Click += new System.EventHandler(this.подзадачиToolStripMenuItem_Click);
            // 
            // рискиПоПроектамToolStripMenuItem
            // 
            this.рискиПоПроектамToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рискиToolStripMenuItem});
            this.рискиПоПроектамToolStripMenuItem.Name = "рискиПоПроектамToolStripMenuItem";
            this.рискиПоПроектамToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.рискиПоПроектамToolStripMenuItem.Text = "Риски по проектам";
            this.рискиПоПроектамToolStripMenuItem.Click += new System.EventHandler(this.риски_по_проектамToolStripMenuItem_Click);
            // 
            // рискиToolStripMenuItem
            // 
            this.рискиToolStripMenuItem.Name = "рискиToolStripMenuItem";
            this.рискиToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.рискиToolStripMenuItem.Text = "Риски";
            this.рискиToolStripMenuItem.Click += new System.EventHandler(this.рискиToolStripMenuItem_Click);
            // 
            // затратыПоПроектамToolStripMenuItem
            // 
            this.затратыПоПроектамToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.затратыToolStripMenuItem});
            this.затратыПоПроектамToolStripMenuItem.Name = "затратыПоПроектамToolStripMenuItem";
            this.затратыПоПроектамToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.затратыПоПроектамToolStripMenuItem.Text = "Затраты по проектам";
            this.затратыПоПроектамToolStripMenuItem.Click += new System.EventHandler(this.затраты_по_проектамToolStripMenuItem_Click);
            // 
            // затратыToolStripMenuItem
            // 
            this.затратыToolStripMenuItem.Name = "затратыToolStripMenuItem";
            this.затратыToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.затратыToolStripMenuItem.Text = "Затраты";
            this.затратыToolStripMenuItem.Click += new System.EventHandler(this.затратыToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыПоПроектамToolStripMenuItem});
            this.отчетыToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетыToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(90, 30);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            this.отчетыToolStripMenuItem.Click += new System.EventHandler(this.отчетыToolStripMenuItem_Click);
            // 
            // отчетыПоПроектамToolStripMenuItem
            // 
            this.отчетыПоПроектамToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетыПоПроектамToolStripMenuItem.Name = "отчетыПоПроектамToolStripMenuItem";
            this.отчетыПоПроектамToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.отчетыПоПроектамToolStripMenuItem.Text = "Отчеты по проектам";
            this.отчетыПоПроектамToolStripMenuItem.Click += new System.EventHandler(this.отчеты_по_проектамToolStripMenuItem_Click);
            // 
            // ещеToolStripMenuItem
            // 
            this.ещеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.клиентыToolStripMenuItem});
            this.ещеToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ещеToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ещеToolStripMenuItem.Name = "ещеToolStripMenuItem";
            this.ещеToolStripMenuItem.Size = new System.Drawing.Size(62, 30);
            this.ещеToolStripMenuItem.Text = "Еще";
            this.ещеToolStripMenuItem.Click += new System.EventHandler(this.ещеToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.должностиToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelClose1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 670);
            this.panel1.TabIndex = 1;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Saar SP Demo", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(449, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Меню";
            // 
            // labelClose1
            // 
            this.labelClose1.AutoSize = true;
            this.labelClose1.BackColor = System.Drawing.Color.Transparent;
            this.labelClose1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelClose1.Location = new System.Drawing.Point(963, 9);
            this.labelClose1.Name = "labelClose1";
            this.labelClose1.Size = new System.Drawing.Size(24, 26);
            this.labelClose1.TabIndex = 0;
            this.labelClose1.Text = "X";
            this.labelClose1.Click += new System.EventHandler(this.labelClose1_Click);
            this.labelClose1.MouseEnter += new System.EventHandler(this.labelClose1_MouseEnter);
            this.labelClose1.MouseLeave += new System.EventHandler(this.labelClose1_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 668);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеПроектамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ещеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClose1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачиПоПроектамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подзадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рискиПоПроектамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem затратыПоПроектамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem затратыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыПоПроектамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подзадачиToolStripMenuItem1;
    }
}