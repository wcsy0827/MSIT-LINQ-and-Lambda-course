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
    public partial class frmMinMaxAverage : Form
    {
        public frmMinMaxAverage()
        {
            InitializeComponent();
        }

        private void frmMinMax_Load(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            var query = from p in dc.Products
                        select p;
            dataGridView1.DataSource = query.ToList();

            var qryMinMax = from p in dc.Products
                         select p.UnitsInStock;
            lbMin.Text = qryMinMax.Min().ToString();
            lbMax.Text = qryMinMax.Max().ToString();

            var qryAverage = from p in dc.Products
                            select p.UnitPrice;
            lbAverage.Text = qryAverage.Average().ToString();
        }
    }
}
