using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSummary
{
    public partial class FrmOrderSummary : Form
    {
        public FrmOrderSummary()
        {
            InitializeComponent();
        }

        private void FrmOrderSummary_Load(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
            sc.AddRange(dc.Customers.Select(c => c.CompanyName).ToArray());
            this.txtCustomer.AutoCompleteCustomSource = sc;
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        { }
            

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            var query = dc.Customers.Where(c => c.CompanyName == this.txtCustomer.Text).Single().Orders.Select(o => o.OrderID);
            if(query.Count()==0)
            {
                MessageBox.Show("此客戶尚未有訂單!");
                this.comboBox1 .DataSource= null;
            }
            this.comboBox1.DataSource = query.ToArray();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            var query = dc.Order_Details.Select(od => od).ToList().Where(od => od.OrderID == int.Parse(this.comboBox1.Text));

            //LINQ to Entiry要先轉集合才會能做int的敘述，沒有先ToList()，會出現錯誤

            this.dataGridView1.DataSource = query.Select(od => new
            {
                訂單編號 = od.OrderID,
                商品編號 = od.ProductID,
                商品單價 = od.UnitPrice,
                商品數量 = od.Quantity,
                折扣 = od.Discount,
                小計 = (od.UnitPrice * od.Quantity * (1 - (decimal)od.Discount)),
            }).ToArray();

            


            decimal total = query.Sum(od => od.Quantity * od.UnitPrice * (1 - (decimal)od.Discount));




            this.lbTotal.Text = $"總計:{total.ToString("C")}";



        }
    }
}
