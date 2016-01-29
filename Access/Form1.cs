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
            Session.GridPosition[Session.currAct] = dataGridView1.CurrentRow.Index;
        }

        public void LoadState()
        {
            dataGridView1.Rows[Session.GridPosition[Session.currAct]].Selected = true;
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


        private void btnItems_Click(object sender, EventArgs e)
        {
            Session.currAct = Session.Act.Items;
            LoadGrid();
        }

        private void btnProducers_Click(object sender, EventArgs e)
        {
            Session.currAct = Session.Act.Producers;
            LoadGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SaveState();
            Form _frm = null;
            if (Session.currAct == Session.Act.Items)
            {
                _frm = new Items((int)dataGridView1.CurrentRow.Cells[0].Value);
            }
            if (Session.currAct == Session.Act.Producers)
            {
                _frm = new Producers((int)dataGridView1.CurrentRow.Cells[0].Value);
            }
            if (Session.currAct == Session.Act.Storages)
            {
                _frm = new FStorages((int)dataGridView1.CurrentRow.Cells[0].Value);
            }
            _frm.Owner = this;
            _frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveState();
            Form frm = null;
            if (Session.currAct == Session.Act.Producers)
            {
                frm = new Producers(0);
            }
            if (Session.currAct == Session.Act.Items)
            {
                 frm = new Items(0);
            }
            if (Session.currAct == Session.Act.Storages)
            {
                frm = new FStorages(0);
            }
            frm.Owner = this;
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SaveState();
            var DlgResult =  MessageBox.Show("Delete current element?","SomeText", MessageBoxButtons.YesNo);
            if (DlgResult == DialogResult.Yes)
            {
                IMyTable tbl = null;
                if (Session.currAct == Session.Act.Producers)
                {
                    tbl = new producer();
                }
                if (Session.currAct == Session.Act.Items)
                {
                    tbl = new Item();
                }
                if (Session.currAct == Session.Act.Storages)
                {
                    tbl = new Storage();
                }
                tbl.DeleteFromDB((int)dataGridView1.CurrentRow.Cells[0].Value);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnStorages_Click(object sender, EventArgs e)
        {
            Session.currAct = Session.Act.Storages;
            LoadGrid();
        }
    }
}
