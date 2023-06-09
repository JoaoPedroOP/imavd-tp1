﻿using ImageProcessor;
using IMAVD_TP1.Enums;
using System.IO;

namespace IMAVD_TP1.Handlers
{
    internal class RotationHandler : IImageHandler
    {
        private int Value;

        public bool CanHandle(Operation operation, params object[] args)
        {
            if (operation == Operation.Rotate && int.TryParse(args[0].ToString(), out int value))
            {
                this.Value = value;

                return true;
            }
            return false;
        }

        public void Transform(MemoryStream inStream, MemoryStream outStream, ImageFactory imageFactory)
        {
            imageFactory.Load(inStream)
                        .Rotate(this.Value)
                        .Save(outStream);
        }
    }
}
