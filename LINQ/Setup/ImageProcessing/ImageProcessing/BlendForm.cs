using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Microsoft.Drawing;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ImageProcessing
{
    public partial class BlendForm : Form
    {
        public BlendForm()
        {
            InitializeComponent();
        }

        internal unsafe Bitmap BlendImages(Bitmap start, Bitmap end, double blend, bool parallel)
        {
            // Validate parameters
            if (start.Width != end.Width || start.Height != end.Height)
                throw new ArgumentException("The sizes of images do not match.");
            if (blend < 0 || blend > 1)
                throw new ArgumentOutOfRangeException("blend", blend, "Must be in the range [0.0,1.1].");

            // Create the output image
            int width = start.Width, height = start.Height;
            Bitmap output = new Bitmap(width, height);

            // Blend the input images into the output
            using (FastBitmap fastOut = new FastBitmap(output))
            using (FastBitmap fastStart = new FastBitmap(start))
            using (FastBitmap fastEnd = new FastBitmap(end))
            {
                if (parallel)
                {
                    // Blend the images in parallel
                    Parallel.For(0, height, j =>
                    {
                        PixelData* outPixel = fastOut.GetInitialPixelForRow(j);
                        PixelData* startPixel = fastStart.GetInitialPixelForRow(j);
                        PixelData* endPixel = fastEnd.GetInitialPixelForRow(j);

                        for (int i = 0; i < width; i++)
                        {
                            // Blend the input pixels into the output pixel
                            outPixel->R = (byte)((startPixel->R * blend) + .5 + (endPixel->R * (1 - blend))); // .5 for rounding
                            outPixel->G = (byte)((startPixel->G * blend) + .5 + (endPixel->G * (1 - blend)));
                            outPixel->B = (byte)((startPixel->B * blend) + .5 + (endPixel->B * (1 - blend)));

                            outPixel++;
                            startPixel++;
                            endPixel++;
                        }
                    });
                }
                else
                {
                    // Blend the images sequentially
                    for (int j = 0; j < height; j++)
                    {
                        PixelData* outPixel = fastOut.GetInitialPixelForRow(j);
                        PixelData* startPixel = fastStart.GetInitialPixelForRow(j);
                        PixelData* endPixel = fastEnd.GetInitialPixelForRow(j);

                        for (int i = 0; i < width; i++)
                        {
                            // Blend the input pixels into the output pixel
                            outPixel->R = (byte)((startPixel->R * blend) + .5 + (endPixel->R * (1 - blend))); // .5 for rounding
                            outPixel->G = (byte)((startPixel->G * blend) + .5 + (endPixel->G * (1 - blend)));
                            outPixel->B = (byte)((startPixel->B * blend) + .5 + (endPixel->B * (1 - blend)));

                            outPixel++;
                            startPixel++;
                            endPixel++;
                        }
                    }
                }
            }
            return output;
        }

        private void btnChoose1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picImage1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnChoose2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picImage2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnNonParallel_Click(object sender, EventArgs e)
        {
            // Get the images
            Bitmap bmp1 = (Bitmap)picImage1.Image;
            Bitmap bmp2 = (Bitmap)picImage2.Image;

            // Clear the output image
            picBlended.Image=null;
            picBlended.Refresh();
            
            // Resize the second image's size to match that of the first
            if (bmp1.Size != bmp2.Size)
            {
                Bitmap newBmp2 = new Bitmap(bmp1.Width, bmp1.Height);
                using (var g = Graphics.FromImage(newBmp2)) g.DrawImage(bmp2, 0, 0, newBmp2.Width, newBmp2.Height);
                picImage2.Image = newBmp2;
                bmp2.Dispose();
                bmp2 = newBmp2;
            }

            // Do Blended
            Stopwatch sw=Stopwatch.StartNew();
            picBlended.Image = BlendImages(bmp1, bmp2, .5, false);
            sw.Stop();
            tmNonParallel.Text=sw.ElapsedMilliseconds.ToString();
        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            // Get the images
            Bitmap bmp1 = (Bitmap)picImage1.Image;
            Bitmap bmp2 = (Bitmap)picImage2.Image;

            // Clear the output image
            picBlended.Image = null;
            picBlended.Refresh();

            // Resize the second image's size to match that of the first
            if (bmp1.Size != bmp2.Size)
            {
                Bitmap newBmp2 = new Bitmap(bmp1.Width, bmp1.Height);
                using (var g = Graphics.FromImage(newBmp2)) g.DrawImage(bmp2, 0, 0, newBmp2.Width, newBmp2.Height);
                picImage2.Image = newBmp2;
                bmp2.Dispose();
                bmp2 = newBmp2;
            }

            // Do Blended
            Stopwatch sw = Stopwatch.StartNew();
            picBlended.Image = BlendImages(bmp1, bmp2, .5, true);
            sw.Stop();
            tmParallel.Text = sw.ElapsedMilliseconds.ToString();
        }

        private void BlendForm_Load(object sender, EventArgs e)
        {
            btnParallel.Text = $"平行運算({Environment.ProcessorCount}核心)";
        }
    }
}
