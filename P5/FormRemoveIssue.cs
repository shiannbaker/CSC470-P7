using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class FormRemoveIssue : Form
    {
        int selectedIssueID;
        FakeIssueRepository fakerep = new FakeIssueRepository();
        Issue issuerep = new Issue();
        public FormRemoveIssue()
        {
            InitializeComponent();
        }

        private void FormRemoveIssue_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            selectedIssueID = FormMain.selectedID;
            issuerep = fakerep.GetIssueById(selectedIssueID);
            labelIssueName.Text = issuerep.Title;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remove Canceled.", "Attention");
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DialogResult isSure = MessageBox.Show("Are you sure you want to remove this project?", "Confirmation", MessageBoxButtons.YesNo);
            if (isSure == DialogResult.Yes)
            {
                issuerep = fakerep.GetIssueById(selectedIssueID);
                bool result = fakerep.Remove(issuerep);
                if (result)
                {
                    MessageBox.Show("Project removed.", "Information");
                }
                else
                {
                    MessageBox.Show("Failed to remove issue.");
                }
                Close();
            }
        }
    }
}
