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
using MetroFramework.Controls;

namespace Управление_проектами
{
    public partial class Projeck_Management : Form
    {
        public Projeck_Management()
        {
            InitializeComponent();
            refresh();
        }
        void refresh()
        {
            switch (Properties.Settings.Default.l)
            {
                case 1:
                    string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter
                        ("SELECT Проекты.ИД_проекта, Сотрудники.ФИО_сотрудника, Клиенты.Контактное_лицо, Проекты.Название_проекта, " +
                        "Проекты.Описание_проекта, Проекты.Статус_проекта, Проекты.Эффективность, Проекты.Дата_начало_проекта, Проекты.Дата_окончания_проекта, " +
                        "Проекты.Бюджет_проекта, Проекты.Тип_приватности, Проекты.Сумма_оплаты, Проекты.Дата_оплаты, Проекты.Способ_оплаты, Проекты.Удален_ли_проект " +
                        "FROM Проекты, Сотрудники, Клиенты " +
                        "WHERE Проекты.ИД_сотрудника = Сотрудники.ИД_сотрудника AND Проекты.ИД_клиента = Клиенты.ИД_клиента", connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);

                    dataGridView1.DataSource = table;
                    dataGridView1.Columns[0].Visible = false;
                    connection.Close();
                    break;

                case 2:
                    string connectionString1 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection1 = new SqlConnection(connectionString1);
                    connection1.Open();
                    SqlDataAdapter dataAdapter1 = new SqlDataAdapter
                        ("SELECT Задачи_по_проектам.ИД_задачи_по_проектам, Проекты.Название_проекта, Задачи.Название_задачи, Задачи_по_проектам.Дата_начала_задачи, " +
                        "Задачи_по_проектам.Дата_окончания_задачи, Задачи_по_проектам.Бюджет_задачи, Задачи_по_проектам.Статус_задачи, Сотрудники.ФИО_сотрудника AS Исполнитель " +
                        "FROM Задачи_по_проектам, Проекты, Задачи, Сотрудники " +
                        "WHERE Задачи_по_проектам.ИД_проекта = Проекты.ИД_проекта AND Задачи_по_проектам.ИД_задачи = Задачи.ИД_задачи AND " +
                        "Задачи_по_проектам.ИД_сотрудника = Сотрудники.ИД_сотрудника", connection1);
                    DataTable table1 = new DataTable();
                    dataAdapter1.Fill(table1);

                    dataGridView1.DataSource = table1;
                    dataGridView1.Columns[0].Visible = false;
                    connection1.Close();
                    break;

                case 3:
                    string connectionString2 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection2 = new SqlConnection(connectionString2);
                    connection2.Open();
                    SqlDataAdapter dataAdapter2 = new SqlDataAdapter
                        ("SELECT Задачи.ИД_задачи, Задачи.Название_задачи, Задачи.Описание_задачи " +
                        "FROM Задачи ", connection2);
                    DataTable table2 = new DataTable();
                    dataAdapter2.Fill(table2);

                    dataGridView1.DataSource = table2;
                    dataGridView1.Columns[0].Visible = false;
                    connection2.Close();
                    break;

                case 4:
                    string connectionString3 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection3 = new SqlConnection(connectionString3);
                    connection3.Open();
                    SqlDataAdapter dataAdapter3 = new SqlDataAdapter
                        ("SELECT Подзадачи_по_задачам.ИД_подзадачи_по_задачам, Задачи.Название_задачи, Подзадачи.Название_подзадачи, " +
                        "Подзадачи_по_задачам.Дата_начала_подзадачи, Подзадачи_по_задачам.Дата_окончания_подзадачи, Подзадачи_по_задачам.Статус_подзадачи, Сотрудники.ФИО_сотрудника AS Назначенный_сотрудник " +
                        "FROM Подзадачи_по_задачам, Задачи, Подзадачи, Сотрудники " +
                        "WHERE Подзадачи_по_задачам.ИД_задачи = Задачи.ИД_задачи AND Подзадачи_по_задачам.ИД_подзадачи = Подзадачи.ИД_подзадачи AND Подзадачи_по_задачам.ИД_сотрудника = Сотрудники.ИД_сотрудника", connection3);
                    DataTable table3 = new DataTable();
                    dataAdapter3.Fill(table3);

                    dataGridView1.DataSource = table3;
                    dataGridView1.Columns[0].Visible = false;
                    connection3.Close();
                    break;

                case 5:
                    string connectionString4 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection4 = new SqlConnection(connectionString4);
                    connection4.Open();
                    SqlDataAdapter dataAdapter4 = new SqlDataAdapter
                        ("SELECT Риски_по_проектам.ИД_риска_по_проектам, Проекты.Название_проекта, Риски.Название_риска, " +
                        "Риски_по_проектам.Вероятность_риска, Сотрудники.ФИО_сотрудника AS Ответственный " +
                        "FROM Риски_по_проектам, Проекты, Риски, Сотрудники " +
                        "WHERE Риски_по_проектам.ИД_проекта = Проекты.ИД_проекта AND Риски_по_проектам.ИД_риска = Риски.ИД_риска AND Риски_по_проектам.ИД_сотрудника = Сотрудники.ИД_сотрудника", connection4);
                    DataTable table4 = new DataTable();
                    dataAdapter4.Fill(table4);

                    dataGridView1.DataSource = table4;
                    dataGridView1.Columns[0].Visible = false;
                    connection4.Close();
                    break;

                case 6:
                    string connectionString5 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection5 = new SqlConnection(connectionString5);
                    connection5.Open();
                    SqlDataAdapter dataAdapter5 = new SqlDataAdapter
                        ("SELECT Риски.ИД_риска, Риски.Название_риска, Риски.Описание_риска, Риски.Влияние_риска, Риски.Меры_по_снижению_риска " +
                        "FROM Риски", connection5);
                    DataTable table5 = new DataTable();
                    dataAdapter5.Fill(table5);

                    dataGridView1.DataSource = table5;
                    dataGridView1.Columns[0].Visible = false;
                    connection5.Close();
                    break;

                case 7:
                    string connectionString6 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection6 = new SqlConnection(connectionString6);
                    connection6.Open();
                    SqlDataAdapter dataAdapter6 = new SqlDataAdapter
                        ("SELECT Затраты_по_проектам.ИД_затрат_по_проектам, Проекты.Название_проекта, Затраты.Тип_затрат, Затраты_по_проектам.Сумма_затрат, " +
                        "Затраты_по_проектам.Дата_затрат, Затраты_по_проектам.Статья_затрат, Затраты_по_проектам.Выход_из_бюджета " +
                        "FROM Затраты_по_проектам, Проекты, Затраты " +
                        "WHERE Затраты_по_проектам.ИД_проекта = Проекты.ИД_проекта AND Затраты_по_проектам.ИД_затрат = Затраты.ИД_затрат ", connection6);
                    DataTable table6 = new DataTable();
                    dataAdapter6.Fill(table6);

                    dataGridView1.DataSource = table6;
                    dataGridView1.Columns[0].Visible = false;
                    connection6.Close();
                    break;

                case 8:
                    string connectionString7 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection7 = new SqlConnection(connectionString7);
                    connection7.Open();
                    SqlDataAdapter dataAdapter7 = new SqlDataAdapter
                        ("SELECT Затраты.ИД_Затрат, Затраты.Тип_затрат " +
                        "FROM Затраты", connection7);
                    DataTable table7 = new DataTable();
                    dataAdapter7.Fill(table7);

                    dataGridView1.DataSource = table7;
                    dataGridView1.Columns[0].Visible = false;
                    connection7.Close();
                    break;

                case 9:
                    string connectionString8 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection8 = new SqlConnection(connectionString8);
                    connection8.Open();
                    SqlDataAdapter dataAdapter8 = new SqlDataAdapter
                        ("SELECT Проекты.ИД_проекта, Сотрудники.ФИО_сотрудника, Клиенты.Контактное_лицо, Проекты.Название_проекта, " +
                        "Проекты.Описание_проекта, Проекты.Статус_проекта, Проекты.Эффективность, Проекты.Дата_начало_проекта, Проекты.Дата_окончания_проекта, " +
                        "Проекты.Бюджет_проекта, Проекты.Тип_приватности, Проекты.Сумма_оплаты, Проекты.Дата_оплаты, Проекты.Способ_оплаты, Проекты.Удален_ли_проект " +
                        "FROM Проекты, Сотрудники, Клиенты " +
                        "WHERE Проекты.ИД_сотрудника = Сотрудники.ИД_сотрудника AND Проекты.ИД_клиента = Клиенты.ИД_клиента", connection8);
                    DataTable table8 = new DataTable();
                    dataAdapter8.Fill(table8);

                    dataGridView1.DataSource = table8;
                    dataGridView1.Columns[0].Visible = false;
                    connection8.Close();
                    break;

                case 10:
                    string connectionString9 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection9 = new SqlConnection(connectionString9);
                    connection9.Open();
                    SqlDataAdapter dataAdapter9 = new SqlDataAdapter
                        ("SELECT Сотрудники.ИД_сотрудника, Пользователи.Логин_пользователя, Сотрудники.ФИО_сотрудника, Сотрудники.Документ, " +
                        "Сотрудники.Образование, Должности.Наименование_должности, Сотрудники.Адрес_электронной_почты, Сотрудники.Номер_телефона " +
                        "FROM Сотрудники, Пользователи, Должности " +
                        "WHERE Сотрудники.ИД_пользователя = Пользователи.ИД_пользователя AND Сотрудники.ИД_Должности = Должности.ИД_Должности ", connection9);
                    DataTable table9 = new DataTable();
                    dataAdapter9.Fill(table9);

                    dataGridView1.DataSource = table9;
                    dataGridView1.Columns[0].Visible = false;
                    connection9.Close();
                    break;

                case 11:
                    string connectionString10 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection10 = new SqlConnection(connectionString10);
                    connection10.Open();
                    SqlDataAdapter dataAdapter10 = new SqlDataAdapter
                        ("SELECT Должности.ИД_Должности, Должности.Наименование_должности, Должности.Описание_должности, Должности.Оклад " +
                        "FROM Должности", connection10);
                    DataTable table10 = new DataTable();
                    dataAdapter10.Fill(table10);

                    dataGridView1.DataSource = table10;
                    dataGridView1.Columns[0].Visible = false;
                    connection10.Close();
                    break;

                case 12:
                    string connectionString11 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection11 = new SqlConnection(connectionString11);
                    connection11.Open();
                    SqlDataAdapter dataAdapter11 = new SqlDataAdapter
                        ("SELECT Клиенты.ИД_клиента, Клиенты.Наименование_компании, Клиенты.Контактное_лицо, " +
                        "Клиенты.Адрес_электронной_почты, Клиенты.Номер_телефона " +
                        "FROM Клиенты", connection11);
                    DataTable table11 = new DataTable();
                    dataAdapter11.Fill(table11);

                    dataGridView1.DataSource = table11;
                    dataGridView1.Columns[0].Visible = false;
                    connection11.Close();
                    break;


                case 13:
                    string connectionString12 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection12 = new SqlConnection(connectionString12);
                    connection12.Open();
                    SqlDataAdapter dataAdapter12 = new SqlDataAdapter
                        ("SELECT Подзадачи.ИД_подзадачи, Подзадачи.Название_подзадачи, Подзадачи.Описание_подзадачи " +
                        "FROM Подзадачи", connection12);
                    DataTable table12 = new DataTable();
                    dataAdapter12.Fill(table12);

                    dataGridView1.DataSource = table12;
                    dataGridView1.Columns[0].Visible = false;
                    connection12.Close();
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                try
                {
                    int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                    switch (Properties.Settings.Default.l)
                    {
                        case 1:
                            {
                                Projects projects = new Projects(id);
                                projects.ShowDialog();
                            }
                            break;

                        case 2:
                            {
                                Tasks_Project tasks_Project = new Tasks_Project(id);
                                tasks_Project.ShowDialog();
                            }
                            break;

                        case 3:
                            {
                                Tasks tasks = new Tasks(id);
                                tasks.ShowDialog();
                            }
                            break;

                        case 4:
                            {
                                Subtasks_Tasks subtasks = new Subtasks_Tasks(id);
                                subtasks.ShowDialog();
                            }
                            break;

                        case 5:
                            {
                                Risks_Project risks_Project = new Risks_Project(id);
                                risks_Project.ShowDialog();
                            }
                            break;

                        case 6:
                            {
                                Risks risks = new Risks(id);
                                risks.ShowDialog();
                            }
                            break;

                        case 7:
                            {
                                Expenses_Project expenses_Project = new Expenses_Project(id);
                                expenses_Project.ShowDialog();
                            }
                            break;

                        case 8:
                            {
                                Expenses expenses = new Expenses(id);
                                expenses.ShowDialog();
                            }
                            break;

                        case 9:
                            {
                                PrintOtchotOProekte printOtchotOProekte = new PrintOtchotOProekte(id);
                                printOtchotOProekte.ShowDialog();
                            }
                            break;

                        case 10:
                            {
                                Employee employee = new Employee(id);
                                employee.ShowDialog();
                            }
                            break;

                        case 11:
                            {
                                Post post = new Post(id);
                                post.ShowDialog();
                            }
                            break;

                        case 12:
                            {
                                Client client = new Client(id);
                                client.ShowDialog();
                            }
                            break;

                        case 13:
                            {
                                Subtasks subtasks = new Subtasks(id);
                                subtasks.ShowDialog();
                            }
                            break;
                    }
                    refresh();
                }
                catch
                {
                    MessageBox.Show("нажата пустая ячейка", "ошибка");
                }
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.l)
            {
                case 1:
                    {
                        Projects projects = new Projects(-1);
                        projects.ShowDialog();
                    }
                    break;

                case 2:
                    {
                        Tasks_Project tasks_Project = new Tasks_Project(-1);
                        tasks_Project.ShowDialog();
                    }
                    break;

                case 3:
                    {
                        Tasks tasks = new Tasks(-1);
                        tasks.ShowDialog();
                    }
                    break;

                case 4:
                    {
                        Subtasks_Tasks subtasks = new Subtasks_Tasks(-1);
                        subtasks.ShowDialog();
                    }
                    break;

                case 5:
                    {
                        Risks_Project risks_Project = new Risks_Project(-1);
                        risks_Project.ShowDialog();
                    }
                    break;

                case 6:
                    {
                        Risks risks = new Risks(-1);
                        risks.ShowDialog();
                    }
                    break;

                case 7:
                    {
                        Expenses_Project expenses_Project = new Expenses_Project(-1);
                        expenses_Project.ShowDialog();
                    }
                    break;

                case 8:
                    {
                        Expenses expenses = new Expenses(-1);
                        expenses.ShowDialog();
                    }
                    break;

                case 9:
                    {
                        PrintOtchotOProekte printOtchotOProekte = new PrintOtchotOProekte(-1);
                        printOtchotOProekte.ShowDialog();
                    }
                    break;

                case 10:
                    {
                        Employee employee = new Employee(-1);
                        employee.ShowDialog();
                    }
                    break;

                case 11:
                    {
                        Post post = new Post(-1);
                        post.ShowDialog();
                    }
                    break;

                case 12:
                    {
                        Client client = new Client(-1);
                        client.ShowDialog();
                    }
                    break;

                case 13:
                    {
                        Subtasks subtasks = new Subtasks(-1);
                        subtasks.ShowDialog();
                    }
                    break;
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Sort(dataGridView1.Columns[textBox1.Text], ListSortDirection.Ascending);
            }
            catch
            {
                MessageBox.Show("Введите имя столбца правильно!", "Неверное имя столбца");
            }
        }

