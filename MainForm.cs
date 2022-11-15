using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S22.Imap;

namespace EmailSender
{
    public partial class MainForm : Form
    {
        static MainForm f;
        public MainForm()
        {
            InitializeComponent();
            f = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            var message = new MailMessage(emailText.Text, recipientText.Text);
            message.Subject = subjectText.Text;
            message.Body = messageText.Text;
            
            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential(emailText.Text, passwordText.Text);
                mailer.EnableSsl = true;
                mailer.Send(message);
            }

            recipientText.Text = null;
            subjectText.Text = null;
            messageText.Text = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            startReceiving();
        }

        private void startReceiving()
        {
            Task.Run(() =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993, emailText.Text, passwordText.Text, AuthMethod.Login, true))
                {
                    if  (client.Supports("IDLE") == false)
                    {
                        MessageBox.Show("Server does not support IMAP IDLE");
                        return;
                    }
                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(onNewMessage);
                    while (true) ;
                }
            });
  
        }

        static void onNewMessage(object sender, IdleMessageEventArgs e)
        {
            MessageBox.Show("New message received!!!");
            MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
            f.Invoke((MethodInvoker)delegate
            {
                f.receiveText.AppendText("From: " + m.From + "\n" + "Subject: " + m.Subject + "\n" + "Body :" + m.Body + "\n");
            });
        }
    }
}
