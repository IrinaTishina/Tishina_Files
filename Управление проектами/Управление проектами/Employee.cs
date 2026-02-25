using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Управление_проектами
{
    public partial class Employee : Form
    {
        public int id;
        public Employee(int _id)
        {
            InitializeComponent();
            id = _id;
            loadCombobox();
            if (id < 0)
            {
                InsertButton.Visible = true;
            }
            else
            {
                UpdateButton.Visible = true;
                DeleteButton.Visible = true;
                LoadString();
            }
        }

        void loadCombobox()
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT * from Пользователи", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            comboBoxUser.DataSource = table;
            comboBoxUser.DisplayMember = "Логин_пользователя";
            comboBoxUser.ValueMember = "ИД_пользователя";
            connection.Close();

            string connectionString1 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString1);
            connection1.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter
                ("SELECT * from Должности", connection1);
            DataTable table1 = new DataTable();
            dataAdapter1.Fill(table1);

            comboBoxDolznost.DataSource = table1;
            comboBoxDolznost.DisplayMember = "Наименование_должности";
            comboBoxDolznost.ValueMember = "ИД_Должности";
            connection1.Close();
        }

        void LoadString()
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT * FROM Сотрудники " +
                "WHERE ИД_сотрудника =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            comboBoxUser.SelectedValue = table.Rows[0][1];
            textBoxFIO.Text = table.Rows[0][2].ToString();
            textBoxDocument.Text = table.Rows[0][3].ToString();
            textBoxObrazovanie.Text = table.Rows[0][4].ToString();
            comboBoxDolznost.SelectedValue = table.Rows[0][5]; ;
            textBoxAdresPochta.Text = table.Rows[0][6].ToString();
            textBoxNomerTelephona.Text = table.Rows[0][7].ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("UPDATE Сотрудники SET " +
                $"ИД_пользователя = '" + comboBoxUser.SelectedValue + "'," +
                $"ФИО_сотрудника = '" + textBoxFIO.Text + "'," +
                $"Документ = '" + textBoxDocument.Text + "'," +
                $"Образование = '" + textBoxObrazovanie.Text + "'," +
                $"ИД_Должности = '" + comboBoxDolznost.SelectedValue + "'," +
                $"Адрес_электронной_почты = '" + textBoxAdresPochta.Text + "'," +
                $"Номер_телефона = '" + textBoxNomerTelephona.Text + "'" +
                "WHERE ИД_сотрудника = " + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            Close();
        }

        private void DeleteButton_Click(Object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("DELETE FROM Сотрудники WHERE ИД_сотрудника = " + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            Close();
        }

        private void InsertButton_Click(object obj, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("INSERT into Сотрудники (ИД_пользователя, ФИО_сотрудника, Документ, Образование, ИД_Должности, Адрес_электронной_почты, Номер_телефона) " +
                "VALUES ('" + comboBoxUser.SelectedValue + "',"
                + "'" + textBoxFIO.Text + "',"
                + "'" + textBoxDocument.Text + "',"
                + "'" + textBoxObrazovanie.Text + "',"
                + "'" + comboBoxDolznost.SelectedValue + "',"
                + "'" + textBoxAdresPochta.Text + "',"
                + "'" + textBoxNomerTelephona.Text + "')", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            Close();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.DarkSlateBlue;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }
        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
