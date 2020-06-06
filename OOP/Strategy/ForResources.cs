using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    [Serializable]
    public class ForResources : IUseFor
    {
        public string Use(params double[] values)
        {
            double timeofLife = values[0];
            double shine = values[1];
            decimal amountOfEnergy = (decimal)(Math.Pow(shine, 2.0) * timeofLife);
            
            string UseInfo = "Количество доступной энергии: " + Math.Round(amountOfEnergy);
            return UseInfo;
        }
    }
}
