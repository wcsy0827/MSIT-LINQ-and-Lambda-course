using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BlockingCollection<string> bc = new BlockingCollection<string>();

        string ReturnOdd()
        {
            for(int i=1;i<=1000;i++)
            {
                if (i%2!=0)
                {
                    bc.Add(string.Format("{0}是奇數", i));
                }
            }
            return "OK!";
        }

        string ReturnEven()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    bc.Add(string.Format("{0}是偶數", i));
                }
            }
            return "OK!";
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            Parallel.Invoke(() => ReturnOdd(), () => ReturnEven());
            string item;
            while (bc.Count != 0)
            {
                bc.TryTake(out item);
                listBox1.Items.Add(item);
            }
        }
        
    }
}
