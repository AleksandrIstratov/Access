using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ListNavigator : UserControl
    {
        public List<string> ListSource;
        public event EventHandler StatusUpdated;
        public int CurrentIndex = 0;

        public ListNavigator()
        {
            InitializeComponent();    
        }

        public void Commit()
        {
            CurrentIndex = 0;
            changeBtns(false, (CurrentIndex < (ListSource.Count - 1)));
        }

        private void changeBtns(bool fst, bool snd)
        {
            btnFirst.Enabled = fst;
            btnPrev.Enabled = fst;
            btnNext.Enabled = snd;
            btnLast.Enabled = snd;
        }

        private void StatusUpdatedFunc(object sender, EventArgs e)
        {
            changeBtns((CurrentIndex > 0), (CurrentIndex < (ListSource.Count - 1)));
            if (this.StatusUpdated != null)
                this.StatusUpdated(this, e);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex = 0;
                StatusUpdatedFunc(this, e);
            }            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int length = ListSource.Count - 1;
            if (CurrentIndex < length)
            {
                CurrentIndex = length;
                StatusUpdatedFunc(this, e);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex--;
                StatusUpdatedFunc(this, e);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int length = ListSource.Count - 1;
            if (CurrentIndex < length)
            {
                CurrentIndex++;
                StatusUpdatedFunc(this, e);
            }
        }
    }
}
