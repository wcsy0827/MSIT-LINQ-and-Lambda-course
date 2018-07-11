using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace LINQCreateXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NorthwindDataContext dc = new NorthwindDataContext();
            XDocument doc =
                new XDocument(
                new XElement("Customers",
                from c in dc.Customers
                select
                new XElement("Customer",
                   new XAttribute("id", c.CustomerID),
                   new XAttribute("country", c.Country),
                   new XAttribute("contactName", c.ContactName),
                   new XAttribute("contactTitle", c.ContactTitle),
                   from o in c.Orders
                   select new XElement("Orders",
                       new XAttribute("id", o.OrderID),
                       new XAttribute("date", o.OrderDate),
                            new XElement("items",
                       from od in o.Order_Details
                       select new XElement("item",
                               new XAttribute("price", od.UnitPrice),
                               new XAttribute("quantity", od.Quantity)))))));

            doc.Save("Customers.xml");
            webBrowser1.Url = new Uri(Path.Combine(Application.StartupPath, "Customers.xml"), UriKind.Absolute);
        }
    }
}
