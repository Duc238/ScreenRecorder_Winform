using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRecorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Capture()
        {
            while (true)
            {
                Bitmap bt = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics g = Graphics.FromImage(bt);
                g.CopyFromScreen(0, 0, 0, 0, bt.Size);
                pictureBox1.Image = bt;
                Thread.Sleep(1000);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Capture);
            thread.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
