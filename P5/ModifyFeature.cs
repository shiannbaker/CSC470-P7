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
    public partial class ModifyFeature : Form
    {
        public ModifyFeature()
        {
            InitializeComponent();
        }

        private void ModifyFeature_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyF_Click(object sender, EventArgs e)
        {
            string title = "";
            title = textBox1.Text;

            if(title == "")
            {
                MessageBox.Show("You must enter a title.");
            }
            else
            {
                int projectId = -1;
                FormSelectProject sProject = new FormSelectProject();
                projectId = sProject.currentPID();

                SelectFeature selectF = new SelectFeature();
                int featureId = selectF.featureId();

                //get feature to modify
                Feature feature = new Feature();
                FakeFeatureRepository f = new FakeFeatureRepository();
                feature = f.GetFeatureById(projectId, featureId);

                //modify feature title
                feature.Title = title;
                this.Close();
            }
        }
    }
}
