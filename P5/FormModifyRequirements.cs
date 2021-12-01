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
    public partial class FormModifyRequirement : Form
    {
        public FormModifyRequirement()
        {
            InitializeComponent();
        }

        private void FormModifyRequirement_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            FakeFeatureRepository featureRepo = new FakeFeatureRepository();
            FakeRequirementRepository repo = new FakeRequirementRepository();
            
            foreach (Feature x in featureRepo.GetAll(FormMain.selectedID))
            {
                int index = featureComboBox.Items.Add(x.Title);
            }
            featureComboBox.SelectedItem = featureRepo.GetFeatureById(FormMain.selectedID, FormSelectRequirement._requirementId).Title;

            statementTextBox.Text = repo.GetRequirementById(FormSelectRequirement._requirementId).Statement;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository featureRepo = new FakeFeatureRepository();
            FakeRequirementRepository repo = new FakeRequirementRepository();

            Requirement newReq = new Requirement();

            newReq.Id = FormSelectRequirement._requirementId;
            newReq.FeatureId = featureRepo.GetFeatureByTitle(FormMain.selectedID, featureComboBox.SelectedItem.ToString()).Id;
            newReq.ProjectId = FormMain.selectedID;
            newReq.Statement = statementTextBox.Text;

            string _return = repo.Modify(newReq);

            if (_return.Equals(""))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(_return, "Attention");
            }
        }
    }
}
