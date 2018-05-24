namespace WodCreatorUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.wodOptionOne = new System.Windows.Forms.Button();
            this.wodOptionTwo = new System.Windows.Forms.Button();
            this.wodOptionThree = new System.Windows.Forms.Button();
            this.wodOptionFour = new System.Windows.Forms.Button();
            this.wodOptionFive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(127, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Tag = "";
            this.titleLabel.Text = "Choose";
            // 
            // wodOptionOne
            // 
            this.wodOptionOne.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.wodOptionOne.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.wodOptionOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wodOptionOne.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wodOptionOne.Location = new System.Drawing.Point(48, 72);
            this.wodOptionOne.Name = "wodOptionOne";
            this.wodOptionOne.Size = new System.Drawing.Size(148, 29);
            this.wodOptionOne.TabIndex = 1;
            this.wodOptionOne.Text = "21-15-9";
            this.wodOptionOne.UseVisualStyleBackColor = true;
            // 
            // wodOptionTwo
            // 
            this.wodOptionTwo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.wodOptionTwo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.wodOptionTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wodOptionTwo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wodOptionTwo.Location = new System.Drawing.Point(48, 107);
            this.wodOptionTwo.Name = "wodOptionTwo";
            this.wodOptionTwo.Size = new System.Drawing.Size(148, 29);
            this.wodOptionTwo.TabIndex = 2;
            this.wodOptionTwo.Text = "10-9-8-7-6-5...";
            this.wodOptionTwo.UseVisualStyleBackColor = true;
            // 
            // wodOptionThree
            // 
            this.wodOptionThree.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.wodOptionThree.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.wodOptionThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wodOptionThree.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wodOptionThree.Location = new System.Drawing.Point(48, 142);
            this.wodOptionThree.Name = "wodOptionThree";
            this.wodOptionThree.Size = new System.Drawing.Size(148, 29);
            this.wodOptionThree.TabIndex = 3;
            this.wodOptionThree.Text = "AMRAP";
            this.wodOptionThree.UseVisualStyleBackColor = true;
            // 
            // wodOptionFour
            // 
            this.wodOptionFour.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.wodOptionFour.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.wodOptionFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wodOptionFour.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wodOptionFour.Location = new System.Drawing.Point(48, 177);
            this.wodOptionFour.Name = "wodOptionFour";
            this.wodOptionFour.Size = new System.Drawing.Size(148, 29);
            this.wodOptionFour.TabIndex = 4;
            this.wodOptionFour.Text = "EMOTM";
            this.wodOptionFour.UseVisualStyleBackColor = true;
            // 
            // wodOptionFive
            // 
            this.wodOptionFive.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.wodOptionFive.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.wodOptionFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wodOptionFive.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wodOptionFive.Location = new System.Drawing.Point(48, 212);
            this.wodOptionFive.Name = "wodOptionFive";
            this.wodOptionFive.Size = new System.Drawing.Size(148, 29);
            this.wodOptionFive.TabIndex = 5;
            this.wodOptionFive.Text = "Ladies";
            this.wodOptionFive.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(243, 339);
            this.Controls.Add(this.wodOptionFive);
            this.Controls.Add(this.wodOptionFour);
            this.Controls.Add(this.wodOptionThree);
            this.Controls.Add(this.wodOptionTwo);
            this.Controls.Add(this.wodOptionOne);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "WOD Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button wodOptionOne;
        private System.Windows.Forms.Button wodOptionTwo;
        private System.Windows.Forms.Button wodOptionThree;
        private System.Windows.Forms.Button wodOptionFour;
        private System.Windows.Forms.Button wodOptionFive;
    }
}

