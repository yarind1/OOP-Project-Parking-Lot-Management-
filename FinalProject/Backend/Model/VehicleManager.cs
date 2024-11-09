using FinalProject.Backend.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Backend.Model
{
    public class VehicleManager
    {
        private static BindingList<Vehicle> vehicles { get; }
        static VehicleManager()
        {
            vehicles = FileUtils.LoadVehiclesFromFile();
        }
        public static void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
        public static BindingList<T> GetSpecificVehicle<T>() where T : Vehicle
        {
            BindingList<T> specificVehicle = new BindingList<T>();
            foreach (Vehicle vehicle in vehicles)
            {
                if(vehicle is T)
                {
                    specificVehicle.Add((T)vehicle);
                }
            }
            return specificVehicle;
        }
        public static void RemoveVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
           
        }
        public static Vehicle GetVehicleByID(string ID)
        {
            Car car = new Car("","","","",DateTime.Now,"Car","BMW");
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.LicensePlate==ID)
                {
                    return vehicle;
                }
            }
            return car;
        }
       
        internal static void SaveVehicles(object sender, FormClosingEventArgs e)
        {
            FileUtils.SaveVehiclesToFile(vehicles);
        }
        public static double CalculateHours(DateTime startDateTime, DateTime endDateTime)
        {
            TimeSpan timeDifference = endDateTime - startDateTime;
            double hours = timeDifference.TotalHours;
            return hours;
        }
        public static double CalculateParkingPrice(Vehicle vehicle)
        {
            double entry = 20.0;
            DateTime now = DateTime.Now;
            double duration = CalculateHours(vehicle.EntryTime, now);
            return entry + duration * 12;
        }
        public static bool IsIdExist(string ID)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.LicensePlate == ID)
                {
                    return true;
                }
            }
            return false;
        }
    }

    
    
}
