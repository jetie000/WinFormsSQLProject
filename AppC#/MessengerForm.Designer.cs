namespace AppC_
{
    partial class MessengerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.labelMessageSend = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelQuit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.buttonSendMessage);
            this.panel1.Controls.Add(this.textBoxMessage);
            this.panel1.Controls.Add(this.panelMessages);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelQuit);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 494);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(15, 38);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(105, 16);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "Был(а) в сети ...";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendMessage.Location = new System.Drawing.Point(206, 453);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(91, 28);
            this.buttonSendMessage.TabIndex = 10;
            this.buttonSendMessage.Text = "Отправить";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMessage.Location = new System.Drawing.Point(11, 453);
            this.textBoxMessage.MaxLength = 300;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(189, 28);
            this.textBoxMessage.TabIndex = 9;
            this.textBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMessage_KeyPress);
            // 
            // panelMessages
            // 
            this.panelMessages.AutoScroll = true;
            this.panelMessages.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMessages.Controls.Add(this.labelMessageSend);
            this.panelMessages.Location = new System.Drawing.Point(12, 60);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(285, 387);
            this.panelMessages.TabIndex = 8;
            // 
            // labelMessageSend
            // 
            this.labelMessageSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMessageSend.AutoSize = true;
            this.labelMessageSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMessageSend.Location = new System.Drawing.Point(269, 271);
            this.labelMessageSend.Name = "labelMessageSend";
            this.labelMessageSend.Size = new System.Drawing.Size(16, 18);
            this.labelMessageSend.TabIndex = 1;
            this.labelMessageSend.Text = "1";
            this.labelMessageSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMessageSend.Visible = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(11, 8);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(153, 22);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Номер продавца";
            // 
            // labelQuit
            // 
            this.labelQuit.AutoSize = true;
            this.labelQuit.BackColor = System.Drawing.Color.Gainsboro;
            this.labelQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuit.Location = new System.Drawing.Point(279, 3);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(26, 25);
            this.labelQuit.TabIndex = 6;
            this.labelQuit.Text = "X";
            this.labelQuit.Click += new System.EventHandler(this.labelQuit_Click);
            // 
            // MessengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 494);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(279, 3);
            this.Name = "MessengerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MessengerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMessages.ResumeLayout(false);
            this.panelMessages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelQuit;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelMessageSend;
        private System.Windows.Forms.Label labelDate;
    }
}