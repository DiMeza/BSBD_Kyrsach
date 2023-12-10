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

namespace Приложение_для_БД_ЭлектронныйМагазин
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }
        private static FormSQL f;
        public static FormSQL fsql
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ЭлектронныйМагазинConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * From Покупатель");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("Select ID_товара,Название+'-'+Поставщик as Подробнее,Стоимость from Товар");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT Товар.Название, ИнформацияЗаказа.[Количество товара], ИнформацияЗаказа.Стоимость, Заказ.ID_заказа FROM   Заказ INNER JOIN ИнформацияЗаказа ON Заказ.ID_заказа = ИнформацияЗаказа.ID_заказа INNER JOIN Товар ON ИнформацияЗаказа.ID_товара = Товар.ID_товара");
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {

        }
    }
}
