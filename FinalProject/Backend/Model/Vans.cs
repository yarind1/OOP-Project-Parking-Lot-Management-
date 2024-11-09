using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend.Model
{
    [Serializable]
    public class Vans : Automobiles
    {
        public string AutoMobileBrand { get; }

        public Vans(string vehicleId, string vehicleType, string ownerName, string color, DateTime entryTime, string autoMobileType, string autoMobileBrand) : base(vehicleId, vehicleType, ownerName, color, entryTime, autoMobileType)
        {
            AutoMobileBrand = autoMobileBrand;
        }
    }
}
