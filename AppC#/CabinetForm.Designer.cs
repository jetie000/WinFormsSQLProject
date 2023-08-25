namespace AppC_
{
    partial class CabinetForm
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
            this.labelCabinet = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.tabControlCabinet = new System.Windows.Forms.TabControl();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.labelIdProduct = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelShowNumber = new System.Windows.Forms.Label();
            this.labelShowDate = new System.Windows.Forms.Label();
            this.labelShowCity = new System.Windows.Forms.Label();
            this.labelShowPrice = new System.Windows.Forms.Label();
            this.labelShowCategory = new System.Windows.Forms.Label();
            this.labelShowName = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.buttonChangeInfo = new System.Windows.Forms.Button();
            this.labelChangeInfo = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.phoneChangeTextBox = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.loginChangeTextBox = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.passwordChangeTextBox = new System.Windows.Forms.TextBox();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.panelChats = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonOpenMessenger = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelQuit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControlCabinet.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            this.panelChats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelCabinet);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.tabControlCabinet);
            this.panel1.Controls.Add(this.labelQuit);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 425);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // labelCabinet
            // 
            this.labelCabinet.AutoSize = true;
            this.labelCabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCabinet.Location = new System.Drawing.Point(38, 3);
            this.labelCabinet.Name = "labelCabinet";
            this.labelCabinet.Size = new System.Drawing.Size(148, 22);
            this.labelCabinet.TabIndex = 53;
            this.labelCabinet.Text = "Личный кабинет";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(354, 3);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(60, 24);
            this.labelUsername.TabIndex = 52;
            this.labelUsername.Text = "label1";
            // 
            // tabControlCabinet
            // 
            this.tabControlCabinet.Controls.Add(this.tabPageProducts);
            this.tabControlCabinet.Controls.Add(this.tabPageSettings);
            this.tabControlCabinet.Controls.Add(this.tabPageMessages);
            this.tabControlCabinet.Location = new System.Drawing.Point(3, 28);
            this.tabControlCabinet.Name = "tabControlCabinet";
            this.tabControlCabinet.SelectedIndex = 0;
            this.tabControlCabinet.Size = new System.Drawing.Size(576, 392);
            this.tabControlCabinet.TabIndex = 51;
            this.tabControlCabinet.SelectedIndexChanged += new System.EventHandler(this.tabControlCabinet_SelectedIndexChanged);
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.panelProducts);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 25);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(568, 363);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Мои объявления";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // panelProducts
            // 
            this.panelProducts.AutoScroll = true;
            this.panelProducts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelProducts.Controls.Add(this.labelIdProduct);
            this.panelProducts.Controls.Add(this.buttonDelete);
            this.panelProducts.Controls.Add(this.buttonEdit);
            this.panelProducts.Controls.Add(this.labelShowNumber);
            this.panelProducts.Controls.Add(this.labelShowDate);
            this.panelProducts.Controls.Add(this.labelShowCity);
            this.panelProducts.Controls.Add(this.labelShowPrice);
            this.panelProducts.Controls.Add(this.labelShowCategory);
            this.panelProducts.Controls.Add(this.labelShowName);
            this.panelProducts.Location = new System.Drawing.Point(6, 6);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(556, 351);
            this.panelProducts.TabIndex = 50;
            // 
            // labelIdProduct
            // 
            this.labelIdProduct.AutoSize = true;
            this.labelIdProduct.Location = new System.Drawing.Point(502, 22);
            this.labelIdProduct.Name = "labelIdProduct";
            this.labelIdProduct.Size = new System.Drawing.Size(18, 16);
            this.labelIdProduct.TabIndex = 8;
            this.labelIdProduct.Text = "id";
            this.labelIdProduct.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(430, 125);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 31);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(19, 125);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(116, 31);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelShowNumber
            // 
            this.labelShowNumber.AutoSize = true;
            this.labelShowNumber.Location = new System.Drawing.Point(425, 93);
            this.labelShowNumber.Name = "labelShowNumber";
            this.labelShowNumber.Size = new System.Drawing.Size(101, 16);
            this.labelShowNumber.TabIndex = 5;
            this.labelShowNumber.Text = "Телефон созд";
            this.labelShowNumber.Visible = false;
            // 
            // labelShowDate
            // 
            this.labelShowDate.AutoSize = true;
            this.labelShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowDate.Location = new System.Drawing.Point(15, 93);
            this.labelShowDate.Name = "labelShowDate";
            this.labelShowDate.Size = new System.Drawing.Size(52, 20);
            this.labelShowDate.TabIndex = 4;
            this.labelShowDate.Text = "Дата";
            this.labelShowDate.Visible = false;
            // 
            // labelShowCity
            // 
            this.labelShowCity.AutoSize = true;
            this.labelShowCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowCity.Location = new System.Drawing.Point(425, 55);
            this.labelShowCity.Name = "labelShowCity";
            this.labelShowCity.Size = new System.Drawing.Size(74, 25);
            this.labelShowCity.TabIndex = 3;
            this.labelShowCity.Text = "Город";
            this.labelShowCity.Visible = false;
            // 
            // labelShowPrice
            // 
            this.labelShowPrice.AutoSize = true;
            this.labelShowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowPrice.Location = new System.Drawing.Point(425, 15);
            this.labelShowPrice.Name = "labelShowPrice";
            this.labelShowPrice.Size = new System.Drawing.Size(58, 25);
            this.labelShowPrice.TabIndex = 2;
            this.labelShowPrice.Text = "Цена";
            this.labelShowPrice.Visible = false;
            // 
            // labelShowCategory
            // 
            this.labelShowCategory.AutoSize = true;
            this.labelShowCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowCategory.Location = new System.Drawing.Point(15, 57);
            this.labelShowCategory.Name = "labelShowCategory";
            this.labelShowCategory.Size = new System.Drawing.Size(97, 22);
            this.labelShowCategory.TabIndex = 1;
            this.labelShowCategory.Text = "Категория";
            this.labelShowCategory.Visible = false;
            // 
            // labelShowName
            // 
            this.labelShowName.AutoSize = true;
            this.labelShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowName.Location = new System.Drawing.Point(14, 15);
            this.labelShowName.Name = "labelShowName";
            this.labelShowName.Size = new System.Drawing.Size(122, 29);
            this.labelShowName.TabIndex = 0;
            this.labelShowName.Text = "Название";
            this.labelShowName.Visible = false;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.buttonChangeInfo);
            this.tabPageSettings.Controls.Add(this.labelChangeInfo);
            this.tabPageSettings.Controls.Add(this.labelPhone);
            this.tabPageSettings.Controls.Add(this.phoneChangeTextBox);
            this.tabPageSettings.Controls.Add(this.labelPassword);
            this.tabPageSettings.Controls.Add(this.loginChangeTextBox);
            this.tabPageSettings.Controls.Add(this.labelLogin);
            this.tabPageSettings.Controls.Add(this.passwordChangeTextBox);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(568, 363);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Мои данные";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // buttonChangeInfo
            // 
            this.buttonChangeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeInfo.Location = new System.Drawing.Point(177, 292);
            this.buttonChangeInfo.Name = "buttonChangeInfo";
            this.buttonChangeInfo.Size = new System.Drawing.Size(226, 35);
            this.buttonChangeInfo.TabIndex = 26;
            this.buttonChangeInfo.Text = "Применить";
            this.buttonChangeInfo.UseVisualStyleBackColor = true;
            this.buttonChangeInfo.Click += new System.EventHandler(this.buttonChangeInfo_Click);
            // 
            // labelChangeInfo
            // 
            this.labelChangeInfo.AutoSize = true;
            this.labelChangeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangeInfo.Location = new System.Drawing.Point(182, 36);
            this.labelChangeInfo.Name = "labelChangeInfo";
            this.labelChangeInfo.Size = new System.Drawing.Size(217, 29);
            this.labelChangeInfo.TabIndex = 25;
            this.labelChangeInfo.Text = "Изменить данные";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(174, 222);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(153, 22);
            this.labelPhone.TabIndex = 24;
            this.labelPhone.Text = "Номер телефона";
            // 
            // phoneChangeTextBox
            // 
            this.phoneChangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneChangeTextBox.Location = new System.Drawing.Point(177, 247);
            this.phoneChangeTextBox.MaxLength = 15;
            this.phoneChangeTextBox.Name = "phoneChangeTextBox";
            this.phoneChangeTextBox.Size = new System.Drawing.Size(226, 28);
            this.phoneChangeTextBox.TabIndex = 21;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(174, 166);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(72, 22);
            this.labelPassword.TabIndex = 23;
            this.labelPassword.Text = "Пароль";
            // 
            // loginChangeTextBox
            // 
            this.loginChangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginChangeTextBox.Location = new System.Drawing.Point(177, 135);
            this.loginChangeTextBox.MaxLength = 30;
            this.loginChangeTextBox.Name = "loginChangeTextBox";
            this.loginChangeTextBox.Size = new System.Drawing.Size(226, 28);
            this.loginChangeTextBox.TabIndex = 19;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(174, 110);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(60, 22);
            this.labelLogin.TabIndex = 22;
            this.labelLogin.Text = "Логин";
            // 
            // passwordChangeTextBox
            // 
            this.passwordChangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordChangeTextBox.Location = new System.Drawing.Point(177, 191);
            this.passwordChangeTextBox.MaxLength = 30;
            this.passwordChangeTextBox.Name = "passwordChangeTextBox";
            this.passwordChangeTextBox.Size = new System.Drawing.Size(226, 28);
            this.passwordChangeTextBox.TabIndex = 20;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.panelChats);
            this.tabPageMessages.Location = new System.Drawing.Point(4, 25);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(568, 363);
            this.tabPageMessages.TabIndex = 2;
            this.tabPageMessages.Text = "Мои сообщения";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // panelChats
            // 
            this.panelChats.BackColor = System.Drawing.Color.Moccasin;
            this.panelChats.Controls.Add(this.labelId);
            this.panelChats.Controls.Add(this.buttonOpenMessenger);
            this.panelChats.Controls.Add(this.labelNumber);
            this.panelChats.Controls.Add(this.labelDate);
            this.panelChats.Controls.Add(this.labelMessage);
            this.panelChats.Location = new System.Drawing.Point(114, 6);
            this.panelChats.Name = "panelChats";
            this.panelChats.Size = new System.Drawing.Size(338, 351);
            this.panelChats.TabIndex = 3;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(135, 15);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 16);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "ID";
            this.labelId.Visible = false;
            // 
            // buttonOpenMessenger
            // 
            this.buttonOpenMessenger.Location = new System.Drawing.Point(201, 8);
            this.buttonOpenMessenger.Name = "buttonOpenMessenger";
            this.buttonOpenMessenger.Size = new System.Drawing.Size(132, 23);
            this.buttonOpenMessenger.TabIndex = 3;
            this.buttonOpenMessenger.Text = "Открыть чат";
            this.buttonOpenMessenger.UseVisualStyleBackColor = true;
            this.buttonOpenMessenger.Visible = false;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(15, 11);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(66, 22);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер";
            this.labelNumber.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(198, 42);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 16);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Дата";
            this.labelDate.Visible = false;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(16, 42);
            this.labelMessage.MaximumSize = new System.Drawing.Size(200, 16);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(176, 16);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Последнее сообщение112";
            this.labelMessage.Visible = false;
            // 
            // labelQuit
            // 
            this.labelQuit.AutoSize = true;
            this.labelQuit.BackColor = System.Drawing.Color.Gainsboro;
            this.labelQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuit.Location = new System.Drawing.Point(553, 3);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(26, 25);
            this.labelQuit.TabIndex = 6;
            this.labelQuit.Text = "X";
            this.labelQuit.Click += new System.EventHandler(this.labelQuit_Click);
            // 
            // CabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CabinetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CabinetForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CabinetForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlCabinet.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panelProducts.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabPageMessages.ResumeLayout(false);
            this.panelChats.ResumeLayout(false);
            this.panelChats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelQuit;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TabControl tabControlCabinet;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Label labelShowNumber;
        private System.Windows.Forms.Label labelShowDate;
        private System.Windows.Forms.Label labelShowCity;
        private System.Windows.Forms.Label labelShowPrice;
        private System.Windows.Forms.Label labelShowCategory;
        private System.Windows.Forms.Label labelShowName;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button buttonChangeInfo;
        private System.Windows.Forms.Label labelChangeInfo;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox phoneChangeTextBox;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox loginChangeTextBox;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox passwordChangeTextBox;
        private System.Windows.Forms.Label labelCabinet;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelIdProduct;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.Panel panelChats;
        private System.Windows.Forms.Button buttonOpenMessenger;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelId;
    }
}