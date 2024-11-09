namespace FinalProject.Frontend.UserControls
{
    partial class UserControlAddCar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.carOwner = new System.Windows.Forms.TextBox();
            this.carsBrand = new System.Windows.Forms.ComboBox();
            this.carsColor = new System.Windows.Forms.ComboBox();
            this.carsID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.carBrand = new System.Windows.Forms.Label();
            this.carColor = new System.Windows.Forms.Label();
            this.carID = new System.Windows.Forms.Label();
            this.automobileType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carOwner
            // 
            this.carOwner.Location = new System.Drawing.Point(146, 192);
            this.carOwner.Name = "carOwner";
            this.carOwner.Size = new System.Drawing.Size(121, 20);
            this.carOwner.TabIndex = 19;
            this.carOwner.TextChanged += new System.EventHandler(this.carOwner_TextChanged);
            // 
            // carsBrand
            // 
            this.carsBrand.FormattingEnabled = true;
            this.carsBrand.Location = new System.Drawing.Point(146, 152);
            this.carsBrand.Name = "carsBrand";
            this.carsBrand.Size = new System.Drawing.Size(121, 21);
            this.carsBrand.TabIndex = 18;
            this.carsBrand.SelectedIndexChanged += new System.EventHandler(this.carsBrand_SelectedIndexChanged);
            // 
            // carsColor
            // 
            this.carsColor.FormattingEnabled = true;
            this.carsColor.Location = new System.Drawing.Point(146, 105);
            this.carsColor.Name = "carsColor";
            this.carsColor.Size = new System.Drawing.Size(121, 21);
            this.carsColor.TabIndex = 17;
            this.carsColor.SelectedIndexChanged += new System.EventHandler(this.carsColor_SelectedIndexChanged);
            // 
            // carsID
            // 
            this.carsID.Location = new System.Drawing.Point(146, 63);
            this.carsID.Name = "carsID";
            this.carsID.Size = new System.Drawing.Size(121, 20);
            this.carsID.TabIndex = 16;
            this.carsID.TextChanged += new System.EventHandler(this.carsID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "OWNER\'S NAME";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // carBrand
            // 
            this.carBrand.AutoSize = true;
            this.carBrand.BackColor = System.Drawing.Color.Gold;
            this.carBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carBrand.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.carBrand.Location = new System.Drawing.Point(12, 153);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(77, 18);
            this.carBrand.TabIndex = 14;
            this.carBrand.Text = "CAR BRAND";
            this.carBrand.Click += new System.EventHandler(this.carBrand_Click);
            // 
            // carColor
            // 
            this.carColor.AutoSize = true;
            this.carColor.BackColor = System.Drawing.Color.Gold;
            this.carColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carColor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.carColor.ForeColor = System.Drawing.Color.Black;
            this.carColor.Location = new System.Drawing.Point(12, 105);
            this.carColor.Name = "carColor";
            this.carColor.Size = new System.Drawing.Size(78, 18);
            this.carColor.TabIndex = 13;
            this.carColor.Text = "CAR COLOR";
            this.carColor.Click += new System.EventHandler(this.carColor_Click);
            // 
            // carID
            // 
            this.carID.AutoSize = true;
            this.carID.BackColor = System.Drawing.Color.Gold;
            this.carID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.carID.Location = new System.Drawing.Point(12, 63);
            this.carID.Name = "carID";
            this.carID.Size = new System.Drawing.Size(90, 18);
            this.carID.TabIndex = 12;
            this.carID.Text = "LICENSE PLATE";
            this.carID.Click += new System.EventHandler(this.carID_Click);
            // 
            // automobileType
            // 
            this.automobileType.FormattingEnabled = true;
            this.automobileType.Location = new System.Drawing.Point(146, 22);
            this.automobileType.Name = "automobileType";
            this.automobileType.Size = new System.Drawing.Size(121, 21);
            this.automobileType.TabIndex = 11;
            this.automobileType.SelectedIndexChanged += new System.EventHandler(this.automobileType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "CHOOSE AUTOMOBILE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(146, 228);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 21;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(49, 228);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 20;
            this.ButtonClear.Text = "CLEAR";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // UserControlAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.carOwner);
            this.Controls.Add(this.carsBrand);
            this.Controls.Add(this.carsColor);
            this.Controls.Add(this.carsID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.carID);
            this.Controls.Add(this.automobileType);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAddCar";
            this.Size = new System.Drawing.Size(291, 266);
            this.Load += new System.EventHandler(this.UserControlAddCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox carOwner;
        private System.Windows.Forms.ComboBox carsBrand;
        private System.Windows.Forms.ComboBox carsColor;
        private System.Windows.Forms.TextBox carsID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label carBrand;
        private System.Windows.Forms.Label carColor;
        private System.Windows.Forms.Label carID;
        private System.Windows.Forms.ComboBox automobileType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonClear;
    }
}
