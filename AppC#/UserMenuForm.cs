using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppC_
{
    public partial class UserMenuForm : Form
    {
        int userId;
        int counter = 0;
        int nameY = 15, categoryY = 57, priceY = 18, dateY = 93, phoneY = 93, cityY = 55;
        MessengerForm openedMessengerForm;
        DB DB = new DB();

        public UserMenuForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            setUserLetter(userId);
        }

        private void setUserLetter(int userId)
        {
            string command = $"SELECT login, leaveDate FROM users WHERE id = '{userId}'";
            SqlCommand comm = new SqlCommand(command, DB.getConnection());
            DB.openConnection();
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            buttonCabinet.Text = Convert.ToString(Convert.ToString(reader["login"])[0]);

            string commandMsg = $"SELECT date FROM messages WHERE date > '{Convert.ToDateTime(reader["leaveDate"])}' AND idUserGet = '{userId}'";
            reader.Close();

            SqlDataAdapter adapter = new SqlDataAdapter(commandMsg, DB.getConnection());
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                labelNotification.Text = Convert.ToString(dataTable.Rows.Count);
                labelNotification.Visible = true;
            }
            DB.closeConnection();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            DB.openConnection();
            DateTime now = DateTime.Now;
            string queryInsert = $"UPDATE users SET leaveDate = '{now}' WHERE id = '{userId}'";
            SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
            commInsert.ExecuteNonQuery();
            DB.closeConnection();
            Application.Exit();
        }

        Point newPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            newPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - newPoint.X;
                this.Top += e.Y - newPoint.Y;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string command = $"SELECT * FROM products WHERE name LIKE '%" + searchTextBox.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(command, DB.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (counter >= 0)
            {
                counter = 0;
                this.panelProducts.Controls.Clear();
            }
            foreach (DataRow row in dt.Rows)
            {
                fillOneProduct(row);
            }
        }

        private void fillOneProduct(DataRow row)
        {
            var cells = row.ItemArray;
            Label labelShowNumber = new Label();
            Label labelShowDate = new Label();
            Label labelShowCity = new Label();
            Label labelShowPrice = new Label();
            Label labelShowCategory = new Label();
            Label labelShowName = new Label();
            Label labelIdProduct = new Label();
            Button buttonOpenMessenger = new Button();
            // 
            // labelShowName
            // 
            labelShowName.AutoSize = true;
            labelShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelShowName.Location = new System.Drawing.Point(15, nameY + counter * 117);
            labelShowName.Name = "labelShowName" + counter;
            labelShowName.Size = new System.Drawing.Size(122, 29);
            labelShowName.TabIndex = 0;
            labelShowName.Text = Convert.ToString(cells[1]);
            // 
            // labelShowCategory
            // 
            labelShowCategory.AutoSize = true;
            labelShowCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelShowCategory.Location = new System.Drawing.Point(15, categoryY + counter * 117);
            labelShowCategory.Name = "labelShowCategory" + counter;
            labelShowCategory.Size = new System.Drawing.Size(97, 22);
            labelShowCategory.TabIndex = 1;
            labelShowCategory.Text = Convert.ToString(cells[2]);
            // 
            // labelShowPrice
            // 
            labelShowPrice.AutoSize = true;
            labelShowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelShowPrice.Location = new System.Drawing.Point(415, priceY + counter * 117);
            labelShowPrice.Name = "labelShowPrice" + counter;
            labelShowPrice.Size = new System.Drawing.Size(58, 25);
            labelShowPrice.TabIndex = 2;
            labelShowPrice.Text = Convert.ToString(cells[3]) + "Р";
            // 
            // labelShowCity
            // 
            labelShowCity.AutoSize = true;
            labelShowCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelShowCity.Location = new System.Drawing.Point(415, cityY + counter * 117);
            labelShowCity.Name = "labelShowCity" + counter;
            labelShowCity.Size = new System.Drawing.Size(74, 25);
            labelShowCity.TabIndex = 3;
            labelShowCity.Text = Convert.ToString(cells[4]);
            // 
            // labelShowDate
            // 
            labelShowDate.AutoSize = true;
            labelShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelShowDate.Location = new System.Drawing.Point(15, dateY + counter * 117);
            labelShowDate.Name = "labelShowDate" + counter;
            labelShowDate.Size = new System.Drawing.Size(52, 20);
            labelShowDate.TabIndex = 4;
            labelShowDate.Text = Convert.ToString(cells[5]);
            // 
            // labelShowNumber
            // 
            labelShowNumber.AutoSize = true;
            labelShowNumber.Location = new System.Drawing.Point(415, phoneY + counter * 117);
            labelShowNumber.Name = "labelShowNumber" + counter;
            labelShowNumber.Size = new System.Drawing.Size(118, 16);
            labelShowNumber.TabIndex = 5;
            string command = $"SELECT phone FROM users WHERE id = '{Convert.ToString(cells[6])}'";

            SqlCommand comm = new SqlCommand(command, DB.getConnection());
            DB.openConnection();
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();

            labelShowNumber.Text = "+" + Convert.ToString(reader["phone"]);
            reader.Close();
            DB.closeConnection();
            // 
            // labelIdProduct
            // 
            labelIdProduct.AutoSize = true;
            labelIdProduct.Location = new System.Drawing.Point(502, 22 + counter * 117);
            labelIdProduct.Name = "labelIdProduct" + counter;
            labelIdProduct.Size = new System.Drawing.Size(18, 16);
            labelIdProduct.TabIndex = 6;
            labelIdProduct.Text = Convert.ToString(cells[0]);
            labelIdProduct.Visible = false;
            // 
            // buttonOpenMessenger
            // 
            buttonOpenMessenger.Location = new System.Drawing.Point(243, 90 + counter * 117);
            buttonOpenMessenger.Name = "buttonOpenMessenger" + counter;
            buttonOpenMessenger.Size = new System.Drawing.Size(159, 23);
            buttonOpenMessenger.TabIndex = 7;
            buttonOpenMessenger.Text = "Написать владельцу";
            buttonOpenMessenger.UseVisualStyleBackColor = true;
            buttonOpenMessenger.Click += new System.EventHandler(buttonOpenMessenger_Click);
            if (userId == Convert.ToInt32(cells[6]))
            {
                buttonOpenMessenger.Visible = false;
            }

            counter++;

            this.panelProducts.Controls.Add(labelShowNumber);
            this.panelProducts.Controls.Add(labelShowDate);
            this.panelProducts.Controls.Add(labelShowCity);
            this.panelProducts.Controls.Add(labelShowPrice);
            this.panelProducts.Controls.Add(labelShowCategory);
            this.panelProducts.Controls.Add(labelShowName);
            this.panelProducts.Controls.Add(labelIdProduct);
            this.panelProducts.Controls.Add(buttonOpenMessenger);
        }

        private void buttonOpenMessenger_Click(object sender, EventArgs e)
        {
            openedMessengerForm?.labelQuit_Click(sender, e);
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string linkPhone = "labelShowNumber" + btn.Name.Substring(btn.Name.Length - 1);
            string phone = panelProducts.Controls[linkPhone].Text;

            string command = $"SELECT id FROM users WHERE phone = '{Convert.ToInt64(phone)}'";

            SqlCommand comm = new SqlCommand(command, DB.getConnection());
            DB.openConnection();
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();

            int getterId = (int)reader["id"];

            DB.closeConnection();
            reader.Close();

            openedMessengerForm = new MessengerForm(userId, getterId, this);
            openedMessengerForm.Show();
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                pictureBox1_Click(sender, e);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string lowestPrice = priceMinTextBox.Text;
            if (lowestPrice == "От")
                lowestPrice = "0";
            string highestPrice = priceMaxTextBox.Text;
            if (highestPrice == "До")
                highestPrice = "9999999999";
            string category = categoryComboBox.Text;
            if (categoryComboBox.SelectedIndex == 0)
            {
                category = "";
            }
            string command = $"SELECT * FROM products WHERE name LIKE '%" + searchTextBox.Text + "%' AND category LIKE '%" + category + "%' AND city LIKE '%" + cityTextBox.Text + "%' AND price >= " + lowestPrice + " AND price <= " + highestPrice;
            SqlDataAdapter adapter = new SqlDataAdapter(command, DB.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            counter = 0;
            if (counter >= 0)
            {
                this.panelProducts.Controls.Clear();
            }
            foreach (DataRow row in dt.Rows)
            {
                fillOneProduct(row);
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            NewProductForm newProductForm = new NewProductForm(this, userId);
            newProductForm.Show();
        }

        public void enablePanel1()
        {
            this.panel1.Enabled = true;
        }


        private void buttonCabinet_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            labelNotification.Visible = false;
            CabinetForm cabinetForm = new CabinetForm(this, userId);
            cabinetForm.Show();
        }

        private void UserMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            quit_Click(sender, e);
        }

        private void labelNoText_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
        }

        private void priceMaxTextBox_Enter(object sender, EventArgs e)
        {
            if (priceMaxTextBox.Text == "До")
            {
                priceMaxTextBox.ForeColor = Color.Black;
                priceMaxTextBox.Text = "";
            }
        }

        private void priceMaxTextBox_Leave(object sender, EventArgs e)
        {
            if (priceMaxTextBox.Text == "")
            {
                priceMaxTextBox.ForeColor = Color.Gray;
                priceMaxTextBox.Text = "До";
            }
        }

        private void priceMinTextBox_Leave(object sender, EventArgs e)
        {
            if (priceMinTextBox.Text == "")
            {
                priceMinTextBox.ForeColor = Color.Gray;
                priceMinTextBox.Text = "От";
            }
        }

        private void priceMinTextBox_Enter(object sender, EventArgs e)
        {
            if (priceMinTextBox.Text == "От")
            {
                priceMinTextBox.ForeColor = Color.Black;
                priceMinTextBox.Text = "";
            }
        }

    }
}
