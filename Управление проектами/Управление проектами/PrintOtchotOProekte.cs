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
using Word = Microsoft.Office.Interop.Word;

namespace Управление_проектами
{
    public partial class PrintOtchotOProekte : Form
    {
        private readonly string fail = @"C:/Users/Ира/Desktop/ОтчетоПроекте.docx";

        public int id;
        public PrintOtchotOProekte(int _id)
        {
            InitializeComponent();
            id = _id;
            LoadString();
        }
        void LoadString()
        {
            string connectionString = "Data Source=DESKTOP-889D1RJ\\SQLEXPRESS;Initial Catalog=Управление_проектами;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT Проекты.ИД_проекта, Сотрудники.ФИО_сотрудника, Клиенты.Контактное_лицо, Проекты.Название_проекта, " +
                "Проекты.Описание_проекта, Проекты.Статус_проекта, Проекты.Эффективность, Проекты.Дата_начало_проекта, Проекты.Дата_окончания_проекта, " +
                "Проекты.Бюджет_проекта, Проекты.Тип_приватности, Проекты.Сумма_оплаты, Проекты.Дата_оплаты, Проекты.Способ_оплаты, Проекты.Удален_ли_проект " +
                "FROM Проекты, Сотрудники, Клиенты " +
                "WHERE Проекты.ИД_сотрудника = Сотрудники.ИД_сотрудника AND Проекты.ИД_клиента = Клиенты.ИД_клиента AND Проекты.ИД_проекта =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            Id_proyektaTextBox.Text = table.Rows[0][0].ToString();
            Id_sotrudnikaTextBox.Text = table.Rows[0][1].ToString();
            Id_klientaTextBox.Text = table.Rows[0][2].ToString();
            Nazvanie_proyektaTextBox.Text = table.Rows[0][3].ToString();
            Opisanie_proyektaTextBox.Text = table.Rows[0][4].ToString();
            Status_proyektaTextBox.Text = table.Rows[0][5].ToString();
            EffectivnostTextBox.Text = table.Rows[0][6].ToString();
            Data_nachalo_proyektaTextBox.Text = table.Rows[0][7].ToString();
            Data_okonchania_proyektaTextBox.Text = table.Rows[0][8].ToString();
            Byudzhet_proyektaTextBox.Text = table.Rows[0][9].ToString();
            Tip_privatnostiTextBox.Text = table.Rows[0][10].ToString();
            Summa_oplatyTextBox.Text = table.Rows[0][11].ToString();
            Data_oplatyTextBox.Text = table.Rows[0][12].ToString();
            Sposob_oplatyTextBox.Text = table.Rows[0][13].ToString();
            Udalon_li_proyektTextBox.Text = table.Rows[0][14].ToString();
            
        }
        private void PrintOtchotButton_Click(object sender, EventArgs e)
        {
            var id_proyekta = Id_proyektaTextBox.Text;
            var id_sotrudnika = Id_sotrudnikaTextBox.Text;
            var id_klienta = Id_klientaTextBox.Text;
            var nazvanie_proyekta = Nazvanie_proyektaTextBox.Text;
            var opisanie_proyekta = Opisanie_proyektaTextBox.Text;
            var status_proyekta = Status_proyektaTextBox.Text;
            var effectivnost = EffectivnostTextBox.Text;
            var data_nachalo_proyekta = Data_nachalo_proyektaTextBox.Text;
            var data_okonchania_proyekta = Data_okonchania_proyektaTextBox.Text;
            var byudzhet_proyekta = Byudzhet_proyektaTextBox.Text;
            var tip_privatnosti = Tip_privatnostiTextBox.Text;
            var summa_oplaty = Summa_oplatyTextBox.Text;
            var data_oplaty = Data_oplatyTextBox.Text;
            var sposob_oplaty = Sposob_oplatyTextBox.Text;
            var udalon_li_proyekt = Udalon_li_proyektTextBox.Text;
            var data_suzdania_otchota = Data_suzdania_otchota.Text;
            var wordap = new Word.Application();

            wordap.Visible = false;

            var worddoc = wordap.Documents.Open(fail);

            ReplaceWord("{id_proyekta}", id_proyekta, worddoc);
            ReplaceWord("{id_sotrudnika}", id_sotrudnika, worddoc);
            ReplaceWord("{id_klienta}", id_klienta, worddoc);
            ReplaceWord("{nazvanie_proyekta}", nazvanie_proyekta, worddoc);
            ReplaceWord("{opisanie_proyekta}", opisanie_proyekta, worddoc);
            ReplaceWord("{status_proyekta}", status_proyekta, worddoc);
            ReplaceWord("{effectivnost}", effectivnost, worddoc);
            ReplaceWord("{data_nachalo_proyekta}", data_nachalo_proyekta, worddoc);
            ReplaceWord("{data_okonchania_proyekta}", data_okonchania_proyekta, worddoc);
            ReplaceWord("{byudzhet_proyekta}", byudzhet_proyekta, worddoc);
            ReplaceWord("{tip_privatnosti}", tip_privatnosti, worddoc);
            ReplaceWord("{summa_oplaty}", summa_oplaty, worddoc);
            ReplaceWord("{data_oplaty}", data_oplaty, worddoc);
            ReplaceWord("{sposob_oplaty}", sposob_oplaty, worddoc);
            ReplaceWord("{udalon_li_proyekt}", udalon_li_proyekt, worddoc);
            ReplaceWord("{data_suzdania_otchota}", data_suzdania_otchota, worddoc);

            worddoc.SaveAs("C:/Users/Ира/Desktop/ОтчетоПроекте1.docx");

            worddoc.Close();
        }

        private void ReplaceWord(string stubreplace, string text, Word.Document worddoc)
        {
            var range = worddoc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubreplace, ReplaceWith: text);
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