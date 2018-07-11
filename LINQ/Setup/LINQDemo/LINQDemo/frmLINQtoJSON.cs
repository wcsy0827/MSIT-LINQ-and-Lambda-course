using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace LINQDemo
{
    public partial class frmLINQtoJSON : Form
    {
        public frmLINQtoJSON()
        {
            InitializeComponent();
        }

        private async void btnQuery_Click(object sender, EventArgs e)
        {
            WebClient obj = new WebClient();
            await obj.DownloadFileTaskAsync("http://opendata.epa.gov.tw/ws/Data/ATM00625/?$format=json", "PM25.json");
            string json = File.ReadAllText("PM25.json");
            JArray arr = JArray.Parse(json);

            var query = from site in arr.Children()
                        select new
                        {
                            城巿 = site["Site"],
                            PM25強度 = site["PM25"],
                            量測時間 = site["DataCreationDate"],
                        };
            dataGridView1.DataSource = query.ToArray();
            frmLINQtoJSON_Resize(sender, e);
        }

        private void frmLINQtoJSON_Resize(object sender, EventArgs e)
        {
            int ColumnCount = dataGridView1.Columns.Count;
            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = dataGridView1.Width / ColumnCount;
            }
        }
    }
}
