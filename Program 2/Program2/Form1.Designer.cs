namespace Program2
{
    partial class InsurancePolicyCalculator
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
            this.Tittle = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ValueCarLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.CarInsuranceLabel = new System.Windows.Forms.Label();
            this.CalBut = new System.Windows.Forms.Button();
            this.smokeYes = new System.Windows.Forms.RadioButton();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.carValueBox = new System.Windows.Forms.TextBox();
            this.healthInsurBox = new System.Windows.Forms.ComboBox();
            this.carInsurBox = new System.Windows.Forms.ComboBox();
            this.smokeNo = new System.Windows.Forms.RadioButton();
            this.accidentYes = new System.Windows.Forms.RadioButton();
            this.accidentNo = new System.Windows.Forms.RadioButton();
            this.smokeLabel = new System.Windows.Forms.Label();
            this.accidentLabel = new System.Windows.Forms.Label();
            this.HealthCovLabel = new System.Windows.Forms.Label();
            this.CarCovLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.healthCost = new System.Windows.Forms.Label();
            this.carCost = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.smokingGroup = new System.Windows.Forms.GroupBox();
            this.accidentGroup = new System.Windows.Forms.GroupBox();
            this.smokingGroup.SuspendLayout();
            this.accidentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Location = new System.Drawing.Point(67, 9);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(176, 13);
            this.Tittle.TabIndex = 0;
            this.Tittle.Text = "Cardinal Insurance Policy Calculator";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(34, 35);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(85, 13);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "Enter Your Age: ";
            // 
            // ValueCarLabel
            // 
            this.ValueCarLabel.AutoSize = true;
            this.ValueCarLabel.Location = new System.Drawing.Point(34, 73);
            this.ValueCarLabel.Name = "ValueCarLabel";
            this.ValueCarLabel.Size = new System.Drawing.Size(120, 13);
            this.ValueCarLabel.TabIndex = 2;
            this.ValueCarLabel.Text = "Estimated Value of Car: ";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Location = new System.Drawing.Point(34, 108);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(143, 13);
            this.HealthLabel.TabIndex = 3;
            this.HealthLabel.Text = "Health Insurance Coverage: ";
            // 
            // CarInsuranceLabel
            // 
            this.CarInsuranceLabel.AutoSize = true;
            this.CarInsuranceLabel.Location = new System.Drawing.Point(34, 150);
            this.CarInsuranceLabel.Name = "CarInsuranceLabel";
            this.CarInsuranceLabel.Size = new System.Drawing.Size(128, 13);
            this.CarInsuranceLabel.TabIndex = 4;
            this.CarInsuranceLabel.Text = "Car Insurance Coverage: ";
            // 
            // CalBut
            // 
            this.CalBut.Location = new System.Drawing.Point(70, 299);
            this.CalBut.Name = "CalBut";
            this.CalBut.Size = new System.Drawing.Size(158, 23);
            this.CalBut.TabIndex = 5;
            this.CalBut.Text = "Calcualte Policy Premiums";
            this.CalBut.UseVisualStyleBackColor = true;
            this.CalBut.Click += new System.EventHandler(this.CalBut_Click);
            // 
            // smokeYes
            // 
            this.smokeYes.AutoSize = true;
            this.smokeYes.Location = new System.Drawing.Point(180, 12);
            this.smokeYes.Name = "smokeYes";
            this.smokeYes.Size = new System.Drawing.Size(43, 17);
            this.smokeYes.TabIndex = 6;
            this.smokeYes.TabStop = true;
            this.smokeYes.Text = "Yes\r\n";
            this.smokeYes.UseVisualStyleBackColor = true;
            this.smokeYes.CheckedChanged += new System.EventHandler(this.smokeYes_CheckedChanged);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(205, 32);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(88, 20);
            this.ageBox.TabIndex = 7;
            this.ageBox.TextChanged += new System.EventHandler(this.ageBox_TextChanged);
            // 
            // carValueBox
            // 
            this.carValueBox.Location = new System.Drawing.Point(205, 66);
            this.carValueBox.Name = "carValueBox";
            this.carValueBox.Size = new System.Drawing.Size(88, 20);
            this.carValueBox.TabIndex = 8;
            this.carValueBox.TextChanged += new System.EventHandler(this.carValueBox_TextChanged);
            // 
            // healthInsurBox
            // 
            this.healthInsurBox.FormattingEnabled = true;
            this.healthInsurBox.Items.AddRange(new object[] {
            "Medical",
            "Dental",
            "Vision"});
            this.healthInsurBox.Location = new System.Drawing.Point(205, 105);
            this.healthInsurBox.Name = "healthInsurBox";
            this.healthInsurBox.Size = new System.Drawing.Size(88, 21);
            this.healthInsurBox.TabIndex = 9;
            this.healthInsurBox.SelectedIndexChanged += new System.EventHandler(this.healthInsurBox_SelectedIndexChanged);
            // 
            // carInsurBox
            // 
            this.carInsurBox.FormattingEnabled = true;
            this.carInsurBox.Items.AddRange(new object[] {
            "Full",
            "Liability"});
            this.carInsurBox.Location = new System.Drawing.Point(205, 142);
            this.carInsurBox.Name = "carInsurBox";
            this.carInsurBox.Size = new System.Drawing.Size(88, 21);
            this.carInsurBox.TabIndex = 10;
            this.carInsurBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // smokeNo
            // 
            this.smokeNo.AutoSize = true;
            this.smokeNo.Location = new System.Drawing.Point(180, 37);
            this.smokeNo.Name = "smokeNo";
            this.smokeNo.Size = new System.Drawing.Size(39, 17);
            this.smokeNo.TabIndex = 11;
            this.smokeNo.TabStop = true;
            this.smokeNo.Text = "No";
            this.smokeNo.UseVisualStyleBackColor = true;
            this.smokeNo.CheckedChanged += new System.EventHandler(this.smokeNo_CheckedChanged);
            // 
            // accidentYes
            // 
            this.accidentYes.AutoSize = true;
            this.accidentYes.Location = new System.Drawing.Point(180, 14);
            this.accidentYes.Name = "accidentYes";
            this.accidentYes.Size = new System.Drawing.Size(43, 17);
            this.accidentYes.TabIndex = 12;
            this.accidentYes.TabStop = true;
            this.accidentYes.Text = "Yes";
            this.accidentYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accidentYes.UseVisualStyleBackColor = true;
            this.accidentYes.CheckedChanged += new System.EventHandler(this.accidentYes_CheckedChanged);
            // 
            // accidentNo
            // 
            this.accidentNo.AutoSize = true;
            this.accidentNo.Location = new System.Drawing.Point(180, 37);
            this.accidentNo.Name = "accidentNo";
            this.accidentNo.Size = new System.Drawing.Size(39, 17);
            this.accidentNo.TabIndex = 13;
            this.accidentNo.TabStop = true;
            this.accidentNo.Text = "No";
            this.accidentNo.UseVisualStyleBackColor = true;
            this.accidentNo.CheckedChanged += new System.EventHandler(this.accidentNo_CheckedChanged);
            // 
            // smokeLabel
            // 
            this.smokeLabel.AutoSize = true;
            this.smokeLabel.Location = new System.Drawing.Point(6, 16);
            this.smokeLabel.Name = "smokeLabel";
            this.smokeLabel.Size = new System.Drawing.Size(85, 13);
            this.smokeLabel.TabIndex = 14;
            this.smokeLabel.Text = "Do You Smoke?";
            this.smokeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // accidentLabel
            // 
            this.accidentLabel.AutoSize = true;
            this.accidentLabel.Location = new System.Drawing.Point(6, 16);
            this.accidentLabel.Name = "accidentLabel";
            this.accidentLabel.Size = new System.Drawing.Size(152, 13);
            this.accidentLabel.TabIndex = 15;
            this.accidentLabel.Text = "Car Accident in the Past Year?";
            // 
            // HealthCovLabel
            // 
            this.HealthCovLabel.AutoSize = true;
            this.HealthCovLabel.Location = new System.Drawing.Point(17, 325);
            this.HealthCovLabel.Name = "HealthCovLabel";
            this.HealthCovLabel.Size = new System.Drawing.Size(160, 13);
            this.HealthCovLabel.TabIndex = 16;
            this.HealthCovLabel.Text = "Health Coverage Cost per Year: ";
            // 
            // CarCovLabel
            // 
            this.CarCovLabel.AutoSize = true;
            this.CarCovLabel.Location = new System.Drawing.Point(32, 351);
            this.CarCovLabel.Name = "CarCovLabel";
            this.CarCovLabel.Size = new System.Drawing.Size(145, 13);
            this.CarCovLabel.TabIndex = 17;
            this.CarCovLabel.Text = "Car Coverage Cost per Year: ";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(42, 377);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(135, 13);
            this.TotalCostLabel.TabIndex = 18;
            this.TotalCostLabel.Text = "Total Policy Cost per Year: ";
            // 
            // healthCost
            // 
            this.healthCost.AutoSize = true;
            this.healthCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthCost.Location = new System.Drawing.Point(193, 325);
            this.healthCost.MinimumSize = new System.Drawing.Size(100, 10);
            this.healthCost.Name = "healthCost";
            this.healthCost.Size = new System.Drawing.Size(100, 15);
            this.healthCost.TabIndex = 19;
            this.healthCost.Click += new System.EventHandler(this.healthCost_Click);
            // 
            // carCost
            // 
            this.carCost.AutoSize = true;
            this.carCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carCost.Location = new System.Drawing.Point(193, 351);
            this.carCost.MinimumSize = new System.Drawing.Size(100, 10);
            this.carCost.Name = "carCost";
            this.carCost.Size = new System.Drawing.Size(100, 15);
            this.carCost.TabIndex = 20;
            this.carCost.Click += new System.EventHandler(this.carCost_Click);
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCost.Location = new System.Drawing.Point(193, 377);
            this.totalCost.MinimumSize = new System.Drawing.Size(100, 10);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(100, 15);
            this.totalCost.TabIndex = 21;
            this.totalCost.Click += new System.EventHandler(this.totalCost_Click);
            // 
            // smokingGroup
            // 
            this.smokingGroup.Controls.Add(this.smokeLabel);
            this.smokingGroup.Controls.Add(this.smokeYes);
            this.smokingGroup.Controls.Add(this.smokeNo);
            this.smokingGroup.Location = new System.Drawing.Point(37, 170);
            this.smokingGroup.Name = "smokingGroup";
            this.smokingGroup.Size = new System.Drawing.Size(256, 59);
            this.smokingGroup.TabIndex = 22;
            this.smokingGroup.TabStop = false;
            this.smokingGroup.Text = "groupBox1";
            // 
            // accidentGroup
            // 
            this.accidentGroup.Controls.Add(this.accidentLabel);
            this.accidentGroup.Controls.Add(this.accidentYes);
            this.accidentGroup.Controls.Add(this.accidentNo);
            this.accidentGroup.Location = new System.Drawing.Point(37, 235);
            this.accidentGroup.Name = "accidentGroup";
            this.accidentGroup.Size = new System.Drawing.Size(256, 58);
            this.accidentGroup.TabIndex = 23;
            this.accidentGroup.TabStop = false;
            this.accidentGroup.Text = "groupBox2";
            // 
            // InsurancePolicyCalculator
            // 
            this.AcceptButton = this.CalBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 541);
            this.Controls.Add(this.accidentGroup);
            this.Controls.Add(this.smokingGroup);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.carCost);
            this.Controls.Add(this.healthCost);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.CarCovLabel);
            this.Controls.Add(this.HealthCovLabel);
            this.Controls.Add(this.carInsurBox);
            this.Controls.Add(this.healthInsurBox);
            this.Controls.Add(this.carValueBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.CalBut);
            this.Controls.Add(this.CarInsuranceLabel);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.ValueCarLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.Tittle);
            this.Name = "InsurancePolicyCalculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InsurancePolicyCalculator_Load);
            this.smokingGroup.ResumeLayout(false);
            this.smokingGroup.PerformLayout();
            this.accidentGroup.ResumeLayout(false);
            this.accidentGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label ValueCarLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label CarInsuranceLabel;
        private System.Windows.Forms.Button CalBut;
        private System.Windows.Forms.RadioButton smokeYes;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox carValueBox;
        private System.Windows.Forms.ComboBox healthInsurBox;
        private System.Windows.Forms.ComboBox carInsurBox;
        private System.Windows.Forms.RadioButton smokeNo;
        private System.Windows.Forms.RadioButton accidentYes;
        private System.Windows.Forms.RadioButton accidentNo;
        private System.Windows.Forms.Label smokeLabel;
        private System.Windows.Forms.Label accidentLabel;
        private System.Windows.Forms.Label HealthCovLabel;
        private System.Windows.Forms.Label CarCovLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label healthCost;
        private System.Windows.Forms.Label carCost;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.GroupBox smokingGroup;
        private System.Windows.Forms.GroupBox accidentGroup;
    }
}

