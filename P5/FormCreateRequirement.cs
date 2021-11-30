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
    public partial class FormCreateRequirement : Form
    {
        public FormCreateRequirement()
        {
            InitializeComponent();
        }

        private void FormCreateRequirement_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            FakeFeatureRepository x = new FakeFeatureRepository();
            featureComboBox.Items.Add("<Make Selection>");
            featureComboBox.SelectedIndex = 0;

            int projectId = FormMain.selectedID;
            List<Feature> features = x.GetAll(projectId);

            foreach (Feature y in features)
            {
                featureComboBox.Items.Add(y.Title);
            }
        }

        private void featureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (featureComboBox.SelectedItem.ToString().Equals("<Make Selection>"))
            {
                createButton.Enabled = false;
                statementTextBox.Enabled = false;
                labelStatement.Enabled = false;
            }
            else
            {
                createButton.Enabled = true;
                statementTextBox.Enabled = true;
                labelStatement.Enabled = true;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository featureRepo = new FakeFeatureRepository();
            FakeRequirementRepository repo = new FakeRequirementRepository();

            Requirement newReq = new Requirement();

            newReq.FeatureId = featureRepo.GetFeatureByTitle(FormMain.selectedID, featureComboBox.SelectedItem.ToString()).Id;
            newReq.ProjectId = FormMain.selectedID;
            newReq.Statement = statementTextBox.Text;

            string _return = repo.Add(newReq);

            if (_return.Equals(""))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(_return, "Attention");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
