using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Управление_проектами
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.textBoxpassword.AutoSize = false;
            this.textBoxpassword.Size = new Size(this.textBoxpassword.Size.Width, 30);
            formMenu = new Menu();
        }
        Menu formMenu;

        private void labelClose1_MouseEnter(object sender, EventArgs e)
        {
            labelClose1.ForeColor = Color.DarkSlateBlue;
        }

        private void labelClose1_MouseLeave(object sender, EventArgs e)
        {
            labelClose1.ForeColor = Color.White;
        }

        private void labelClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string login = textBoxlogin.Text;
            string password = textBoxpassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин и пароль не могут быть пустыми");
                return;
            }

            string connString = @"Data Source = DESKTOP-889D1RJ\SQLEXPRESS; Initial Catalog = Управление_проектами; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = "SELECT COUNT(*) FROM Пользователи WHERE Логин_пользователя = @Login AND Пароль_пользователя = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();

                    if (userCount == 0)
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                        return;
                    }
                }
            }

            MessageBox.Show("Авторизация прошла успешно!");
            formMenu.Show();
        }
    }
}
