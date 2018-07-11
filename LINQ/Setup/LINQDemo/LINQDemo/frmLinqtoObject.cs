using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LINQDemo
{
    public partial class frmLinqtoObject : Form
    {
        public frmLinqtoObject()
        {
            InitializeComponent();
        }

        private void btnQueryFileLength_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\temp");
            //FileInfo[] Files = di.GetFiles("*.*", SearchOption.AllDirectories);
            IEnumerable<FileInfo> Files = di.EnumerateFiles("*.*", SearchOption.AllDirectories);
            var query = (from file in Files
                        where file.Length>10240
                        orderby file.Length ascending
                        select file).Select((file, index) => new 
                             {
                                 ID = index+1,
                                 檔案名稱 = file.Name,
                                 檔案大小 = file.Length,
                                 建立日期 = file.CreationTime,
                                 最後修改時間 = file.LastWriteTime
                             });
            dataGridView1.DataSource = query.ToList();
        }

        private void btnQueryFileContent_Click(object sender, EventArgs e)
        {
            string startFolder = @"C:\Program Files\Microsoft Visual Studio 10.0";
            IEnumerable<string> fileList = Directory.EnumerateFiles(startFolder, "*.*", SearchOption.AllDirectories);

            System.Text.RegularExpressions.Regex searchTerm =
                new System.Text.RegularExpressions.Regex(@"Visual (Basic|C#|C\+\+|SourceSafe|Studio)");

            var queryMatchingFiles =
                from file in fileList
                where Path.GetExtension(file).ToLower().Equals(".htm")
                let fileText = System.IO.File.ReadAllText(file)
                let matches = searchTerm.Matches(fileText)
                where searchTerm.Matches(fileText).Count > 0
                select new
                {
                    name = file,
                    matches = (from System.Text.RegularExpressions.Match match in matches
                              select match.Value).First()
                };
            dataGridView1.DataSource = queryMatchingFiles.ToList();
        }
    }
}
