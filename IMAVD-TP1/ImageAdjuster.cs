using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace IMAVD_TP1
{
    internal class ImageAdjuster
    {
        internal static Bitmap transform(Image originalImage, string option, int value)
        {
            var resultBitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics graphics = Graphics.FromImage(resultBitmap))
            {
                graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height));
            }

            int brightValue = value;
            for (int y = 0; y < resultBitmap.Height; y++)
            {
                for (int x = 0; x < resultBitmap.Width; x++)
                {
                    Color pixelColor = resultBitmap.GetPixel(x, y);

                    if (option == "Bright")
                    {
                        //modelo HSL para melhor atuação no Light apenas
                        double h, s, l;
                        ImageUtils.RgbToHsl(pixelColor.R, pixelColor.G, pixelColor.B,
                            out h, out s, out l);

                        // Ajusta a luminosidade (lightness) da cor
                        // sem alterar a saturação e o matiz (hue)
                        l *= brightValue;
                        l = Math.Max(l, 0);
                        l = Math.Min(l, 1);

                        // Converte a cor de volta para o espaço de cores RGB
                        int r, g, b;
                        ImageUtils.HslToRgb(h, s, l, out r, out g, out b);

                        // Define a nova cor para o pixel atual preservando a cor original
                        Color newColor = Color.FromArgb(pixelColor.A, r, g, b);

                        resultBitmap.SetPixel(x, y,newColor);
                    }
                
                }
            }

            return resultBitmap;
        }
    }
}
