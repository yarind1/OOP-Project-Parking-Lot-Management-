using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend.Model
{
    [Serializable]
    public class Car:Automobiles
    {
        public string Brand { get; }

        public Car(string vehicleId, string vehicleType, string ownerName, string color, DateTime entryTime, string autoMobileType,string autoMobileBrand) : base( vehicleId,  vehicleType,  ownerName,  color,  entryTime,  autoMobileType)
        {
            Brand = autoMobileBrand;
        }

       
    }
}
