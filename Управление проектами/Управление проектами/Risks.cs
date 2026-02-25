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
    public partial class Risks : Form
    {
        public int id;
        public Risks(int _id)
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
                ("SELECT * FROM Риски " +
                "WHERE ИД_риска =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            textBoxNazvanie.Text = table.Rows[0][1].ToString();
            textBoxOpisanie.Text = table.Rows[0][2].ToString();
            textBoxVlianie.Text = table.Rows[0][3].ToString();
            textBoxMeryPoSnicheniu.Text = table.Rows[0][4].ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("UPDATE Риски SET " +
                $"Название_риска = '" + textBoxNazvanie.Text + "'," +
                $"Описание_риска = '" + textBoxOpisanie.Text + "'," +
                $"Влияние_риска = '" + textBoxVlianie.Text + "'," +
                $"Меры_по_снижению_риска = '" + textBoxMeryPoSnicheniu.Text + "'" +
                "WHERE ИД_риска = " + id, connection);
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
                ("DELETE FROM Риски WHERE ИД_риска = " + id, connection);
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
                ("INSERT into Риски (Название_риска, Описание_риска, Влияние_риска, Меры_по_снижению_риска) " +
                "VALUES ('" + textBoxNazvanie.Text + "',"
                + "'" + textBoxOpisanie.Text + "',"
                + "'" + textBoxVlianie.Text + "',"
                + "'" + textBoxMeryPoSnicheniu.Text + "')", connection);
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
