
namespace P5
{
    partial class FormRecord
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDiscoveryDate = new System.Windows.Forms.Label();
            this.labelDiscoverer = new System.Windows.Forms.Label();
            this.labelComponent = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxComponent = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerDiscoveryDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDiscoverer = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(165, 100);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 17);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(149, 140);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 17);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title:";
            // 
            // labelDiscoveryDate
            // 
            this.labelDiscoveryDate.AutoSize = true;
            this.labelDiscoveryDate.Location = new System.Drawing.Point(80, 180);
            this.labelDiscoveryDate.Name = "labelDiscoveryDate";
            this.labelDiscoveryDate.Size = new System.Drawing.Size(108, 17);
            this.labelDiscoveryDate.TabIndex = 2;
            this.labelDiscoveryDate.Text = "Discovery Date:";
            // 
            // labelDiscoverer
            // 
            this.labelDiscoverer.AutoSize = true;
            this.labelDiscoverer.Location = new System.Drawing.Point(108, 220);
            this.labelDiscoverer.Name = "labelDiscoverer";
            this.labelDiscoverer.Size = new System.Drawing.Size(80, 17);
            this.labelDiscoverer.TabIndex = 3;
            this.labelDiscoverer.Text = "Discoverer:";
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Location = new System.Drawing.Point(108, 260);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(84, 17);
            this.labelComponent.TabIndex = 4;
            this.labelComponent.Text = "Component:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(136, 300);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 17);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(80, 340);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(115, 17);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Initial Description";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(200, 100);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(80, 22);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(200, 140);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(300, 22);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxComponent
            // 
            this.textBoxComponent.Location = new System.Drawing.Point(200, 260);
            this.textBoxComponent.Name = "textBoxComponent";
            this.textBoxComponent.Size = new System.Drawing.Size(300, 22);
            this.textBoxComponent.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 370);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(380, 292);
            this.textBox1.TabIndex = 7;
            // 
            // dateTimePickerDiscoveryDate
            // 
            this.dateTimePickerDiscoveryDate.CustomFormat = "hh:mm:ss tt dd MMM yyyy";
            this.dateTimePickerDiscoveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDiscoveryDate.Location = new System.Drawing.Point(200, 180);
            this.dateTimePickerDiscoveryDate.Name = "dateTimePickerDiscoveryDate";
            this.dateTimePickerDiscoveryDate.Size = new System.Drawing.Size(300, 22);
            this.dateTimePickerDiscoveryDate.TabIndex = 3;
            // 
            // comboBoxDiscoverer
            // 
            this.comboBoxDiscoverer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverer.FormattingEnabled = true;
            this.comboBoxDiscoverer.Location = new System.Drawing.Point(200, 220);
            this.comboBoxDiscoverer.Name = "comboBoxDiscoverer";
            this.comboBoxDiscoverer.Size = new System.Drawing.Size(300, 24);
            this.comboBoxDiscoverer.TabIndex = 4;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(200, 300);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(300, 24);
            this.comboBoxStatus.TabIndex = 6;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(360, 680);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(134, 41);
            this.buttonCreate.TabIndex = 9;
            this.buttonCreate.Text = "Create Issue";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(180, 680);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 41);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 742);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxDiscoverer);
            this.Controls.Add(this.dateTimePickerDiscoveryDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxComponent);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelComponent);
            this.Controls.Add(this.labelDiscoverer);
            this.Controls.Add(this.labelDiscoveryDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelId);
            this.Name = "FormRecord";
            this.Text = "Record Issue";
            this.Load += new System.EventHandler(this.FormRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDiscoveryDate;
        private System.Windows.Forms.Label labelDiscoverer;
        private System.Windows.Forms.Label labelComponent;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxComponent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiscoveryDate;
        private System.Windows.Forms.ComboBox comboBoxDiscoverer;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
    }
}