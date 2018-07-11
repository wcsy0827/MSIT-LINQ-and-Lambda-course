using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LambdaDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate double AreaDelegate(double radius);

        private void btnCircle_Click(object sender, EventArgs e)
        {
            AreaDelegate circleArea = r => r * r * 3.14;
            MessageBox.Show(string.Format("圓形面積為:{0}", circleArea(5)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnClickMe.Click += (s, e) =>
            { 
                MessageBox.Show("Click Me!!"); 
            };

        }

        private void btnControlArray_Click(object sender, EventArgs e)
        {
            //宣告int陣列
            int[] array = { 10, 24, 36, 18, 59, 67, 42, 5, 13 };

            //計算奇數個數
            int oddCount = array.Count(n => n % 2 == 1);
            MessageBox.Show(string.Format("共有{0}個奇數", oddCount));

            //取出奇數奇數
            var oddNumbers = from n in array                      
                             where n % 2 == 1
                             select n;

            //將奇數進行排序
            int MaxOdd = oddNumbers.OrderBy(n => n).Last();
            MessageBox.Show(string.Format("最大的奇數:{0}", MaxOdd));
        }
    }
}
