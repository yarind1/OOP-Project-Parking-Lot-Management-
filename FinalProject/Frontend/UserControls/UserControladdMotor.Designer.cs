namespace FinalProject.Frontend.UserControls
{
    partial class UserControladdMotor
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
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.MotorOwner = new System.Windows.Forms.TextBox();
            this.MotorBrand = new System.Windows.Forms.ComboBox();
            this.MotorColor = new System.Windows.Forms.ComboBox();
            this.MotorID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.carBrand = new System.Windows.Forms.Label();
            this.carColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(151, 208);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 20);
            this.ButtonAdd.TabIndex = 33;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonClear.Location = new System.Drawing.Point(48, 208);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 20);
            this.ButtonClear.TabIndex = 32;
            this.ButtonClear.Text = "CLEAR";
            this.ButtonClear.UseVisualStyleBackColor = true;
            // 
            // MotorOwner
            // 
            this.MotorOwner.Location = new System.Drawing.Point(136, 163);
            this.MotorOwner.Name = "MotorOwner";
            this.MotorOwner.Size = new System.Drawing.Size(121, 20);
            this.MotorOwner.TabIndex = 31;
            // 
            // MotorBrand
            // 
            this.MotorBrand.FormattingEnabled = true;
            this.MotorBrand.Location = new System.Drawing.Point(136, 120);
            this.MotorBrand.Name = "MotorBrand";
            this.MotorBrand.Size = new System.Drawing.Size(121, 21);
            this.MotorBrand.TabIndex = 30;
            // 
            // MotorColor
            // 
            this.MotorColor.FormattingEnabled = true;
            this.MotorColor.Location = new System.Drawing.Point(136, 78);
            this.MotorColor.Name = "MotorColor";
            this.MotorColor.Size = new System.Drawing.Size(121, 21);
            this.MotorColor.TabIndex = 29;
            // 
            // MotorID
            // 
            this.MotorID.Location = new System.Drawing.Point(136, 33);
            this.MotorID.Name = "MotorID";
            this.MotorID.Size = new System.Drawing.Size(121, 20);
            this.MotorID.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "OWNER\'S NAME";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // carBrand
            // 
            this.carBrand.AutoSize = true;
            this.carBrand.BackColor = System.Drawing.Color.Gold;
            this.carBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carBrand.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBrand.ForeColor = System.Drawing.Color.Black;
            this.carBrand.Location = new System.Drawing.Point(0, 122);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(125, 17);
            this.carBrand.TabIndex = 26;
            this.carBrand.Text = "MOTORCYCLE BRAND";
            // 
            // carColor
            // 
            this.carColor.AutoSize = true;
            this.carColor.BackColor = System.Drawing.Color.Gold;
            this.carColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carColor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carColor.ForeColor = System.Drawing.Color.Black;
            this.carColor.Location = new System.Drawing.Point(0, 78);
            this.carColor.Name = "carColor";
            this.carColor.Size = new System.Drawing.Size(133, 18);
            this.carColor.TabIndex = 25;
            this.carColor.Text = "MOTORCYCLE COLOR";
            this.carColor.Click += new System.EventHandler(this.carColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "LICENSE PLATE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControladdMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.MotorOwner);
            this.Controls.Add(this.MotorBrand);
            this.Controls.Add(this.MotorColor);
            this.Controls.Add(this.MotorID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.label1);
            this.Name = "UserControladdMotor";
            this.Size = new System.Drawing.Size(271, 251);
            this.Load += new System.EventHandler(this.UserControladdMotor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.TextBox MotorOwner;
        private System.Windows.Forms.ComboBox MotorBrand;
        private System.Windows.Forms.ComboBox MotorColor;
        private System.Windows.Forms.TextBox MotorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label carBrand;
        private System.Windows.Forms.Label carColor;
        private System.Windows.Forms.Label label1;
    }
}
