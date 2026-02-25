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
    public partial class Subtasks_Tasks : Form
    {
        public int id;
        public Subtasks_Tasks(int _id)
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
                ("SELECT * from Задачи", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            comboBoxNazvanieZadachi.DataSource = table;
            comboBoxNazvanieZadachi.DisplayMember = "Название_задачи";
            comboBoxNazvanieZadachi.ValueMember = "ИД_задачи";
            connection.Close();

            string connectionString1 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString1);
            connection1.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter
                ("SELECT * from Подзадачи", connection1);
            DataTable table1 = new DataTable();
            dataAdapter1.Fill(table1);

            comboBoxNazvaniePodzadachi.DataSource = table1;
            comboBoxNazvaniePodzadachi.DisplayMember = "Название_подзадачи";
            comboBoxNazvaniePodzadachi.ValueMember = "ИД_подзадачи";
            connection1.Close();

            string connectionString2 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection2 = new SqlConnection(connectionString2);
            connection2.Open();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter
                ("SELECT * from Сотрудники", connection2);
            DataTable table2 = new DataTable();
            dataAdapter2.Fill(table2);

            comboBoxNaznachennSotrudnik.DataSource = table2;
            comboBoxNaznachennSotrudnik.DisplayMember = "ФИО_сотрудника";
            comboBoxNaznachennSotrudnik.ValueMember = "ИД_сотрудника";
            connection2.Close();
        }

        void LoadString()
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT * FROM Подзадачи_по_задачам " +
                "WHERE ИД_подзадачи_по_задачам =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            comboBoxNazvanieZadachi.SelectedValue = table.Rows[0][1];
            comboBoxNazvaniePodzadachi.SelectedValue = table.Rows[0][2];
            dateTimePicker1.Text = table.Rows[0][3].ToString();
            dateTimePicker2.Text = table.Rows[0][4].ToString();
            textBoxStatus.Text = table.Rows[0][5].ToString();
            comboBoxNaznachennSotrudnik.SelectedValue = table.Rows[0][6];
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("UPDATE Подзадачи_по_задачам SET " +
                $"ИД_задачи = '" + comboBoxNazvanieZadachi.SelectedValue + "'," +
                $"ИД_подзадачи = '" + comboBoxNazvaniePodzadachi.SelectedValue + "'," +
                $"Дата_начала_подзадачи = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," +
                $"Дата_окончания_подзадачи = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'," +
                $"Статус_подзадачи = '" + textBoxStatus.Text + "'," +
                $"ИД_сотрудника = '" + comboBoxNaznachennSotrudnik.SelectedValue + "'" +
                "WHERE ИД_подзадачи_по_задачам = " + id, connection);
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
                ("DELETE FROM Подзадачи_по_задачам WHERE ИД_подзадачи_по_задачам = " + id, connection);
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
                ("INSERT into Подзадачи_по_задачам (ИД_задачи, ИД_подзадачи, Дата_начала_подзадачи, Дата_окончания_подзадачи, Статус_подзадачи, ИД_сотрудника) " +
                "VALUES ('" + comboBoxNazvanieZadachi.SelectedValue + "',"
                + "'" + comboBoxNazvaniePodzadachi.SelectedValue + "',"
                + "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',"
                + "'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',"
                + "'" + textBoxStatus.Text + "',"
                + "'" + comboBoxNaznachennSotrudnik.SelectedValue + "')", connection);
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
