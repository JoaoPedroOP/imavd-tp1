using IMAVD_TP1.DTO;
using System.Drawing;

namespace IMAVD_TP1
{
    internal class ImageSearcher
    {
        internal static ColorSearchDTO searchColor(Image originalImage, Color selectedColor)
        {
            var resultBitmap = new Bitmap(originalImage.Width, originalImage.Height);
            var colorSearchInfo = new ColorSearchDTO();

            using (Graphics graphics = Graphics.FromImage(resultBitmap))
            {
                graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height));
            }

            for (int y = 0; y < resultBitmap.Height; y++)
            {
                for (int x = 0; x < resultBitmap.Width; x++)
                {
                    Color pixelColor = resultBitmap.GetPixel(x, y);

                    if(pixelColor == selectedColor)
                    {
                        colorSearchInfo.numberOfSameColorPixels++;
                    }
               
                }
            }

            if(colorSearchInfo.numberOfSameColorPixels > 0)
            {
                colorSearchInfo.colorExists = true;
            }

            return colorSearchInfo;
        }
    }
}
