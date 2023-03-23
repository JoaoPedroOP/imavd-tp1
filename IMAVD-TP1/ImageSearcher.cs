using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace IMAVD_TP1
{
    internal class ImageSearcher
    {
        internal static void searchColor(Image originalImage, Color selectedColor)
        {
            var resultBitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics graphics = Graphics.FromImage(resultBitmap))
            {
                graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height));
            }

            int numberOfSameColorPixels = 0;
            bool colorExists = false;

            for (int y = 0; y < resultBitmap.Height; y++)
            {
                for (int x = 0; x < resultBitmap.Width; x++)
                {
                    Color pixelColor = resultBitmap.GetPixel(x, y);

                    if(pixelColor == selectedColor)
                    {
                        numberOfSameColorPixels++;
                    }
               
                }
            }

            if(numberOfSameColorPixels > 0)
            {
                colorExists = true;
            }

        }
    }
}
