namespace AppC_
{
    partial class NewProductForm
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
            this.quit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.labelQuit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.BackColor = System.Drawing.Color.Gainsboro;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quit.Location = new System.Drawing.Point(385, 30);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(26, 25);
            this.quit.TabIndex = 7;
            this.quit.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonAddProduct);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelCity);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(this.labelQuit);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 276);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonAddProduct.Location = new System.Drawing.Point(11, 218);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(221, 45);
            this.buttonAddProduct.TabIndex = 48;
            this.buttonAddProduct.Text = "Добавить объявление";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
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
            this.categoryComboBox.Location = new System.Drawing.Point(11, 91);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(221, 24);
            this.categoryComboBox.TabIndex = 47;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(11, 72);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(75, 16);
            this.labelCategory.TabIndex = 46;
            this.labelCategory.Text = "Категория";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 16);
            this.labelName.TabIndex = 43;
            this.labelName.Text = "Название";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(8, 162);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(46, 16);
            this.labelCity.TabIndex = 45;
            this.labelCity.Text = "Город";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(11, 47);
            this.nameTextBox.MaxLength = 30;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(221, 22);
            this.nameTextBox.TabIndex = 40;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(11, 137);
            this.priceTextBox.MaxLength = 15;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(221, 22);
            this.priceTextBox.TabIndex = 41;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(8, 118);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 16);
            this.labelPrice.TabIndex = 44;
            this.labelPrice.Text = "Цена (р)";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(11, 181);
            this.cityTextBox.MaxLength = 30;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(221, 22);
            this.cityTextBox.TabIndex = 42;
            // 
            // labelQuit
            // 
            this.labelQuit.AutoSize = true;
            this.labelQuit.BackColor = System.Drawing.Color.Gainsboro;
            this.labelQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuit.Location = new System.Drawing.Point(206, 8);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(26, 25);
            this.labelQuit.TabIndex = 6;
            this.labelQuit.Text = "X";
            this.labelQuit.Click += new System.EventHandler(this.labelQuit_Click);
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewProductForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelQuit;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox cityTextBox;
    }
}