using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    [Serializable]
    public class ForLiving : IUseFor
    {
        public string Use(params double[] values)
        {
            double diametr = values[0];
            double shine = values[1];
            double livingSpace = Math.Pow(diametr, 2.0)*Math.PI;
            string things;
            if (shine < 10000)
            {
                things = "Шапку, валенки, санки";
            }
            else if (shine < 99999)
            {
                things = "Кроссовки, мячик, рюкзак";
            }
            else
            {
                things = "Очки, шлепки, крем от загара";
            }
            string useInfo = "Жилая площадь: "+ Math.Round(livingSpace)+", рекомендованно взять: " + things;
            return useInfo;
        }
    }
}
