using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend.Model
{
    [Serializable]
    public abstract class Automobiles : Vehicle
    {
        public string Type { get; }
        

        protected Automobiles(string vehicleId, string vehicleType, string ownerName, string color, DateTime entryTime, string autoMobileType) : base( vehicleId,  vehicleType, ownerName, color,  entryTime)
        {
            Type = autoMobileType;
        }
    }
}
