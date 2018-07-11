using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace LINQPerformance
{
    public partial class frmPLINQ : Form
    {
        public frmPLINQ()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            DirectoryInfo di = new DirectoryInfo(@"C:\temp");
            //FileInfo[] Files = di.GetFiles("*.*", SearchOption.AllDirectories);
            IEnumerable<FileInfo> Files = di.EnumerateFiles("*.*", SearchOption.AllDirectories);
            var query = from file in Files.AsParallel()
                        where file.Length > 1024
                        orderby file.Length ascending
                        select file;
            dataGridView1.DataSource = query.ToList();
            sw.Stop();
            Text = sw.ElapsedMilliseconds.ToString();
        }
    }
}
