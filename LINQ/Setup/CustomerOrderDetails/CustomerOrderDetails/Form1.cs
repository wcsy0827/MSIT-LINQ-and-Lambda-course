using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerOrderDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            northwindEntities dc = new northwindEntities();
            AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
            foreach(Customers c in dc.Customers)
            {
                sc.Add(c.CompanyName);
            }
            txtCustomer.AutoCompleteCustomSource = sc;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            northwindEntities dc = new northwindEntities();
            var query = (from c in dc.Customers
                         where c.CompanyName == txtCustomer.Text
                         select c).Single().Orders.Select(o=>o.OrderID);
            if (query.Count() == 0)
            {
                MessageBox.Show("客戶尚未有訂購記錄!");
                dataGridView1.DataSource = null;
            }
            cboOrders.DataSource = query.ToArray();
        }

        private void cboOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            northwindEntities dc = new northwindEntities();
            var query = (from od in dc.Order_Details
                        select od).ToList().Where(od=>od.OrderID==int.Parse(cboOrders.Text));
            //===============
            decimal subtotal=query.Sum(od => od.UnitPrice * od.Quantity * (1 - (decimal)od.Discount));
            lbSubtotal.Text = string.Format("小計:{0}", subtotal.ToString("C"));
            //===============

            dataGridView1.DataSource = query.Select(od => new 
            { 
                訂單編號=od.OrderID,
                //商品編號=od.ProductID,
                商品單價=od.UnitPrice,
                訂購數量=od.Quantity,
                優惠折扣=od.Discount,
                小計 = (od.UnitPrice * od.Quantity * (1 - (decimal)od.Discount)).ToString("C"),
            }).ToArray();
            //dataGridView1.Columns[5].Visible = false;
        }
    }
}
