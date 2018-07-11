using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            northwindEntities dc = GetEmployees();

            var query = (from emp in dc.Employees
                         select emp.Title).Distinct();
            cboTitle.DataSource = EditTitle.DataSource=query.ToArray();
        }

        private northwindEntities GetEmployees()
        {
            northwindEntities dc = new northwindEntities();
            dataGridView1.DataSource = dc.Employees.ToArray();
            return dc;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            EditFirstName.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            EditLastName.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            EditTitle.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Title = cboTitle.Text;

            northwindEntities dc = new northwindEntities();
            dc.Employees.Add(emp);
            dc.SaveChanges();

            GetEmployees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.CurrentCell.RowIndex;
            int EmployeeID = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[0].Value);

            northwindEntities dc = new northwindEntities();
            Employees emp = dc.Employees.Find(EmployeeID);
            emp.FirstName = EditFirstName.Text;
            emp.LastName = EditLastName.Text;
            emp.Title = EditTitle.Text;

            dc.Entry(emp).State = EntityState.Modified;
            dc.SaveChanges();

            GetEmployees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除嗎?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                northwindEntities dc=new northwindEntities();
                int EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
                Employees emp = dc.Employees.Find(EmployeeID);
                if (emp==null)
                {
                    MessageBox.Show(string.Format("找不到員工編號為{0}的記錄!", EmployeeID));
                }
                else
                {
                    dc.Employees.Remove(emp);
                    dc.SaveChanges();
                    GetEmployees();
                }
                
            }
        }
        
    }
}
