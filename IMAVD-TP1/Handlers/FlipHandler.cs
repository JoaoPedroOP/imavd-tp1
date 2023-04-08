using ImageProcessor;
using IMAVD_TP1.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMAVD_TP1.Handlers
{
    internal class FlipHandler : IImageHandler
    {

        private bool Value;
        public bool CanHandle(Operation operation, params object[] args)
        {
            if (operation == Operation.Flip && bool.TryParse(args[0].ToString(), out bool value))
            {
                this.Value = value;

                return true;
            }
            return false;
        }

        public void Transform(MemoryStream inStream, MemoryStream outStream, ImageFactory imageFactory)
        {
            imageFactory.Load(inStream)
                        .Flip(this.Value)
                        .Save(outStream);
        }
    }
}
