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
    public partial class CreateFeature : Form
    {
        FakeFeatureRepository fakeFeature = new FakeFeatureRepository();

        public CreateFeature()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//cancel
        {
            this.Close();
        }

        private void createF_Click(object sender, EventArgs e)
        {
            string title;
            title = textBox1.Text;

            Feature feature = new Feature();
            feature.Title = title;

            title = fakeFeature.Add(feature);
            MessageBox.Show(title);

            if(title == "Added Successfully.")
            {
                this.Close();
            }
        }

        private void CreateFeature_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
