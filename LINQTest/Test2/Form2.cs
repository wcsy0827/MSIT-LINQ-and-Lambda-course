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

namespace Test2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"d:\C#進階");
            IEnumerable<FileInfo> files = di.EnumerateFiles("*.cs", SearchOption.AllDirectories);
            var query = (from file in files
                         where file.Length < 4096
                         let aaa=Readfile(file.FullName)
                         where aaa.Contains("using")
                         orderby file.Length descending
                         select file).Select((file, index) => new
                         {
                             檔案編號=index+1,
                            檔案名稱 = file.FullName,
                            檔案長度 = file.Length,
                            建立日期 = file.CreationTime,
                            最後修改日期 = file.LastWriteTime,

                         });
            dataGridView1.DataSource = query.ToArray();

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string Filename = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            this.textBox1.Text = Readfile(Filename);
        }

        private string Readfile(string fullname)
        {
            return File.ReadAllText(fullname);
        }
    }
}
