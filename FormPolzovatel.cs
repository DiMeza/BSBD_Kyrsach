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
    public partial class FormPolzovatel : Form
    {
        public FormPolzovatel()
        {
            InitializeComponent();
        }

        private void FormPolzovatel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "электронныйМагазинDataSet.Покупатель". При необходимости она может быть перемещена или удалена.
            this.покупательTableAdapter.Fill(this.электронныйМагазинDataSet.Покупатель);

        }
        private static FormPolzovatel f;
        public static FormPolzovatel fp
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormPolzovatel();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void покупательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.электронныйМагазинDataSet);

        }
    }
}
