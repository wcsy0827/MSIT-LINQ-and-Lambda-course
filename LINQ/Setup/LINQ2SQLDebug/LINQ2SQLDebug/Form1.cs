using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;

namespace LINQ2SQLDebug
{
    public partial class Form1 : Form
    {
        NorthwindDataContext dc=null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dc = new NorthwindDataContext();
            dc.Log = new DebugTextWriter();            
#if DEBUG
            dc.Log = new System.IO.StreamWriter("linq-to-sql.log") { AutoFlush = true };
#endif
        }

        int index = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {            
            var query = from od in dc.Order_Details.Skip(index).Take(10)
                        select od;
            MessageBox.Show(dc.GetCommand(query).CommandText);
            index += 10;
            dataGridView1.DataSource = query.ToList();
        }

        private void btnDisplayChangeSet_Click(object sender, EventArgs e)
        {
            Order_Details odUpdate= (from od in dc.Order_Details where od.OrderID == 10248 select od).First();
            odUpdate.UnitPrice = 100;

            ChangeSet cs = dc.GetChangeSet();
            foreach (var obj in cs.Updates)
            {
                if (obj is Order_Details)
                {
                    Order_Details od = obj as Order_Details;
                    MessageBox.Show(od.UnitPrice.ToString());
                }
            }
            dc.SubmitChanges();
        }

        

    }
}
