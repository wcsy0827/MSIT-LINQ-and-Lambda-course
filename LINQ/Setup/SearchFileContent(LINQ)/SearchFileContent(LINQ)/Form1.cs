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

namespace SearchFileContent_LINQ_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(txtFolder.Text);

            IEnumerable<FileInfo> files = dir.EnumerateFiles("*.*", SearchOption.AllDirectories);
            var query = (from file in files
                        where file.Length > 0 && file.Name.StartsWith("F")
                        let FileContent = ReadFile(file.FullName)
                        where FileContent.Contains("using")
                        select file).Select((f, index)=>new {
                            編號 = index + 1,
                            檔案名稱 = f.FullName,
                            檔案大小 = f.Length,
                            建立時間 = f.CreationTime,
                            最後修改時間 = f.LastAccessTime,
                        });

            dataGridView1.DataSource = query.ToArray();
            Form1_Resize(sender, e);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int ColumnCount = dataGridView1.Columns.Count;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = dataGridView1.Width / ColumnCount;
            }
        }

        private string ReadFile(string filename)
        {
            return File.ReadAllText(filename);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string Fullname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);            
            textBox1.Text = ReadFile(Fullname);
        }

    }
}
