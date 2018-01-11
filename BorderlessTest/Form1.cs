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

        private void bMaximise_Click(object sender, EventArgs e)
        {
            toggleWindowState();
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

        private void bMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion


    }
}
