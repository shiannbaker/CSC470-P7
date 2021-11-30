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
    public partial class FormSelectRequirement : Form
    {
        public static int _requirementId = -1;
        public FormSelectRequirement()
        {
            InitializeComponent();
        }

        private void FormSelectRequirement_Load(object sender, EventArgs e)
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
                dataGridViewRequirements.Enabled = false;
                buttonSelectRequirement.Enabled = false;
                dataGridViewRequirements.Rows.Clear();
            }
            else
            {
                dataGridViewRequirements.Enabled = true;
                dataGridViewRequirements.Rows.Clear();

                FakeFeatureRepository featureRepo = new FakeFeatureRepository();

                FakeRequirementRepository repo = new FakeRequirementRepository();
                List<Requirement> reqs = repo.GetAll(FormMain.selectedID);
                foreach (Requirement X in reqs)
                {
                    //Console.WriteLine(X.FeatureId);
                    if (X.FeatureId == featureRepo.GetFeatureByTitle(FormMain.selectedID, featureComboBox.SelectedItem.ToString()).Id)
                    {
                        dataGridViewRequirements.Rows.Add(X.Id, X.Statement);
                    }
                }
            }
        }

        private void dataGridViewRequirements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRequirements.SelectedRows.Count > 0)
            {
                buttonSelectRequirement.Enabled = true;
            }
            else
            {
                buttonSelectRequirement.Enabled = false;
            }
        }

        private void buttonSelectRequirement_Click(object sender, EventArgs e)
        {
            //GET TITLE INPUT : GET FEATURE ID
            if (dataGridViewRequirements.SelectedRows.Count < 1)
            {
                MessageBox.Show("A row must be selected.", "Attention");
            }
            int num = (int)dataGridViewRequirements.SelectedRows[0].Cells[0].Value;
            _requirementId = num;
            this.Close();
        }
    }
}
