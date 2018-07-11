using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQDemo
{
    public partial class frmLinqtoExcel : Form
    {
        public frmLinqtoExcel()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            ExcelQueryFactory Doc = new ExcelQueryFactory("MSIT109.xlsx");

            var query = from c in Doc.Worksheet("數學")
                        select new
                        {
                            姓名 = c["姓名"],
                            成績 = c["成績"],
                        };
            dataGridView1.DataSource = query.ToArray();
        }
    }
}
