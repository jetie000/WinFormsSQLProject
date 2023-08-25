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
    public partial class RegisterForm : Form
    {
        DB DB = new DB();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
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

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var loginUser = loginText.Text;
            string passwordUser;
            var phoneUser = phoneText.Text.Substring(1, 3) + phoneText.Text.Substring(6, 2) + phoneText.Text.Substring(10, 3) + phoneText.Text.Substring(14, 4);
            passwordUser = passwordText.Text == passwordRepeatText.Text ? passwordText.Text : "";
            if (loginUser == "" || passwordUser == "" || phoneUser == "")
                return;
            if (!loginCheck(loginUser))
            {
                MessageBox.Show("1) от 5 до 20 символов\n2) допустимы:\n\tлатинские буквы\n\tцифры\n\tсимволы(-_.)","Правила ввода логина");
                return;
            }
            if (!passwordCheck(passwordUser))
            {
                MessageBox.Show("1) от 8 до 30 символов\n2) допустимы:\n\tлатинские буквы\n\tцифры\n\tсимволы (!@#$%^&*_-+:.)\n3) обязательно должны быть буквы верхнего и нижнего регистра", "Правила ввода пароля");
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT role FROM C#Project.dbo.users WHERE login = '{loginUser}'";

            SqlCommand comm = new SqlCommand(query, DB.getConnection());
            adapter.SelectCommand = comm;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Такой пользователь уже существует", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DB.openConnection();
                DateTime leaveDate = DateTime.Now;
                string queryInsert = $"INSERT INTO users (login, password, role, phone, leaveDate) VALUES ('{loginUser}','{passwordUser}',0,'{phoneUser}', '{leaveDate}')";
                SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
                if (commInsert.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вы успешно зарегистрированы!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                    MessageBox.Show("Ошибка создания аккаунта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DB.closeConnection();
            }
            
        }

        private bool loginCheck(string login)   //Проверка логина на разрешенные символы
        {
            if (login.Length < 5)
                return false;
            for (int i = 0; i < login.Length; i++)
            {
                if (( login[i] < 97 || login[i] > 122) && (login[i] < 65 || login[i] > 90) && login[i] != 95 && login[i] != 45 && login[i] != 46 && (login[i] < 48 || login[i] > 57))
                    return false;
            }
            return true;
        }
        private bool passwordCheck(string password) //Проверка пароля на размер и разрешенные символы
        {
            if (password.Length < 8 && password.Length > 30)
                return false;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] < 97 || password[i] > 122) && (password[i] < 65 || password[i] > 90) && password[i] != 95 && password[i] != 45 && password[i] != 46 && (password[i] < 48 || password[i] > 57) && password[i] != 33 && (password[i] < 35 || password[i] > 38) && password[i] != 43 && password[i] != 42 && password[i] != 64 && password[i] != 58 && password[i] != 94)
                    return false;
            }
            for (int i = 0; i < password.Length; i++)
                for (int k = i + 1; k < password.Length; k++)
                    if (((password[i] >= 97 && password[i] <= 122) && (password[k] >= 65 && password[k] <= 90)) || ((password[k] >= 97 && password[k] <= 122) && (password[i] >= 65 && password[i] <= 90)))
                        return true;
            return false;
        }

        private void phoneText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                buttonEnter_Click(sender, e);
        }

        private void passwordRepeatText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                buttonEnter_Click(sender, e);
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

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            quit_Click(sender, e);
        }
    }
}
