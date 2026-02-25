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
    public partial class Expenses : Form
    {
        public int id;
        public Expenses(int _id)
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
                ("SELECT * FROM Затраты " +
                "WHERE ИД_затрат =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            textBoxTipZatrat.Text = table.Rows[0][1].ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("UPDATE Затраты SET " +
                $"Тип_затрат = '" + textBoxTipZatrat.Text + "'" +
                "WHERE ИД_затрат = " + id, connection);
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
                ("DELETE FROM Затраты WHERE ИД_затрат = " + id, connection);
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
                ("INSERT into Затраты (Тип_затрат) " +
                "VALUES ('" + textBoxTipZatrat.Text + "')", connection);
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
