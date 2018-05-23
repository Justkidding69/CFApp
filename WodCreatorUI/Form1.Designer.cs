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
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(74, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(90, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Tag = "";
            this.titleLabel.Text = "Choose";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // wodOptionOne
            // 
            this.wodOptionOne.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.wodOptionOne.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.wodOptionOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wodOptionOne.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wodOptionOne.Location = new System.Drawing.Point(45, 93);
            this.wodOptionOne.Name = "wodOptionOne";
            this.wodOptionOne.Size = new System.Drawing.Size(148, 29);
            this.wodOptionOne.TabIndex = 1;
            this.wodOptionOne.Text = "21-15-9";
            this.wodOptionOne.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(243, 339);
            this.Controls.Add(this.wodOptionOne);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "WOD Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button wodOptionOne;
    }
}

