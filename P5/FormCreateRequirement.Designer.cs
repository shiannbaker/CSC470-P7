
namespace P5
{
    partial class FormCreateRequirement
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.featureComboBox = new System.Windows.Forms.ComboBox();
            this.labelStatement = new System.Windows.Forms.Label();
            this.statementTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(310, 393);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 29);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(550, 393);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(200, 29);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create Requirement";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Feature:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // featureComboBox
            // 
            this.featureComboBox.FormattingEnabled = true;
            this.featureComboBox.Location = new System.Drawing.Point(135, 58);
            this.featureComboBox.Name = "featureComboBox";
            this.featureComboBox.Size = new System.Drawing.Size(615, 24);
            this.featureComboBox.TabIndex = 3;
            this.featureComboBox.SelectedIndexChanged += new System.EventHandler(this.featureComboBox_SelectedIndexChanged);
            // 
            // labelStatement
            // 
            this.labelStatement.AutoSize = true;
            this.labelStatement.Enabled = false;
            this.labelStatement.Location = new System.Drawing.Point(53, 97);
            this.labelStatement.Name = "labelStatement";
            this.labelStatement.Size = new System.Drawing.Size(76, 17);
            this.labelStatement.TabIndex = 4;
            this.labelStatement.Text = "Statement:";
            // 
            // statementTextBox
            // 
            this.statementTextBox.Enabled = false;
            this.statementTextBox.Location = new System.Drawing.Point(135, 94);
            this.statementTextBox.Multiline = true;
            this.statementTextBox.Name = "statementTextBox";
            this.statementTextBox.Size = new System.Drawing.Size(615, 292);
            this.statementTextBox.TabIndex = 8;
            // 
            // FormCreateRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statementTextBox);
            this.Controls.Add(this.labelStatement);
            this.Controls.Add(this.featureComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "FormCreateRequirement";
            this.Text = "Create Requirement";
            this.Load += new System.EventHandler(this.FormCreateRequirement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox featureComboBox;
        private System.Windows.Forms.Label labelStatement;
        private System.Windows.Forms.TextBox statementTextBox;
    }
}