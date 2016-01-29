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
    public partial class Items : Form
    {

        private Item _item = new Item();
        private FileContent _fc { get; set; }
        private string URL { get; set; }

        public Items(int _id)
        {
            InitializeComponent();
            if (_id>0) _item.LoadFromDB(_id);
            tbItemName.Text = _item.ItemName;
            tbOrderPrefix.Text = _item.OrderPrefix;
            chbMachineBit.Checked = _item.MachineBit;

            AccessDB aDB = new AccessDB();
            cbProducer.DataSource = aDB.getTable(Session.DTables[Session.Act.Producers]);
            cbProducer.DisplayMember = "ProducerName";
            cbProducer.ValueMember = "IdProducer";
            cbProducer.SelectedValue = _item.ProducerId;

            _fc = new FileContent();
            _fc.MakePath(_item);
            Renew();
        }

        public void Renew()
        {
            listNavigator1.ListSource = _fc.GetImg();
            listNavigator1.Commit();
            tsmImgDelete.Enabled = !_fc.IsEmpty;
            picBItem.ImageLocation = _fc.GetImg()[0];
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
            _item.ItemName = tbItemName.Text;
            _item.OrderPrefix = tbOrderPrefix.Text;
            _item.MachineBit = chbMachineBit.Checked;
            _item.ProducerId = (int)cbProducer.SelectedValue;
            _item.SaveToDB();
            _fc.CreateFolder(Session.__dirPhoto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_fc.SaveFromURL();
            //fc.OpenFile();

        }

        private void listNavigator1_StatusUpdated(object sender, EventArgs e)
        {
            //MessageBox.Show(String.Format("{0}", listNavigator1.CurrentIndex));
            picBItem.ImageLocation = _fc.GetImg()[listNavigator1.CurrentIndex];
        }

        private void fromDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fc.AddFile();
            Renew();
        }

        private void ShowMyDialogBox()
        {
            Dialog testDialog = new Dialog();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.URL = testDialog.tbURL.Text;
            }
            else
            {
                this.URL = "";
            }
            testDialog.Dispose();
        }

        private void ffromURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
            if (this.URL.Length > 0)
            {
                _fc.SaveFromURL(this.URL);
            }
            Renew();
        }

        private void tsmImgDelete_Click(object sender, EventArgs e)
        {
            DialogResult Reslt = MessageBox.Show("Delete", "Delete file?", MessageBoxButtons.OKCancel);
            if (Reslt == DialogResult.OK)
            {
                _fc.DeleteImg(_fc.GetImg()[listNavigator1.CurrentIndex]);
                Renew();
            }
            
        }
    }
}
