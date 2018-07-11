using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects.DataClasses;

namespace LINQOperation
{
    public partial class frmSum : Form
    {
        NorthwindEntities ne = null;

        public frmSum()
        {
            InitializeComponent();
        }

        private void frmSum_Load(object sender, EventArgs e)
        {
            ne = new NorthwindEntities();
            ordersBindingSource.DataSource = ne.Orders;      
        }

        private void ordersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            EntityCollection<Order_Details> OrderDetailsList=((Orders)ordersBindingSource.Current).Order_Details;
            decimal Subtotal = OrderDetailsList.Sum(o => (decimal)o.UnitPrice * (decimal)o.Quantity * (1 - (decimal)o.Discount));
            lbSum.Text = Subtotal.ToString("C");
        }
    }
}
