using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace frmChartTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Customers' 資料表。您可以視需要進行移動或移除。
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            NorthwindEntities dc = new NorthwindEntities();
            var query = (from c in dc.Customers
                         group c by c.Country into CountryGroup
                         select new
                         {
                             國家 = CountryGroup.Key,
                             人數 = CountryGroup.Count()
                         }).OrderByDescending(group => group.人數);
            this.dataGridView1.DataSource = query.ToArray();

           


        }

        private void chart1_PrePaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
        {
            foreach(DataPoint p in chart1.Series[0].Points)
            {
                p["Exploded"] = "true";
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            string country = Convert.ToString(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var query = dc.Customers.Where(c => c.Country == country);
            this.dataGridView2.DataSource = query.ToArray();
        }
    }
}
