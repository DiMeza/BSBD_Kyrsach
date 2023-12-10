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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxLogin.Text;
            string passUser = textBoxPass.Text;
            if (string.IsNullOrEmpty(loginUser) || string.IsNullOrEmpty(passUser))
            {
                MessageBox.Show("Заполните поля","Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ЭлектронныйМагазинConnectionString);
                SqlCommand command = connection.CreateCommand();
                command.CommandText = ("SELECT * FROM [Пользователи приложения] where Логин=@usr AND Пароль=@pas");
                command.Parameters.Add("@usr",DbType.String).Value= loginUser;
                command.Parameters.Add("@pas", DbType.String).Value = passUser;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    FormMain formMain = new FormMain();
                    formMain.FormClosed += (s, args) => this.Close();
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль","Ошибка авторизации",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
               
                
            }

        }
    }
}
