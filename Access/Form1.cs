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
            if (dGW.DataSource != null)
            Session.GridPosition[Session.currAct] = dGW.CurrentRow.Index;
        }

        public void LoadState()
        {
            int index = Session.GridPosition[Session.currAct];
            int indexMax = dGW.RowCount - 1;
            index = index > indexMax ? indexMax : index;
            dGW.CurrentCell = dGW[1,index];
        }

        public void LoadGrid()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            dGW.Columns.Clear();
            dGW.DataSource = Session.GetCurrTable().GetDataTable();
            CGrid.SetDGridView(dGW, Session.currAct.ToString());
            dGW.AutoResizeColumns();
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
                Session.GetCurrTable().DeleteFromDB((int)dGW.CurrentRow.Cells[0].Value);
            }
            LoadGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SaveState();
            Form _frm = Session.ReturnActForm((int)dGW.CurrentRow.Cells[0].Value);
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
