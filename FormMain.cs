using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Приложение_для_БД_ЭлектронныйМагазин.Properties;

namespace Приложение_для_БД_ЭлектронныйМагазин
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, БИС, Хасанов Дмитрий Тимурович, 741-1 ,2023", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTovar.ft.ShowForm();
        }

        private void отзывыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOtziv.fo.ShowForm();
        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPolzovatel.fp.ShowForm();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZakaz.fz.ShowForm();
        }

        private void информацияЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo.fi.ShowForm();
        }

        private void заказыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormZakazInfo.fs.ShowForm();
        }

        private void списокПокупателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPokypatelList.fpl.ShowForm();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL.fsql.ShowForm();
        }
    }
}
