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

        private Item _item { get; set; }
        private FileContent _fc { get; set; }
        public Items(Item _itm)
        {
            InitializeComponent();
            _item = _itm;
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

            _fc.SaveFromURL();
            //fc.OpenFile();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
