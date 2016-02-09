using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void SaveState()
        {
            if (dataGridView1.DataSource != null)
            Session.GridPosition[Session.currAct] = dataGridView1.CurrentRow.Index;
        }

        public void LoadState()
        {    
            dataGridView1.CurrentCell = dataGridView1[0,Session.GridPosition[Session.currAct]];
        }

        public void LoadGrid()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            AccessDB aDB = new AccessDB();
            DataTable dT = aDB.getTable(Session.ActToString());
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dT;
            LoadState();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveState();
            Form frm = Session.ReturnActForm(0);
            frm.Owner = this;
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SaveState();
            var DlgResult =  MessageBox.Show("Delete current element?","SomeText", MessageBoxButtons.YesNo);
            if (DlgResult == DialogResult.Yes)
            {
                IMyTable tbl = Session.ReturnActTable();
                tbl.DeleteFromDB((int)dataGridView1.CurrentRow.Cells[0].Value);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SaveState();
            Form _frm = Session.ReturnActForm((int)dataGridView1.CurrentRow.Cells[0].Value);
            _frm.Owner = this;
            _frm.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            SaveState();
            Session.currAct = Session.Act.Items;
            LoadGrid();
        }

        private void btnProducers_Click(object sender, EventArgs e)
        {
            SaveState();
            Session.currAct = Session.Act.Producers;
            LoadGrid();
        }

        private void btnStorages_Click(object sender, EventArgs e)
        {
            SaveState();
            Session.currAct = Session.Act.Storages;
            LoadGrid();
        }

        private void btnHardwares_Click(object sender, EventArgs e)
        {
            SaveState();
            Session.currAct = Session.Act.Hardwares;
            LoadGrid();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SaveState();
            Session.currAct = Session.Act.Products;
            LoadGrid();
        }
    }
}
