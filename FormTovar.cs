using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение_для_БД_ЭлектронныйМагазин
{
    public partial class FormTovar : Form
    {
        public FormTovar()
        {
            InitializeComponent();
        }

        private void товарBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.электронныйМагазинDataSet);

        }

        private void FormTovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "электронныйМагазинDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.электронныйМагазинDataSet.Товар);

        }
        private static FormTovar f;
        public static FormTovar ft
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormTovar();
                return f;
            }
        }
        public void ShowForm()
        {
            товарBindingSource.Position = 0;
            Show();
            Activate();
        }
        private void FormTovar_Shown(object sender, EventArgs e)
        {
            товарBindingSource.Position = товарBindingSource.Find("ID_товара", idCurrent);
        }
        int idCurrent = -1;
        public int ShowSelectForm(int idDish, out decimal price)
        {
            idCurrent = idDish;
            ShowDialog();
            price = (decimal)((DataRowView)товарBindingSource.Current)
           ["Стоимость"];
            return (int)((DataRowView)товарBindingSource.Current)
           ["ID_товара"];
        }
    }
}
