using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WodCreatorUI
{
    public partial class WodDashBoard : Form
    {
        public WodDashBoard()
        {
            InitializeComponent();
        }

        private void wodOptionFiveButton_Click(object sender, EventArgs e)
        {
            var formFive = new WodOptionFive();
            formFive.Show();
        }

        private void wodOptionSixButton_Click(object sender, EventArgs e)
        {
            var formSix = new WodOptionSix();

            formSix.Show();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var WodBuild = new CustomWod();
            WodBuild.Show();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}
