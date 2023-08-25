using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppC_
{
    public partial class CabinetForm : Form
    {
        UserMenuForm userMenuForm;
        MessengerForm openedMessengerForm;
        int userId;
        DateTime leaveDate;
        DB DB = new DB();
        int counterProducts = 0, counterChats = 0;
        int diffYproducts = 150 , diffYchats = 60;
        int nameY = 15, categoryY = 57, priceY = 18, dateY = 93, phoneY = 93, cityY = 55, buttonsY = 125;
        public CabinetForm(UserMenuForm userMenuForm, int userId)
        {
            InitializeComponent();
            this.userMenuForm = userMenuForm;
            this.userId = userId;
            setUserLetter(userId);
            fillProducts();
        }
        private void setUserLetter(int userId)
        {
            string command = $"SELECT login, leaveDate FROM users WHERE id = '{userId}'";

            SqlCommand comm = new SqlCommand(command, DB.getConnection());
            DB.openConnection();
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            labelUsername.Text = Convert.ToString(reader["login"]);
            leaveDate = Convert.ToDateTime(reader["leaveDate"]);
            reader.Close();
            DB.closeConnection();
        }

        private void labelQuit_Click(object sender, EventArgs e)
        {
            openedMessengerForm?.labelQuit_Click(sender, e);
            this.Hide();
            userMenuForm.enablePanel1();
        }
        public void enablePanel1()
        {
            this.panel1.Enabled = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;

            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string linkName = "labelIdProduct" + btn.Name.Substring(btn.Name.Length - 1);
            int id = Convert.ToInt32(panelProducts.Controls[linkName].Text);

            CabinetFormChangeProduct newProductForm = new CabinetFormChangeProduct(this, id);
            newProductForm.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DB.openConnection();
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string linkName = "labelShowName" + btn.Name.Substring(btn.Name.Length - 1);
            var name = panelProducts.Controls[linkName].Text;
            string linkId = "labelIdProduct" + btn.Name.Substring(btn.Name.Length - 1);
            var idProduct = panelProducts.Controls[linkId].Text;
            DialogResult res = MessageBox.Show($"Вы точно хотите удалить объявление \"{name}\"?", "Удаление объявления.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string queryInsert = $"DELETE FROM products WHERE id = '{idProduct}'";
                SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
                commInsert.ExecuteNonQuery();
                MessageBox.Show("Объявление успешно удалено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DB.closeConnection();
            fillProducts();
        }

        Point newPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            newPoint = new Point(e.X, e.Y);
        }

        private void CabinetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            labelQuit_Click(sender, e);
        }
        

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - newPoint.X;
                this.Top += e.Y - newPoint.Y;
            }
        }

        private void buttonChangeInfo_Click(object sender, EventArgs e)
        {
            var login = loginChangeTextBox.Text;
            var password = passwordChangeTextBox.Text;
            Int64 phone;

            if (login != "" && password != "" && Int64.TryParse(phoneChangeTextBox.Text, out phone))
            {
                string query = $"SELECT role FROM C#Project.dbo.users WHERE login = '{login}' AND id != '{userId}'";

                SqlCommand comm = new SqlCommand(query, DB.getConnection());
                DB.openConnection();
                SqlDataReader reader1 = comm.ExecuteReader();

                if (reader1.HasRows)
                {
                    reader1.Close();
                    MessageBox.Show("Такой логин пользователя уже существует.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    reader1.Close();
                    string queryInsert = $"UPDATE users SET login = '{login}', password = '{password}', phone = '{phone}' WHERE id = '{userId}'";
                    SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
                    commInsert.ExecuteNonQuery();
                    MessageBox.Show("Ваши данные успешно изменены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DB.closeConnection();
            }
        }

        private void tabControlCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCabinet.SelectedIndex == 1) 
            {
                string command = $"SELECT login, password, phone FROM users WHERE id = '{userId}'";

                SqlCommand comm = new SqlCommand(command, DB.getConnection());
                DB.openConnection();
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                loginChangeTextBox.Text = Convert.ToString(reader["login"]);
                passwordChangeTextBox.Text = Convert.ToString(reader["password"]);
                phoneChangeTextBox.Text = Convert.ToString(reader["phone"]);
                reader.Close();
                DB.closeConnection();
            }
            if (tabControlCabinet.SelectedIndex == 2)
            {
                fillChats();
            }
        }


        public void fillProducts()
        {
            string command = $"SELECT * FROM products WHERE userId = '{userId}'";
            SqlDataAdapter adapter = new SqlDataAdapter(command, DB.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            counterProducts = 0;
            this.panelProducts.Controls.Clear();
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
            Label labelIdProduct =  new Label();
            System.Windows.Forms.Button buttonEdit = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonDelete = new System.Windows.Forms.Button();
            // 
            // labelShowName
            // 
            labelShowName.AutoSize = true;
            labelShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelShowName.Location = new System.Drawing.Point(15, nameY + counterProducts * diffYproducts);
            labelShowName.Name = "labelShowName" + counterProducts;
            labelShowName.Size = new System.Drawing.Size(122, 29);
            labelShowName.TabIndex = 0;
            labelShowName.Text = Convert.ToString(cells[1]);
            // 
            // labelShowCategory
            // 
            labelShowCategory.AutoSize = true;
            labelShowCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelShowCategory.Location = new System.Drawing.Point(15, categoryY + counterProducts * diffYproducts);
            labelShowCategory.Name = "labelShowCategory" + counterProducts;
            labelShowCategory.Size = new System.Drawing.Size(97, 22);
            labelShowCategory.TabIndex = 1;
            labelShowCategory.Text = Convert.ToString(cells[2]);
            // 
            // labelShowPrice
            // 
            labelShowPrice.AutoSize = true;
            labelShowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelShowPrice.Location = new System.Drawing.Point(412, priceY + counterProducts * diffYproducts);
            labelShowPrice.Name = "labelShowPrice" + counterProducts;
            labelShowPrice.Size = new System.Drawing.Size(58, 25);
            labelShowPrice.TabIndex = 2;
            labelShowPrice.Text = Convert.ToString(cells[3]) + "Р";
            // 
            // labelShowCity
            // 
            labelShowCity.AutoSize = true;
            labelShowCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelShowCity.Location = new System.Drawing.Point(412, cityY + counterProducts * diffYproducts);
            labelShowCity.Name = "labelShowCity" + counterProducts;
            labelShowCity.Size = new System.Drawing.Size(74, 25);
            labelShowCity.TabIndex = 3;
            labelShowCity.Text = Convert.ToString(cells[4]);
            // 
            // labelShowDate
            // 
            labelShowDate.AutoSize = true;
            labelShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelShowDate.Location = new System.Drawing.Point(15, dateY + counterProducts * diffYproducts);
            labelShowDate.Name = "labelShowDate" + counterProducts;
            labelShowDate.Size = new System.Drawing.Size(52, 20);
            labelShowDate.TabIndex = 4;
            labelShowDate.Text = Convert.ToString(cells[5]);
            // 
            // labelShowNumber
            // 
            labelShowNumber.AutoSize = true;
            labelShowNumber.Location = new System.Drawing.Point(415, phoneY + counterProducts * diffYproducts);
            labelShowNumber.Name = "labelShowNumber" + counterProducts;
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
            labelIdProduct.Location = new System.Drawing.Point(502, 22 + counterProducts * diffYproducts);
            labelIdProduct.Name = "labelIdProduct"+counterProducts;
            labelIdProduct.Size = new System.Drawing.Size(18, 16);
            labelIdProduct.TabIndex = 8;
            labelIdProduct.Text = Convert.ToString(cells[0]);
            labelIdProduct.Visible = false;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            buttonEdit.Location = new System.Drawing.Point(20, buttonsY + counterProducts * diffYproducts);
            buttonEdit.Name = "buttonEdit" + counterProducts;
            buttonEdit.Size = new System.Drawing.Size(116, 31);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += new System.EventHandler(buttonEdit_Click);
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(417, buttonsY + counterProducts * diffYproducts);
            buttonDelete.Name = "buttonDelete" + counterProducts;
            buttonDelete.Size = new System.Drawing.Size(116, 31);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += new System.EventHandler(buttonDelete_Click); 

            counterProducts++;

            panelProducts.Controls.Add(labelIdProduct);
            panelProducts.Controls.Add(labelShowNumber);
            panelProducts.Controls.Add(labelShowDate);
            panelProducts.Controls.Add(labelShowCity);
            panelProducts.Controls.Add(labelShowPrice);
            panelProducts.Controls.Add(labelShowCategory);
            panelProducts.Controls.Add(labelShowName);
            panelProducts.Controls.Add(buttonEdit);
            panelProducts.Controls.Add(buttonDelete);
        }

        public void fillChats()
        {
            string command = $"SELECT * FROM messages WHERE idUserSend = '{userId}' OR idUserGet = '{userId}' ORDER BY date DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(command, DB.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            counterChats = 0;
            this.panelChats.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                fillOneChat(row);
            }
        }

        private void fillOneChat(DataRow row)
        {
            var cells = row.ItemArray;
            
            int userIdCompanion;

            if (Convert.ToInt32(cells[2]) == userId)
                userIdCompanion = Convert.ToInt32(cells[3]);
            else
                userIdCompanion = Convert.ToInt32(cells[2]);

            for (int i = counterChats - 1; i >= 0; i--) 
            { 
                string labelNameIdCheck = "labelId" + i;
                if (panelChats.Controls[labelNameIdCheck].Text == Convert.ToString(userIdCompanion))
                    return;
            }
            Label labelNumber = new Label();
            Label labelDate = new Label();
            Label labelMessage = new Label();
            Label labelId = new Label();
            System.Windows.Forms.Button buttonOpenMessenger = new System.Windows.Forms.Button();
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelNumber.Location = new System.Drawing.Point(15, 11 + counterChats * diffYchats);
            labelNumber.Name = "labelNumber" + counterChats;
            labelNumber.Size = new System.Drawing.Size(66, 22);
            labelNumber.TabIndex = 0;
           
            string command = $"SELECT phone FROM users WHERE id = '{userIdCompanion}'";

            SqlCommand comm = new SqlCommand(command, DB.getConnection());
            DB.openConnection();
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            labelNumber.Text = "+" + Convert.ToString(reader["phone"]);

            reader.Close();
            DB.closeConnection();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new System.Drawing.Point(195, 42 + counterChats * diffYchats);
            labelDate.Name = "labelDate" + counterChats;
            labelDate.Size = new System.Drawing.Size(39, 16);
            labelDate.TabIndex = 1;
            labelDate.Text = Convert.ToString(cells[4]);
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new System.Drawing.Point(16, 42 + counterChats * diffYchats);
            labelMessage.MaximumSize = new System.Drawing.Size(173, 16);
            labelMessage.Name = "labelMessage" + counterChats;
            labelMessage.Size = new System.Drawing.Size(197, 16);
            labelMessage.TabIndex = 2;
            if (leaveDate < Convert.ToDateTime(cells[4]) && Convert.ToInt32(cells[2]) != userId)
            {
                labelMessage.Text = "Есть новые сообщения!";
                labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            }
            else
                labelMessage.Text = Convert.ToString(cells[1]);
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new System.Drawing.Point(135, 15 + counterChats * diffYchats);
            labelId.Name = "labelId" + counterChats;
            labelId.Size = new System.Drawing.Size(20, 16);
            labelId.TabIndex = 4;
            labelId.Text = Convert.ToString(userIdCompanion);
            labelId.Visible = false;
            // 
            // buttonOpenMessenger
            // 
            buttonOpenMessenger.Location = new System.Drawing.Point(201, 11 + counterChats * diffYchats);
            buttonOpenMessenger.Name = "buttonOpenMessenger" + counterChats;
            buttonOpenMessenger.Size = new System.Drawing.Size(132, 23);
            buttonOpenMessenger.TabIndex = 3;
            buttonOpenMessenger.Text = "Открыть чат";
            buttonOpenMessenger.UseVisualStyleBackColor = true;
            buttonOpenMessenger.Click += new System.EventHandler(buttonOpenMessenger_Click);

            counterChats++;

            panelChats.Controls.Add(labelId);
            panelChats.Controls.Add(labelNumber);
            panelChats.Controls.Add(labelDate);
            panelChats.Controls.Add(labelMessage);
            panelChats.Controls.Add(buttonOpenMessenger);
        }

        private void buttonOpenMessenger_Click(object sender, EventArgs e)
        {
            openedMessengerForm?.labelQuit_Click(sender, e);
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string linkPhone = "labelNumber" + btn.Name.Substring(btn.Name.Length - 1);
            string phone = panelChats.Controls[linkPhone].Text;

            string command = $"SELECT id FROM users WHERE phone = '{Convert.ToInt64(phone)}'";

            SqlCommand comm = new SqlCommand(command, DB.getConnection());
            DB.openConnection();
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();

            int getterId = (int)reader["id"];

            DB.closeConnection();
            reader.Close();
            openedMessengerForm = new MessengerForm(userId, getterId, userMenuForm);
            openedMessengerForm.Show();
        }
    }
}
