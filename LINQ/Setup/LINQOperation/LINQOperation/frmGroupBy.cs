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
    public partial class frmGroupBy : Form
    {
        public frmGroupBy()
        {
            InitializeComponent();
        }

        private void frmGroupBy_Load(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            var query = from c in dc.Customers                        
                        group c by c.Country into CountryGroup
                        orderby CountryGroup.Count() descending
                        select new 
                        {
                            Country=CountryGroup.Key,
                            Count=CountryGroup.Count()
                        };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
