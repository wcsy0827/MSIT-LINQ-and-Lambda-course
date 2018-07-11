using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            customersBindingSource.DataSource = dc.Customers.ToArray();
        }

        private void customersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //if (customersBindingSource.Current != null)
            //{
                ordersDataGridView.DataSource =
                    ((Customers)customersBindingSource.Current).Orders.ToArray();
            //}
        }
    }
}
