using FinalProject.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Backend.Utils
{
    public class FileUtils
    {
        public static void SaveVehiclesToFile(BindingList<Vehicle> vehicles)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("vehicles.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, vehicles);
                binaryFile.Flush();
            }
        }

        public static BindingList<Vehicle> LoadVehiclesFromFile()
        {
            BindingList<Vehicle> vehicles;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("vehicles.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    vehicles = (BindingList<Vehicle>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception ex)
            {
                vehicles = new BindingList<Vehicle>();
            }
            return vehicles;
        }
        public static void SaveCapacityToFile(int capacity)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("capacity.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, capacity);
                binaryFile.Flush();
            }
        }
        public static int LoadCapacityFromFile()
        {
            int capacity;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("capacity.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    capacity = (int)binaryFormatter.Deserialize(binaryFile);
                    if(capacity<0)
                    {
                        capacity = 12;
                    }
                }
            }
            catch (Exception ex)
            {
                capacity = -1;
            }
            return capacity;
        }
        public static void SaveParkingDetailsToFile(string[] parkingDetails)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("parkingDetails.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, parkingDetails);
                binaryFile.Flush();
            }
        }
        public static string[] LoadParkingDetailsFromFile()
        {
            string[] parkingDetails = new string[12];

            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("parkingDetails.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    object deserializedObject = binaryFormatter.Deserialize(binaryFile);

                    if (deserializedObject is string[] deserializedArray && deserializedArray.Length == 12)
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            parkingDetails[i] = deserializedArray[i];
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid data format in parkingDetails.bin");
                    }
                }
            }
            catch (Exception ex)
            {
                for (int i = 0; i < 12; i++)
                {
                    parkingDetails[i] = "C:\\Users\\IMOE001\\source\\repos\\FinalProject\\FinalProject\\Resources\\VehiclesPics\\BlackVehicles\\blackCar.png";
                }
            }

            return parkingDetails;
        }
        public static void SaveParkingVehIdsToFile(string[] parkingVehIds)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("parkingVehIds.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, parkingVehIds);
                binaryFile.Flush();
            }
        }
        public static string[] LoadParkingVehIdsFromFile()
        {
            string[] parkingVehIds = new string[12];

            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("parkingVehIds.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    object deserializedObject = binaryFormatter.Deserialize(binaryFile);

                    if (deserializedObject is string[] deserializedArray && deserializedArray.Length == 12)
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            parkingVehIds[i] = deserializedArray[i];
                        }

                    }
                    else
                    {
                        throw new Exception("Invalid data format in parkingDetails.bin");
                    }
                }
            }
            catch (Exception ex)
            {
                for (int i = 0; i < 12; i++)
                {
                    parkingVehIds[i] = "";
                }
            }

            return parkingVehIds;
        }
    }
}
