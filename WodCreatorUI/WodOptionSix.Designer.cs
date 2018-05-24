namespace WodCreatorUI
{
    partial class WodOptionSix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WodOptionSix));
            this.wodListBox = new System.Windows.Forms.ListBox();
            this.LadyWodNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.CreatButton = new System.Windows.Forms.Button();
            this.ladyInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wodListBox
            // 
            this.wodListBox.BackColor = System.Drawing.Color.White;
            this.wodListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wodListBox.FormattingEnabled = true;
            this.wodListBox.ItemHeight = 30;
            this.wodListBox.Location = new System.Drawing.Point(254, 87);
            this.wodListBox.Name = "wodListBox";
            this.wodListBox.Size = new System.Drawing.Size(199, 244);
            this.wodListBox.TabIndex = 52;
            // 
            // LadyWodNameLabel
            // 
            this.LadyWodNameLabel.AutoSize = true;
            this.LadyWodNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LadyWodNameLabel.Location = new System.Drawing.Point(249, 25);
            this.LadyWodNameLabel.Name = "LadyWodNameLabel";
            this.LadyWodNameLabel.Size = new System.Drawing.Size(155, 30);
            this.LadyWodNameLabel.TabIndex = 51;
            this.LadyWodNameLabel.Text = "<place holder>";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(121, 50);
            this.titleLabel.TabIndex = 45;
            this.titleLabel.Tag = "";
            this.titleLabel.Text = "Ladies";
            // 
            // CreatButton
            // 
            this.CreatButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreatButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.CreatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatButton.Location = new System.Drawing.Point(459, 87);
            this.CreatButton.Name = "CreatButton";
            this.CreatButton.Size = new System.Drawing.Size(148, 29);
            this.CreatButton.TabIndex = 43;
            this.CreatButton.Text = "Create";
            this.CreatButton.UseVisualStyleBackColor = true;
            // 
            // ladyInfoLabel
            // 
            this.ladyInfoLabel.AutoSize = true;
            this.ladyInfoLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladyInfoLabel.Location = new System.Drawing.Point(16, 87);
            this.ladyInfoLabel.Name = "ladyInfoLabel";
            this.ladyInfoLabel.Size = new System.Drawing.Size(155, 90);
            this.ladyInfoLabel.TabIndex = 53;
            this.ladyInfoLabel.Text = "<place holder>\r\ntext about the \r\nOffical wods";
            // 
            // Ladies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 356);
            this.Controls.Add(this.ladyInfoLabel);
            this.Controls.Add(this.wodListBox);
            this.Controls.Add(this.LadyWodNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.CreatButton);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ladies";
            this.Text = "Ladies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wodListBox;
        private System.Windows.Forms.Label LadyWodNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button CreatButton;
        private System.Windows.Forms.Label ladyInfoLabel;
    }
}