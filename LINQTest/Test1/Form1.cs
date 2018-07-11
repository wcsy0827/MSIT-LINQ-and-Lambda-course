using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate double AreaDelegate(double radious);
        double Area(double r,AreaDelegate ad)
        {
            return ad(r);
        }
        private void btnArea_Click(object sender, EventArgs e)
        {
            AreaDelegate WoodArea = r => (r + 1) * (r + 1) * Math.PI;
            AreaDelegate GoldArea = r => (r + 0.05) * (r + 0.05) * Math.PI;

            Console.WriteLine(Area(5,WoodArea));
            Console.WriteLine(Area(5,GoldArea));
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            int[] arr1 = { 3, 9, 50, 648, 1543, 88, 96, 380 };
            this.listBox1.DataSource = arr1.Where(s => s < 100).ToArray();

            
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string Filename = "pic_054.png";
            WebClient obj = new WebClient();
            obj.DownloadFileCompleted += (dseder, de) =>
            {
                MessageBox.Show("檔案下載完成");
                string DownloadFilenam = Path.Combine(Application.StartupPath, Filename);
                Process.Start(DownloadFilenam);

            };
            obj.DownloadFileAsync(new Uri(Path.Combine("http://localhost/", Filename)),Filename);

        }

        BlockingCollection<string> bc = new BlockingCollection<string>();
        private void btnInvoke_Click(object sender, EventArgs e)
        {
            Parallel.Invoke(() => ReturnOdd(), () => ReturnEver());
            this.listBox1.DataSource = bc.ToArray();
        }

        private string ReturnEver()
        {
           for(int i=1;i<=10000;i++)
            {
                if(i%2==0)
                {
                    bc.Add($"{i}是偶數");
                }                
            }
            return "ReturnOdd Done!";
        }

        private object ReturnOdd()
        {
            for (int i = 1; i <= 10000; i++)
            {
                if (i % 2 ==1)
                {
                    bc.Add($"{i}是奇數");
                }
            }
            return "ReturnEven Done!";
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            Parallel.For(1, 50, i =>
            {
                var result = i * i;
                bc.Add($"{i}的平方={result}");


            });
            this.listBox1.DataSource = bc.ToArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            customersBindingSource.DataSource = dc.Customers.ToArray();



        }

        private void customersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if(this.customersBindingSource.Current!=null)
            {
               this.ordersDataGridView.DataSource=((Customers)this.customersBindingSource.Current).Orders.ToArray();

            }
        }
    }
}
