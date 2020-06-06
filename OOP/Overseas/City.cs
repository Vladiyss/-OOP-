using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overseas
{
    [Serializable]
    public class City : ISettlement
    {
        public string ToArrive (string transport) 
        {
            string howToArriveInformation;
            if (String.IsNullOrEmpty(transport))
            {
                howToArriveInformation = "Добраться нельзя";
            }
            else
            {
                howToArriveInformation = "Собрать чемодан, купить билет на " + transport;
            }
            return howToArriveInformation;
        }
    }
}
