using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace LINQDemo
{
    public partial class frmLinqtoSQL : Form
    {
        public frmLinqtoSQL()
        {
            InitializeComponent();
        }

        int index = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            NorthwindDataContext dc = new NorthwindDataContext();
            var query = from o in dc.Orders.Skip(index).Take(5)
                        select o;
            index += 5;
            dataGridView1.DataSource = query.ToList();
        }
    }
}
