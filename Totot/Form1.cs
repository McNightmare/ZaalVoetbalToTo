using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Totot
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Hide();
            button6.Hide();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button3, "Logout");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < panel1.Width; i++)
            {
                panel1.Location = new Point(panel1.Location.X - 1, panel1.Location.Y);
                System.Threading.Thread.Sleep(1);
            }
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.DarkOrange;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.ForeColor = Color.DarkOrange;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.White;

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(panel4.Location.X, 78);
            button2.Hide();
            button6.Show();
            label3.Hide();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(panel4.Location.X, 389);
            button2.Show();
            button6.Hide();
            label3.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < panel1.Width; i++)
            {
                panel1.Location = new Point(panel1.Location.X + 1, panel1.Location.Y);
                System.Threading.Thread.Sleep(1);
            }
            button3.Hide();
        }
    }
}

