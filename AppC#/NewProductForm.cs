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

namespace AppC_
{
    public partial class NewProductForm : Form
    {
        UserMenuForm userMenuForm;
        int userId;
        DB DB = new DB();
        public NewProductForm(UserMenuForm userMenuForm, int userId)
        {
            InitializeComponent();
            this.userMenuForm = userMenuForm;
            this.userId = userId;
        }

        private void labelQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
            userMenuForm.enablePanel1();
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

        private void button1_Click(object sender, EventArgs e)
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
                DB.closeConnection();
                labelQuit_Click(sender, e);
            }
        }

        private void NewProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            labelQuit_Click(sender, e);
        }
    }
}
