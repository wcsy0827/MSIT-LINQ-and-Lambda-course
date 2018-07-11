using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessing
{
	public class BitmapGrey
	{
		Bitmap bitmap;

		public BitmapGrey(Bitmap bitmap)
		{
			this.bitmap = bitmap;
		}

		public void Save(string filename)
		{
			bitmap.Save(filename, ImageFormat.Jpeg);
		}

		public void Dispose()
		{
			bitmap.Dispose();
		}

		public Bitmap Bitmap
		{
			get
			{
				return(bitmap);
			}
		}

		public Point PixelSize
		{
			get
			{
				GraphicsUnit unit = GraphicsUnit.Pixel;
				RectangleF bounds = bitmap.GetBounds(ref unit);

				return new Point((int) bounds.Width, (int) bounds.Height);
			}
		}

		public void MakeGrey()
		{
			Point size = PixelSize;

			for (int x = 0; x < size.X; x++)
			{
				for (int y = 0; y < size.Y; y++)
				{
					Color c = bitmap.GetPixel(x, y);
					int value = (c.R + c.G + c.B) / 3;
					bitmap.SetPixel(x, y, Color.FromArgb(value, value, value));
				}
			}
		}

		public void MakeInverse()
		{
			Point size = PixelSize;

			for (int x = 0; x < size.X; x++)
			{
				for (int y = 0; y < size.Y; y++)
				{
					Color c = bitmap.GetPixel(x, y);
					//int value = (c.R + c.G + c.B) / 3;
					bitmap.SetPixel(x, y, Color.FromArgb(255-c.R, 255-c.G, 255-c.B));
				}
			}
		}		
	}
}
