using ImageProcessor;
using IMAVD_TP1.Enums;
using System.IO;

namespace IMAVD_TP1.Handlers
{
    internal class GammaHandler : IImageHandler
    {
        private float Value;

        public bool CanHandle(Operation operation, params object[] args)
        {
            if (operation == Operation.Gamma && float.TryParse(args[0].ToString(), out float value))
            {
                this.Value = value;

                return true;
            }
            return false;
        }

        public void Transform(MemoryStream inStream, MemoryStream outStream, ImageFactory imageFactory)
        {
            imageFactory.Load(inStream)
                        .Gamma(this.Value)
                        .Save(outStream);
        }
    }
}
