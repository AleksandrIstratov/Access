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
    public partial class FStorages : Form
    {
        private Storage Storage = new Storage();
        public FStorages(int id)
        {
            InitializeComponent();
            if (id > 0) this.Storage.LoadFromDB(id);
            tbName.Text = this.Storage.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Storage.Name = tbName.Text;
            this.Storage.SaveToDB();
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
