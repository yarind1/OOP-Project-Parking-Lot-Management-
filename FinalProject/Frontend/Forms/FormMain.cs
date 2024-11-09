using FinalProject.Backend.Model;
using FinalProject.Backend.Utils;
using FinalProject.enums;
using FinalProject.Frontend;
using FinalProject.Frontend.UserControls;
using FinalProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{

    public partial class FormMain : Form
    {
        private string filePath;
        public PictureBox[] parkingMatrix;
        public string[] parkingDetails;
        public string[] parkingVehIds;
        private Point initialPosition;


        public FormMain()
        {
            SettingParking();
            InitializeComponent();

            vehTypeComb.DataSource = Enum.GetValues(typeof(eVehicleType));
            GVcombo.DataSource = Enum.GetValues(typeof(eGraphicViews));
            this.FormClosing += new FormClosingEventHandler(VehicleManager.SaveVehicles);
            this.FormClosing += FormMain_FormClosing;
            UserControlAddCar userControlAddCar = new UserControlAddCar(this);
            panelAddCar.Controls.Add(userControlAddCar);
            FillMatrix();

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileUtils.SaveCapacityToFile(int.Parse(capacity.Text));
            FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
            FileUtils.SaveParkingDetailsToFile(parkingDetails);
           //ResetParking(); // Used for de-bugging

        }
        private void CreateControls()
        {
            UserControlAddCar userControl = new UserControlAddCar(this);

        }

        private async Task DriveAwayTop(PictureBox carPictureBox)
        {
            // Store the initial position
            initialPosition = carPictureBox.Location;
            int startPositionY = carPictureBox.Top;
            int endPositionY = ParkingBackground.Height - carPictureBox.Height; // Adjust based on the parking lot height

            int totalDistance = endPositionY - startPositionY;
            int movementSpeed = 13; // Adjust the movement speed as needed
            int delayBetweenMovements = 30; // Adjust the delay between movements as needed

            // Calculate the number of steps needed for smooth movement
            int numSteps = totalDistance / movementSpeed;

            // Calculate the distance to move in each step
            int distancePerStep = totalDistance / numSteps;

            // Move the car vertically from its current position to the end position
            for (int i = 0; i < numSteps; i++)
            {
                carPictureBox.Top -= distancePerStep;
                await Task.Delay(delayBetweenMovements);
            }

            // Reset the position to the end position
            carPictureBox.Top = endPositionY;

            // Hide or remove the car PictureBox after it has left the parking lot
            carPictureBox.Visible = false;
        }

        private async Task DriveAwayBottom(PictureBox carPictureBox)
        {
            // Store the initial position
            initialPosition = carPictureBox.Location;
            int startPositionY = carPictureBox.Top;
            int endPositionY = ParkingBackground.Height - carPictureBox.Height; // Adjust based on the parking lot height

            int totalDistance = endPositionY - startPositionY;
            int movementSpeed = 13; // Adjust the movement speed as needed
            int delayBetweenMovements = 30; // Adjust the delay between movements as needed

            // Calculate the number of steps needed for smooth movement
            int numSteps = totalDistance / movementSpeed;

            // Calculate the distance to move in each step
            int distancePerStep = totalDistance / numSteps;

            // Move the car vertically from its current position to the end position
            for (int i = 0; i < numSteps; i++)
            {
                carPictureBox.Top += distancePerStep;
                await Task.Delay(delayBetweenMovements);
            }

            // Reset the position to the end position
            carPictureBox.Top = endPositionY;

            // Hide or remove the car PictureBox after it has left the parking lot
            carPictureBox.Visible = false;
        }


        private void ResetPictureBox(PictureBox carPictureBox)
        {
            // Set the location to the initial position
            carPictureBox.Location = initialPosition;
            carPictureBox.Visible = true;
        }

        public string SelectedComboBoxItem
        {
            get { return vehTypeComb.SelectedItem?.ToString(); }
        }
        public string CapacityLabelText
        {
            get { return capacity.Text; }
            set { capacity.Text = value; }
        }
        public void DecCapacity(int newCapacity)
        {
            capacity.Text = newCapacity.ToString();
        }
        public void ClearComboBox()
        {
            vehTypeComb.Items.Clear();
        }
        private void carColor_Click(object sender, EventArgs e)
        {

        }
        private void vehTypeComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAddCar.Controls.Clear();

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                BindingList<Car> am = VehicleManager.GetSpecificVehicle<Car>();
                dataGridViewAM.DataSource = am;
                panelAddCar.Controls.Add(new UserControlAddCar(am, this));
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                BindingList<Motorcycle> mtc = VehicleManager.GetSpecificVehicle<Motorcycle>();
                dataGridViewAM.DataSource = mtc;
                panelAddCar.Controls.Add(new UserControladdMotor(mtc, this));
            }
        }
        private void userControladdMotor1_Load(object sender, EventArgs e)
        {

        }
        private void userControladdMotor1_Load_1(object sender, EventArgs e)
        {

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            parkingMatrix = new PictureBox[12];
            SettingParking();
            int cap = FileUtils.LoadCapacityFromFile();
            capacity.Text = cap.ToString();
            capacity.BackColor = Color.Gold;
            if (dataGridViewAM.Rows.Count == 0 || int.Parse(capacity.Text) > 12)
            {
                capacity.Text = "12";
                FileUtils.SaveCapacityToFile(12);
            }

            vehTypeComb.DropDownStyle = ComboBoxStyle.DropDownList;
            GVcombo.DropDownStyle = ComboBoxStyle.DropDownList;

            parkingDetails = FileUtils.LoadParkingDetailsFromFile();
            parkingVehIds = FileUtils.LoadParkingVehIdsFromFile();
            LoadPictures();
            LoadIds();

        }

        public void RefreshDateGridView()
        {
            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                BindingList<Car> am = VehicleManager.GetSpecificVehicle<Car>();
                dataGridViewAM.DataSource = am;
                panelAddCar.Controls.Add(new UserControlAddCar(am, this));
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                BindingList<Motorcycle> mtc = VehicleManager.GetSpecificVehicle<Motorcycle>();
                dataGridViewAM.DataSource = mtc;
                panelAddCar.Controls.Add(new UserControladdMotor(mtc, this));
            }
        }
        private void FillMatrix()
        {
            // Create PictureBox controls and assign them to the parkingMatrix array
            parkingMatrix[0] = pictureBox1;
            parkingMatrix[1] = pictureBox2;
            parkingMatrix[2] = pictureBox3;
            parkingMatrix[3] = pictureBox4;
            parkingMatrix[4] = pictureBox5;
            parkingMatrix[5] = pictureBox6;
            parkingMatrix[6] = pictureBox7;
            parkingMatrix[7] = pictureBox8;
            parkingMatrix[8] = pictureBox9;
            parkingMatrix[9] = pictureBox10;
            parkingMatrix[10] = pictureBox11;
            parkingMatrix[11] = pictureBox12;

            // Add Click event handler to each PictureBox
            for (int i = 0; i < 12; i++)
            {
                parkingMatrix[i].Click += PictureBox_Click;
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int index = Array.IndexOf(parkingMatrix, pictureBox);

            if (!string.IsNullOrEmpty(parkingVehIds[index]))
            {
                checkOut(VehicleManager.GetVehicleByID(parkingVehIds[index]));
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(parkingVehIds[index]));
                pictureBox.Image = null;
                pictureBox.Visible = false;

                parkingVehIds[index] = "";
                parkingDetails[index] = "";
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);

                if (vehTypeComb.SelectedItem.ToString() == "Automobile")
                {
                    dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
                }
                else if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
                {
                    dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>();
                }
            }
        }
        private void LoadPictures()
        {
            for (int i = 0; i < parkingMatrix.Length; i++)
            {
                try
                {

                    if (!string.IsNullOrEmpty(this.parkingDetails[i]))
                    {
                        if (GVcombo.SelectedItem.ToString() == "Visually")
                        {
                            this.parkingMatrix[i].Image = Image.FromFile(this.parkingDetails[i]);
                            this.parkingMatrix[i].Visible = true;
                            parkingMatrix[i].SizeMode = PictureBoxSizeMode.StretchImage;
                            parkingMatrix[i].BringToFront();
                        }
                    }

                }
                catch (Exception ex)
                {
                    continue;
                }
            }
        }
        private void LoadIds()
        {
            for (int i = 0; i < parkingVehIds.Length; i++)
            {
                try
                {
                    if (!string.IsNullOrEmpty(this.parkingVehIds[i]))
                    {
                        this.parkingMatrix[i].Tag = this.parkingVehIds[i];
                    }
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
        }
        private void GVcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (GVcombo.SelectedItem.ToString() == "Visually")
            {

                ParkingBackground.Visible = true;
                //for (int i = 0; i < parkingMatrix.Length; i++)
                //{
                //    parkingMatrix[i].Visible = true;
                //    parkingMatrix[i].BringToFront();
                //}
                if (vehTypeComb.SelectedItem.ToString() == "Automobile")
                {
                    dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
                }
                if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
                {
                    dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
                }
                panel2.Invalidate();
                panel2.Update();
                LoadPictures();
            }
            else if (GVcombo.SelectedItem.ToString() == "Table")
            {
                ParkingBackground.Visible = false;
                for (int i = 0; i < 12; i++)
                {
                    if (parkingMatrix[i] != null)
                        this.parkingMatrix[i].Visible = false;
                }
                if (vehTypeComb.SelectedItem.ToString() == "Automobile")
                {
                    dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
                }
                if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
                {
                    dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
                }

            }
        }
        public string GVcomboValue()
        {
            return GVcombo.SelectedItem.ToString();
        }
        private void capacity_Click(object sender, EventArgs e)
        {

        }

        private void IncCapacity()
        {
            int capacityValue = int.Parse(capacity.Text);
            capacityValue++;
            DecCapacity(capacityValue);
        }
        private void checkOut(Vehicle vehicle)
        {
            DateTime now = DateTime.Now;
            double hoursParked = VehicleManager.CalculateHours(vehicle.EntryTime, now);
            double price = VehicleManager.CalculateParkingPrice(vehicle);

            string message = $"Entry Time: {vehicle.EntryTime}\nCurrent Time: {now}\nPrice: {price:C}";

            MessageBox.Show(message, "Parking Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IncCapacity();
        }
        private void dataGridViewAM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAM.Columns[e.ColumnIndex].Name == "LeaveParking")
            {
                if (dataGridViewAM.Rows[e.RowIndex].DataBoundItem is Car car)
                {
                    // Remove the car visually
                    RemoveCarVisually(car);

                    checkOut(car);
                    VehicleManager.RemoveVehicle(car);
                    VehicleManager.SaveVehicles(this, null);
                    dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>(); // Reset the DataSource
                }
                else if (dataGridViewAM.Rows[e.RowIndex].DataBoundItem is Motorcycle motorcycle)
                {
                    // Remove the motorcycle visually
                    RemoveMotorcycleVisually(motorcycle);

                    checkOut(motorcycle);
                    VehicleManager.RemoveVehicle(motorcycle);
                    VehicleManager.SaveVehicles(this, null);
                    dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
                }
            }
        }

        private void RemoveCarVisually(Car car)
        {
            // Find the index of the car in the parkingVehIds array
            int index = Array.IndexOf(this.parkingVehIds, car.LicensePlate);

            if (index != -1)
            {
                // Clear the parking spot visually
                parkingMatrix[index].Image = null;
                parkingMatrix[index].Update();
                parkingMatrix[index].Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[index] = "";
                this.parkingDetails[index] = "";

                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            // Update the data source of the dataGridViewAM
            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            else if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>();
            }
        }

        private void RemoveMotorcycleVisually(Motorcycle motorcycle)
        {
            // Find the index of the motorcycle in the parkingVehIds array
            int index = Array.IndexOf(this.parkingVehIds, motorcycle.LicensePlate);

            if (index != -1)
            {
                // Clear the parking spot visually
                parkingMatrix[index].Image = null;
                parkingMatrix[index].Update();
                parkingMatrix[index].Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[index] = "";
                this.parkingDetails[index] = "";

                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            // Update the data source of the dataGridViewAM
            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            else if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>();
            }
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ResetParking()
        {
            for (int i = 0; i < parkingDetails.Length; i++)
            {
                parkingDetails[i] = "";
                parkingVehIds[i] = "";
            }
            FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
            FileUtils.SaveParkingDetailsToFile(parkingDetails);
        }

        private void SettingParking()
        {
            this.parkingMatrix = new PictureBox[12];

            for (int i = 0; i < 12; i++)
            {
                this.parkingMatrix[i] = new PictureBox();
            }
            // Assign the PictureBox controls to the corresponding elements in the array
            this.parkingMatrix[0] = pictureBox1;
            this.parkingMatrix[1] = pictureBox2;
            this.parkingMatrix[2] = pictureBox3;
            this.parkingMatrix[3] = pictureBox4;
            this.parkingMatrix[4] = pictureBox5;
            this.parkingMatrix[5] = pictureBox6;
            this.parkingMatrix[6] = pictureBox7;
            this.parkingMatrix[7] = pictureBox8;
            this.parkingMatrix[8] = pictureBox9;
            this.parkingMatrix[9] = pictureBox10;
            this.parkingMatrix[10] = pictureBox11;
            this.parkingMatrix[11] = pictureBox12;
        }
        public PictureBox GetPictureBox(int index)
        {
            return this.parkingMatrix[index - 1];
        }
        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox1.Location;
            await DriveAwayTop(pictureBox1);
            if (this.parkingVehIds[0] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[0]));
                parkingMatrix[0].Image = null;
                parkingMatrix[0].Update();

                // Hide the car PictureBox immediately
                pictureBox1.Visible = false;


                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[0] = "";
                this.parkingDetails[0] = "";

                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }
            
            ResetPictureBox(pictureBox1);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[0] = "";
        }


        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox2.Location;
            await DriveAwayTop(pictureBox2);
            if (this.parkingVehIds[1] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[1]));
                parkingMatrix[1].Image = null;
                parkingMatrix[1].Update();
                pictureBox2.Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[1] = "";
                this.parkingDetails[1] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox2);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[1] = "";
        }

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox3.Location;
            await DriveAwayTop(pictureBox3);
            if (this.parkingVehIds[2] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[2]));
                parkingMatrix[2].Image = null;
                parkingMatrix[2].Update();
                pictureBox3.Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[2] = "";
                this.parkingDetails[2] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox3);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[2] = "";
        }

        private async void pictureBox4_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox4.Location;
            await DriveAwayTop(pictureBox4);
            if (this.parkingVehIds[3] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[3]));
                parkingMatrix[3].Image = null;  
                parkingMatrix[3].Update();
                pictureBox4.Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[3] = "";
                this.parkingDetails[3] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox4);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[3] = "";
        }

        private async void pictureBox5_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox5.Location;
            await DriveAwayTop(pictureBox5);
            if (this.parkingVehIds[4] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[4]));
                parkingMatrix[4].Image = null;
                parkingMatrix[4].Update();
                pictureBox5.Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[4] = "";
                this.parkingDetails[4] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox5);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[4] = "";
        }

        private async void pictureBox6_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox6.Location;
            await DriveAwayTop(pictureBox6);
            if (this.parkingVehIds[5] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[5]));
                parkingMatrix[5].Image = null;
                parkingMatrix[5].Update();
                pictureBox6.Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[5] = "";
                this.parkingDetails[5] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox6);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[5] = "";
        }

        private async void pictureBox7_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox7.Location;
            await DriveAwayBottom(pictureBox7);
            if (this.parkingVehIds[6] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[6]));
                parkingMatrix[6].Image = null;
                parkingMatrix[6].Update();
                pictureBox7.Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[4] = "";
                this.parkingDetails[4] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox7);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[6] = "";
        }

        private async void pictureBox8_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox8.Location;
            await DriveAwayBottom(pictureBox8);
            if (this.parkingVehIds[7] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[7]));
                parkingMatrix[7].Image = null;
                parkingMatrix[7].Update();
                pictureBox8.Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[7] = "";
                this.parkingDetails[7] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox8);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[7] = "";
        }

        private async void pictureBox9_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox9.Location;
            await DriveAwayBottom(pictureBox9);
            if (this.parkingVehIds[8] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[8]));
                parkingMatrix[8].Image = null;
                parkingMatrix[8].Update();
                pictureBox9.Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[8] = "";
                this.parkingDetails[8] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox9);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[8] = "";
        }

        private async void pictureBox10_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox10.Location;
            await DriveAwayBottom(pictureBox10);
            if (this.parkingVehIds[9] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[9]));
                parkingMatrix[9].Image = null;
                parkingMatrix[9].Update();
                pictureBox10.Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[9] = "";
                this.parkingDetails[9] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox10);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[9] = "";
        }

        private async void pictureBox11_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox11.Location;
            await DriveAwayBottom(pictureBox11);
            if (this.parkingVehIds[10] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[10]));
                parkingMatrix[10].Image = null;
                parkingMatrix[10].Update();
                pictureBox11.Visible = false;
                    
                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[10] = "";
                this.parkingDetails[10] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox11);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[10] = "";
        }

        private async void pictureBox12_Click(object sender, EventArgs e)
        {
            initialPosition = pictureBox12.Location;
            await DriveAwayBottom(pictureBox12);
            if (this.parkingVehIds[11] != "")
            {
                VehicleManager.RemoveVehicle(VehicleManager.GetVehicleByID(this.parkingVehIds[11]));
                parkingMatrix[11].Image = null;
                parkingMatrix[11].Update();
                pictureBox12.Visible = false;

                // Clear the data in the arrays for the corresponding parking slot
                this.parkingVehIds[11] = "";
                this.parkingDetails[11] = "";
                // Save the updated arrays to file
                FileUtils.SaveParkingVehIdsToFile(parkingVehIds);
                FileUtils.SaveParkingDetailsToFile(parkingDetails);
            }

            ResetPictureBox(pictureBox12);

            if (vehTypeComb.SelectedItem.ToString() == "Automobile")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Car>();
            }
            if (vehTypeComb.SelectedItem.ToString() == "Motorcycles")
            {
                dataGridViewAM.DataSource = VehicleManager.GetSpecificVehicle<Motorcycle>(); // Reset the DataSource
            }
            this.parkingVehIds[11] = "";
        }

        private void panelAddCar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ParkingBackground_Click(object sender, EventArgs e)
        {

        }

        private void vehType_Click(object sender, EventArgs e)
        {

        }

        private void capacitylbl_Click(object sender, EventArgs e)
        {

        }
    }
}
