using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace zooManager
{
    public partial class SplashScreen : Form
    {
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Form1 _mainForm;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            _mainForm = new Form1();
            timerWait.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_mainForm.Ready)
            {
                if (_mainForm.Progress == 0) progressBar1.Style = ProgressBarStyle.Marquee;
                else
                {
                    progressBar1.Style = ProgressBarStyle.Blocks;
                    progressBar1.Value = _mainForm.Progress;
                }
            }
            else
            {
                timerWait.Stop();
                _mainForm.Show();
                Hide();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
