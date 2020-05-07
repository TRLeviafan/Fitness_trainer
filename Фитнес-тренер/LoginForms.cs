using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фитнес_тренер
{
    public partial class LoginForms : Form
    {
        public static string Name { get; set; }
        public LoginForms()
        {
            InitializeComponent();

            //this.PassField.AutoSize = false;
            //this.PassField.Size = new Size(this.PassField.Size.Width,32 );
        }

        //
        // Передвижение окна программы по клику мыши.
        //

        Point lastPoint;

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //
        // Кнопка авторизация.
        //
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //
            // Проверка, на ввод логина и пароля.
            //

            if (LoginField.Text == "") 
            {
                MessageBox.Show("Вы не ввели логин!", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (PassField.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль!", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            //
            // Проверка на наличие такого аккаунта в базе данных.
            //

            Name = LoginField.Text;
            String passUser = PassField.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
            else
                MessageBox.Show("Неверный Логин или Пароль", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            
        }

        //
        // Переход на вкладку регестрации
        //

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        //
        // Вопрос: Закрыть приложение: Да / Нет.
        //

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?","Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }    
            
        }
    }
}
