using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereNot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnWhereNot_Click(object sender, EventArgs e)
        {
            northwindEntities dc = new northwindEntities();

            var query = from c in dc.Customers
                        where !(from o in dc.Orders
                                select o.CustomerID).Distinct().Contains(c.CustomerID)
                        select c;
            dataGridView1.DataSource = query.ToList();
        }

        private void btnNavProp_Click(object sender, EventArgs e)
        {
            northwindEntities dc = new northwindEntities();
            var query = from c in dc.Customers
                        where c.Orders.Count == 0
                        select c;
            dataGridView2.DataSource = query.ToList();
        }                       
    }
}
