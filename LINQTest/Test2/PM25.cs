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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class PM25 : Form
    {
        public PM25()
        {
            InitializeComponent();
        }

        private async void PM25_Load(object sender, EventArgs e)
        {
            WebClient obj = new WebClient();
            await obj.DownloadFileTaskAsync("http://opendata.epa.gov.tw/ws/Data/ATM00625/?$format=json", "PM25.json");
            string json = File.ReadAllText("PM25.json");
            JArray arr = JArray.Parse(json);
            var query = from site in arr.Children()
                        select new
                        {
                            city = site["site"],
                            Country = site["county"],
                            PM25 = site["PM25"],
                            Time = site["DataCreationDate"]
                        };
            this.dataGridView1.DataSource = query.ToArray();
            
        }
    }
}
