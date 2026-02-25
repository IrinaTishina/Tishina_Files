namespace Управление_проектами
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelClose = new System.Windows.Forms.Panel();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.labelClose1 = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClose
            // 
            this.labelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labelClose.BackgroundImage")));
            this.labelClose.Controls.Add(this.buttonSignIn);
            this.labelClose.Controls.Add(this.labelClose1);
            this.labelClose.Controls.Add(this.textBoxpassword);
            this.labelClose.Controls.Add(this.textBoxlogin);
            this.labelClose.Controls.Add(this.label3);
            this.labelClose.Controls.Add(this.label2);
            this.labelClose.Controls.Add(this.label1);
            this.labelClose.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.Location = new System.Drawing.Point(-9, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(1003, 667);
            this.labelClose.TabIndex = 0;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.Transparent;
            this.buttonSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSignIn.BackgroundImage")));
            this.buttonSignIn.FlatAppearance.BorderSize = 0;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSignIn.Location = new System.Drawing.Point(393, 422);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(207, 44);
            this.buttonSignIn.TabIndex = 6;
            this.buttonSignIn.Text = "ВОЙТИ";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // labelClose1
            // 
            this.labelClose1.AutoSize = true;
            this.labelClose1.BackColor = System.Drawing.Color.Transparent;
            this.labelClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelClose1.Location = new System.Drawing.Point(964, 9);
            this.labelClose1.Name = "labelClose1";
            this.labelClose1.Size = new System.Drawing.Size(24, 26);
            this.labelClose1.TabIndex = 5;
            this.labelClose1.Text = "X";
            this.labelClose1.Click += new System.EventHandler(this.labelClose1_Click);
            this.labelClose1.MouseEnter += new System.EventHandler(this.labelClose1_MouseEnter);
            this.labelClose1.MouseLeave += new System.EventHandler(this.labelClose1_MouseLeave);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxpassword.Location = new System.Drawing.Point(392, 354);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(208, 33);
            this.textBoxpassword.TabIndex = 4;
            this.textBoxpassword.UseSystemPasswordChar = true;
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxlogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxlogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxlogin.Location = new System.Drawing.Point(392, 255);
            this.textBoxlogin.Multiline = true;
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(207, 30);
            this.textBoxlogin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(386, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "ПАРОЛЬ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(387, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "ЛОГИН";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Saar SP Demo", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1003, 243);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 666);
            this.Controls.Add(this.labelClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.labelClose.ResumeLayout(false);
            this.labelClose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxlogin;
        private System.Windows.Forms.Label labelClose1;
        private System.Windows.Forms.Button buttonSignIn;
    }
}

