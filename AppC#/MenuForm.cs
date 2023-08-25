using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AppC_
{
    public partial class MenuForm : Form
    {
        int userId;

        DB DB = new DB();

        public MenuForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;

        }

        public void quit_Click(object sender, EventArgs e)
        {
            DB.openConnection();
            DateTime now = DateTime.Now;
            string queryInsert = $"UPDATE users SET leaveDate = '{now}' WHERE id = '{userId}'";
            SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
            commInsert.ExecuteNonQuery();
            DB.closeConnection();
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetUsers.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dataSetUsers.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetProducts.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.dataSetProducts.products);


        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow >= 0) 
            { 
                DataGridViewRow row = dataGridViewUsers.Rows[selectedRow];
                IDtextBox.Text = row.Cells[0].Value.ToString();
                loginTextBox.Text = row.Cells[1].Value.ToString();
                passwordTextBox.Text = row.Cells[2].Value.ToString();
                roleComboBox.Text = row.Cells[3].Value.ToString();
                phoneTextBox.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridViewUpdateUsers()
        {
            string command = "Select * From users";
            SqlDataAdapter adapter = new SqlDataAdapter(command, DB.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewUsers.DataSource = dt;
            adapter.Update((DataTable)dataGridViewUsers.DataSource);
        }

        private void dataGridViewUpdateProducts()
        {
            string command = "Select * From products";
            SqlDataAdapter adapter = new SqlDataAdapter(command, DB.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewProducts.DataSource = dt;
            adapter.Update((DataTable)dataGridViewProducts.DataSource);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (menusTabControl.SelectedIndex == 1)
            {
                DB.openConnection();
                int index = dataGridViewUsers.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridViewUsers.Rows[index];
                var login = row.Cells[1].Value.ToString();
                DialogResult res = MessageBox.Show($"Вы точно хотите удалить пользователя {login}?", "Удаление пользователя.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string queryInsert = $"DELETE FROM users WHERE login = '{login}'";
                    SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
                    commInsert.ExecuteNonQuery();
                    MessageBox.Show("Пользователь успешно удален!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewUpdateUsers();
                }
                DB.closeConnection();
            }
            else
            {
                DB.openConnection();
                int index = dataGridViewProducts.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridViewProducts.Rows[index];
                var name = row.Cells[1].Value.ToString();
                var idProduct = row.Cells[0].Value.ToString();
                DialogResult res = MessageBox.Show($"Вы точно хотите удалить объявление \"{name}\"?", "Удаление объявления.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string queryInsert = $"DELETE FROM products WHERE id = '{idProduct}'";
                    SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
                    commInsert.ExecuteNonQuery();
                    MessageBox.Show("Объявление успешно удалено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewUpdateProducts();
                }
                DB.closeConnection();
            }
                
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (menusTabControl.SelectedIndex == 1)
            {
                var login = loginTextBox.Text;
                var password = passwordTextBox.Text;
                Int64 role;
                Int64 phone;

                if (login != "" && password != "" && Int64.TryParse(roleComboBox.Text, out role) && Int64.TryParse(phoneTextBox.Text, out phone))
                {
                    string query = $"SELECT role FROM C#Project.dbo.users WHERE login = '{login}'";

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
                        DateTime leaveDate = DateTime.Now;
                        string queryInsert = $"INSERT INTO users (login, password, role, phone, leaveDate) VALUES ('{login}','{password}','{role}','{phone}', '{leaveDate}')";
                        SqlCommand commInsert = new SqlCommand( queryInsert, DB.getConnection());
                        commInsert.ExecuteNonQuery();
                        MessageBox.Show("Пользователь успешно добавлен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewUpdateUsers();
                    }
                    DB.closeConnection();
                }
            }
            else
            {
                var name = nameTextBox.Text;
                var category = categoryComboBox.Text;
                Int64 price;
                var city = cityTextBox.Text;
                DateTime date = DateTime.Now;

                if (name != "" && category != "" && Int64.TryParse(priceTextBox.Text, out price))
                {
                    DB.openConnection();

                    string queryInsert = $"INSERT INTO products (name, category, price, city, date, userId) VALUES ('{name}','{category}','{price}','{city}','{date}', '{userId}')";
                    SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
                    commInsert.ExecuteNonQuery();
                    MessageBox.Show("Объявление успешно добавлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewUpdateProducts();

                    DB.closeConnection();
                }
            }
            
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (menusTabControl.SelectedIndex == 1)
            {
                var login = loginTextBox.Text;
                var password = passwordTextBox.Text;
                Int64 role;
                Int64 phone;
                int idUser;

                if (login != "" && password != "" && Int64.TryParse(roleComboBox.Text, out role) && Int64.TryParse(phoneTextBox.Text, out phone) && int.TryParse(IDtextBox.Text,out idUser))
                {
                    string query = $"SELECT role FROM C#Project.dbo.users WHERE login = '{login}' AND id != '{idUser}'";

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
                        string queryInsert = $"UPDATE users SET login = '{login}', password = '{password}', role = '{role}', phone = '{phone}' WHERE id = '{idUser}'";
                        SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
                        commInsert.ExecuteNonQuery();
                        MessageBox.Show("Данные пользователя успешно изменены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewUpdateUsers();
                    }
                    DB.closeConnection();
                }
            }
            else
            {
                var name = nameTextBox.Text;
                var category = categoryComboBox.Text;
                Int64 price;
                var city = cityTextBox.Text;
                int idProduct;

                if (name != "" && category != "" && Int64.TryParse(priceTextBox.Text, out price) && int.TryParse(id2textBox.Text, out idProduct))
                {
                    DB.openConnection();

                    string queryInsert = $"UPDATE products SET name = '{name}', category = '{category}', price = '{price}', city = '{city}' WHERE id = '{idProduct}'";
                    SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
                    commInsert.ExecuteNonQuery();
                    MessageBox.Show("Объявление успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewUpdateProducts();

                    DB.closeConnection();
                }
            }
            
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[selectedRow];
                id2textBox.Text = row.Cells[0].Value.ToString();
                nameTextBox.Text = row.Cells[1].Value.ToString();
                categoryComboBox.Text = row.Cells[2].Value.ToString();
                priceTextBox.Text = row.Cells[3].Value.ToString();
                cityTextBox.Text = row.Cells[4].Value.ToString();
                dateTextBox.Text = row.Cells[5].Value.ToString();
                idCreatorBox1.Text = row.Cells[6].Value.ToString();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (menusTabControl.SelectedIndex == 0)
            {
                string command = $"SELECT * FROM products WHERE CONCAT (id, name, category, price, city, date, userId) LIKE '%" + searchTextBox.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(command, DB.getConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewProducts.DataSource = dt;
                adapter.Update((DataTable)dataGridViewProducts.DataSource);
            }
            else
            {
                string command = $"SELECT * FROM users WHERE CONCAT (id, login, password, role, phone, leaveDate) LIKE '%" + searchTextBox.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(command, DB.getConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUsers.DataSource = dt;
                adapter.Update((DataTable)dataGridViewUsers.DataSource);
            }
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            quit_Click(sender, e);
        }

        private void buttonOpenUserMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMenuForm userMenuForm = new UserMenuForm(userId);
            userMenuForm.Show();
        }
    }
}
