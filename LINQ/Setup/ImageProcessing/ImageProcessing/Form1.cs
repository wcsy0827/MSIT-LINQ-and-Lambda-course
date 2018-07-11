using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnGreyScale_Click(object sender, EventArgs e)
        {
            GreyScaleForm f = new GreyScaleForm();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnBlend_Click(object sender, EventArgs e)
        {            
            BlendForm f = new BlendForm();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
