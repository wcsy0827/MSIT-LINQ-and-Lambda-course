using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQTest2
{
    public partial class Test2 : Form
    {
        public Test2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            var query = from c in dc.Customers
                        select c.CustomerID;
            this.cbCustomers.DataSource = query.ToList();
            this.cbCustomers.SelectedIndex = 0;
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            var query = (from c in dc.Customers
                         where c.CustomerID == this.cbCustomers.Text
                         select c).SingleOrDefault();
            this.dataGridView1.DataSource = query.Orders.ToList();
        }
    }
}
