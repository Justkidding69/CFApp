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
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void wodOptionOne_Click(object sender, EventArgs e)
        {
            var formOne = new WodOptionOne();
            formOne.StartPosition = FormStartPosition.CenterScreen;
            formOne.Show();
            
            
        }

        private void wodOptionTwo_Click(object sender, EventArgs e)
        {
            var formTwo = new WodOptionTwo();
            formTwo.StartPosition = FormStartPosition.CenterScreen;
            formTwo.Show();

        }

        private void wodOptionThreeButton_Click(object sender, EventArgs e)
        {
            var formTree = new WodOptionTree();
            formTree.StartPosition = FormStartPosition.CenterScreen;
            formTree.Show();
        }

        private void wodOptionFourButton_Click(object sender, EventArgs e)
        {
            var formFour = new WodOptionFour();
            formFour.StartPosition = FormStartPosition.CenterScreen;
            formFour.Show();
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
            formSix.StartPosition = FormStartPosition.CenterScreen;
            formSix.Show();
        }
    }
}
