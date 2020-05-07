namespace Фитнес_тренер
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ProfileTab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.LoadImage = new System.Windows.Forms.Label();
            this.AvatarProfile = new System.Windows.Forms.PictureBox();
            this.NickName = new System.Windows.Forms.Label();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.UpMainPanel = new System.Windows.Forms.Panel();
            this.Авторизация = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarProfile)).BeginInit();
            this.UpMainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.DimGray;
            this.MainPanel.Controls.Add(this.ProfileTab);
            this.MainPanel.Controls.Add(this.UpMainPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(777, 645);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // ProfileTab
            // 
            this.ProfileTab.Controls.Add(this.metroTabPage1);
            this.ProfileTab.Controls.Add(this.metroTabPage2);
            this.ProfileTab.Controls.Add(this.metroTabPage3);
            this.ProfileTab.Controls.Add(this.metroTabPage4);
            this.ProfileTab.Controls.Add(this.metroTabPage5);
            this.ProfileTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProfileTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileTab.Location = new System.Drawing.Point(0, 52);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.SelectedIndex = 0;
            this.ProfileTab.Size = new System.Drawing.Size(777, 593);
            this.ProfileTab.TabIndex = 12;
            this.ProfileTab.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage1.Controls.Add(this.NickName);
            this.metroTabPage1.Controls.Add(this.WelcomeText);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(769, 551);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Профиль";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // LoadImage
            // 
            this.LoadImage.AutoSize = true;
            this.LoadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadImage.Location = new System.Drawing.Point(34, 192);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(108, 13);
            this.LoadImage.TabIndex = 5;
            this.LoadImage.Text = "Загрузить аватарку";
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // AvatarProfile
            // 
            this.AvatarProfile.Image = global::Фитнес_тренер.Properties.Resources.b10495dc4b720ed600f47b71ec9bf38ccbdaf7c1;
            this.AvatarProfile.Location = new System.Drawing.Point(11, 17);
            this.AvatarProfile.Name = "AvatarProfile";
            this.AvatarProfile.Size = new System.Drawing.Size(157, 161);
            this.AvatarProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarProfile.TabIndex = 4;
            this.AvatarProfile.TabStop = false;
            // 
            // NickName
            // 
            this.NickName.AutoSize = true;
            this.NickName.Location = new System.Drawing.Point(312, 28);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(16, 13);
            this.NickName.TabIndex = 3;
            this.NickName.Text = "...";
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Location = new System.Drawing.Point(199, 28);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(107, 13);
            this.WelcomeText.TabIndex = 2;
            this.WelcomeText.Text = "Добро пожаловать:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(769, 551);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Тренировки";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(769, 551);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Диеты";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(769, 551);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "О программе";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(769, 551);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "Справка";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // UpMainPanel
            // 
            this.UpMainPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.UpMainPanel.BackgroundImage = global::Фитнес_тренер.Properties.Resources.BackGraund;
            this.UpMainPanel.Controls.Add(this.Авторизация);
            this.UpMainPanel.Controls.Add(this.Exitbutton);
            this.UpMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpMainPanel.Location = new System.Drawing.Point(0, 0);
            this.UpMainPanel.Name = "UpMainPanel";
            this.UpMainPanel.Size = new System.Drawing.Size(777, 52);
            this.UpMainPanel.TabIndex = 11;
            this.UpMainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpMainPanel_MouseDown);
            this.UpMainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpMainPanel_MouseMove);
            // 
            // Авторизация
            // 
            this.Авторизация.AutoSize = true;
            this.Авторизация.BackColor = System.Drawing.Color.Transparent;
            this.Авторизация.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Авторизация.ForeColor = System.Drawing.SystemColors.Control;
            this.Авторизация.Location = new System.Drawing.Point(12, 9);
            this.Авторизация.Name = "Авторизация";
            this.Авторизация.Size = new System.Drawing.Size(222, 33);
            this.Авторизация.TabIndex = 9;
            this.Авторизация.Text = "Фитнес тренер";
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.White;
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exitbutton.Location = new System.Drawing.Point(687, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(90, 52);
            this.Exitbutton.TabIndex = 10;
            this.Exitbutton.Text = "Выйти";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.LoadImage);
            this.panel1.Controls.Add(this.AvatarProfile);
            this.panel1.Location = new System.Drawing.Point(3, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 218);
            this.panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 645);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainPanel.ResumeLayout(false);
            this.ProfileTab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarProfile)).EndInit();
            this.UpMainPanel.ResumeLayout(false);
            this.UpMainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label Авторизация;
        private System.Windows.Forms.Panel UpMainPanel;
        private MetroFramework.Controls.MetroTabControl ProfileTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Label NickName;
        private System.Windows.Forms.Label WelcomeText;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private System.Windows.Forms.Label LoadImage;
        private System.Windows.Forms.PictureBox AvatarProfile;
        private System.Windows.Forms.Panel panel1;
    }
}