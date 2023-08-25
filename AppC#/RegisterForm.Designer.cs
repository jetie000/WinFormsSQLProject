namespace AppC_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.passwordRepeatText = new System.Windows.Forms.TextBox();
            this.loginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.quit = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.phoneText);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelRepeatPassword);
            this.panel1.Controls.Add(this.passwordRepeatText);
            this.panel1.Controls.Add(this.loginLinkLabel);
            this.panel1.Controls.Add(this.quit);
            this.panel1.Controls.Add(this.buttonEnter);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Controls.Add(this.loginText);
            this.panel1.Controls.Add(this.RegisterLabel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 350);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(24, 220);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(119, 16);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "Номер телефона";
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.AutoSize = true;
            this.labelRepeatPassword.Location = new System.Drawing.Point(24, 176);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Size = new System.Drawing.Size(129, 16);
            this.labelRepeatPassword.TabIndex = 17;
            this.labelRepeatPassword.Text = "Повторите пароль";
            // 
            // passwordRepeatText
            // 
            this.passwordRepeatText.Location = new System.Drawing.Point(27, 195);
            this.passwordRepeatText.Name = "passwordRepeatText";
            this.passwordRepeatText.Size = new System.Drawing.Size(199, 22);
            this.passwordRepeatText.TabIndex = 3;
            this.passwordRepeatText.UseSystemPasswordChar = true;
            this.passwordRepeatText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordRepeatText_KeyPress);
            // 
            // loginLinkLabel
            // 
            this.loginLinkLabel.AutoSize = true;
            this.loginLinkLabel.LinkColor = System.Drawing.Color.Gray;
            this.loginLinkLabel.Location = new System.Drawing.Point(64, 315);
            this.loginLinkLabel.Name = "loginLinkLabel";
            this.loginLinkLabel.Size = new System.Drawing.Size(128, 16);
            this.loginLinkLabel.TabIndex = 6;
            this.loginLinkLabel.TabStop = true;
            this.loginLinkLabel.Text = "Уже есть аккаунт?";
            this.loginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLinkLabel_LinkClicked);
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.BackColor = System.Drawing.Color.Gainsboro;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quit.Location = new System.Drawing.Point(224, 2);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(26, 25);
            this.quit.TabIndex = 7;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            this.quit.MouseEnter += new System.EventHandler(this.quit_MouseEnter);
            this.quit.MouseLeave += new System.EventHandler(this.quit_MouseLeave);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Location = new System.Drawing.Point(50, 272);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(155, 33);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "Зарегистрироваться";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(24, 132);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 16);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(24, 88);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(46, 16);
            this.labelLogin.TabIndex = 15;
            this.labelLogin.Text = "Логин";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(27, 151);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(199, 22);
            this.passwordText.TabIndex = 2;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordText_KeyPress);
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(27, 107);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(199, 22);
            this.loginText.TabIndex = 1;
            this.loginText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginText_KeyPress);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLabel.Location = new System.Drawing.Point(44, 38);
            this.RegisterLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(169, 35);
            this.RegisterLabel.TabIndex = 0;
            this.RegisterLabel.Text = "Регистрация";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(27, 239);
            this.phoneText.Mask = "+375 (99) 000-0000";
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(199, 22);
            this.phoneText.TabIndex = 4;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel loginLinkLabel;
        private System.Windows.Forms.Label quit;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label labelRepeatPassword;
        private System.Windows.Forms.TextBox passwordRepeatText;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.MaskedTextBox phoneText;
    }
}