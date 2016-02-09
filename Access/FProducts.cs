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
    public partial class FProducts : Form
    {
        private Product _product = new Product();
        public FProducts(int _id)
        {
            InitializeComponent();
            //if (_id > 0) this.hdwr.LoadFromDB(_id);
            //tbName.Text = this.hdwr.Name;
            //cbHardware.DataSource = this.hdwr.GetHardwareTable();
            //cbHardware.DisplayMember = "DisplayMember";
            //cbHardware.ValueMember = "ValueMember";
            //cbHardware.SelectedValue = this.hdwr.ParentHardware ?? 0;
            //cbItem.DataSource = this.hdwr.GetItemsTable();
            //cbItem.DisplayMember = "DisplayMember";
            //cbItem.ValueMember = "ValueMember";
            //cbItem.SelectedValue = this.hdwr.ItemId ?? 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.LoadGrid();
            }
            Close();
        }
    }
}
