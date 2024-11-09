using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Frontend
{
    [Serializable]
    public class ParkingSpot
    {
        public string ImagePath { get; set; }
        public bool Visible { get; set; }
        // Add any other necessary properties

        public ParkingSpot(string imagePath, bool visible)
        {
            ImagePath = imagePath;
            Visible = visible;
        }

        public static void SaveParkingMatrixToFile(PictureBox[] parking)
        {
            ParkingSpot[] parkingSpots = new ParkingSpot[parking.Length];

            for (int i = 0; i < parking.Length; i++)
            {
                parkingSpots[i] = new ParkingSpot(parking[i].ImageLocation, parking[i].Visible);
            }

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("parkingMatrix.bin", FileMode.Create))
            {
                binaryFormatter.Serialize(fileStream, parkingSpots);
            }
        }

        public static ParkingSpot[] LoadParkingMatrixFromFile()
        {
            ParkingSpot[] parking = new ParkingSpot[12];

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("parkingMatrix.bin", FileMode.Open))
            {
                ParkingSpot[] parkingSpots = (ParkingSpot[])binaryFormatter.Deserialize(fileStream);

                for (int i = 0; i < parkingSpots.Length; i++)
                {
                    parking[i] = parkingSpots[i];
                }
            }

            return parking;
        }
    }
}
