using System;
using System.Drawing;

namespace IMAVD_TP1
{
    internal class ImageCroper
    {

        internal static Bitmap crop(Image originalImage, String option)
        {
            var resultBitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics graphics = Graphics.FromImage(resultBitmap))
            {
                graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height));
            }


            switch (option)
            {
                case "Two Areas":
                    return cropTwoAreas(originalImage);
                case "Four Areas":
                    return cropFourAreas(originalImage);
                case "Top Left Corner":
                    return cropTopLeftCorner(originalImage);
                case "Low Right Corner":
                    return cropLowRightCorner(originalImage);
                default: break;
            }

            return resultBitmap;
        }

        private static Bitmap cropLowRightCorner(Image originalImage)
        {
            var resultBitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (var graphics = Graphics.FromImage(resultBitmap))
            {
                graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height));
            }

            int pixelsErased = originalImage.Width;
            for (var y = originalImage.Height; y >= 0; y--)
            {
                for (var x = originalImage.Width; x >= originalImage.Width-pixelsErased; x--)
                {
                    resultBitmap.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                }
                pixelsErased += originalImage.Width / originalImage.Height;
            }

            return resultBitmap;
        }

        private static Bitmap cropTopLeftCorner(Image originalImage)
        {
            var resultBitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics graphics = Graphics.FromImage(resultBitmap))
            {
                graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height));
            }

            int notErasingCollumBits = 0;

            for (var y = resultBitmap.Height - 1; y > 0; y--)
            {
                for (var x = resultBitmap.Width-1; x > notErasingCollumBits; x--)
                {
                    resultBitmap.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                }
                notErasingCollumBits += resultBitmap.Height / resultBitmap.Width;
            }

            return resultBitmap;
        }

        private static Bitmap cropFourAreas(Image originalImage)
        {
            //dimensoes de cada uma das 4 partes
            int halfHeight = originalImage.Height / 2;
            int halfWidth = originalImage.Width / 2;

            // Cria objetos Bitmap para as 4 partes
            Bitmap topLeft = new Bitmap(halfWidth, halfHeight);
            Bitmap topRight = new Bitmap(halfWidth, halfHeight);
            Bitmap bottomLeft = new Bitmap(halfWidth, halfHeight);
            Bitmap bottomRight = new Bitmap(halfWidth, halfHeight);

            // Copia a imagem original para as 4 partes
            Graphics gTopLeft = Graphics.FromImage(topLeft);
            gTopLeft.DrawImage(originalImage,
                new Rectangle(0, 0, halfWidth, halfHeight),
                new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                GraphicsUnit.Pixel);
            Graphics gTopRight = Graphics.FromImage(topRight);
            gTopRight.DrawImage(originalImage,
                new Rectangle(0, 0, halfWidth, halfHeight),
                new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                GraphicsUnit.Pixel);
            Graphics gBottomLeft = Graphics.FromImage(bottomLeft);
            gBottomLeft.DrawImage(originalImage,
                new Rectangle(0, 0, halfWidth, halfHeight),
                new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                GraphicsUnit.Pixel);
            Graphics gBottomRight = Graphics.FromImage(bottomRight);
            gBottomRight.DrawImage(originalImage,
                new Rectangle(0, 0, halfWidth, halfHeight),
                new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                GraphicsUnit.Pixel);

            // Cria um objeto Bitmap para a imagem final combinada
            Bitmap joinedImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Copia as 4 partes para a imagem final combinada
            Graphics g = Graphics.FromImage(joinedImage);
            g.DrawImage(topLeft,
                new Rectangle(0, 0, halfWidth, halfHeight),
                new Rectangle(0, 0, halfWidth, halfHeight),
                GraphicsUnit.Pixel);
            g.DrawImage(topRight,
                new Rectangle(halfWidth, 0, halfWidth, halfHeight),
                new Rectangle(0, 0, halfWidth, halfHeight),
                GraphicsUnit.Pixel);
            g.DrawImage(bottomLeft,
                new Rectangle(0, halfHeight, halfWidth, halfHeight),
                new Rectangle(0, 0, halfWidth, halfHeight),
                GraphicsUnit.Pixel);
            g.DrawImage(bottomRight,
                new Rectangle(halfWidth, halfHeight, halfWidth, halfHeight),
                new Rectangle(0, 0, halfWidth, halfHeight),
                GraphicsUnit.Pixel);

            // Retorna a imagem final combinada
            return joinedImage;
        }

        private static Bitmap cropTwoAreas(Image originalImage)
        {
            int halfHeight = originalImage.Height / 2;

            // Cria objetos Bitmap para as metades superior e inferior
            Bitmap topHalf = new Bitmap(originalImage.Width, halfHeight);
            Bitmap bottomHalf = new Bitmap(originalImage.Width, halfHeight);

            // Copia as metades da imagem original para os objetos Bitmap das metades
            Graphics gTop = Graphics.FromImage(topHalf);
            gTop.DrawImage(originalImage,
                new Rectangle(0, 0, originalImage.Width, halfHeight),
                new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                GraphicsUnit.Pixel);

            Graphics gBottom = Graphics.FromImage(bottomHalf);
            gBottom.DrawImage(originalImage,
                new Rectangle(0, 0, originalImage.Width, halfHeight),
                new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                GraphicsUnit.Pixel);

            // Cria um objeto Bitmap para a imagem final combinada
            Bitmap joinedImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Copia as metades superior e inferior para a imagem final combinada
            Graphics g = Graphics.FromImage(joinedImage);
            g.DrawImage(topHalf,
                new Rectangle(0, 0, originalImage.Width, halfHeight),
                new Rectangle(0, 0, originalImage.Width, halfHeight),
                GraphicsUnit.Pixel);

            //atencao que os pontos dos retângulos são somados relativamente
            //dai que o retangulo inferior apenas se desloca metade da altura
            //na coordenada a declarar
            g.DrawImage(bottomHalf,
                new Rectangle(0, halfHeight, originalImage.Width, halfHeight),
                new Rectangle(0, 0, originalImage.Width, halfHeight),
                GraphicsUnit.Pixel);

            // Retorna a imagem final combinada
            return joinedImage;
        }
    }
}
