using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPlugins
{
    public static class Astronomic
    {
        const double SunTemperature = 6065;
        const double SunRadius = 695510;
        const double SunShine = 38280;
        const double SunWeight = 19885000;

        public static int GetTemperature(double shine, int diametr)
        {
            double radius = diametr / 2;
            double temp = Math.Sqrt(Math.Sqrt(shine / SunShine)) * Math.Sqrt(SunRadius / radius) * SunTemperature;

            return (int)Math.Round(temp);
        }

        public static int GetTimeofLife(double weight)
        {
            double n;
            if (weight < (4.7 * SunWeight))
            {
                n = 3.75;
            }
            else if (weight < (8 * SunWeight))
            {
                n = 7.75;
            }
            else
            {
                n = 10;
            }
            n = 1 - n;

            double time = 100 * Math.Pow(((double)weight / SunWeight), n);

            return (int)Math.Round(time);
        }
    }
}
