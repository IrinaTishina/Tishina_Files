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
    public partial class Risks_Project : Form
    {
        public int id;
        public Risks_Project(int _id)
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
                ("SELECT * from Риски", connection1);
            DataTable table1 = new DataTable();
            dataAdapter1.Fill(table1);

            comboBoxNazvanieRiska.DataSource = table1;
            comboBoxNazvanieRiska.DisplayMember = "Название_риска";
            comboBoxNazvanieRiska.ValueMember = "ИД_риска";
            connection1.Close();

            string connectionString2 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection2 = new SqlConnection(connectionString2);
            connection2.Open();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter
                ("SELECT * from Сотрудники", connection2);
            DataTable table2 = new DataTable();
            dataAdapter2.Fill(table2);

            comboBoxOtvetstvenny.DataSource = table2;
            comboBoxOtvetstvenny.DisplayMember = "ФИО_сотрудника";
            comboBoxOtvetstvenny.ValueMember = "ИД_сотрудника";
            connection2.Close();
        }

        void LoadString()
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT * FROM Риски_по_проектам " +
                "WHERE ИД_риска_по_проектам =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            comboBoxNazvanieProject.SelectedValue = table.Rows[0][1];
            comboBoxNazvanieRiska.SelectedValue = table.Rows[0][2];
            textBoxVeroatnostRiska.Text = table.Rows[0][3].ToString();
            comboBoxOtvetstvenny.SelectedValue = table.Rows[0][4];
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("UPDATE Риски_по_проектам SET " +
                $"ИД_проекта = '" + comboBoxNazvanieProject.SelectedValue + "'," +
                $"ИД_риска = '" + comboBoxNazvanieRiska.SelectedValue + "'," +
                $"Вероятность_риска = '" + textBoxVeroatnostRiska.Text + "'," +
                $"ИД_сотрудника = '" + comboBoxOtvetstvenny.SelectedValue + "'" +
                " WHERE ИД_риска_по_проектам = " + id, connection);
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
                ("DELETE FROM Риски_по_проектам WHERE ИД_риска_по_проектам = " + id, connection);
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
                ("INSERT into Риски_по_проектам (ИД_проекта, ИД_риска, Вероятность_риска, ИД_сотрудника) " +
                "VALUES ('" + comboBoxNazvanieProject.SelectedValue + "',"
                + "'" + comboBoxNazvanieRiska.SelectedValue + "',"
                + "'" + textBoxVeroatnostRiska.Text + "',"
                + "'" + comboBoxOtvetstvenny.SelectedValue + "')", connection);
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
