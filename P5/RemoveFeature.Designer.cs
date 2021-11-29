
namespace P5
{
    partial class RemoveFeature
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
            this.label1 = new System.Windows.Forms.Label();
            this.FeatureName = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to remove: ";
            // 
            // FeatureName
            // 
            this.FeatureName.AutoSize = true;
            this.FeatureName.Location = new System.Drawing.Point(230, 120);
            this.FeatureName.Name = "FeatureName";
            this.FeatureName.Size = new System.Drawing.Size(64, 13);
            this.FeatureName.TabIndex = 1;
            this.FeatureName.Text = "Change me!";
            // 
            // yesButton
            // 
            this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.yesButton.Location = new System.Drawing.Point(96, 177);
            this.yesButton.Margin = new System.Windows.Forms.Padding(2);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(110, 31);
            this.yesButton.TabIndex = 5;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(237, 177);
            this.NoButton.Margin = new System.Windows.Forms.Padding(2);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(104, 31);
            this.NoButton.TabIndex = 4;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // RemoveFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.FeatureName);
            this.Controls.Add(this.label1);
            this.Name = "RemoveFeature";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.RemoveFeature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FeatureName;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button NoButton;
    }
}