using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using Microsoft.Drawing;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public partial class GreyScaleForm : Form
    {
        public GreyScaleForm()
        {
            InitializeComponent();
        }

        public Bitmap convertToGray(Bitmap originalBmp)
        {
            FastBitmap fastOriginal = new FastBitmap(originalBmp);
            int h = originalBmp.Height, w = originalBmp.Width;
            for (int y = 0; y < originalBmp.Height; y++)
            {
                for (int x = 0; x < originalBmp.Width; x++)
                {
                    Color c = fastOriginal.GetColor(x, y);
                    int gray = (byte)(c.R * 0.11 + c.G * 0.59 + c.R * 0.3);

                    fastOriginal.SetColor(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            fastOriginal.Dispose();
            return originalBmp;
        }

        public Bitmap ToGrayscale(Bitmap originalBmp, bool parallel)
        {
            FastBitmap fastOriginal = new FastBitmap(originalBmp);
            int h = originalBmp.Height, w = originalBmp.Width;
            if (parallel)
            {
                Parallel.For(0, h, (y) =>
                {
                    Parallel.For(0, w, (x) =>
                    {
                        Color c = fastOriginal.GetColor(x, y);
                        int gray = (byte)(c.R * 0.11 + c.G * 0.59 + c.R * 0.3);

                        fastOriginal.SetColor(x, y, Color.FromArgb(gray, gray, gray));

                    });
                });

            }
            else
            {
                for (int y = 0; y < originalBmp.Height; y++)
                {
                    for (int x = 0; x < originalBmp.Width; x++)
                    {
                        Color c = fastOriginal.GetColor(x, y);
                        int gray = (byte)(c.R * 0.11 + c.G * 0.59 + c.R * 0.3);

                        fastOriginal.SetColor(x, y, Color.FromArgb(gray, gray, gray));
                    }
                }
            }
            fastOriginal.Dispose();
            return originalBmp;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picOriginal.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnNonParallel_Click(object sender, EventArgs e)
        {
            tmNonParallel.Text = "";
            picGreyScale.Image = null;
            picGreyScale.Refresh();

            Stopwatch sw = Stopwatch.StartNew();
            //==============================
            picGreyScale.Image = ToGrayscale(new Bitmap(picOriginal.Image), false);
            //==============================          
            sw.Stop();
            tmNonParallel.Text = sw.ElapsedMilliseconds.ToString();
        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            tmParallel.Text = "";
            picGreyScale.Image = null;
            picGreyScale.Refresh();

            Stopwatch sw = Stopwatch.StartNew();
            //==============================
            picGreyScale.Image = ToGrayscale(new Bitmap(picOriginal.Image), true);
            //==============================          
            sw.Stop();
            tmParallel.Text = sw.ElapsedMilliseconds.ToString();
        }

        private void GreyScaleForm_Load(object sender, EventArgs e)
        {
            btnParallel.Text = $"平行運算({Environment.ProcessorCount}核心)";
        }
    }
}
