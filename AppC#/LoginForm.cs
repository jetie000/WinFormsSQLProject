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
    public partial class LoginForm : Form
    {

        DB DB = new DB();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quit_MouseEnter(object sender, EventArgs e)
        {
            quit.BackColor = Color.FromArgb(250, 120, 120);
        }

        private void quit_MouseLeave(object sender, EventArgs e)
        {
            quit.BackColor = Color.Gainsboro;
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

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var loginUser = loginText.Text;
            var passwordUser = passwordText.Text;
            if (loginUser == "" || passwordUser == "")
                return;

            string query = $"SELECT login, password, role, id FROM C#Project.dbo.users WHERE login = '{loginUser}' AND password = '{passwordUser}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, DB.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                var cells = row.ItemArray;
                if (Convert.ToString(cells[0]) == loginUser && Convert.ToString(cells[1]) == passwordUser) 
                { 
                    MessageBox.Show("Вы вошли успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if ((int)cells[2] == 0)
                    {
                        this.Hide();
                        UserMenuForm userMenuForm = new UserMenuForm((int)cells[3]);
                        userMenuForm.Show();
                    }
                    else
                    {
                        this.Hide();
                        MenuForm menuForm = new MenuForm((int)cells[3]);
                        menuForm.Show();
                    }
                }
                else
                    MessageBox.Show("Вы ввели неправильный логин или пароль.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Вы ввели неправильный логин или пароль.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DB.closeConnection();
        }

        private void passwordText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                buttonEnter_Click(sender, e);
        }

        private void loginText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                buttonEnter_Click(sender, e);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            quit_Click(sender, e);
        }
    }
}
