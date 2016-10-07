using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zooManager
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ProccessPlaceholderTagIn(object sender, System.EventArgs e)
        {
            var txtBox = (TextBox)sender;
            if (txtBox.Text != (string)txtBox.Tag) return;
            if ((string)txtBox.Tag == "Password") txtBox.PasswordChar = '*';
            txtBox.Text = "";
        }

        private void ProccessPlaceholderTagOut(object sender, System.EventArgs e)
        {
            var txtBox = (TextBox)sender;
            if (txtBox.Text != "") return;
            if ((string)txtBox.Tag == "Password") txtBox.PasswordChar = '\0';
            txtBox.Text = (string)txtBox.Tag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            if (login.Length == 0) return;
            var user = MyRegistry.GetUserTable().LoadByLogin(login);
            var msg = "";
            if (user != null)
            {
                if (user.SecretPhrase == textBox2.Text)
                    msg = user.Name + @", password is: " + user.Password;
                else
                    msg = "Invalid secret phrase!";
            }
            else msg = @"User not found!";
            MessageBox.Show(msg, @"Password Reminder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Validate(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3 &&
                textBox1.Text != (string) textBox1.Tag &&
                textBox2.Text.Length > 0 &&
                textBox2.Text != (string)textBox2.Tag)
                button1.Enabled = true;
            else button1.Enabled = false;
        }
    }
}
