using LinqToWikipedia;
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
    public partial class frmLinqtoWiki : Form
    {
        public frmLinqtoWiki()
        {
            InitializeComponent();
        }

        private void btnOpenSearch_Click(object sender, EventArgs e)
        {
            WikipediaContext datacontext = new WikipediaContext();

            var query = (
                from wikipedia in datacontext.OpenSearch
                where wikipedia.Keyword == "HTC"
                select wikipedia).Take(10);

            dataGridView1.DataSource = query.ToArray();
        }

        private void btnKeywordSearch_Click(object sender, EventArgs e)
        {
            WikipediaContext datacontext = new WikipediaContext();

            var query = (
                from wikipedia in datacontext.KeywordSearch
                where
                    wikipedia.Keyword == "HTC" &&
                    wikipedia.Keyword == "A9" 
                select wikipedia).Skip(3).Take(25);
            dataGridView1.DataSource = query.ToArray();
        }        
    }
}
