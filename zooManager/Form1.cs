using System.Threading;
using System.Windows.Forms;

namespace zooManager
{
    public partial class Form1 : Form
    {
        public bool Ready { get; private set; }
        public int Progress { get; private set; }

        public Form1()
        {
            Ready = false;
            Progress = 0;
            InitializeComponent();
            var threadInit = new Thread(InitApp);
            threadInit.Start();
        }

        private void InitApp()
        {
            MyRegistry.GetUserTable();
            Progress = 25;
            MyRegistry.GetPlacementTable();
            Progress = 50;
            MyRegistry.GetAnimalTypeTable();
            Progress = 75;
            MyRegistry.GetUserGroupTable();
            Progress = 100;
            Ready = true;
        }

        private void SimpleLoadProgress()
        {
            Thread.Sleep(2000);
            Progress = 10;
            Thread.Sleep(1000);
            Progress = 34;
            Thread.Sleep(500);
            Progress = 56;
            Thread.Sleep(900);
            Progress = 89;
            Thread.Sleep(1400);
            Progress = 97;
            Thread.Sleep(1000);
            Progress = 100;
            Thread.Sleep(1000);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            MyRegistry.Set("LoginForm", this);
            textLogin.Select();
            if (MyRegistry.GetUserGroupTable().Count() == 0) InitUserGroupTable();
            if (MyRegistry.GetUserTable().Count() == 0) InitUserTable();
        }

        private static void InitUserGroupTable()
        {
            MyRegistry.GetUserGroupTable().Add(new UserGroup
            {
                Name = "user",
                PrivilegesAccess = UserGroup.Access.Read
            });
            MyRegistry.GetUserGroupTable().Add(new UserGroup
            {
                Name = "manager",
                PrivilegesAccess = UserGroup.Access.Write
            });
            MyRegistry.GetUserGroupTable().Add(new UserGroup
            {
                Name = "admin",
                PrivilegesAccess = UserGroup.Access.Admin
            });
        }

        private static void InitUserTable()
        {
            MyRegistry.GetUserTable().Add(new User
            {
                Group = 2,
                Login = "admin",
                Name = "Admin",
                Password = "admin",
                Surname = "Admin",
                SecretPhrase = "admin"
            });
        }

        private void ProccessPlaceholderTagIn(object sender, System.EventArgs e)
        {
            var txtBox = (TextBox)sender;
            if (txtBox.Text != (string) txtBox.Tag) return;
            if ((string)txtBox.Tag == "Password") txtBox.PasswordChar = '*';
            txtBox.Text = "";
        }

        private void ProccessPlaceholderTagOut(object sender, System.EventArgs e)
        {
            var txtBox = (TextBox)sender;
            if (txtBox.Text != "") return;
            if ((string)txtBox.Tag == "Password") txtBox.PasswordChar = '\0';
            txtBox.Text = (string) txtBox.Tag;
        }

        private void ValidateLogin(object sender, System.EventArgs e)
        {
            if (textLogin.Text.Length > 3 &&
                textLogin.Text != (string)textLogin.Tag &&
                textPassword.Text.Length > 3 &&
                textPassword.Text != (string)textPassword.Tag)
                buttonLogin.Enabled = true;
            else buttonLogin.Enabled = false;
        }

        private void ValidateRegister(object sender, System.EventArgs e)
        {
            if (textRegLogin.Text.Length > 3 &&
                textRegLogin.Text != (string)textRegLogin.Tag &&
                textRegPassword.Text.Length > 3 &&
                textRegPassword.Text != (string)textRegPassword.Tag &&
                textRegName.Text.Length > 0 &&
                textRegName.Text != (string)textRegName.Tag &&
                textRegSurname.Text.Length > 0 &&
                textRegSurname.Text != (string)textRegSurname.Tag &&
                textRegSecretPhrase.Text.Length > 0 &&
                textRegSecretPhrase.Text != (string)textRegSecretPhrase.Tag)
                buttonRegister.Enabled = true;
            else buttonRegister.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fpf = new ForgotPasswordForm();
            fpf.ShowDialog();
            fpf.Close();
        }

        private void buttonRegister_Click(object sender, System.EventArgs e)
        {
            var login = textRegLogin.Text;
            if (MyRegistry.GetUserTable().LoadByLogin(login) != null)
            {
                MessageBox.Show(@"User already exist!", @"Register",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            MyRegistry.GetUserTable().Add(new User {
                Group = 0,
                Login = login,
                Password = textRegPassword.Text,
                Name = textRegName.Text,
                Surname = textRegSurname.Text,
                SecretPhrase = textRegSecretPhrase.Text
            });
            MessageBox.Show(@"You have been registered!", @"Register",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            textLogin.Text = login;
            tabControl1.SelectedTab = tabLogin;
            textPassword.Focus();
            textRegLogin.Text = (string)textRegLogin.Tag;
            textRegPassword.Text = (string)textRegPassword.Tag;
            textRegPassword.PasswordChar = '\0';
            textRegName.Text = (string)textRegName.Tag;
            textRegSurname.Text = (string)textRegSurname.Tag;
            textRegSecretPhrase.Text = (string)textRegSecretPhrase.Tag;
        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            var login = textLogin.Text;
            var user = MyRegistry.GetUserTable().LoadByLogin(login);
            if (user == null || user.Password != textPassword.Text)
            {
                MessageBox.Show(@"Invalid login or/and password!", @"Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MyRegistry.Set("user", user);
            MyRegistry.Set("UserHomeForm", new UserHomeForm());
            MyRegistry.GetUserHomeForm().Show();
            Hide();
            textLogin.Text = (string)textLogin.Tag;
            textPassword.Text = (string)textPassword.Tag;
            textPassword.PasswordChar = '\0';
        }
    }
}
