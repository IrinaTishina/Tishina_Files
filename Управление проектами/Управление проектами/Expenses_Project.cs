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
    public partial class Expenses_Project : Form
    {
        public int id;
        public Expenses_Project(int _id)
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
                ("SELECT * from Затраты", connection1);
            DataTable table1 = new DataTable();
            dataAdapter1.Fill(table1);

            comboBoxTipZatrat.DataSource = table1;
            comboBoxTipZatrat.DisplayMember = "Тип_затрат";
            comboBoxTipZatrat.ValueMember = "ИД_затрат";
            connection1.Close();
        }

        void LoadString()
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT * FROM Затраты_по_проектам " +
                "WHERE ИД_затрат_по_проектам =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            comboBoxNazvanieProject.SelectedValue = table.Rows[0][1];
            comboBoxTipZatrat.SelectedValue = table.Rows[0][2];
            textBoxSummaZatrat.Text = table.Rows[0][3].ToString();
            dateTimePicker1.Text = table.Rows[0][4].ToString();
            textBoxStatiaZatrat.Text = table.Rows[0][5].ToString();
            textBoxVihodIzBudgeta.Text = table.Rows[0][6].ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("UPDATE Затраты_по_проектам SET " +
                $"ИД_проекта = '" + comboBoxNazvanieProject.SelectedValue + "'," +
                $"ИД_затрат = '" + comboBoxTipZatrat.SelectedValue + "'," +
                $"Сумма_затрат = '" + textBoxSummaZatrat.Text + "'," +
                $"Дата_затрат = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," +
                $"Статья_затрат = '" + textBoxStatiaZatrat.Text + "'," +
                $"Выход_из_бюджета = '" + textBoxVihodIzBudgeta.Text + "'" +
                " WHERE ИД_затрат_по_проектам = " + id, connection);
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
                ("DELETE FROM Затраты_по_проектам WHERE ИД_затрат_по_проектам = " + id, connection);
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
                ("INSERT into Затраты_по_проектам (ИД_проекта, ИД_затрат, Сумма_затрат, Дата_затрат, Статья_затрат, Выход_из_бюджета) " +
                "VALUES ('" + comboBoxNazvanieProject.SelectedValue + "',"
                + "'" + comboBoxTipZatrat.SelectedValue + "',"
                + "'" + textBoxSummaZatrat.Text + "',"
                + "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',"
                + "'" + textBoxStatiaZatrat.Text + "',"
                + "'" + textBoxVihodIzBudgeta.Text + "')", connection);
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
