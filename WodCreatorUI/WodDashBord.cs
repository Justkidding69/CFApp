﻿using System;
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
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void wodOptionFiveButton_Click(object sender, EventArgs e)
        {
            var formFive = new WodOptionFive();
            formFive.StartPosition = FormStartPosition.CenterScreen;
            formFive.Show();
        }

        private void wodOptionSixButton_Click(object sender, EventArgs e)
        {
            var formSix = new WodOptionSix();

            formSix.Show();
        }

        private void WodDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var WodBuild = new CustomWod();
            WodBuild.Show();
        }
    }
}
