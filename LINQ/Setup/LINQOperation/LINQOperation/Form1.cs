using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDistinct_Click(object sender, EventArgs e)
        {
            frmDistinct f = new frmDistinct();
            f.ShowDialog();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            frmSum f = new frmSum();
            f.ShowDialog();
        }

        private void btnMinMaxAverage_Click(object sender, EventArgs e)
        {
            frmMinMaxAverage f= new frmMinMaxAverage();
            f.ShowDialog();
        }

        private void btnGroupByCount_Click(object sender, EventArgs e)
        {
            frmGroupBy f = new frmGroupBy();
            f.ShowDialog();
        }
    }
}
