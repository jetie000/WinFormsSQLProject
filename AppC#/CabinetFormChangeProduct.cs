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
    public partial class CabinetFormChangeProduct : Form
    {
        CabinetForm cabinetForm;
        DB DB = new DB();
        int productId; 
        public CabinetFormChangeProduct(CabinetForm cabinetForm, int productId)
        {
            InitializeComponent();
            this.cabinetForm = cabinetForm;
            this.productId = productId;
            fillTextBoxes();
        }

        private void fillTextBoxes()
        {
            string command = $"SELECT name, category, price, city FROM products WHERE id = '{productId}'";

            SqlCommand comm = new SqlCommand(command, DB.getConnection());
            DB.openConnection();
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            nameTextBox.Text = Convert.ToString(reader["name"]);
            categoryComboBox.Text = Convert.ToString(reader["category"]);
            priceTextBox.Text = Convert.ToString(reader["price"]);
            cityTextBox.Text = Convert.ToString(reader["city"]);
            reader.Close();
            DB.closeConnection();
        }
        private void labelQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
            cabinetForm.enablePanel1();
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

        private void buttonChangeProduct_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var category = categoryComboBox.Text;
            Int64 price;
            var city = cityTextBox.Text;

            if (name != "" && category != "" && Int64.TryParse(priceTextBox.Text, out price))
            {
                DB.openConnection();

                string queryInsert = $"UPDATE products SET name = '{name}', category = '{category}', price = '{price}', city = '{city}' WHERE id = '{productId}'";
                SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
                commInsert.ExecuteNonQuery();
                MessageBox.Show("Объявление успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.closeConnection();
                cabinetForm.fillProducts();
                labelQuit_Click(sender, e);
            }
        }

        private void CabinetFormChangeProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            labelQuit_Click(sender, e);
        }
    }
}
