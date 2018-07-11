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

namespace CustomerGroup
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
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Customers' 資料表。您可以視需要進行移動或移除。
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            //select Country, Count(*) from Customers group by Country
            northwindEntities dc = new northwindEntities();
            //var query = (from c in dc.Customers
            //             group c by c.Country into CountryGroup
            //             select new
            //             {
            //                 國家 = CountryGroup.Key,
            //                 人數 = CountryGroup.Count()
            //             }).OrderByDescending(group => group.人數);
            var query = dc.Customers.GroupBy(c => c.Country).Select(CountryGroup => new
            {
                國家 = CountryGroup.Key,
                人數 = CountryGroup.Count()
            }).OrderByDescending(g => g.人數);
            dgvGroup.DataSource = query.ToList();
        }

        private void dgvGroup_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            northwindEntities dc = new northwindEntities();
            string Country = Convert.ToString(dgvGroup.Rows[e.RowIndex].Cells[0].Value);
            var query = from c in dc.Customers
                         where c.Country == Country
                         select c;
            dgvDetails.DataSource = query.ToList();
        }

        private void chart1_PrePaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
        {
            foreach (DataPoint p in chart1.Series[0].Points)
            {
                p["Exploded"] = "True";
            }
        }
    }
}
