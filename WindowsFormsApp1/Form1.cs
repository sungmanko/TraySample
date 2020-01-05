using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = textBox1.Text;
            notifyIcon1.BalloonTipText = textBox2.Text + "\r\n" + textBox3.Text;
            notifyIcon1.Click += NotifyIcon1_Click;
            notifyIcon1.BalloonTipClicked += NotifyIcon1_BalloonTipClicked;
            notifyIcon1.ShowBalloonTip(10000);
        }

        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.TopMost = true;
            MessageBox.Show("BalloonTipClicked");
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NotifyIcon1_Click");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
