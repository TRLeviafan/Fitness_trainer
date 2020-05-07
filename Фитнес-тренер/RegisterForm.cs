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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        //
        // Вопрос: Закрыть приложение: Да / Нет.
        //

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //
        // Открытие вкладки "Авторизация". 
        //

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForms loginform = new LoginForms();
            loginform.Show();
        }

        //
        // Передвижения окна
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
        // Проверка на ввод данных.
        //
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                MessageBox.Show("Вы не ввели логин!","Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (PassField.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль!", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (AgeComboBox.Text == "")
            {
                MessageBox.Show("Вы не ввели возраст!", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (HeightComboBox.Text == "")
            {
                MessageBox.Show("Вы не ввели рост!", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (WeightComboBox.Text == "")
            {
                MessageBox.Show("Вы не ввели вес!", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (GenderComboBox.Text == "")
            {
                MessageBox.Show("Вы не ввели пол", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (checkloginname())
                return;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `Age`, `Weight`, `Height`, `Gender`) VALUES (@login, @password, @age, @weight, @height, @gender);", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = AgeComboBox.Text;
            command.Parameters.Add("@weight", MySqlDbType.VarChar).Value = WeightComboBox.Text;
            command.Parameters.Add("@height", MySqlDbType.VarChar).Value = HeightComboBox.Text;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = GenderComboBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                LoginForms loginform = new LoginForms();
                loginform.Show();
            }
            else
                MessageBox.Show("Вы ввели некорректные данные!", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


            db.closeConnection();
        }

        //
        // Проверка на оригинальность логина.
        //

        public Boolean checkloginname()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже зарегестрирован!", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;

        }
    }
}
