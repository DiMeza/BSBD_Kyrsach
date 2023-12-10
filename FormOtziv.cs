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
    public partial class FormOtziv : Form
    {
        public FormOtziv()
        {
            InitializeComponent();
        }

        private void отзывBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отзывBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.электронныйМагазинDataSet);

        }

        private void отзывBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.отзывBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.электронныйМагазинDataSet);

        }

        private void FormOtziv_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "электронныйМагазинDataSet.Отзыв". При необходимости она может быть перемещена или удалена.
            this.отзывTableAdapter.Fill(this.электронныйМагазинDataSet.Отзыв);

        }
        private static FormOtziv f;
        public static FormOtziv fo
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormOtziv();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
