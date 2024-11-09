using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend.Model
{
    [Serializable]
    public class Motorcycle : Vehicle
    {
        public string Brand { get; }
        public Motorcycle(string vehicleId, string vehicleType, string ownerName, string color, DateTime entryTime, string brand) : base(vehicleId, vehicleType, ownerName, color, entryTime)
        {
            Brand = brand;
        }
    }
}
