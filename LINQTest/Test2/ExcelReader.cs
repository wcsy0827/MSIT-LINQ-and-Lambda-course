using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class ExcelReader : Form
    {
        public ExcelReader()
        {
            InitializeComponent();
        }

        private void ExcelReader_Load(object sender, EventArgs e)
        {
            ExcelQueryFactory doc = new ExcelQueryFactory(@"d:\LINQTest\含除權息及現金股利率20170113.xlsx");
            var query = from c in doc.Worksheet("除權息表")
                        select new
                        {
                            公司 = c["公司"],
                            股東會日期 = c["股東會日期"],
                            現金股利 = c["現金股利(元)"],
                            除息日=c["除息日"]

                        };
            dataGridView1.DataSource = query.ToArray();
        }
    }
}
