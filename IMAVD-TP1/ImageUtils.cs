using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMAVD_TP1
{
    internal class ImageUtils
    {

        public static void RgbToHsl(int r, int g, int b, out double h, out double s, out double l)
        {
            double rd = (double)r / 255.0;
            double gd = (double)g / 255.0;
            double bd = (double)b / 255.0;
            double max = Math.Max(rd, Math.Max(gd, bd));
            double min = Math.Min(rd, Math.Min(gd, bd));
            double delta = max - min;

            l = (max + min) / 2;

            if (delta == 0)
            {
                h = 0;
                s = 0;
            }
            else
            {
                if (l < 0.5)
                {
                    s = delta / (max + min);
                }
                else
                {
                    s = delta / (2 - max - min);
                }

                if (rd == max)
                {
                    h = (gd - bd) / delta;
                }
                else if (gd == max)
                {
                    h = 2 + (bd - rd) / delta;
                }
                else
                {
                    h = 4 + (rd - gd) / delta;
                }

                h *= 60;
                if (h < 0)
                {
                    h += 360;
                }
            }

        }

        internal static void HslToRgb(double h, double s, double l, out int r, out int g, out int b)
        {
            if (s == 0)
            {
                r = g = b = (int)(l * 255.0 + 0.5);
            }
            else
            {
                double q = l < 0.5 ? l * (1 + s) : l + s - l * s;
                double p = 2 * l - q;
                double hk = h / 360.0;

                double[] tc = new double[3];
                tc[0] = hk + 1.0 / 3.0;
                tc[1] = hk;
                tc[2] = hk - 1.0 / 3.0;

                for (int i = 0; i < 3; i++)
                {
                    if (tc[i] < 0)
                    {
                        tc[i] += 1.0;
                    }
                    if (tc[i] > 1)
                    {
                        tc[i] -= 1.0;
                    }

                    if (tc[i] < 1.0 / 6.0)
                    {
                        tc[i] = p + (q - p) * 6.0 * tc[i];
                    }
                    else if (tc[i] < 0.5)
                    {
                        tc[i] = q;
                    }
                    else if (tc[i] < 2.0 / 3.0)
                    {
                        tc[i] = p + (q - p) * (2.0 / 3.0 - tc[i]) * 6.0;
                    }
                    else
                    {
                        tc[i] = p;
                    }
                }

                r = (int)(tc[0] * 255.0 + 0.5);
                g = (int)(tc[1] * 255.0 + 0.5);
                b = (int)(tc[2] * 255.0 + 0.5);
            }
        }
    }
}