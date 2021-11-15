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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            FakeProjectRepository projectRepo = new FakeProjectRepository();
            FakeIssueRepository issueRepo = new FakeIssueRepository();

            // Get the text of the FormMain to use to lookup the projectId from the name of the current project
            Project project = projectRepo.GetAll().Find(x => x.Name.Equals(Application.OpenForms[0].Text.Remove(0, 7)));

            if (project != null)
            {
                textBoxTotalIssues.Text = issueRepo.GetAll(project.Id).Count().ToString();
            }
            else
            {
                textBoxTotalIssues.Text = "0";
            }

            listBoxIssuesByMonth.Items.AddRange(issueRepo.GetIssuesByMonth(project.Id).ToArray());
            listBoxIssuesByDiscoverer.Items.AddRange(issueRepo.GetIssuesByDiscoverer(project.Id).ToArray());

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
