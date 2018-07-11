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
    public partial class frmLinqtoDataSet : Form
    {
        public frmLinqtoDataSet()
        {
            InitializeComponent();
        }

        private IEnumerable<Products> GetProducts(int ProductID)
        {
            var DataSet = from p in northwindDataSet.Products
                          join s in northwindDataSet.Suppliers
                          on p.SupplierID equals s.SupplierID
                          where p.ProductID == ProductID
                          select new Products
                          {
                              ProductID = p.ProductID,
                              SupplierID = p.SupplierID,
                              CompanyName = s.CompanyName
                          };
            return DataSet.ToList();
        }

        private void frmLinqtoDataSet_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Suppliers' 資料表。您可以視需要進行移動或移除。
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetProducts(Convert.ToInt32(txtProductID.Text));
        }
    }
}
