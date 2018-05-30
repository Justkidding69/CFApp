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
    public partial class WodOptionSix : Form
    {
        List<ExerciseModel> exercise = new List<ExerciseModel>();
        List<ExerciseModel> exercise2 = new List<ExerciseModel>();
        List<ExerciseModel> exercise3 = new List<ExerciseModel>();
        List<ExerciseModel> exercise4 = new List<ExerciseModel>();


        public WodOptionSix()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateBinding()
        {
            wodListBox.DataSource = exercise;
            wodListBox.DisplayMember = "FullInfo";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {         

            DataAccess db = new DataAccess();

            if (BarBellCheckBox.Checked)
            {
                exercise = db.GetExercise(BarBellCheckBox.Text);
                UpdateBinding();
            }
            if (WallBallCheckBox.Checked)
            {
                exercise = db.GetExercise(WallBallCheckBox.Text);
                UpdateBinding();
            }
            if (KettleBellCheckBox.Checked)
            {
                exercise = db.GetExercise(KettleBellCheckBox.Text);
                UpdateBinding();
            }
            if (BarCheckBox.Checked)
            {
                exercise = db.GetExercise(BarCheckBox.Text);
                UpdateBinding();
            }

            //UpdateBinding();
        }
    }
}
