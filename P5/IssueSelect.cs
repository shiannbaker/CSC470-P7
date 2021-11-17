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
    public partial class IssueSelect : Form
    {
        public int _SelectedId = -1;
        public bool cancel;
        FakeProjectRepository _ProjectRepository = new FakeProjectRepository();
        FakeIssueRepository _IssueRepository = new FakeIssueRepository();


        public IssueSelect()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            cancel = true;
            if (dataGridView1.SelectedRows.Count < 1 )
            {
                MessageBox.Show("A row must be selected.", "Attention");
            }
            else
            {
                int num = (int) dataGridView1.SelectedRows[0].Cells[0].Value;
                var Formpopup = new Form();
                Formpopup.Show();
                Formpopup.Text = num.ToString() + " I";
                _SelectedId = num;
               
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        public int selectedID()
        {
            return _SelectedId;
        }

        private void IssueSelect_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            cancel = false;

            dataGridView1.RowHeadersVisible = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.DataSource = null;

            dataGridView1.ColumnCount = 8;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Title";
            dataGridView1.Columns[2].Name = "DiscoveryDate";
            dataGridView1.Columns[3].Name = "Discoverer";
            dataGridView1.Columns[4].Name = "Initial Description";
            dataGridView1.Columns[5].Name = "Component";
            dataGridView1.Columns[6].Name = "Status";

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 60;

            Project project = _ProjectRepository.GetAll().Find(x => x.Name.Equals(Application.OpenForms[0].Text.Remove(0, 7)));
            if (project != null)
            {
                foreach (Issue _issue in _IssueRepository.GetAll(project.Id))
                {
                    dataGridView1.Rows.Add(_issue.Id, _issue.Title, _issue.DiscoveryDate, _issue.Discoverer, _issue.InitialDescription, 
                        _issue.Component, _issue.IssueStatusId);
                }
            }
            else
            {
                foreach (Issue _issue in _IssueRepository.GetAll(0))
                {
                    dataGridView1.Rows.Add(_issue.Id, _issue.Title, _issue.DiscoveryDate, _issue.Discoverer, _issue.InitialDescription, 
                        _issue.Component, _issue.IssueStatusId);
                }
            }

        }
    }
}
