namespace FinalProject
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewAM = new System.Windows.Forms.DataGridView();
            this.LeaveParking = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vehType = new System.Windows.Forms.Label();
            this.vehTypeComb = new System.Windows.Forms.ComboBox();
            this.panelAddCar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ParkingBackground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GVcombo = new System.Windows.Forms.ComboBox();
            this.capacitylbl = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAM)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAM
            // 
            this.dataGridViewAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaveParking});
            this.dataGridViewAM.Location = new System.Drawing.Point(20, 19);
            this.dataGridViewAM.Name = "dataGridViewAM";
            this.dataGridViewAM.Size = new System.Drawing.Size(497, 341);
            this.dataGridViewAM.TabIndex = 10;
            this.dataGridViewAM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAM_CellContentClick);
            // 
            // LeaveParking
            // 
            this.LeaveParking.HeaderText = "LeaveParking";
            this.LeaveParking.Name = "LeaveParking";
            this.LeaveParking.Text = "Leave";
            this.LeaveParking.UseColumnTextForButtonValue = true;
            // 
            // vehType
            // 
            this.vehType.AutoSize = true;
            this.vehType.BackColor = System.Drawing.Color.Gold;
            this.vehType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.vehType.ForeColor = System.Drawing.Color.Black;
            this.vehType.Location = new System.Drawing.Point(21, 59);
            this.vehType.Name = "vehType";
            this.vehType.Size = new System.Drawing.Size(84, 18);
            this.vehType.TabIndex = 13;
            this.vehType.Text = "VEHICLE TYPE";
            this.vehType.Click += new System.EventHandler(this.vehType_Click);
            // 
            // vehTypeComb
            // 
            this.vehTypeComb.FormattingEnabled = true;
            this.vehTypeComb.Location = new System.Drawing.Point(146, 59);
            this.vehTypeComb.Name = "vehTypeComb";
            this.vehTypeComb.Size = new System.Drawing.Size(121, 21);
            this.vehTypeComb.TabIndex = 14;
            this.vehTypeComb.SelectedIndexChanged += new System.EventHandler(this.vehTypeComb_SelectedIndexChanged);
            // 
            // panelAddCar
            // 
            this.panelAddCar.BackColor = System.Drawing.Color.Transparent;
            this.panelAddCar.Location = new System.Drawing.Point(9, 82);
            this.panelAddCar.Name = "panelAddCar";
            this.panelAddCar.Size = new System.Drawing.Size(298, 364);
            this.panelAddCar.TabIndex = 15;
            this.panelAddCar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddCar_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ParkingBackground);
            this.panel2.Controls.Add(this.dataGridViewAM);
            this.panel2.Location = new System.Drawing.Point(313, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 388);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(460, 235);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(46, 90);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 21;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Visible = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(372, 235);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(46, 90);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 20;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Visible = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::FinalProject.Properties.Resources.vehicleBackground;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(282, 235);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(46, 90);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Visible = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::FinalProject.Properties.Resources.vehicleBackground;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(194, 235);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(46, 90);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::FinalProject.Properties.Resources.vehicleBackground;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(460, 54);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 90);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::FinalProject.Properties.Resources.vehicleBackground;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(110, 235);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(46, 90);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::FinalProject.Properties.Resources.vehicleBackground;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(20, 235);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 90);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            this.pictureBox5.BackgroundImage = global::FinalProject.Properties.Resources.vehicleBackground;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(372, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            this.pictureBox4.BackgroundImage = global::FinalProject.Properties.Resources.vehicleBackground;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(282, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            this.pictureBox3.BackgroundImage = global::FinalProject.Properties.Resources.vehicleBackground;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(194, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            this.pictureBox2.BackgroundImage = global::FinalProject.Properties.Resources.vehicleBackground;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(110, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.vehicleBackground;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ParkingBackground
            // 
            this.ParkingBackground.BackColor = System.Drawing.Color.DimGray;
            this.ParkingBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParkingBackground.Image = ((System.Drawing.Image)(resources.GetObject("ParkingBackground.Image")));
            this.ParkingBackground.Location = new System.Drawing.Point(0, 3);
            this.ParkingBackground.Name = "ParkingBackground";
            this.ParkingBackground.Size = new System.Drawing.Size(517, 366);
            this.ParkingBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ParkingBackground.TabIndex = 11;
            this.ParkingBackground.TabStop = false;
            this.ParkingBackground.Visible = false;
            this.ParkingBackground.Click += new System.EventHandler(this.ParkingBackground_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(258, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "TABLE\\GRAPHIC";
            // 
            // GVcombo
            // 
            this.GVcombo.FormattingEnabled = true;
            this.GVcombo.Location = new System.Drawing.Point(366, 6);
            this.GVcombo.Name = "GVcombo";
            this.GVcombo.Size = new System.Drawing.Size(88, 21);
            this.GVcombo.TabIndex = 19;
            this.GVcombo.SelectedIndexChanged += new System.EventHandler(this.GVcombo_SelectedIndexChanged);
            // 
            // capacitylbl
            // 
            this.capacitylbl.AutoSize = true;
            this.capacitylbl.BackColor = System.Drawing.Color.Gold;
            this.capacitylbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.capacitylbl.ForeColor = System.Drawing.Color.Black;
            this.capacitylbl.Location = new System.Drawing.Point(502, 11);
            this.capacitylbl.Name = "capacitylbl";
            this.capacitylbl.Size = new System.Drawing.Size(78, 16);
            this.capacitylbl.TabIndex = 20;
            this.capacitylbl.Text = "PLACES LEFT:";
            this.capacitylbl.Click += new System.EventHandler(this.capacitylbl_Click);
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.capacity.Location = new System.Drawing.Point(592, 12);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(0, 15);
            this.capacity.TabIndex = 21;
            this.capacity.Click += new System.EventHandler(this.capacity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(642, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(625, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "/";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Gold;
            this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox13.Location = new System.Drawing.Point(589, 9);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(81, 21);
            this.pictureBox13.TabIndex = 25;
            this.pictureBox13.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            this.BackgroundImage = global::FinalProject.Properties.Resources._2d615ba676ffc86e022cb18b4e83eb33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.capacitylbl);
            this.Controls.Add(this.GVcombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAddCar);
            this.Controls.Add(this.vehTypeComb);
            this.Controls.Add(this.vehType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkingLot";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAM)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAM;
        private System.Windows.Forms.Label vehType;
        private System.Windows.Forms.ComboBox vehTypeComb;
        private System.Windows.Forms.Panel panelAddCar;
        private System.Windows.Forms.Panel panel2;
        private Frontend.UserControls.UserControlAddCar userControlAddCar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GVcombo;
        private System.Windows.Forms.PictureBox ParkingBackground;
        private System.Windows.Forms.Label capacitylbl;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.DataGridViewButtonColumn LeaveParking;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox13;
        //   private System.Windows.Forms.Panel panelAddMotor;
    }
}

