using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend.Model
{
    [Serializable]
    public abstract class Vehicle
    {
        public string LicensePlate { get; }
        public string Type { get;}
        public string Name { get;set; }
        public string Color { get; set; }
        public DateTime EntryTime { get; set; }
        
     
     
        protected Vehicle(string vehicleId, string vehicleType, string ownerName, string color, DateTime entryTime)
        {
            LicensePlate = vehicleId;
            Type = vehicleType;
            Name = ownerName;
            Color = color;
            EntryTime = entryTime;
            Name = ownerName;  
        }
    }
}
