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
        private CProduct _product = new CProduct();
        public FProducts(int _id)
        {
            InitializeComponent();
            if (_id > 0) this._product.LoadFromDB(_id);
            tbName.Text = this._product.Name;
            cbItemName.DataSource = this._product.GetItemsTable();
            cbItemName.DisplayMember = "DisplayMember";
            cbItemName.ValueMember = "ValueMember";
            cbItemName.SelectedValue = this._product.ItemId ?? 0;
            tbSerialNumber.Text = this._product.SerialNumber;
            tbInventoryNumber.Text = this._product.InventoryNumber;
            if (this._product.ProductionDate == null)
            {
                dtProductionDate.Checked = false;
            }
            else
            {
                dtProductionDate.Value = (DateTime)this._product.ProductionDate;
            }
            if (this._product.PurchaseDate == null)
            {
                dtPurchaseDate.Checked = false;
            }
            else
            {
                dtPurchaseDate.Value = (DateTime)this._product.PurchaseDate;
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._product.Name = tbName.Text;
            this._product.ItemId = (int?)cbItemName.SelectedValue;
            this._product.SerialNumber = tbSerialNumber.Text;
            this._product.InventoryNumber = tbInventoryNumber.Text;
            this._product.ProductionDate = dtProductionDate.Checked == true ? (DateTime?)dtProductionDate.Value : null;
            this._product.PurchaseDate = dtPurchaseDate.Checked == true ? (DateTime?)dtPurchaseDate.Value : null;
            this._product.SaveToDB();
        }
    }
}
