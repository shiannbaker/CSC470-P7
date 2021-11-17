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
    public partial class IssueModify : Form
    {
        AppUser _CurrentAppUser;
        int selectedid = -1;

        IssueSelect issuses = new IssueSelect();
        
        Issue newIssue = new Issue();

        public IssueModify(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void IssueModify_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Hide();

            FakeIssueRepository issueRepo = new FakeIssueRepository();
            selectedid = FormMain.selectedID;
            var Formpopup = new Form();
            Formpopup.Show();
            Formpopup.Text = FormMain.selectedID.ToString() + " mod";
            if (selectedid == -1)
                this.Close();

            //set defaults
            //newIssue = issueRepo.GetIssueById(selectedid);

            //regular set up
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
            newIssue = issueRepo.GetIssueById(FormMain.selectedID);
            comboBoxStatus.SelectedIndex = newIssue.IssueStatusId; //status
            textBoxId.Text = FormMain.selectedID.ToString(); //id

            textBoxTitle.Text = newIssue.Title;
            dateTimePickerDiscoveryDate.Value = newIssue.DiscoveryDate;
            comboBoxDiscoverer.Text = newIssue.Discoverer;
            textBoxComponent.Text = newIssue.Component;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FakeIssueRepository issueRepo = new FakeIssueRepository();
            newIssue.Title = textBoxTitle.Text;
            newIssue.DiscoveryDate = dateTimePickerDiscoveryDate.Value;
            newIssue.Discoverer = comboBoxDiscoverer.Text;
            newIssue.Component = textBoxComponent.Text;
            newIssue.IssueStatusId = comboBoxStatus.SelectedIndex;

            FakeProjectRepository projectRepo = new FakeProjectRepository();
            // Get the text of the FormMain to use to lookup the projectId from the name of the current project
            Project project = projectRepo.GetAll().Find(x => x.Name.Equals(Application.OpenForms[0].Text.Remove(0, 7)));
            string errorMsg = issueRepo.Modify(newIssue);

            if (errorMsg.Equals(""))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error - Issue Not Recorded");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
