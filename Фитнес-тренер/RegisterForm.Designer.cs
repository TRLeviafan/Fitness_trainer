namespace Фитнес_тренер
{
    partial class RegisterForm
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
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WeightComboBox = new System.Windows.Forms.ComboBox();
            this.HeightComboBox = new System.Windows.Forms.ComboBox();
            this.AgeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Регистрация = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainPanel.BackgroundImage = global::Фитнес_тренер.Properties.Resources.BackGraund;
            this.MainPanel.Controls.Add(this.GenderComboBox);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.WeightComboBox);
            this.MainPanel.Controls.Add(this.HeightComboBox);
            this.MainPanel.Controls.Add(this.AgeComboBox);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.LabelAge);
            this.MainPanel.Controls.Add(this.LabelPassword);
            this.MainPanel.Controls.Add(this.LabelLogin);
            this.MainPanel.Controls.Add(this.buttonRegister);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.Регистрация);
            this.MainPanel.Controls.Add(this.RegisterLabel);
            this.MainPanel.Controls.Add(this.PassField);
            this.MainPanel.Controls.Add(this.LoginField);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(639, 477);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.GenderComboBox.Location = new System.Drawing.Point(215, 299);
            this.GenderComboBox.MaxDropDownItems = 2;
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(110, 21);
            this.GenderComboBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(129, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Пол:";
            // 
            // WeightComboBox
            // 
            this.WeightComboBox.FormattingEnabled = true;
            this.WeightComboBox.Items.AddRange(new object[] {
            "25 ",
            "26 ",
            "27 ",
            "28 ",
            "29 ",
            "30 ",
            "31 ",
            "32 ",
            "33 ",
            "34 ",
            "35 ",
            "36 ",
            "37 ",
            "38 ",
            "39 ",
            "40 ",
            "41 ",
            "42 ",
            "43 ",
            "44 ",
            "45 ",
            "46 ",
            "47 ",
            "48 ",
            "49 ",
            "50 ",
            "51 ",
            "52 ",
            "53 ",
            "54 ",
            "55 ",
            "56 ",
            "57 ",
            "58 ",
            "59 ",
            "60 ",
            "61 ",
            "62 ",
            "63 ",
            "64 ",
            "65 ",
            "66 ",
            "67 ",
            "68 ",
            "69 ",
            "70 ",
            "71 ",
            "72 ",
            "73 ",
            "74 ",
            "75 ",
            "76 ",
            "77 ",
            "78 ",
            "79 ",
            "80 ",
            "81 ",
            "82 ",
            "83 ",
            "84 ",
            "85 ",
            "86 ",
            "87 ",
            "88 ",
            "89 ",
            "90 ",
            "91 ",
            "92 ",
            "93 ",
            "94 ",
            "95 ",
            "96 ",
            "97 ",
            "98 ",
            "99 ",
            "100 ",
            "101 ",
            "102 ",
            "103 ",
            "104 ",
            "105 ",
            "106 ",
            "107 ",
            "108 ",
            "109 ",
            "110 ",
            "111 ",
            "112 ",
            "113 ",
            "114 ",
            "115 ",
            "116 ",
            "117 ",
            "118 ",
            "119 ",
            "120 ",
            "121 ",
            "122 ",
            "123 ",
            "124 ",
            "125 ",
            "126 ",
            "127 ",
            "128 ",
            "129 ",
            "130 ",
            "131 ",
            "132 ",
            "133 ",
            "134 ",
            "135 ",
            "136 ",
            "137 ",
            "138 ",
            "139 ",
            "140 ",
            "141 ",
            "142 ",
            "143 ",
            "144 ",
            "145 ",
            "146 ",
            "147 ",
            "148 ",
            "149 ",
            "150 ",
            "151 ",
            "152 ",
            "153 ",
            "154 ",
            "155 ",
            "156 ",
            "157 ",
            "158 ",
            "159 ",
            "160 "});
            this.WeightComboBox.Location = new System.Drawing.Point(215, 267);
            this.WeightComboBox.MaxDropDownItems = 2;
            this.WeightComboBox.MaxLength = 3;
            this.WeightComboBox.Name = "WeightComboBox";
            this.WeightComboBox.Size = new System.Drawing.Size(110, 21);
            this.WeightComboBox.TabIndex = 21;
            // 
            // HeightComboBox
            // 
            this.HeightComboBox.FormattingEnabled = true;
            this.HeightComboBox.Items.AddRange(new object[] {
            "100 ",
            "101 ",
            "102 ",
            "103 ",
            "104 ",
            "105 ",
            "106 ",
            "107 ",
            "108 ",
            "109 ",
            "110 ",
            "111 ",
            "112 ",
            "113 ",
            "114 ",
            "115 ",
            "116 ",
            "117 ",
            "118 ",
            "119 ",
            "120 ",
            "121 ",
            "122 ",
            "123 ",
            "124 ",
            "125 ",
            "126 ",
            "127 ",
            "128 ",
            "129 ",
            "130 ",
            "131 ",
            "132 ",
            "133 ",
            "134 ",
            "135 ",
            "136 ",
            "137 ",
            "138 ",
            "139 ",
            "140 ",
            "141 ",
            "142 ",
            "143 ",
            "144 ",
            "145 ",
            "146 ",
            "147 ",
            "148 ",
            "149 ",
            "150 ",
            "151 ",
            "152 ",
            "153 ",
            "154 ",
            "155 ",
            "156 ",
            "157 ",
            "158 ",
            "159 ",
            "160 ",
            "161 ",
            "162 ",
            "163 ",
            "164 ",
            "165 ",
            "166 ",
            "167 ",
            "168 ",
            "169 ",
            "170 ",
            "171 ",
            "172 ",
            "173 ",
            "174 ",
            "175 ",
            "176 ",
            "177 ",
            "178 ",
            "179 ",
            "180 ",
            "181 ",
            "182 ",
            "183 ",
            "184 ",
            "185 ",
            "186 ",
            "187 ",
            "188 ",
            "189 ",
            "190 ",
            "191 ",
            "192 ",
            "193 ",
            "194 ",
            "195 ",
            "196 ",
            "197 ",
            "198 ",
            "199 ",
            "200 ",
            "201 ",
            "202 ",
            "203 ",
            "204 ",
            "205 ",
            "206 ",
            "207 ",
            "208 ",
            "209 ",
            "210 "});
            this.HeightComboBox.Location = new System.Drawing.Point(215, 236);
            this.HeightComboBox.MaxDropDownItems = 2;
            this.HeightComboBox.MaxLength = 3;
            this.HeightComboBox.Name = "HeightComboBox";
            this.HeightComboBox.Size = new System.Drawing.Size(110, 21);
            this.HeightComboBox.TabIndex = 20;
            // 
            // AgeComboBox
            // 
            this.AgeComboBox.FormattingEnabled = true;
            this.AgeComboBox.Items.AddRange(new object[] {
            "6 ",
            "7 ",
            "8 ",
            "9 ",
            "10 ",
            "11 ",
            "12 ",
            "13 ",
            "14 ",
            "15 ",
            "16 ",
            "17 ",
            "18 ",
            "19 ",
            "20 ",
            "21 ",
            "22 ",
            "23 ",
            "24 ",
            "25 ",
            "26 ",
            "27 ",
            "28 ",
            "29 ",
            "30 ",
            "31 ",
            "32 ",
            "33 ",
            "34 ",
            "35 ",
            "36 ",
            "37 ",
            "38 ",
            "39 ",
            "40 ",
            "41 ",
            "42 ",
            "43 ",
            "44 ",
            "45 ",
            "46 ",
            "47 ",
            "48 ",
            "49 ",
            "50 ",
            "51 ",
            "52 ",
            "53 ",
            "54 ",
            "55 ",
            "56 ",
            "57 ",
            "58 ",
            "59 ",
            "60 ",
            "61 ",
            "62 ",
            "63 ",
            "64 ",
            "65 ",
            "66 ",
            "67 ",
            "68 ",
            "69 ",
            "70 "});
            this.AgeComboBox.Location = new System.Drawing.Point(215, 204);
            this.AgeComboBox.MaxDropDownItems = 2;
            this.AgeComboBox.MaxLength = 3;
            this.AgeComboBox.Name = "AgeComboBox";
            this.AgeComboBox.Size = new System.Drawing.Size(110, 21);
            this.AgeComboBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(129, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Рост:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(129, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Вес:";
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.BackColor = System.Drawing.Color.Transparent;
            this.LabelAge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAge.ForeColor = System.Drawing.Color.GhostWhite;
            this.LabelAge.Location = new System.Drawing.Point(129, 204);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(79, 21);
            this.LabelAge.TabIndex = 16;
            this.LabelAge.Text = "Возраст:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.ForeColor = System.Drawing.Color.GhostWhite;
            this.LabelPassword.Location = new System.Drawing.Point(129, 164);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(73, 21);
            this.LabelPassword.TabIndex = 15;
            this.LabelPassword.Text = "Пароль:";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.ForeColor = System.Drawing.Color.GhostWhite;
            this.LabelLogin.Location = new System.Drawing.Point(129, 125);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(65, 21);
            this.LabelLogin.TabIndex = 9;
            this.LabelLogin.Text = "Логин:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(182, 371);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(284, 49);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(543, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Регистрация
            // 
            this.Регистрация.AutoSize = true;
            this.Регистрация.BackColor = System.Drawing.Color.Transparent;
            this.Регистрация.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Регистрация.ForeColor = System.Drawing.SystemColors.Control;
            this.Регистрация.Location = new System.Drawing.Point(173, 41);
            this.Регистрация.Name = "Регистрация";
            this.Регистрация.Size = new System.Drawing.Size(293, 52);
            this.Регистрация.TabIndex = 0;
            this.Регистрация.Text = "Регистрация";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RegisterLabel.Location = new System.Drawing.Point(262, 438);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(109, 20);
            this.RegisterLabel.TabIndex = 7;
            this.RegisterLabel.Text = "Авторизация";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(215, 159);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(206, 32);
            this.PassField.TabIndex = 5;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(215, 120);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(206, 26);
            this.LoginField.TabIndex = 3;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 477);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Регистрация;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.ComboBox AgeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.ComboBox WeightComboBox;
        private System.Windows.Forms.ComboBox HeightComboBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label label1;
    }
}