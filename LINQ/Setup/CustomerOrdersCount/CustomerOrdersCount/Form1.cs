using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByCount
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
            var query = from c in dc.Customers
                        where c.Orders.Count > 20
                        select c.CompanyName;
            comboBox1.DataSource = query.ToArray();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            dataGridView1.DataSource = dc.Customers.Where(c=>c.CompanyName==comboBox1.Text).SingleOrDefault().Orders.ToList();
        }
    }
}
