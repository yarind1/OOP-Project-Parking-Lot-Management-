using FinalProject.Backend;
using FinalProject.Backend.Model;
using FinalProject.Backend.Utils;
using FinalProject.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject.Frontend.UserControls
{
    public partial class UserControladdMotor : UserControl
    {
        private BindingList<Motorcycle> motor;
        private FormMain form;
        private static int capacity = FileUtils.LoadCapacityFromFile();
        private static UserInputValidator userInputValidator;
        public UserControladdMotor(BindingList<Motorcycle> motor,FormMain form)
        {
            InitializeComponent();
            MotorBrand.DataSource = Enum.GetValues(typeof(eAMbrand));
            MotorColor.DataSource = Enum.GetValues(typeof(eColors));
            this.motor = motor;
            this.form = form;
            MotorColor.DropDownStyle = ComboBoxStyle.DropDownList;
            MotorBrand.DropDownStyle = ComboBoxStyle.DropDownList;
          


        }

        public UserControladdMotor()
        {
        }

        private void UpdateCapacity()
        {
            int newCapacity = int.Parse(form.CapacityLabelText) - 1;
            form.DecCapacity(newCapacity);
            capacity = newCapacity;
           
        }
        internal static void SaveCapacity(object sender, FormClosingEventArgs e)
        {
            FileUtils.SaveCapacityToFile(capacity);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void fillMatrix(Motorcycle motor)
        {
            for (int i = 0; i < 12; i++)
            {
                if (form.parkingMatrix[i].Image == null)  // Check if the picture box is not already visible
                {
                    string imagePath = GetImagePathForColor(motor.Color); // Get the appropriate image path based on color
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        form.parkingMatrix[i].Tag = MotorID;
                        form.parkingMatrix[i].Image = Image.FromFile(imagePath);
                        form.parkingDetails[i] = imagePath;
                        form.parkingVehIds[i] = motor.LicensePlate;
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
        }

        private string GetImagePathForColor(string color)
        {
            string projectFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string imageFolderPath = Path.Combine(projectFolderPath, "Resources", "VehiclesPics");

            switch (color.ToLower())
            {
                case "black":
                    return Path.Combine(imageFolderPath, "BlackVehicles", "BlackMotor.png");
                case "white":
                    return Path.Combine(imageFolderPath, "WhiteVehicles", "WhiteMotor.png");
                case "red":
                    return Path.Combine(imageFolderPath, "RedVehicles", "RedMotor.png");
                default:
                    return string.Empty; // Return empty string if color is not recognized
            }
        }

        private bool IsValidMotorID(string motorID)
        {
            return motorID.Length >= 7 && motorID.Length <= 8 && !motorID.Any(char.IsLetter);
        }

        private bool IsValidMotorOwnerName(string ownerName)
        {
            return !ownerName.Any(char.IsDigit);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string ownerName = MotorOwner.Text;
            string motorID = MotorID.Text;
            string color = MotorColor.SelectedItem.ToString();
            string brand = MotorBrand.SelectedItem.ToString();
            string VHtype = "Motorcycle";
            userInputValidator = new UserInputValidator(MotorOwner, MotorColor, MotorBrand, MotorOwner);

            if (string.IsNullOrWhiteSpace(ownerName) || string.IsNullOrWhiteSpace(motorID)) // Check if owner name or motor ID is empty
            {
                MessageBox.Show("Please fill in the owner name and license plate fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidMotorID(motorID) && !IsValidMotorOwnerName(ownerName)) // If both wrong
            {
                MessageBox.Show("The license plate should only consist of numbers, and owner name should only contain letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidMotorID(motorID)) // Check if the license plate is valid
            {
                MessageBox.Show("Invalid license plate. Please enter a valid license plate with 7 to 8 numbers and no letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidMotorOwnerName(ownerName)) // Check if the owner name is valid
            {
                MessageBox.Show("Invalid owner name. Please enter a valid name without numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (userInputValidator.ValidateInput()&& ownerName.Length != 0&&motorID.Length!=0)
            {
                Motorcycle mtr = new Motorcycle(motorID, VHtype, ownerName, color, DateTime.Now, brand);
                int cap = int.Parse(form.CapacityLabelText);
                if (cap <= 0)
                {
                    MessageBox.Show("The parking is at full capacity", "Parking Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    motor.Clear();
                    VehicleManager.AddVehicle(mtr);
                    motor.Add(mtr);
                    fillMatrix(mtr);
                    UpdateCapacity();
                    form.RefreshDateGridView();
                }
            }
            clearForm();
        }
        private void clearForm()
        {
            //  FormMain FormMain = new FormMain();
            MotorID.Clear();
            MotorOwner.Clear();
            MotorColor.ResetText();
            MotorBrand.ResetText();

        }

        private void UserControladdMotor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carColor_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
