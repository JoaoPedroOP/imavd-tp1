using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMAVD_TP1.DTO
{
    internal class ColorSearchDTO
    {
        public int numberOfSameColorPixels { get; set; }
        public bool colorExists { get; set; }

        public ColorSearchDTO()
        {
            numberOfSameColorPixels = 0;
            colorExists = false;
        }

    }
}
