    using System;
using System.Drawing;

namespace IMAVD_TP1
{
    internal class ImageColorer
    {
        internal static Bitmap transform(Image originalImage,String option,Color color)
        {
            var resultBitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics graphics = Graphics.FromImage(resultBitmap))
            {
                graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height));
            }

            for(var y=0; y < resultBitmap.Height; y++)
            {
                for(var x=0; x < resultBitmap.Width; x++)
                {
                    Color pixelColor = resultBitmap.GetPixel(x,y);

                    var pixelAlpha = pixelColor.A;
                    var pixelRed = pixelColor.R;
                    var pixelGreen = pixelColor.G;
                    var pixelBlue = pixelColor.B;

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
                    if(option == "Customize")
                    {
                        int redDiff = Math.Abs(pixelRed - color.R);
                        int greenDiff = Math.Abs(pixelGreen - color.G);
                        int blueDiff = Math.Abs(pixelBlue - color.B);

                        if (redDiff <= 100 && greenDiff <= 100 && blueDiff <= 100) // change the threshold value as needed
                        {
                            resultBitmap.SetPixel(x, y, Color.FromArgb(pixelAlpha, 255 - pixelRed, 255 - pixelGreen, 255 - pixelBlue));
                        }
                        else
                        {
                            resultBitmap.SetPixel(x, y, Color.FromArgb(pixelAlpha, pixelRed, pixelGreen, pixelBlue));
                        }
                    }
                }
            }

            return resultBitmap;
        }

        internal static Bitmap getImageWithNoColor(Bitmap originalImage, Color clToRemove)
        {
            var resultBitmap = originalImage;

            for (var y = 0; y < resultBitmap.Height; y++)
            {
                for (var x = 0; x < resultBitmap.Width; x++)
                {
                    Color pixelColor = resultBitmap.GetPixel(x, y);

                    var pixelAlpha = pixelColor.A;
                    var pixelRed = pixelColor.R;
                    var pixelGreen = pixelColor.G;
                    var pixelBlue = pixelColor.B;

                    var clToRemoveAlpha = clToRemove.A;
                    var clToRemoveRed = clToRemove.R;
                    var clToRemoveGreen = clToRemove.G;
                    var clToRemoveBlue = clToRemove.B;

                    var newAlpha = pixelAlpha - clToRemoveAlpha;
                    if (newAlpha < 0) { newAlpha = 0; }
                    var newRed = pixelRed - clToRemoveRed;
                    if (newRed < 0) { newRed = 0; }
                    var newGreen = pixelGreen - clToRemoveGreen;
                    if (newGreen < 0) { newGreen = 0; }
                    var newBlue = pixelBlue - clToRemoveBlue;
                    if (newBlue < 0) { newBlue = 0; }

                    resultBitmap.SetPixel(x, y,
                        Color.FromArgb(newAlpha,newRed,newGreen,newBlue)
                        );
                }
            }
            return resultBitmap;
        }
    }
}
