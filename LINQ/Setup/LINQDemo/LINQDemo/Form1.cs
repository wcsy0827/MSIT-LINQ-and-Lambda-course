using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLINQtoObject_Click(object sender, EventArgs e)
        {
            frmLinqtoObject f = new frmLinqtoObject();
            f.ShowDialog();
        }

        private void btnLinqtoXML_Click(object sender, EventArgs e)
        {
            frmLinqtoXML f = new frmLinqtoXML();
            f.ShowDialog();
        }

        private void btnLINQtoDataSet_Click(object sender, EventArgs e)
        {
            frmLinqtoDataSet f = new frmLinqtoDataSet();
            f.ShowDialog();
        }

        private void btnLinqtoSQL_Click(object sender, EventArgs e)
        {
            frmLinqtoSQL f = new frmLinqtoSQL();
            f.ShowDialog();
        }

        private void btnLinqtoEntity_Click(object sender, EventArgs e)
        {
            frmLinqtoEntity f = new frmLinqtoEntity();
            f.ShowDialog();
        }

        private void btnLINQtoJSON_Click(object sender, EventArgs e)
        {
            frmLINQtoJSON f = new frmLINQtoJSON();
            f.ShowDialog();
        }

        private void btnLinqtoExcel_Click(object sender, EventArgs e)
        {
            frmLinqtoExcel f = new frmLinqtoExcel();
            f.ShowDialog();
        }

        private void btnLinqToWiki_Click(object sender, EventArgs e)
        {
            frmLinqtoWiki f = new frmLinqtoWiki();
            f.ShowDialog();
        }
    }
}
