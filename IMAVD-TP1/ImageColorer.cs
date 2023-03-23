using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMAVD_TP1
{
    internal class ImageColorer
    {
        
        internal static Bitmap transform(Image originalImage,String option)
        {
            var resultBitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics graphics = Graphics.FromImage(resultBitmap))
            {
                graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height));
            }

            for(int y=0; y < resultBitmap.Height; y++)
            {
                for(int x=0; x < resultBitmap.Width; x++)
                {
                    Color pixelColor = resultBitmap.GetPixel(x,y);

                    int pixelAlpha = pixelColor.A;
                    int pixelRed = pixelColor.R;
                    int pixelGreen = pixelColor.G;
                    int pixelBlue = pixelColor.B;

                    if (option == "Red")
                    {
                        resultBitmap.SetPixel(x, y, Color.FromArgb(pixelAlpha, pixelRed, 0, 0));
                    }
                    if (option == "Green")
                    {
                        resultBitmap.SetPixel(x, y, Color.FromArgb(pixelAlpha, 0, pixelGreen, 0));
                    }
                    if (option == "Blue")
                    {
                        resultBitmap.SetPixel(x, y, Color.FromArgb(pixelAlpha, 0, 0, pixelBlue));
                    }
                    if (option == "InvertColors")
                    {
                        resultBitmap.SetPixel(x, y, Color.FromArgb(pixelAlpha, 255-pixelRed, 255-pixelGreen, 255-pixelBlue));
                    }
                }
            }

            return resultBitmap;
        }


    }
}
