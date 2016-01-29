﻿using System;
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
    public partial class Producers : Form
    {
        private producer prd = new producer();

        public Producers(int _id)
        {
            InitializeComponent();
            if (_id>0) this.prd.LoadFromDB(_id);
            tbName.Text = prd.ProducerName;
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
            this.prd.ProducerName = tbName.Text;
            this.prd.SaveToDB();
        }
    }
}
