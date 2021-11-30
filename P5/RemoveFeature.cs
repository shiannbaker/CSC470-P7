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
    public partial class RemoveFeature : Form
    {
        public RemoveFeature()
        {
            InitializeComponent();
        }

        private void RemoveFeature_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            SelectFeature form = new SelectFeature(); //just change the form

            //display selected feature name
            int projectId = -1;
            FormSelectProject sProject = new FormSelectProject();
            projectId = sProject.currentPID();

            SelectFeature selectF = new SelectFeature();
            int featureId = selectF.featureId();

            //get feature to modify
            Feature feature = new Feature();
            FakeFeatureRepository f = new FakeFeatureRepository();
            feature = f.GetFeatureById(projectId, featureId);
            FeatureName.Text = feature.Title;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository f = new FakeFeatureRepository();
            FormSelectProject sProject = new FormSelectProject();
            SelectFeature selectF = new SelectFeature();

            int projectId = -1;
            projectId = sProject.currentPID();
            int featureId = selectF.featureId();

            //get feature to modify
            Feature feature = new Feature();
            feature = f.GetFeatureById(projectId, featureId);

            // If and only If requirements
            FakeRequirementRepository requirements = new FakeRequirementRepository();
            if (requirements.CountByFeatureId(featureId) > 0)
            {
                DialogResult result = MessageBox.Show("There are one or more requirements assosociated with this feature. " +
                    "These requirements will be destroyed if you remove this feature. " +
                    "Are you sure you want to remove: " + feature.Title + "?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string _remove;
                    _remove = f.Remove(feature);

                    if (_remove == "")
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(_remove, "Error Removing.");
                        //FormMain rem_f = new FormMain();
                        //rem_f.Text = "Error Removing.";
                        //rem_f.ShowDialog();
                    }
                }
                else
                {

                }
            }
        }
    }
}
