using ImageProcessor;
using IMAVD_TP1.Enums;
using IMAVD_TP1.Handlers;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace IMAVD_TP1
{
    public class ImageProcessor
    {
        private List<IImageHandler> imageHandlers = new List<IImageHandler>
            {
                new ContrastHandler(),
                new BrightnessHandler(),
                new RotationHandler(),
                new GammaHandler(),
            };

        public Image ImageProcessing(string fileName, Operation operation, params object[] args)
        {
            byte[] photoBytes = File.ReadAllBytes(fileName);

            using (MemoryStream inStream = new MemoryStream(photoBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        // Load, resize, set the format and quality and save an image.
                        foreach (IImageHandler handler in imageHandlers)
                        {
                            if (handler.CanHandle(operation, args))
                            {
                                handler.Transform(inStream, outStream, imageFactory);
                            }
                        }
                    }
                    // Do something with the stream.
                    Image transformedImage = Image.FromStream(outStream);

                    return transformedImage;
                }
            }
        }
    }
}
