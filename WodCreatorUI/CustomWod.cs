﻿using System;
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
    public partial class CustomWod : Form
    {
        List<ExerciseModel> Exercise = new List<ExerciseModel>();

        public CustomWod()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            string nrValue = NrOfExerciseTextbox.Text;
            Int32 i;
            if (!string.IsNullOrEmpty(nrValue) && Int32.TryParse(nrValue, out i))
            {
                wodListBox.DataSource = null;
                wodListBox.DataSource = Exercise.OrderBy(a => Guid.NewGuid()).Take(i).ToList(); //".OrderBy(a => Guid.NewGuid()).take(i).ToList();" makes the list random
                wodListBox.DisplayMember = "ExerciseID"; //get the info from ExerciseModel
            }
            else
            {
                wodListBox.DataSource = null;
                wodListBox.DataSource = Exercise.OrderBy(a => Guid.NewGuid()).ToList(); //".OrderBy(a => Guid.NewGuid()).ToList();" makes the list random
                wodListBox.DisplayMember = "ExerciseID"; //get the info from ExerciseModel
            }
        }
        private void WodType_Checkboxes()
        {
            if (fastCheckBox.Checked)
            {
                RandomWodText.Text = fastCheckBox.Text;
            }
            if (EmotmCheckBox.Checked)
            {
                RandomWodText.Text = EmotmCheckBox.Text;
            }
            if (AmrapCheckBox.Checked)
            {
                RandomWodText.Text = AmrapCheckBox.Text;
            }
            if (ChipperCheckBox.Checked)
            {
                RandomWodText.Text = ChipperCheckBox.Text;
            }
            if (CountDownCheckBox.Checked)
            {
                RandomWodText.Text = CountDownCheckBox.Text;
            }
        }

        private void Exercise_Checkboxes()
        {
            DataAccess db = new DataAccess(); // connect's with the database
            Exercise = new List<ExerciseModel>(); // makes a new list for Exercise, so it wont be overridden at every IF statement

            if (BarBellCheckBox.Checked)
            {
                Exercise.AddRange(db.GetExercise(BarBellCheckBox.Text));
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

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Exercise_Checkboxes();
            UpdateBinding();
            WodType_Checkboxes();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            wodListBox.DataSource = null;
            RandomWodText.Text = "";
        }
    }
}
