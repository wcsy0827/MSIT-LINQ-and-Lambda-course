using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LINQDemo
{
    public partial class frmLinqtoXML : Form
    {
        DataTable dt = new DataTable();

        public frmLinqtoXML()
        {
            InitializeComponent();
        }

        private void frmLinqtoXML_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new ComboBoxItem("政治新聞", "http://tw.news.yahoo.com/rss/politics"));
            comboBox1.Items.Add(new ComboBoxItem("社會新聞", "http://tw.news.yahoo.com/rss/society"));
            comboBox1.Items.Add(new ComboBoxItem("地方新聞", "http://tw.news.yahoo.com/rss/taiwan"));
            comboBox1.Items.Add(new ComboBoxItem("國際新聞", "http://tw.news.yahoo.com/rss/intl"));
            comboBox1.Items.Add(new ComboBoxItem("財經新聞", "http://tw.news.yahoo.com/rss/biz"));
            comboBox1.Items.Add(new ComboBoxItem("科技新聞", "http://tw.news.yahoo.com/rss/tech"));
            comboBox1.Items.Add(new ComboBoxItem("運動新聞", "http://tw.news.yahoo.com/rss/sports"));
            comboBox1.Items.Add(new ComboBoxItem("健康新聞", "http://tw.news.yahoo.com/rss/health"));
            comboBox1.Items.Add(new ComboBoxItem("教育新聞", "http://tw.news.yahoo.com/rss/edu"));
            comboBox1.Items.Add(new ComboBoxItem("藝文新聞", "http://tw.news.yahoo.com/rss/art"));
            comboBox1.Items.Add(new ComboBoxItem("影劇新聞", "http://tw.news.yahoo.com/rss/showbiz"));
            comboBox1.Items.Add(new ComboBoxItem("旅遊新聞", "http://tw.news.yahoo.com/rss/travel"));
            comboBox1.Items.Add(new ComboBoxItem("生活新聞", "http://tw.news.yahoo.com/rss/life"));

            comboBox1.SelectedIndex = 0;
        }

        private void frmLinqtoXML_Resize(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Width = dataGridView1.Width * 2 / 3;
                dataGridView1.Columns[1].Width = dataGridView1.Width / 3;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            XDocument rssFeed = XDocument.Load(((ComboBoxItem)comboBox1.SelectedItem).Uri);
            var NewsItem = from item in rssFeed.Descendants("item")
                           //where item.Element("title").Value.Contains("公投")
                           select new
                           {
                               title = item.Element("title").Value,
                               link = item.Element("link").Value,
                               pubDate = item.Element("pubDate").Value
                           };

            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("新聞標題", typeof(String));
                dt.Columns.Add("連結網址", typeof(String));
                dt.Columns.Add("發佈時間", typeof(String));
            }
            else
            {
                dt.Rows.Clear();
            }

            foreach (var News in NewsItem)
            {
                DataRow dr = dt.NewRow();
                dr["新聞標題"] = News.title;
                dr["連結網址"] = News.link;
                dr["發佈時間"] = DateTime.Parse(News.pubDate).ToString("g");
                dt.Rows.Add(dr);
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;

            DataGridViewLinkColumn TitleColumn = new DataGridViewLinkColumn();
            TitleColumn.DataPropertyName = "新聞標題";
            TitleColumn.HeaderText = "新聞標題";
            TitleColumn.Width = dataGridView1.Width * 2 / 3;
            dataGridView1.Columns.Add(TitleColumn);

            DataGridViewTextBoxColumn DateColumn = new DataGridViewTextBoxColumn();
            DateColumn.DataPropertyName = "發佈時間";
            DateColumn.HeaderText = "發佈時間";
            DateColumn.Width = dataGridView1.Width / 3;
            dataGridView1.Columns.Add(DateColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    webBrowser1.Url = new Uri(dt.Rows[e.RowIndex]["連結網址"].ToString());
                    break;
            }
        }
    }
}
