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
using System.Windows.Forms.VisualStyles;

namespace Управление_проектами
{
    public partial class Projects : Form
    {
        public int id;
        public Projects(int _id)
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
                ("SELECT * from Сотрудники", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            comboBoxSotrudnik.DataSource = table;
            comboBoxSotrudnik.DisplayMember = "ФИО_сотрудника";
            comboBoxSotrudnik.ValueMember = "ИД_сотрудника";
            connection.Close();

            string connectionString1 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString1);
            connection1.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter
                ("SELECT * from Клиенты", connection1);
            DataTable table1 = new DataTable();
            dataAdapter1.Fill(table1);

            comboBoxKlient.DataSource = table1;
            comboBoxKlient.DisplayMember = "Контактное_лицо";
            comboBoxKlient.ValueMember = "ИД_клиента";
            connection1.Close();
        }

        void LoadString()
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT * FROM Проекты " +
                "WHERE ИД_проекта =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            comboBoxSotrudnik.SelectedValue = table.Rows[0][1];
            comboBoxKlient.SelectedValue = table.Rows[0][2];
            textBoxNazvanieProjecta.Text = table.Rows[0][3].ToString();
            textBoxOpisanieProjecta.Text = table.Rows[0][4].ToString();
            textBoxStatus.Text = table.Rows[0][5].ToString();
            textBoxEffectivnost.Text = table.Rows[0][6].ToString();
            dateTimePicker1.Text = table.Rows[0][7].ToString();
            dateTimePicker2.Text = table.Rows[0][8].ToString();
            textBoxBudgetProject.Text = table.Rows[0][9].ToString();
            textBoxTipPrivata.Text = table.Rows[0][10].ToString();
            textBoxsummaOplat.Text = table.Rows[0][11].ToString();
            dateTimePicker3.Text = table.Rows[0][12].ToString();
            textBoxSposobOplaty.Text = table.Rows[0][13].ToString();
            textBoxUdalenLiProject.Text = table.Rows[0][14].ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("UPDATE Проекты SET " +
                $"ИД_сотрудника = '" + comboBoxSotrudnik.SelectedValue + "'," +
                $"ИД_клиента = '" + comboBoxKlient.SelectedValue + "'," +
                $"Название_проекта = '" + textBoxNazvanieProjecta.Text + "'," +
                $"Описание_проекта  = '" + textBoxOpisanieProjecta.Text + "'," +
                $"Статус_проекта  = '" + textBoxStatus.Text + "'," +
                $"Эффективность  = '" + textBoxEffectivnost.Text + "'," +
                $"Дата_начало_проекта  = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," +
                $"Дата_окончания_проекта  = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'," +
                $"Бюджет_проекта = '" + textBoxBudgetProject.Text + "'," +
                $"Тип_приватности = '" + textBoxTipPrivata.Text + "'," +
                $"Сумма_оплаты = '" + textBoxsummaOplat.Text + "'," +
                $"Дата_оплаты = '" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "'," +
                $"Способ_оплаты = '" + textBoxSposobOplaty.Text + "'," +
                $"Удален_ли_проект = '" + textBoxUdalenLiProject.Text + "'" +
                "WHERE ИД_проекта = " + id, connection);
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
                ("DELETE FROM Проекты WHERE ИД_проекта = " + id, connection);
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
                ("INSERT into Проекты (ИД_сотрудника, ИД_клиента, Название_проекта, Описание_проекта, Статус_проекта, " +
                "Эффективность, Дата_начало_проекта, Дата_окончания_проекта, Бюджет_проекта, Тип_приватности, Сумма_оплаты, " +
                "Дата_оплаты, Способ_оплаты, Удален_ли_проект) " +
                "VALUES ('" + comboBoxSotrudnik.SelectedValue + "',"
                + "'" + comboBoxKlient.SelectedValue + "',"
                + "'" + textBoxNazvanieProjecta.Text + "',"
                + "'" + textBoxOpisanieProjecta.Text + "',"
                + "'" + textBoxStatus.Text + "',"
                + "'" + textBoxEffectivnost.Text + "',"
                + "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',"
                + "'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',"
                + "'" + textBoxBudgetProject.Text + "',"
                + "'" + textBoxTipPrivata.Text + "',"
                + "'" + textBoxsummaOplat.Text + "',"
                + "'" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "',"
                + "'" + textBoxSposobOplaty.Text + "',"
                + "'" + textBoxUdalenLiProject.Text + "')", connection);
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
