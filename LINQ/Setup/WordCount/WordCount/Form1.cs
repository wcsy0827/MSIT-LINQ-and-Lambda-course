using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            int i = txtString.Text.WordCount();
            MessageBox.Show(i.ToString());
        }
    }
}
