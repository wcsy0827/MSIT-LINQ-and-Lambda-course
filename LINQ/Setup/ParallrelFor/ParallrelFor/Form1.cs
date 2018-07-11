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

namespace ParallrelFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BlockingCollection<string> bc = new BlockingCollection<string>();

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Parallel.For(1, 10001, (i) => 
            {
                int result = i * i;
                bc.Add(string.Format("{0}的平方={1}", i, result));
            });

            string item;
            while(bc.Count!=0)
            {
                bc.TryTake(out item);
                listBox1.Items.Add(item);
            }
        }
    }
}
