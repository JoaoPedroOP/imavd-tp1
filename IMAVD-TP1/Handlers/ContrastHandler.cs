using ImageProcessor;
using IMAVD_TP1.Enums;
using System.IO;

namespace IMAVD_TP1.Handlers
{
    internal class ContrastHandler : IImageHandler
    {
        private int Value;

        public bool CanHandle(Operation operation, params object[] args)
        {
            if(operation == Operation.Contrast && int.TryParse(args[0].ToString(), out var value))
            {
                this.Value = value;

                return true;
            }
            return false;
        }

        public void Transform(MemoryStream inStream, MemoryStream outStream, ImageFactory imageFactory)
        {
            imageFactory.Load(inStream)
                        .Contrast(this.Value)
                        .Save(outStream);
        }
    }
}
