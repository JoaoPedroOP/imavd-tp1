﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

        internal static Bitmap getImageWithNoColor(Bitmap originalImage, Color clToRemove)
        {
            var resultBitmap = originalImage;

            for (int y = 0; y < resultBitmap.Height; y++)
            {
                for (int x = 0; x < resultBitmap.Width; x++)
                {
                    Color pixelColor = resultBitmap.GetPixel(x, y);

                    int pixelAlpha = pixelColor.A;
                    int pixelRed = pixelColor.R;
                    int pixelGreen = pixelColor.G;
                    int pixelBlue = pixelColor.B;

                    int clToRemoveAlpha = clToRemove.A;
                    int clToRemoveRed = clToRemove.R;
                    int clToRemoveGreen = clToRemove.G;
                    int clToRemoveBlue = clToRemove.B;

                    int newAlpha = pixelAlpha - clToRemoveAlpha;
                    if (newAlpha < 0) { newAlpha = 0; }
                    int newRed = pixelRed - clToRemoveRed;
                    if (newRed < 0) { newRed = 0; }
                    int newGreen = pixelGreen - clToRemoveGreen;
                    if (newGreen < 0) { newGreen = 0; }
                    int newBlue = pixelBlue - clToRemoveBlue;
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
