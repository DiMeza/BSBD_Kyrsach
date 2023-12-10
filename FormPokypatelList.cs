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
    public partial class FormPokypatelList : Form
    {
        public FormPokypatelList()
        {
            InitializeComponent();
        }

        private void покупательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.электронныйМагазинDataSet);

        }

        private void FormPokypatelList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "электронныйМагазинDataSet.Покупатель". При необходимости она может быть перемещена или удалена.
            this.покупательTableAdapter.Fill(this.электронныйМагазинDataSet.Покупатель);

        }
        string GetSelectedFieldName()
        {
            return покупательDataGridView.Columns[покупательDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               покупательBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxSearch.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                покупательBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких покупателей нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                покупательBindingSource.Position = 0;
            }
        }
        private static FormPokypatelList f;
        public static FormPokypatelList fpl
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormPokypatelList();
                return f;
            }
        }
        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            покупательBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilter.Checked)
            {
                if (toolStripTextBoxSearch.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        покупательBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxSearch.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                покупательBindingSource.Filter = "";
            if (покупательBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                покупательBindingSource.Filter = "";
                checkBoxFilter.Checked = false;
            }
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return (int)((DataRowView)покупательBindingSource.Current)["ID_покупателя"];
            else
                return -1;
        }
        private void FormPocupatelList_Shown(object sender, EventArgs e)
        {
            покупательBindingSource.Position = покупательBindingSource.Find("ID_покупателя", idCurrent);
        }
    }
}
