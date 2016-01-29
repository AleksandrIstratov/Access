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
            _frm.Owner = this;
            _frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveState();

            if (Session.currAct == Session.Act.Producers)
            {
                var prod = new Producers(0);
                prod.Owner = this;
                prod.Show();
            }
            if (Session.currAct == Session.Act.Items)
            {
                var _item = new Items(0);
                _item.Owner = this;
                _item.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SaveState();
            var DlgResult =  MessageBox.Show("Delete current element?","SomeText", MessageBoxButtons.YesNo);
            if (DlgResult == DialogResult.Yes)
            {
                if (Session.currAct == Session.Act.Producers)
                {
                    producer prd = new producer();
                    prd.DeleteFromDB((int)dataGridView1.CurrentRow.Cells[0].Value);
                }
                if (Session.currAct == Session.Act.Items)
                {
                    Item itm = new Item();
                    itm.DeleteFromDB((int)dataGridView1.CurrentRow.Cells[0].Value);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }


    }
}
