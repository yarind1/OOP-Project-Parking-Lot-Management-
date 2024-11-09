using FinalProject.Backend;
using FinalProject.Backend.Model;
using FinalProject.Backend.Utils;
using FinalProject.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace FinalProject.Frontend.UserControls
{
    public partial class UserControlAddCar : UserControl
    {
        private BindingList<Car> am;
        private FormMain form;  
        private static int capacity = FileUtils.LoadCapacityFromFile();
        private static UserInputValidator userInputValidator;

        public UserControlAddCar(BindingList<Car> am, FormMain form)
        {
            InitializeComponent();
            carsBrand.DataSource = Enum.GetValues(typeof(eAMbrand));
            carsColor.DataSource = Enum.GetValues(typeof(eColors));
            automobileType.DataSource = Enum.GetValues(typeof(eAutomobiles));
            this.am = am;
            this.form = form;
            carsColor.DropDownStyle = ComboBoxStyle.DropDownList;
            carsBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            automobileType.DropDownStyle = ComboBoxStyle.DropDownList;

            // Attach the FormClosing event handler to the form
            form.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileUtils.SaveCapacityToFile(capacity);
        }

        private void SaveCapacity(object sender, FormClosingEventArgs e)
        {
            FileUtils.SaveCapacityToFile(capacity);
        }

        public UserControlAddCar()
        {
        }
        public UserControlAddCar(FormMain form)
        {
            InitializeComponent();
            carsColor.DropDownStyle = ComboBoxStyle.DropDownList;
            carsBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            automobileType.DropDownStyle= ComboBoxStyle.DropDownList;
            this.form = form;
        }


        private void ButtonClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
      
        private void UpdateCapacity()
        {
            int newCapacity = int.Parse(form.CapacityLabelText) - 1;
            form.DecCapacity(newCapacity);
            capacity= newCapacity;
        }

        private void fillMatrix(Automobiles vehicle)
        {

            for (int i = 0; i < 12; i++)
            {
                if (form.parkingMatrix[i].Image == null)  // Check if the picture box is not already visible
                {
                    string imagePath = GetImagePathForColor(vehicle.Color, vehicle.Type); // Get the appropriate image path based on color
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        form.parkingMatrix[i].Image = Image.FromFile(imagePath);
                        form.parkingDetails[i] = imagePath;
                        form.parkingVehIds[i] = vehicle.LicensePlate;
                        form.parkingMatrix[i].Tag = vehicle.LicensePlate;
                        form.parkingMatrix[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        if (form.GVcomboValue() == "Visually")
                        {
                            form.parkingMatrix[i].BringToFront();
                            form.parkingMatrix[i].Visible = true;
                        }
                        break; // Exit the loop after finding the first empty slot
                    }
                }
            }
            FileUtils.SaveParkingVehIdsToFile(form.parkingVehIds);
            FileUtils.SaveParkingDetailsToFile(form.parkingDetails);
        }

        private string GetImagePathForColor(string color, string type)
        {
            string projectFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string imageFolderPath = Path.Combine(projectFolderPath, "Resources", "VehiclesPics");

            if (type == "Car")
            {
                switch (color.ToLower()) // Convert the color value to lowercase
                {
                    case "black":
                        return Path.Combine(imageFolderPath, "BlackVehicles", "BlackCar.png");
                    case "white":
                        return Path.Combine(imageFolderPath, "WhiteVehicles", "WhiteCar.png");
                    case "red":
                        return Path.Combine(imageFolderPath, "RedVehicles", "RedCar.png");
                    default:
                        return string.Empty; // Return empty string if color is not recognized
                }
            }
            else
            {
                switch (color.ToLower()) // Convert the color value to lowercase
                {
                    case "black":
                        return Path.Combine(imageFolderPath, "BlackVehicles", "BlackVan.png");
                    case "white":
                        return Path.Combine(imageFolderPath, "WhiteVehicles", "WhiteVan.png");
                    case "red":
                        return Path.Combine(imageFolderPath, "RedVehicles", "RedVan.png");
                    default:
                        return string.Empty; // Return empty string if color is not recognized
                }
            }
        }
        private bool IsValidVehicleID(string vehicleID) 
        {
            return vehicleID.Length >= 7 && vehicleID.Length <= 8 && !vehicleID.Any(char.IsLetter);
        }

        private bool IsValidOwnerName(string ownerName)
        {
            return !ownerName.Any(char.IsDigit);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string ownerName = carOwner.Text;
            string carID = carsID.Text;
            string amType = automobileType.SelectedItem.ToString();
            string color = carsColor.SelectedItem.ToString();
            string brand = carsBrand.SelectedItem.ToString();
            string VHtype = "Automobile";
            userInputValidator = new UserInputValidator(automobileType, carsID, carsColor, carsBrand, carOwner);

            if (string.IsNullOrWhiteSpace(ownerName) || string.IsNullOrWhiteSpace(carID)) // Check if owner name or license plate is empty
            {
                MessageBox.Show("Please fill in the owner name and license plate fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (VehicleManager.IsIdExist(carID))
            {
                MessageBox.Show("The license plate already exists.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidVehicleID(carID) && !IsValidOwnerName(ownerName)) // If both wrong
            {
                MessageBox.Show("The license plate should only consist numbers, and owner name should only contain letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidVehicleID(carID)) // Check if the license plate is valid
            {
                MessageBox.Show("Invalid license plate. Please enter a valid license plate with 7 to 8 numbers and no letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidOwnerName(ownerName)) // Check if the owner name is valid
            {
                MessageBox.Show("Invalid owner name. Please enter a valid name without numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userInputValidator.ValidateInput() && ownerName.Length != 0)
            {
                Car car = new Car(carID, VHtype, ownerName, color, DateTime.Now, amType, brand);
                int cap = int.Parse(form.CapacityLabelText);
                if (cap <= 0)
                {
                    MessageBox.Show("The parking is at full capacity", "Parking Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    VehicleManager.AddVehicle(car);
                    am.Add(car);
                    fillMatrix(car);
                    UpdateCapacity();
                    form.RefreshDateGridView();
                }
            }
            clearForm();
        }




        private void clearForm()
        {
          
            carsID.Clear();
            carOwner.Clear();
            automobileType.ResetText();
            carsColor.ResetText();
            carsBrand.ResetText();

        }

        private void carOwner_TextChanged(object sender, EventArgs e)
        {

        }
        private void carsBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void carsColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void carsID_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void carBrand_Click(object sender, EventArgs e)
        {

        }
        private void carColor_Click(object sender, EventArgs e)
        {

        }
        private void carID_Click(object sender, EventArgs e)
        {

        }
        private void automobileType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlAddCar_Load(object sender, EventArgs e)
        {

        }
    }
}