        private void buttonSearch_Click(Object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.l)
            {
                case 1:
                    string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter
                        ("SELECT Проекты.ИД_проекта, Сотрудники.ФИО_сотрудника, Клиенты.Контактное_лицо, Проекты.Название_проекта, Проекты.Описание_проекта, Проекты.Статус_проекта, " +
                        "Проекты.Эффективность, Проекты.Дата_начало_проекта, Проекты.Дата_окончания_проекта, Проекты.Бюджет_проекта, Проекты.Тип_приватности, Проекты.Сумма_оплаты, " +
                        "Проекты.Дата_оплаты, Проекты.Способ_оплаты, Проекты.Удален_ли_проект " +
                        "FROM Проекты JOIN Сотрудники ON Проекты.ИД_сотрудника = Сотрудники.ИД_сотрудника " +
                        "JOIN Клиенты ON Проекты.ИД_клиента = Клиенты.ИД_клиента " +
                        "WHERE Сотрудники.ФИО_сотрудника LIKE '%" +
                        SearchTextBox.Text + "%' OR Клиенты.Контактное_лицо LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Название_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Описание_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Статус_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Эффективность LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Дата_начало_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Дата_окончания_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Бюджет_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Тип_приватности LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Сумма_оплаты LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Дата_оплаты LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Способ_оплаты LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Удален_ли_проект LIKE '%" +
                        SearchTextBox.Text + "%' ", connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);

                    dataGridView1.DataSource = table;
                    dataGridView1.Columns[0].Visible = false;
                    connection.Close();
                    break;

                case 2:
                    string connectionString1 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection1 = new SqlConnection(connectionString1);
                    connection1.Open();
                    SqlDataAdapter dataAdapter1 = new SqlDataAdapter
                        ("SELECT Задачи_по_проектам.ИД_задачи_по_проектам, Проекты.Название_проекта, Задачи.Название_задачи, Задачи_по_проектам.Дата_начала_задачи, " +
                        "Задачи_по_проектам.Дата_окончания_задачи, Задачи_по_проектам.Бюджет_задачи, Задачи_по_проектам.Статус_задачи, Сотрудники.ФИО_сотрудника " +
                        "FROM Задачи_по_проектам JOIN Проекты ON Задачи_по_проектам.ИД_проекта = Проекты.ИД_проекта " +
                        "JOIN Задачи ON Задачи_по_проектам.ИД_задачи = Задачи.ИД_задачи " +
                        "JOIN Сотрудники ON Задачи_по_проектам.ИД_сотрудника = Сотрудники.ИД_сотрудника " +
                        "WHERE Проекты.Название_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Задачи.Название_задачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Задачи_по_проектам.Дата_начала_задачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Задачи_по_проектам.Дата_окончания_задачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Задачи_по_проектам.Бюджет_задачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Задачи_по_проектам.Статус_задачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Сотрудники.ФИО_сотрудника LIKE '%" +
                        SearchTextBox.Text + "%' ", connection1);
                    DataTable table1 = new DataTable();
                    dataAdapter1.Fill(table1);

                    dataGridView1.DataSource = table1;
                    dataGridView1.Columns[0].Visible = false;
                    connection1.Close();
                    break;

                case 3:
                    string connectionString2 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection2 = new SqlConnection(connectionString2);
                    connection2.Open();
                    SqlDataAdapter dataAdapter2 = new SqlDataAdapter
                        ("SELECT Задачи.ИД_задачи, Задачи.Название_задачи, Задачи.Описание_задачи " +
                        "FROM Задачи " +
                        "WHERE Задачи.Название_задачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Задачи.Описание_задачи LIKE '%" +
                        SearchTextBox.Text + "%' ", connection2);
                    DataTable table2 = new DataTable();
                    dataAdapter2.Fill(table2);

                    dataGridView1.DataSource = table2;
                    dataGridView1.Columns[0].Visible = false;
                    connection2.Close();
                    break;

                case 4:
                    string connectionString3 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection3 = new SqlConnection(connectionString3);
                    connection3.Open();
                    SqlDataAdapter dataAdapter3 = new SqlDataAdapter
                        ("SELECT Подзадачи_по_задачам.ИД_подзадачи_по_задачам, Задачи.Название_задачи, Подзадачи.Название_подзадачи, " +
                        "Подзадачи_по_задачам.Дата_начала_подзадачи, Подзадачи_по_задачам.Дата_окончания_подзадачи, Подзадачи_по_задачам.Статус_подзадачи, Сотрудники.ФИО_сотрудника AS Назначенный_сотрудник " +
                        "FROM Подзадачи_по_задачам JOIN Задачи ON Подзадачи_по_задачам.ИД_задачи = Задачи.ИД_задачи " +
                        "JOIN Подзадачи ON Подзадачи_по_задачам.ИД_подзадачи = Подзадачи.ИД_подзадачи " +
                        "JOIN Сотрудники ON Подзадачи_по_задачам.ИД_сотрудника = Сотрудники.ИД_сотрудника " +
                        "WHERE Задачи.Название_задачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Подзадачи.Название_подзадачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Подзадачи_по_задачам.Дата_начала_подзадачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Подзадачи_по_задачам.Дата_окончания_подзадачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Подзадачи_по_задачам.Статус_подзадачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Сотрудники.ФИО_сотрудника LIKE '%" +
                        SearchTextBox.Text + "%' ", connection3);
                    DataTable table3 = new DataTable();
                    dataAdapter3.Fill(table3);

                    dataGridView1.DataSource = table3;
                    dataGridView1.Columns[0].Visible = false;
                    connection3.Close();
                    break;

                case 5:
                    string connectionString4 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection4 = new SqlConnection(connectionString4);
                    connection4.Open();
                    SqlDataAdapter dataAdapter4 = new SqlDataAdapter
                        ("SELECT Риски_по_проектам.ИД_риска_по_проектам, Проекты.Название_проекта, Риски.Название_риска, Риски_по_проектам.Вероятность_риска, Сотрудники.ФИО_сотрудника AS Ответственный " +
                        "FROM Риски_по_проектам JOIN Проекты ON Риски_по_проектам.ИД_проекта = Проекты.ИД_проекта " +
                        "JOIN Риски ON Риски_по_проектам.ИД_риска = Риски.ИД_риска " +
                        "JOIN Сотрудники ON Риски_по_проектам.ИД_сотрудника = Сотрудники.ИД_сотрудника " +
                        "WHERE Проекты.Название_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Риски.Название_риска LIKE '%" +
                        SearchTextBox.Text + "%' OR Риски_по_проектам.Вероятность_риска LIKE '%" +
                        SearchTextBox.Text + "%' OR Сотрудники.ФИО_сотрудника LIKE '%" +
                        SearchTextBox.Text + "%' ", connection4);
                    DataTable table4 = new DataTable();
                    dataAdapter4.Fill(table4);

                    dataGridView1.DataSource = table4;
                    dataGridView1.Columns[0].Visible = false;
                    connection4.Close();
                    break;

                case 6:
                    string connectionString5 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection5 = new SqlConnection(connectionString5);
                    connection5.Open();
                    SqlDataAdapter dataAdapter5 = new SqlDataAdapter
                        ("SELECT Риски.ИД_риска, Риски.Название_риска, Риски.Описание_риска, Риски.Влияние_риска, Риски.Меры_по_снижению_риска " +
                        "FROM Риски " +
                        "WHERE Риски.Название_риска LIKE '%" +
                        SearchTextBox.Text + "%' OR Риски.Описание_риска LIKE '%" +
                        SearchTextBox.Text + "%' OR Риски.Влияние_риска LIKE '%" +
                        SearchTextBox.Text + "%' OR Риски.Меры_по_снижению_риска LIKE '%" +
                        SearchTextBox.Text + "%' ", connection5);
                    DataTable table5 = new DataTable();
                    dataAdapter5.Fill(table5);

                    dataGridView1.DataSource = table5;
                    dataGridView1.Columns[0].Visible = false;
                    connection5.Close();
                    break;

                case 7:
                    string connectionString6 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection6 = new SqlConnection(connectionString6);
                    connection6.Open();
                    SqlDataAdapter dataAdapter6 = new SqlDataAdapter
                        ("SELECT Затраты_по_проектам.ИД_затрат_по_проектам, Проекты.Название_проекта, Затраты.Тип_затрат, Затраты_по_проектам.Сумма_затрат, " +
                        "Затраты_по_проектам.Дата_затрат, Затраты_по_проектам.Статья_затрат, Затраты_по_проектам.Выход_из_бюджета " +
                        "FROM Затраты_по_проектам JOIN Проекты ON Затраты_по_проектам.ИД_проекта = Проекты.ИД_проекта " +
                        "JOIN Затраты ON Затраты_по_проектам.ИД_затрат = Затраты.ИД_затрат " +
                        "WHERE Проекты.Название_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Затраты.Тип_затрат LIKE '%" +
                        SearchTextBox.Text + "%' OR Затраты_по_проектам.Сумма_затрат LIKE '%" +
                        SearchTextBox.Text + "%' OR Затраты_по_проектам.Дата_затрат LIKE '%" +
                        SearchTextBox.Text + "%' OR Затраты_по_проектам.Статья_затрат LIKE '%" +
                        SearchTextBox.Text + "%' OR Затраты_по_проектам.Выход_из_бюджета LIKE '%" +
                        SearchTextBox.Text + "%' ", connection6);
                    DataTable table6 = new DataTable();
                    dataAdapter6.Fill(table6);

                    dataGridView1.DataSource = table6;
                    dataGridView1.Columns[0].Visible = false;
                    connection6.Close();
                    break;

                case 8:
                    string connectionString7 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection7 = new SqlConnection(connectionString7);
                    connection7.Open();
                    SqlDataAdapter dataAdapter7 = new SqlDataAdapter
                        ("SELECT Затраты.ИД_Затрат, Затраты.Тип_затрат " +
                        "FROM Затраты " +
                        "WHERE Затраты.Тип_затрат LIKE '%" +
                        SearchTextBox.Text + "%' ", connection7);
                    DataTable table7 = new DataTable();
                    dataAdapter7.Fill(table7);

                    dataGridView1.DataSource = table7;
                    dataGridView1.Columns[0].Visible = false;
                    connection7.Close();
                    break;

                case 9:
                    string connectionString8 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection8 = new SqlConnection(connectionString8);
                    connection8.Open();
                    SqlDataAdapter dataAdapter8 = new SqlDataAdapter
                        ("SELECT Проекты.ИД_проекта, Сотрудники.ФИО_сотрудника, Клиенты.Контактное_лицо, Проекты.Название_проекта, Проекты.Описание_проекта, Проекты.Статус_проекта, " +
                        "Проекты.Эффективность, Проекты.Дата_начало_проекта, Проекты.Дата_окончания_проекта, Проекты.Бюджет_проекта, Проекты.Тип_приватности, Проекты.Сумма_оплаты " +
                        "Проекты.Дата_оплаты, Проекты.Способ_оплаты, Проекты.Удален_ли_проект " +
                        "FROM Проекты JOIN Сотрудники ON Проекты.ИД_сотрудника = Сотрудники.ИД_сотрудника " +
                        "JOIN Клиенты ON Проекты.ИД_клиента = Клиенты.ИД_клиента " +
                        "WHERE Сотрудники.ФИО_сотрудника LIKE '%" +
                        SearchTextBox.Text + "%' OR Клиенты.Контактное_лицо LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Название_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Описание_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Статус_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Эффективность LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Дата_начало_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Дата_окончания_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Бюджет_проекта LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Тип_приватности LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Сумма_оплаты LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Дата_оплаты LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Способ_оплаты LIKE '%" +
                        SearchTextBox.Text + "%' OR Проекты.Удален_ли_проект LIKE '%" +
                        SearchTextBox.Text + "%' ", connection8);
                    DataTable table8 = new DataTable();
                    dataAdapter8.Fill(table8);

                    dataGridView1.DataSource = table8;
                    dataGridView1.Columns[0].Visible = false;
                    connection8.Close();
                    break;

                case 10:
                    string connectionString9 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection9 = new SqlConnection(connectionString9);
                    connection9.Open();
                    SqlDataAdapter dataAdapter9 = new SqlDataAdapter
                        ("SELECT Сотрудники.ИД_сотрудника, Пользователи.Логин_пользователя, Сотрудники.ФИО_сотрудника, Сотрудники.Документ, " +
                        "Сотрудники.Образование, Должности.Наименование_должности, Сотрудники.Адрес_электронной_почты, Сотрудники.Номер_телефона " +
                        "FROM Сотрудники JOIN Пользователи ON Сотрудники.ИД_пользователя = Пользователи.ИД_пользователя " +
                        "JOIN Должности ON Сотрудники.ИД_Должности = Должности.ИД_Должности " +
                        "WHERE Пользователи.Логин_пользователя LIKE '%" +
                        SearchTextBox.Text + "%' OR Сотрудники.ФИО_сотрудника LIKE '%" +
                        SearchTextBox.Text + "%' OR Сотрудники.Документ LIKE '%" +
                        SearchTextBox.Text + "%' OR Сотрудники.Образование LIKE '%" +
                        SearchTextBox.Text + "%' OR Должности.Наименование_должности LIKE '%" +
                        SearchTextBox.Text + "%' OR Сотрудники.Адрес_электронной_почты LIKE '%" +
                        SearchTextBox.Text + "%' OR Сотрудники.Номер_телефона LIKE '%" +
                        SearchTextBox.Text + "%' ", connection9);
                    DataTable table9 = new DataTable();
                    dataAdapter9.Fill(table9);

                    dataGridView1.DataSource = table9;
                    dataGridView1.Columns[0].Visible = false;
                    connection9.Close();
                    break;

                case 11:
                    string connectionString10 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection10 = new SqlConnection(connectionString10);
                    connection10.Open();
                    SqlDataAdapter dataAdapter10 = new SqlDataAdapter
                        ("SELECT Должности.ИД_Должности, Должности.Наименование_должности, Должности.Описание_должности, Должности.Оклад " +
                        "FROM Должности " +
                        "WHERE Должности.Наименование_должности LIKE '%" +
                        SearchTextBox.Text + "%' OR Должности.Описание_должности LIKE '%" +
                        SearchTextBox.Text + "%' OR Должности.Оклад LIKE '%" +
                        SearchTextBox.Text + "%' ", connection10);
                    DataTable table10 = new DataTable();
                    dataAdapter10.Fill(table10);

                    dataGridView1.DataSource = table10;
                    dataGridView1.Columns[0].Visible = false;
                    connection10.Close();
                    break;

                case 12:
                    string connectionString11 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection11 = new SqlConnection(connectionString11);
                    connection11.Open();
                    SqlDataAdapter dataAdapter11 = new SqlDataAdapter
                        ("SELECT Клиенты.ИД_клиента, Клиенты.Наименование_компании, Клиенты.Контактное_лицо, " +
                        "Клиенты.Адрес_электронной_почты, Клиенты.Номер_телефона " +
                        "FROM Клиенты " +
                        "WHERE Клиенты.Наименование_компании LIKE '%" +
                        SearchTextBox.Text + "%' OR Клиенты.Контактное_лицо LIKE '%" +
                        SearchTextBox.Text + "%' OR Клиенты.Адрес_электронной_почты LIKE '%" +
                        SearchTextBox.Text + "%' OR Клиенты.Номер_телефона LIKE '%" +
                        SearchTextBox.Text + "%' ", connection11);
                    DataTable table11 = new DataTable();
                    dataAdapter11.Fill(table11);

                    dataGridView1.DataSource = table11;
                    dataGridView1.Columns[0].Visible = false;
                    connection11.Close();
                    break;

                case 13:
                    string connectionString12 = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
                    SqlConnection connection12 = new SqlConnection(connectionString12);
                    connection12.Open();
                    SqlDataAdapter dataAdapter12 = new SqlDataAdapter
                        ("SELECT Подзадачи.ИД_подзадачи, Подзадачи.Название_подзадачи, Подзадачи.Описание_подзадачи " +
                        "FROM Подзадачи " +
                        "WHERE Подзадачи.Название_подзадачи LIKE '%" +
                        SearchTextBox.Text + "%' OR Подзадачи.Описание_подзадачи LIKE '%" +
                        SearchTextBox.Text + "%' ", connection12);
                    DataTable table12 = new DataTable();
                    dataAdapter12.Fill(table12);

                    dataGridView1.DataSource = table12;
                    dataGridView1.Columns[0].Visible = false;
                    connection12.Close();
                    break;
            }
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
