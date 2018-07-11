using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Test2
{
    public partial class RSSReader : Form
    {
        public RSSReader()
        {
            InitializeComponent();
        }

        private void RSSReader_Load(object sender, EventArgs e)
        {
            XDocument rssFeed = XDocument.Load("https://tw.appledaily.com/rss/newcreate/kind/rnews/type/107");
            var query = from item in rssFeed.Descendants("item")
                        select new
                        {
                            title = item.Element("title").Value,
                            description = item.Element("description").Value,
                            pubdate = item.Element("pubDate").Value,
                            link = item.Element("link").Value,
                        };
            dataGridView1.DataSource = query.ToList();

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string link = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            this.webBrowser1.Url = new Uri(link);
        }
    }
}
