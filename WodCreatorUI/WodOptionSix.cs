using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WodLibrary;

namespace WodCreatorUI
{
    public partial class WodOptionSix : Form
    {
        List<ExerciseModel> Exercise = new List<ExerciseModel>();

        
        public WodOptionSix()
        {
            InitializeComponent();
            UpdateBinding();        
        }


        private void CreateButton_Click(object sender, EventArgs e)
        {
            Checkboxes();
            UpdateBinding();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateBinding()
        {
            wodListBox.DataSource = null;
            wodListBox.DataSource = Exercise;
            wodListBox.DisplayMember = "ExerciseID";
        }

        private void Checkboxes()
        {
            DataAccess db = new DataAccess();
            Exercise = new List<ExerciseModel>();

            if (BarBellCheckBox.Checked)
            {
                Exercise.AddRange( db.GetExercise(BarBellCheckBox.Text));
            }
            if (WallBallCheckBox.Checked)
            {
                Exercise.AddRange(db.GetExercise(WallBallCheckBox.Text));
            }
            if (KettleBellCheckBox.Checked)
            {
                Exercise.AddRange(db.GetExercise(KettleBellCheckBox.Text));
            }
            if (BarCheckBox.Checked)
            {
                Exercise.AddRange(db.GetExercise(BarCheckBox.Text));
            }
            if (BodyCheckBox.Checked)
            {
                Exercise.AddRange(db.GetExercise(BodyCheckBox.Text));
            }


            if (!BarBellCheckBox.Checked && !WallBallCheckBox.Checked && !KettleBellCheckBox.Checked && !BarCheckBox.Checked)
            {
                Exercise.AddRange(db.GetExercise(BarBellCheckBox.Text));
                Exercise.AddRange(db.GetExercise(WallBallCheckBox.Text));
                Exercise.AddRange(db.GetExercise(KettleBellCheckBox.Text));
                Exercise.AddRange(db.GetExercise(BarCheckBox.Text));
                Exercise.AddRange(db.GetExercise(BodyCheckBox.Text));
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
