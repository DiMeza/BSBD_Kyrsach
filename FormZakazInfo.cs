using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters;

namespace Приложение_для_БД_ЭлектронныйМагазин
{
    public partial class FormZakazInfo : Form
    {
        public FormZakazInfo()
        {
            InitializeComponent();
        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.заказBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.электронныйМагазинDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FormZakazInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "электронныйМагазинDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.электронныйМагазинDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "электронныйМагазинDataSet.Покупатель". При необходимости она может быть перемещена или удалена.
            this.покупательTableAdapter.Fill(this.электронныйМагазинDataSet.Покупатель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "электронныйМагазинDataSet.ИнформацияЗаказа". При необходимости она может быть перемещена или удалена.
            this.информацияЗаказаTableAdapter.Fill(this.электронныйМагазинDataSet.ИнформацияЗаказа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "электронныйМагазинDataSet.ИнформацияЗаказа". При необходимости она может быть перемещена или удалена.
            this.информацияЗаказаTableAdapter.Fill(this.электронныйМагазинDataSet.ИнформацияЗаказа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "электронныйМагазинDataSet.ИнформацияЗаказа". При необходимости она может быть перемещена или удалена.
            this.информацияЗаказаTableAdapter.Fill(this.электронныйМагазинDataSet.ИнформацияЗаказа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "электронныйМагазинDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.электронныйМагазинDataSet.Заказ);
            электронныйМагазинDataSet.Заказ.Columns["Дата"].DefaultValue = DateTime.Now;

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.информацияЗаказаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.электронныйМагазинDataSet);
        }
        private static FormZakazInfo f;
        public static FormZakazInfo fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormZakazInfo();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void buttonPokypatel_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)заказBindingSource.Current)
           ["ID_покупателя"].ToString() != "")
            {
                id = (int)(((DataRowView)заказBindingSource.Current)["ID_покупателя"]);
            }
            id = FormPokypatelList.fpl.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)заказBindingSource.Current)["ID_покупателя"] = id;
                заказBindingSource.EndEdit();
                покупательTableAdapter.Fill(this.электронныйМагазинDataSet.Покупатель);
            }
        }
        string GetSelectedFieldName()
        {
            return
           информацияЗаказаDataGridView.Columns[информацияЗаказаDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void инфоЗаказDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (String.Compare(GetSelectedFieldName(), "О товаре", false) == 0)
                {
                    decimal price = 0;
                    int idTovarCurrent = -1;
                    int.TryParse((((DataRowView)информацияЗаказаBindingSource.Current)["ID_товара"]).ToString(), out idTovarCurrent);
                    int idTovar = FormTovar.ft.ShowSelectForm(idTovarCurrent, out price);
                    MessageBox.Show("ID товара=" + idTovar.ToString());
                    ((DataRowView)информацияЗаказаBindingSource.Current)["ID_товара"] = idTovar;
                    ((DataRowView)информацияЗаказаBindingSource.Current)["Стоимость"] = price;
                    информацияЗаказаBindingSource.EndEdit();
                    информацияЗаказаTableAdapter.Update(this.электронныйМагазинDataSet);
                    товарTableAdapter.Fill(this.электронныйМагазинDataSet.Товар);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
