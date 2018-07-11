using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListImage_LINQ_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Screen");
            IEnumerable<FileInfo> files = dir.EnumerateFiles("*.*");
            var query = from f in files
                        select new
                        {
                            檔案名稱 = f.FullName,
                            檔案大小 = f.Length,
                            建立時間 = f.CreationTime,
                            最後修改時間 = f.LastWriteTime
                        };
            dataGridView1.DataSource = query.ToArray();
            Form1_Resize(sender, e);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int ColumnCount = dataGridView1.Columns.Count;
            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = dataGridView1.Width / ColumnCount;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            propertyGrid1.SelectedObject = pictureBox1.Image;
        }

    }
}
