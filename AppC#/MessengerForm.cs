using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppC_
{
    public partial class MessengerForm : Form
    {
        DB DB = new DB();
        int idUser, idGetter;
        int counterMsgSend = 0, counterMsgGet = 0, heightMsgs = 0;
        public MessengerForm(int idUser, int idGetter, UserMenuForm userMenuForm)
        {
            InitializeComponent();
            this.idUser = idUser;
            this.idGetter = idGetter;
            this.Location = new System.Drawing.Point(userMenuForm.Location.X + userMenuForm.Size.Width + 2, userMenuForm.Location.Y + userMenuForm.Size.Height - this.Size.Height);
            setInfo();
            messagesFill();
        }

        public void labelQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Point newPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            newPoint = new Point(e.X, e.Y);
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            if (textBoxMessage.Text != "")
            {
                DB.openConnection();
                string queryInsert = $"INSERT INTO messages (message, idUserSend, idUserGet, date) VALUES ('{textBoxMessage.Text}','{idUser}','{idGetter}','{DateTime.Now}')";
                SqlCommand commInsert = new SqlCommand(queryInsert, DB.getConnection());
                commInsert.ExecuteNonQuery();
                DB.closeConnection();
                textBoxMessage.Text = string.Empty;
                messagesFill();
            }
        }

        private void textBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buttonSendMessage_Click(sender, e);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - newPoint.X;
                this.Top += e.Y - newPoint.Y;
            }
        }
        private void setInfo()
        {
            DataTable dt = new DataTable();
            string query = $"SELECT phone, leaveDate FROM users WHERE id = '{idGetter}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, DB.getConnection());
            adapter.Fill(dt);
            DataRow row = dt.Rows[0];
            var cells = row.ItemArray;
            labelPhone.Text = "+" + Convert.ToString(cells[0]);
            labelDate.Text = "Был(а) в сети " + Convert.ToString(cells[1]);

            DB.openConnection();
            string querySetTime = $"UPDATE users SET leaveDate = '{DateTime.Now}' WHERE id = '{idUser}'";
            SqlCommand command = new SqlCommand(querySetTime, DB.getConnection());
            command.ExecuteNonQuery();
            DB.closeConnection();
        }
        private void messagesFill()
        {
            string command = $"SELECT * FROM messages WHERE idUserSend = '{idUser}' AND idUserGet = '{idGetter}' OR idUserSend = '{idGetter}' AND idUserGet = '{idUser}'";
            SqlDataAdapter adapter = new SqlDataAdapter(command, DB.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            counterMsgGet = 0;
            counterMsgSend = 0;
            heightMsgs = 0;
            panelMessages.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                fillOneMessage(row);
            }
            Point current = panelMessages.AutoScrollPosition;
            Point scrolled = new Point(current.X, -current.Y + 10);
            panelMessages.AutoScrollPosition = scrolled;

        }

        private void fillOneMessage(DataRow row)
        {
            var cells = row.ItemArray;
            if ((int)cells[2] == idUser)
            {
                System.Windows.Forms.Label labelMessageSend = new System.Windows.Forms.Label
                {
                    AutoSize = true,
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    Location = new System.Drawing.Point(246, 10 + heightMsgs),
                    MaximumSize = new System.Drawing.Size(230, 0),
                    Name = "labelMessageSend" + counterMsgSend,
                    Size = new System.Drawing.Size(46, 18),
                    TabIndex = 1,
                    Text = Convert.ToString(cells[1])
                };
                panelMessages.Controls.Add(labelMessageSend);

                if (labelMessageSend.Location.X + labelMessageSend.Width > panelMessages.Width - 23)
                    labelMessageSend.Location = new System.Drawing.Point(panelMessages.Width - labelMessageSend.Width - 23, 10 + heightMsgs);

                counterMsgSend++;
                heightMsgs += labelMessageSend.Height + 10;
            }
            else
            {
                System.Windows.Forms.Label labelMessageGet = new System.Windows.Forms.Label
                {
                    AutoSize = true,
                    BackColor = System.Drawing.SystemColors.Control,
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    Location = new System.Drawing.Point(2, 10 + heightMsgs),
                    MaximumSize = new System.Drawing.Size(230, 0),
                    Name = "labelMessageGet" + counterMsgGet,
                    Size = new System.Drawing.Size(46, 18),
                    TabIndex = 0,
                    Text = Convert.ToString(cells[1])
                };

                panelMessages.Controls.Add(labelMessageGet);
                counterMsgGet++;
                heightMsgs += labelMessageGet.Height + 10;
            }
        }
    }
}
