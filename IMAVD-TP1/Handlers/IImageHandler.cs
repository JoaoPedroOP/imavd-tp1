using ImageProcessor;
using IMAVD_TP1.Enums;
using System.IO;

namespace IMAVD_TP1.Handlers
{
    internal interface IImageHandler
    {
        bool CanHandle(Operation operation, params object[] args);

        void Transform(MemoryStream inStream, MemoryStream outStream, ImageFactory imageFactory);
    }
}
