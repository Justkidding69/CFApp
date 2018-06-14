namespace WodCreatorUI
{
    partial class WodDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WodDashBoard));
            this.titleLabel = new System.Windows.Forms.Label();
            this.wodOptionFiveButton = new System.Windows.Forms.Button();
            this.wodOptionSixButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(51, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(141, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Tag = "";
            this.titleLabel.Text = "Choose";
            // 
            // wodOptionFiveButton
            // 
            this.wodOptionFiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.wodOptionFiveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.wodOptionFiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.wodOptionFiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wodOptionFiveButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wodOptionFiveButton.Location = new System.Drawing.Point(48, 133);
            this.wodOptionFiveButton.Name = "wodOptionFiveButton";
            this.wodOptionFiveButton.Size = new System.Drawing.Size(148, 29);
            this.wodOptionFiveButton.TabIndex = 5;
            this.wodOptionFiveButton.Text = "Ladies";
            this.wodOptionFiveButton.UseVisualStyleBackColor = false;
            this.wodOptionFiveButton.Click += new System.EventHandler(this.wodOptionFiveButton_Click);
            // 
            // wodOptionSixButton
            // 
            this.wodOptionSixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.wodOptionSixButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.wodOptionSixButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.wodOptionSixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wodOptionSixButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wodOptionSixButton.Location = new System.Drawing.Point(48, 87);
            this.wodOptionSixButton.Name = "wodOptionSixButton";
            this.wodOptionSixButton.Size = new System.Drawing.Size(148, 29);
            this.wodOptionSixButton.TabIndex = 6;
            this.wodOptionSixButton.Text = "Random";
            this.wodOptionSixButton.UseVisualStyleBackColor = false;
            this.wodOptionSixButton.Click += new System.EventHandler(this.wodOptionSixButton_Click);
            // 
            // WodDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(243, 305);
            this.Controls.Add(this.wodOptionSixButton);
            this.Controls.Add(this.wodOptionFiveButton);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "WodDashBoard";
            this.Text = " ";
            this.Load += new System.EventHandler(this.WodDashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button wodOptionFiveButton;
        private System.Windows.Forms.Button wodOptionSixButton;
    }
}

