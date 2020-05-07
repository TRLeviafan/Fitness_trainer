using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Фитнес_тренер.ServiceNEW;

namespace Фитнес_тренер
{
    public partial class MainForm : Form
    {
        Service1Client client;
        public MainForm()
        {
            InitializeComponent();
            ConnectUser();
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
        private void UpMainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UpMainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //
        // Загрузака аватарки.
        //

        private void LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AvatarProfile.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть указанный фаил!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void ConnectUser()
        {
            //client.Connect(LoginForms.Name);
        }

    }
}
