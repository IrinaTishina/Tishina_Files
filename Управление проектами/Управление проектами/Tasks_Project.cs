using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Управление_проектами
{
    public partial class Tasks_Project : Form
    {
        public int id;
        public Tasks_Project(int _id)
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
                ("SELECT * from Проекты", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            comboBoxNazvanieProject.DataSource = table;
            comboBoxNazvanieProject.DisplayMember = "Название_проекта";
            comboBoxNazvanieProject.ValueMember = "ИД_проекта";
            connection.Close();

            string connectionString1 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString1);
            connection1.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter
                ("SELECT * from Задачи", connection1);
            DataTable table1 = new DataTable();
            dataAdapter1.Fill(table1);

            comboBoxNazvanieZadachi.DataSource = table1;
            comboBoxNazvanieZadachi.DisplayMember = "Название_задачи";
            comboBoxNazvanieZadachi.ValueMember = "ИД_задачи";
            connection1.Close();

            string connectionString3 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection3 = new SqlConnection(connectionString3);
            connection3.Open();
            SqlDataAdapter dataAdapter3 = new SqlDataAdapter
                ("SELECT * from Сотрудники", connection3);
            DataTable table3 = new DataTable();
            dataAdapter3.Fill(table3);

            comboBoxIspolnitel.DataSource = table3;
            comboBoxIspolnitel.DisplayMember = "ФИО_сотрудника";
            comboBoxIspolnitel.ValueMember = "ИД_сотрудника";
            connection3.Close();
        }

        void LoadString()
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT * FROM Задачи_по_проектам " +
                "WHERE ИД_задачи_по_проектам =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            comboBoxNazvanieProject.SelectedValue = table.Rows[0][1];
            comboBoxNazvanieZadachi.SelectedValue = table.Rows[0][2];
            dateTimePicker1.Text = table.Rows[0][3].ToString();
            dateTimePicker2.Text = table.Rows[0][4].ToString();
            textBoxBudgetZadachi.Text = table.Rows[0][5].ToString();
            textBoxStatusZadachi.Text = table.Rows[0][6].ToString();
            comboBoxIspolnitel.SelectedValue = table.Rows[0][7];

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("UPDATE Задачи_по_проектам SET " +
                $"ИД_проекта = '" + comboBoxNazvanieProject.SelectedValue + "'," +
                $"ИД_задачи = '" + comboBoxNazvanieZadachi.SelectedValue + "'," +
                $"Дата_начала_задачи = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," +
                $"Дата_окончания_задачи = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'," +
                $"Бюджет_задачи = '" + textBoxBudgetZadachi.Text + "'," +
                $"Статус_задачи = '" + textBoxStatusZadachi.Text + "'," +
                $"ИД_сотрудника = '" + comboBoxIspolnitel.SelectedValue + "'" +
                " WHERE ИД_задачи_по_проектам = " + id, connection);
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
                ("DELETE FROM Задачи_по_проектам WHERE ИД_задачи_по_проектам = " + id, connection);
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
                ("INSERT into Задачи_по_проектам (ИД_проекта, ИД_задачи, Дата_начала_задачи, Дата_окончания_задачи, Бюджет_задачи, Статус_задачи, ИД_сотрудника) " +
                "VALUES ('" + comboBoxNazvanieProject.SelectedValue + "',"
                + "'" + comboBoxNazvanieZadachi.SelectedValue + "',"
                + "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',"
                + "'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',"
                + "'" + textBoxBudgetZadachi.Text + "',"
                + "'" + textBoxStatusZadachi.Text + "',"
                + "'" + comboBoxIspolnitel.SelectedValue + "')", connection);
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
