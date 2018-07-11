using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LINQDemo;
using LINQDemo.Models;

namespace LINQDemo
{
    public partial class frmLinqtoEntity : Form
    {
        public frmLinqtoEntity()
        {
            InitializeComponent();
        }

        private void frmLinqtoEntity_Load(object sender, EventArgs e)
        {
            NorthwindEntities ne = new NorthwindEntities();
            var query = from c in ne.Customers
                        select c.CustomerID;
            //foreach (Customers c in query)
            //{
            //    comboBox1.Items.Add(c.CustomerID);
            //}
            comboBox1.DataSource = query.ToList();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NorthwindEntities ne = new NorthwindEntities();
            var query = (from c in ne.Customers
                        where c.CustomerID==comboBox1.Text
                        select c).FirstOrDefault();
            dataGridView1.DataSource = query.Orders;
        }
    }
}
