
namespace P5
{
    partial class FormDashboard
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotalIssues = new System.Windows.Forms.TextBox();
            this.labelIssuesByMonth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listBoxIssuesByMonth = new System.Windows.Forms.ListBox();
            this.listBoxIssuesByDiscoverer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(100, 72);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(158, 17);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total Number of Issues:";
            // 
            // textBoxTotalIssues
            // 
            this.textBoxTotalIssues.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTotalIssues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalIssues.Location = new System.Drawing.Point(265, 72);
            this.textBoxTotalIssues.Name = "textBoxTotalIssues";
            this.textBoxTotalIssues.ReadOnly = true;
            this.textBoxTotalIssues.Size = new System.Drawing.Size(100, 15);
            this.textBoxTotalIssues.TabIndex = 0;
            this.textBoxTotalIssues.TabStop = false;
            this.textBoxTotalIssues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelIssuesByMonth
            // 
            this.labelIssuesByMonth.AutoSize = true;
            this.labelIssuesByMonth.Location = new System.Drawing.Point(100, 130);
            this.labelIssuesByMonth.Name = "labelIssuesByMonth";
            this.labelIssuesByMonth.Size = new System.Drawing.Size(110, 17);
            this.labelIssuesByMonth.TabIndex = 1;
            this.labelIssuesByMonth.Text = "Issues by Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issues by Discoverer";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(298, 547);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 38);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listBoxIssuesByMonth
            // 
            this.listBoxIssuesByMonth.FormattingEnabled = true;
            this.listBoxIssuesByMonth.ItemHeight = 16;
            this.listBoxIssuesByMonth.Location = new System.Drawing.Point(100, 150);
            this.listBoxIssuesByMonth.Name = "listBoxIssuesByMonth";
            this.listBoxIssuesByMonth.ScrollAlwaysVisible = true;
            this.listBoxIssuesByMonth.Size = new System.Drawing.Size(300, 148);
            this.listBoxIssuesByMonth.Sorted = true;
            this.listBoxIssuesByMonth.TabIndex = 4;
            // 
            // listBoxIssuesByDiscoverer
            // 
            this.listBoxIssuesByDiscoverer.FormattingEnabled = true;
            this.listBoxIssuesByDiscoverer.ItemHeight = 16;
            this.listBoxIssuesByDiscoverer.Location = new System.Drawing.Point(100, 360);
            this.listBoxIssuesByDiscoverer.Name = "listBoxIssuesByDiscoverer";
            this.listBoxIssuesByDiscoverer.ScrollAlwaysVisible = true;
            this.listBoxIssuesByDiscoverer.Size = new System.Drawing.Size(300, 148);
            this.listBoxIssuesByDiscoverer.Sorted = true;
            this.listBoxIssuesByDiscoverer.TabIndex = 5;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 613);
            this.Controls.Add(this.listBoxIssuesByDiscoverer);
            this.Controls.Add(this.listBoxIssuesByMonth);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIssuesByMonth);
            this.Controls.Add(this.textBoxTotalIssues);
            this.Controls.Add(this.labelTotal);
            this.Name = "FormDashboard";
            this.Text = "Issue Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotalIssues;
        private System.Windows.Forms.Label labelIssuesByMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxIssuesByMonth;
        private System.Windows.Forms.ListBox listBoxIssuesByDiscoverer;
    }
}