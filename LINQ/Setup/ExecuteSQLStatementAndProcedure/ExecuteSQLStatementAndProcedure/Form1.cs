using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecuteSQLProcedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            var query = dc.Products.SqlQuery("Select * from Products where UnitPrice > {0}", 0);
            dataGridView1.DataSource = query.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            dc.Database.ExecuteSqlCommand("Update Products Set UnitPrice={0}", 1);
            btnQuery_Click(sender, e);
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            int Count=dc.UpdateProductPrice(1, 500);
            MessageBox.Show(string.Format("{0}筆記錄被更新!", Count));
            btnQuery_Click(sender, e);
        }
    }
}
