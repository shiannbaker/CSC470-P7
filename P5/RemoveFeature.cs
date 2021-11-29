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

            string _remove;
            _remove = f.Remove(feature);

            if(_remove == "true")
            {
                this.Close();
            }
            else
            {
                FormMain rem_f = new FormMain();
                rem_f.Text = "Error Removing.";
                rem_f.ShowDialog();
            }

            //ADD IF AND ONLY IF requirements associated with feature
        }
    }
}
