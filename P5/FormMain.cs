using System.Windows.Forms;

namespace P5
{
    public partial class FormMain : Form
    {
        private AppUser _CurrentAppUser = new AppUser();
        public static int selectedID;
        public int ProjectID;
        private static bool _modify;
        public FormMain()
        {
            InitializeComponent();
        }

        private void preferencesCreateProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateProject form = new FormCreateProject();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            this.CenterToScreen();
            // Force the user to login successfully or abort the application
            DialogResult isOK = DialogResult.OK;
            while (!_CurrentAppUser.IsAuthenticated && isOK == DialogResult.OK)
            {
                FormLogin login = new FormLogin();
                isOK = login.ShowDialog();
                _CurrentAppUser = login._CurrentAppUser;
                login.Dispose();
            }
            if (isOK != DialogResult.OK)
            {
                Close();
                return;
            }
            this.Text = "Main - No Project Selected";
            while (selectAProject() == "")
            {
                DialogResult result = MessageBox.Show("A project must be selected.", "Attention", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
        }

        private void preferencesSelectProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            selectAProject();
        }

        private string selectAProject()
        {
            string selectedProject = "";
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_NAME,
                                                   form._SelectedProjectName);
                int selectedProjectId = form._SelectedProjectId;
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID,
                                                   selectedProjectId.ToString());
                this.Text = "Main - " + form._SelectedProjectName;
                selectedProject = form._SelectedProjectName;
            }
            form.Dispose();
            return selectedProject;
        }

        private void preferencesModifyProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyProject form = new FormModifyProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void preferencesRemoveProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRemoveProject form = new FormRemoveProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesDashboardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormDashboard form = new FormDashboard();
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRecord form = new FormRecord(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesModifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IssueSelect form1 = new IssueSelect();
            form1.ShowDialog();
            selectedID = form1.selectedID();
            var Formpopup = new Form();
            Formpopup.Show();
            Formpopup.Text = selectedID.ToString() + " m";
            form1.Dispose();

            IssueModify form = new IssueModify(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRemoveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IssueSelect form1 = new IssueSelect();
            form1.ShowDialog();
            selectedID = form1.selectedID();
            var Formpopup = new Form();
            Formpopup.Show();
            Formpopup.Text = selectedID.ToString() + " r";
            form1.Dispose();

            FormRemoveIssue form = new FormRemoveIssue();
            form.ShowDialog();
            form.Dispose();
        }

        private void createToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ProjectID = selectedID;
            CreateFeature createFeature = new CreateFeature();
            createFeature.Show();
            //createFeature.Dispose();
        }

        private void modifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _modify = true;
            ProjectID = selectedID;
            SelectFeature selectF = new SelectFeature();
            selectF.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _modify = false;
            ProjectID = selectedID;
            SelectFeature selectF = new SelectFeature();
            selectF.Show();
        }
        public bool Modify()
        {
            if (_modify == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void createToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            FormCreateRequirement newForm = new FormCreateRequirement();
            newForm.ShowDialog();
            newForm.Dispose();
        }

        private void modifyToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            FormSelectRequirement newFormA = new FormSelectRequirement();
            newFormA.ShowDialog();
            FormModifyRequirement newFormB = new FormModifyRequirement();
            newFormB.ShowDialog();
            newFormA.Dispose();
            newFormB.Dispose();
            
        }

        private void removeToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            FormSelectRequirement newForm = new FormSelectRequirement();
            newForm.ShowDialog();

            FakeRequirementRepository repo = new FakeRequirementRepository();
            Requirement requirement = repo.GetRequirementById(FormSelectRequirement._requirementId);

            DialogResult _Return = MessageBox.Show("Are you sure you want to remove: " + requirement.Statement, "Confirmation", MessageBoxButtons.YesNo);

            if (_Return == DialogResult.Yes)
            {
                repo.Remove(requirement);
            }
        }
    }
}
