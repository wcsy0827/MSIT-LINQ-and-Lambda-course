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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            string[] content=File.ReadAllLines("Test.txt");

            //var group = from s in content
            //            group s by s[0] into g
            //            select new
            //            {
            //                result = g.ToList()
            //            };

            var group = from s in content
                        group s by s[0];

            List<string> result = new List<string>();
            foreach (var g in group)
            {
                foreach(var item in g)
                {
                    result.Add(item.Substring(1));
                }                
            }            
            listBox1.DataSource = result;
        }
    }
}
