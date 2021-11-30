
namespace P5
{
    partial class FormSelectRequirement
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
            this.dataGridViewRequirements = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelectRequirement = new System.Windows.Forms.Button();
            this.featureComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequirements)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequirements
            // 
            this.dataGridViewRequirements.AllowUserToAddRows = false;
            this.dataGridViewRequirements.AllowUserToDeleteRows = false;
            this.dataGridViewRequirements.AllowUserToResizeRows = false;
            this.dataGridViewRequirements.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequirements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Requirement});
            this.dataGridViewRequirements.Enabled = false;
            this.dataGridViewRequirements.Location = new System.Drawing.Point(25, 75);
            this.dataGridViewRequirements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRequirements.Name = "dataGridViewRequirements";
            this.dataGridViewRequirements.ReadOnly = true;
            this.dataGridViewRequirements.RowHeadersWidth = 51;
            this.dataGridViewRequirements.RowTemplate.Height = 28;
            this.dataGridViewRequirements.Size = new System.Drawing.Size(748, 330);
            this.dataGridViewRequirements.TabIndex = 7;
            this.dataGridViewRequirements.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequirements_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 50;
            // 
            // Requirement
            // 
            this.Requirement.HeaderText = "Requirement";
            this.Requirement.MinimumWidth = 6;
            this.Requirement.Name = "Requirement";
            this.Requirement.ReadOnly = true;
            this.Requirement.Width = 500;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(395, 430);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 37);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSelectRequirement
            // 
            this.buttonSelectRequirement.Enabled = false;
            this.buttonSelectRequirement.Location = new System.Drawing.Point(613, 430);
            this.buttonSelectRequirement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectRequirement.Name = "buttonSelectRequirement";
            this.buttonSelectRequirement.Size = new System.Drawing.Size(160, 37);
            this.buttonSelectRequirement.TabIndex = 8;
            this.buttonSelectRequirement.Text = "Select Requirement";
            this.buttonSelectRequirement.UseVisualStyleBackColor = true;
            this.buttonSelectRequirement.Click += new System.EventHandler(this.buttonSelectRequirement_Click);
            // 
            // featureComboBox
            // 
            this.featureComboBox.FormattingEnabled = true;
            this.featureComboBox.Location = new System.Drawing.Point(93, 26);
            this.featureComboBox.Name = "featureComboBox";
            this.featureComboBox.Size = new System.Drawing.Size(680, 24);
            this.featureComboBox.TabIndex = 11;
            this.featureComboBox.SelectedIndexChanged += new System.EventHandler(this.featureComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Feature:";
            // 
            // FormSelectRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.featureComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectRequirement);
            this.Controls.Add(this.dataGridViewRequirements);
            this.Name = "FormSelectRequirement";
            this.Text = "Select Requirement";
            this.Load += new System.EventHandler(this.FormSelectRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequirements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequirements;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSelectRequirement;
        private System.Windows.Forms.ComboBox featureComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requirement;
    }
}