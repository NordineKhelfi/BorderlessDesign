using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorderlessTest
{
    public partial class Form1 : Form
    {

        private bool isMouseDown;
        private bool isMaximized = false;
        private Point lastPosition;

        public Form1()
        {
            InitializeComponent();
        }

        #region From interactivity functions

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {

            isMouseDown = true;
            lastPosition = e.Location;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastPosition = e.Location;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastPosition.X) + e.X,
                    (this.Location.Y - lastPosition.Y) + e.Y);

                this.Update();
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastPosition.X) + e.X,
                    (this.Location.Y - lastPosition.Y) + e.Y);

                this.Update();
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panelTop_DoubleClick(object sender, EventArgs e)
        {
            toggleWindowState();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            toggleWindowState();
        }

        void toggleWindowState()
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                bMaximize.Image = BorderlessTest.Properties.Resources.BTctrlAgrandir;
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                bMaximize.Image = BorderlessTest.Properties.Resources.BTctrlRestaurer;
                isMaximized = true;
            }
        }
        

        private void bMaximize_Click(object sender, EventArgs e)
        {
            toggleWindowState();
        }

        private void bMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Menu's buttons

        private void button1_Click_1(object sender, EventArgs e)
        {
            sidePanel.Top = button1.Top;
            label2.Text = "The 2 testimonies";
            decryptPanel.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sidePanel.Top = button2.Top;
            label2.Text = "The 5 daily prayers";
            decryptPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Top = button3.Top;
            label2.Text = "The oligatory zakât";
            decryptPanel.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidePanel.Top = button4.Top;
            label2.Text = "The fast of Ramadhân";
            decryptPanel.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidePanel.Top = button5.Top;
            label2.Text = "The hadj";
            decryptPanel.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidePanel.Top = button6.Top;
            label2.Text = "Secret message decrypting function";
            decryptPanel.Visible = true;
        }

        #endregion

        string DeCrypt(int key, string msg)
        {

            string result = "";

            foreach(char c in msg)
            {
                result += (char) ( (int)c ^ key);
            }

            return result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbResult.Text = DeCrypt(Int32.Parse(tbKey.Text), tbMsg.Text);
        }

        private void tbKey_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                tbResult.Text = DeCrypt(Int32.Parse(tbKey.Text), tbMsg.Text);
        }
    }
}
