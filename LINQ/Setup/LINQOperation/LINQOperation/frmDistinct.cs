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
    public partial class frmDistinct : Form
    {
        public frmDistinct()
        {
            InitializeComponent();
        }

        private void frmDistinct_Load(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            var query = (from c in dc.Customers
                         select c.Country).Distinct();
            comboBox1.DataSource = query.ToList();
        }
    }
}
