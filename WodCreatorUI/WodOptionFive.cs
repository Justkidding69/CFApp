using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WodLibrary;

namespace WodCreatorUI
{
    public partial class WodOptionFive : Form
    {
        List<GirlsModel> Girls = new List<GirlsModel>();
        public WodOptionFive()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Girls = db.GetGirls("Barbara");
            UpdateBinding();

        }
        private void UpdateBinding()
        {

            listBox1.DataSource = Girls;
            listBox1.DisplayMember = "GirlInfo";
        }
    }
}
