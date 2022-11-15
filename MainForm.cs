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

namespace EmailSender
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "dmytrynskiy74@gmail.com",
                    Password = "xalexkmgsdrnuijj"
                }
            };
            MailAddress FromEmail = new MailAddress("dmytrynskiy74@gmail.com", "Roma Dmytrynskyi");
            MailAddress ToEmail = new MailAddress(emailText.Text, "SomeOne");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = subjectText.Text,
                Body = messageText.Text
            };
            Message.To.Add(ToEmail);

            try
            {
                Client.Send(Message);
                MessageBox.Show("Sent Successfully", "Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something wrong \n " + ex.Message, "Error");
            }
        }

    }
}
