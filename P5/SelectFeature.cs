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
    public partial class SelectFeature : Form
    {
        int projectID = -1;
        static int featureID = -1;
        public bool closed = false;
        public SelectFeature()
        {
            InitializeComponent();
        }

        private void SelectFeature_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeFeatureRepository fakefeatures = new FakeFeatureRepository();
            List<Feature> features = new List<Feature>();
            FormMain mainform = new FormMain();
            projectID = mainform.ProjectID;


            dataGridView1.RowHeadersVisible = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.DataSource = null;

            dataGridView1.ColumnCount = 2;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Feature";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;

            //display features
            if (projectID != -1)
            {
                foreach (Feature feature in fakefeatures.GetAll(projectID))
                {
                    dataGridView1.Rows.Add(feature.Id, feature.Title);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int featureId()
        {
            return featureID;
        }
        private void buttonSelectFeature_Click(object sender, EventArgs e)
        {
            //GET TITLE INPUT : GET FEATURE ID
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("A row must be selected.", "Attention");
            }
            else
            {
                int num = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                /*var Formpopup = new Form();
                Formpopup.Show();
                Formpopup.Text = num.ToString() + " I";*/
                featureID = num;

                FormMain m = new FormMain();
                bool next;
                next = m.Modify();
                if(next == true)
                {
                    ModifyFeature modifyF = new ModifyFeature();
                    this.Close();
                    modifyF.Show();
                }
                else
                {
                    RemoveFeature removeF = new RemoveFeature();
                    this.Close();
                    removeF.Show();
                }
                //this.DialogResult = DialogResult.OK;
            }
        }
    }
}
