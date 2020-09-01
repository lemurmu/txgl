using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Library.Basic
{
    public class ToolImage
    {
        public static Image Cut(Image img, int width, int height, int x, int y)
        {
            var r = new Bitmap(width, height);
            var destinationRectange = new Rectangle(0, 0, width, height);
            var sourceRectangle = new Rectangle(x, y, width, height);

            using (Graphics g = Graphics.FromImage(r))
            {
                g.DrawImage(img, destinationRectange, sourceRectangle, GraphicsUnit.Pixel);
            }

            return r;
        }

        public static Image Scale(Image img, int width, int height)
        {
            var r = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(r))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(img, 0, 0, width, height);
            }

            return r;
        }

        public static Image Scale(Image img, double ratio)
        {
            int width = Convert.ToInt32(img.Width * ratio);
            int height = Convert.ToInt32(img.Height * ratio);

            var r = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(r))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(img, 0, 0, width, height);
            }

            return r;
        }
    }
}
