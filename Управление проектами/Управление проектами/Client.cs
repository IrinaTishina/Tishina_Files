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
    public partial class Client : Form
    {
        public int id;
        public Client(int _id)
        {
            InitializeComponent();
            id = _id;
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
        void LoadString()
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT * FROM Клиенты " +
                "WHERE ИД_клиента =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            textBoxNaimenovanie_companii.Text = table.Rows[0][1].ToString();
            textBoxKontactnoeLitso.Text = table.Rows[0][2].ToString();
            textBoxAdresPochta.Text = table.Rows[0][3].ToString();
            textBoxTelephon.Text = table.Rows[0][4].ToString();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("UPDATE Клиенты SET " +
                $"Наименование_компании = '" + textBoxNaimenovanie_companii.Text + "'," +
                $"Контактное_лицо = '" + textBoxKontactnoeLitso.Text + "'," +
                $"Адрес_электронной_почты = '" + textBoxAdresPochta.Text + "'," +
                $"Номер_телефона = '" + textBoxTelephon.Text + "'" +
                "WHERE ИД_клиента = " + id, connection);
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
                ("DELETE FROM Клиенты WHERE ИД_клиента = " + id, connection);
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
                ("INSERT into Клиенты (Наименование_компании, Контактное_лицо, Адрес_электронной_почты, Номер_телефона) " +
                "VALUES ('" + textBoxNaimenovanie_companii.Text + "',"
                + "'" + textBoxKontactnoeLitso.Text + "',"
                + "'" + textBoxAdresPochta.Text + "',"
                + "'" + textBoxTelephon.Text + "')", connection);
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
