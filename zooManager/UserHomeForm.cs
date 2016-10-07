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
    public partial class UserHomeForm : Form
    {
        public UserHomeForm()
        {
            InitializeComponent();
        }

        private void UserHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyRegistry.Unset("user");
            MyRegistry.GetLoginForm().Show();
        }

        private void UserHomeForm_Load(object sender, EventArgs e)
        {
            var mode = MyRegistry.GetUserGroupTable().LoadById(MyRegistry.GetUser().Group).Name;
            Text = Text + @" (" + mode + @")";
            labelGreeting.Text = @"Hello, " + MyRegistry.GetUser().Name
                + @" " + MyRegistry.GetUser().Surname;
        }
    }
}
