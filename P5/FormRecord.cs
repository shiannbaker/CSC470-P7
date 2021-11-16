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
    public partial class FormRecord : Form
    {
        AppUser _CurrentAppUser;
        public FormRecord(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void FormRecord_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            // Get the names of all users to fill the dropdown for Discoverers
            FakeAppUserRepository userRepo = new FakeAppUserRepository();
            List<AppUser> userList = userRepo.GetAll();

            foreach (AppUser x in userList)
            {
                int index = comboBoxDiscoverer.Items.Add(x.LastName + ", " + x.FirstName);

                if (x.UserName.Equals(_CurrentAppUser.UserName))
                {
                    comboBoxDiscoverer.SelectedIndex = index;
                }
            }

            FakeIssueStatusRepository issueStatRepo = new FakeIssueStatusRepository();
            List<IssueStatus> issueStatList = issueStatRepo.GetAll();
            foreach (IssueStatus y in issueStatList)
            {
                int index = comboBoxStatus.Items.Add(y.Value);
            }
            comboBoxStatus.SelectedIndex = 0;

            FakeIssueRepository issueRepo = new FakeIssueRepository();
            textBoxId.Text = issueRepo.GetId().ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Issue newIssue = new Issue();
            FakeIssueRepository issueRepo = new FakeIssueRepository();
            newIssue.Title = textBoxTitle.Text;
            newIssue.DiscoveryDate = dateTimePickerDiscoveryDate.Value;
            newIssue.Discoverer = comboBoxDiscoverer.Text;
            newIssue.Component = textBoxComponent.Text;
            newIssue.IssueStatusId = comboBoxStatus.SelectedIndex;
            newIssue.Id = 0;

            string errorMsg = issueRepo.Add(newIssue);

            if (errorMsg.Equals(""))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error - Issue Not Recorded");
            }
        }
    }
}
