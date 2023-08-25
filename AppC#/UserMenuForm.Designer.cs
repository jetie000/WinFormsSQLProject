namespace AppC_
{
    partial class UserMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenuForm));
            this.quit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.buttonOpenMessenger = new System.Windows.Forms.Button();
            this.labelShowNumber = new System.Windows.Forms.Label();
            this.labelShowDate = new System.Windows.Forms.Label();
            this.labelShowCity = new System.Windows.Forms.Label();
            this.labelShowPrice = new System.Windows.Forms.Label();
            this.labelShowCategory = new System.Windows.Forms.Label();
            this.labelShowName = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelFilters = new System.Windows.Forms.Label();
            this.priceMaxTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.priceMinTextBox = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.labelNoText = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonCabinet = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelNotification = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.BackColor = System.Drawing.Color.Gainsboro;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quit.Location = new System.Drawing.Point(757, 4);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(26, 25);
            this.quit.TabIndex = 6;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelNotification);
            this.panel1.Controls.Add(this.panelProducts);
            this.panel1.Controls.Add(this.buttonShow);
            this.panel1.Controls.Add(this.labelFilters);
            this.panel1.Controls.Add(this.priceMaxTextBox);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.labelCity);
            this.panel1.Controls.Add(this.priceMinTextBox);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(this.pictureBoxSearch);
            this.panel1.Controls.Add(this.labelNoText);
            this.panel1.Controls.Add(this.buttonAddProduct);
            this.panel1.Controls.Add(this.buttonCabinet);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Controls.Add(this.quit);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 593);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panelProducts
            // 
            this.panelProducts.AutoScroll = true;
            this.panelProducts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelProducts.Controls.Add(this.buttonOpenMessenger);
            this.panelProducts.Controls.Add(this.labelShowNumber);
            this.panelProducts.Controls.Add(this.labelShowDate);
            this.panelProducts.Controls.Add(this.labelShowCity);
            this.panelProducts.Controls.Add(this.labelShowPrice);
            this.panelProducts.Controls.Add(this.labelShowCategory);
            this.panelProducts.Controls.Add(this.labelShowName);
            this.panelProducts.Location = new System.Drawing.Point(220, 79);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(555, 501);
            this.panelProducts.TabIndex = 49;
            // 
            // buttonOpenMessenger
            // 
            this.buttonOpenMessenger.Location = new System.Drawing.Point(243, 90);
            this.buttonOpenMessenger.Name = "buttonOpenMessenger";
            this.buttonOpenMessenger.Size = new System.Drawing.Size(159, 23);
            this.buttonOpenMessenger.TabIndex = 6;
            this.buttonOpenMessenger.Text = "Написать владельцу";
            this.buttonOpenMessenger.UseVisualStyleBackColor = true;
            this.buttonOpenMessenger.Visible = false;
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
            this.labelShowPrice.Location = new System.Drawing.Point(425, 18);
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
            this.labelShowName.Location = new System.Drawing.Point(15, 15);
            this.labelShowName.Name = "labelShowName";
            this.labelShowName.Size = new System.Drawing.Size(122, 29);
            this.labelShowName.TabIndex = 0;
            this.labelShowName.Text = "Название";
            this.labelShowName.Visible = false;
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShow.Location = new System.Drawing.Point(19, 353);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(181, 41);
            this.buttonShow.TabIndex = 48;
            this.buttonShow.Text = "Показать объявления";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilters.Location = new System.Drawing.Point(58, 155);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(103, 27);
            this.labelFilters.TabIndex = 47;
            this.labelFilters.Text = "Фильтры";
            // 
            // priceMaxTextBox
            // 
            this.priceMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceMaxTextBox.ForeColor = System.Drawing.Color.Gray;
            this.priceMaxTextBox.Location = new System.Drawing.Point(113, 265);
            this.priceMaxTextBox.MaxLength = 15;
            this.priceMaxTextBox.Name = "priceMaxTextBox";
            this.priceMaxTextBox.Size = new System.Drawing.Size(87, 24);
            this.priceMaxTextBox.TabIndex = 46;
            this.priceMaxTextBox.Text = "До";
            this.priceMaxTextBox.Enter += new System.EventHandler(this.priceMaxTextBox_Enter);
            this.priceMaxTextBox.Leave += new System.EventHandler(this.priceMaxTextBox_Leave);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Все категории",
            "Транспорт",
            "Недвижимость",
            "Личные вещи",
            "Одежда и обувь",
            "Для дома и дачи",
            "Электроника",
            "Хобии и отдых",
            "Животные",
            "Бизнес и оборудование",
            "Для детей",
            "Красота и здоровье"});
            this.categoryComboBox.Location = new System.Drawing.Point(20, 211);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(180, 26);
            this.categoryComboBox.TabIndex = 45;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(18, 189);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(80, 18);
            this.labelCategory.TabIndex = 44;
            this.labelCategory.Text = "Категория";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(16, 294);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(52, 18);
            this.labelCity.TabIndex = 43;
            this.labelCity.Text = "Город";
            // 
            // priceMinTextBox
            // 
            this.priceMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceMinTextBox.ForeColor = System.Drawing.Color.Gray;
            this.priceMinTextBox.Location = new System.Drawing.Point(19, 265);
            this.priceMinTextBox.MaxLength = 15;
            this.priceMinTextBox.Name = "priceMinTextBox";
            this.priceMinTextBox.Size = new System.Drawing.Size(87, 24);
            this.priceMinTextBox.TabIndex = 40;
            this.priceMinTextBox.Text = "От";
            this.priceMinTextBox.Enter += new System.EventHandler(this.priceMinTextBox_Enter);
            this.priceMinTextBox.Leave += new System.EventHandler(this.priceMinTextBox_Leave);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(17, 243);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(65, 18);
            this.labelPrice.TabIndex = 42;
            this.labelPrice.Text = "Цена (р)";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.Location = new System.Drawing.Point(19, 316);
            this.cityTextBox.MaxLength = 30;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(181, 24);
            this.cityTextBox.TabIndex = 41;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(438, 12);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearch.TabIndex = 16;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelNoText
            // 
            this.labelNoText.AutoSize = true;
            this.labelNoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoText.Location = new System.Drawing.Point(408, 13);
            this.labelNoText.Name = "labelNoText";
            this.labelNoText.Size = new System.Drawing.Size(30, 29);
            this.labelNoText.TabIndex = 15;
            this.labelNoText.Text = "X";
            this.labelNoText.Click += new System.EventHandler(this.labelNoText_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddProduct.Location = new System.Drawing.Point(520, 4);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(131, 60);
            this.buttonAddProduct.TabIndex = 14;
            this.buttonAddProduct.Text = "Подать объявление";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonCabinet
            // 
            this.buttonCabinet.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCabinet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonCabinet.Location = new System.Drawing.Point(675, 9);
            this.buttonCabinet.Name = "buttonCabinet";
            this.buttonCabinet.Size = new System.Drawing.Size(50, 50);
            this.buttonCabinet.TabIndex = 13;
            this.buttonCabinet.Text = "U";
            this.buttonCabinet.UseVisualStyleBackColor = false;
            this.buttonCabinet.Click += new System.EventHandler(this.buttonCabinet_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.Location = new System.Drawing.Point(206, 10);
            this.searchTextBox.MaxLength = 30;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(201, 34);
            this.searchTextBox.TabIndex = 12;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(11, 13);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(189, 25);
            this.labelSearch.TabIndex = 11;
            this.labelSearch.Text = "Поиск по названию";
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.BackColor = System.Drawing.Color.SkyBlue;
            this.labelNotification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNotification.Location = new System.Drawing.Point(716, 4);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(16, 18);
            this.labelNotification.TabIndex = 50;
            this.labelNotification.Text = "1";
            this.labelNotification.Visible = false;
            // 
            // UserMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 593);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMenuForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelProducts.ResumeLayout(false);
            this.panelProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label quit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Label labelNoText;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonCabinet;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox priceMinTextBox;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox priceMaxTextBox;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Label labelShowNumber;
        private System.Windows.Forms.Label labelShowDate;
        private System.Windows.Forms.Label labelShowCity;
        private System.Windows.Forms.Label labelShowPrice;
        private System.Windows.Forms.Label labelShowCategory;
        private System.Windows.Forms.Label labelShowName;
        private System.Windows.Forms.Button buttonOpenMessenger;
        private System.Windows.Forms.Label labelNotification;
    }
}