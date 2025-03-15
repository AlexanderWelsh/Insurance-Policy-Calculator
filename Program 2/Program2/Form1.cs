//Program 2
//CIS-199-50
//Due 10/21/2023
//By: A1029
//This program will takes information and selections to output the cost of health and car insurance yearly.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class InsurancePolicyCalculator : Form
    {
        public InsurancePolicyCalculator()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsurancePolicyCalculator_Load(object sender, EventArgs e)
        {

        }

        private void CalBut_Click(object sender, EventArgs e)
        {
            double healthCov = 0;
            double carCov = 0;

            //creates age and carPrice while also parsing them.
            if (int.TryParse(ageBox.Text, out int age) && age > 0)
            {
                if (int.TryParse(carValueBox.Text, out int carPrice) && carPrice > 0)
                {
                    //Ensures the user checked all required boxes
                    if (smokeYes.Checked || smokeNo.Checked)
                    {
                        if (accidentYes.Checked || accidentNo.Checked)
                        {
                            //checks if a health insurance policy is picked
                            if (healthInsurBox.SelectedIndex >= 0)
                            {
                                //Checks for the difference choices of insurence policies
                                if (healthInsurBox.Text == "Medical")
                                {
                                    healthCov = 160 * 12;

                                    //sees if the user smokes and should be charged for it
                                    if (smokeYes.Checked)
                                    {
                                        healthCov += 70 * 12;
                                    }
                                }
                                else if (healthInsurBox.Text == "Dental")
                                {
                                    healthCov = 20 * 12;
                                }
                                else if (healthInsurBox.Text == "Vision")
                                {
                                    healthCov = 30 * 12;
                                }
                            //checks if a health insurance policy is picked
                            if (carInsurBox.SelectedIndex >= 0)
                            {
                                //Beniging of car insurence checks
                                if (carInsurBox.Text == "Full")
                                {
                                    carCov = 110 * 12;
                                }
                                else if (carInsurBox.Text == "Liability")
                                {
                                    carCov = 50 * 12;
                                }

                                if (carPrice < 15000)
                                {
                                    carCov -= (carCov * 0.12);
                                }
                                if (accidentYes.Checked)
                                {
                                    carCov += (carCov * 0.2);
                                }
                                if (age < 21)
                                {
                                    carCov += 25 * 12;
                                }
                            }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select an accident option");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a smoking option");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Car Value Entered.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Age Entered.");
            }

            //Takes the totals and prints it as a string
            healthCost.Text = healthCov.ToString("C2");
            carCost.Text = carCov.ToString("C2");
            totalCost.Text = (healthCov + carCov).ToString("C2");
        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void carValueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void healthInsurBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void smokeYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void smokeNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void accidentYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void accidentNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void healthCost_Click(object sender, EventArgs e)
        {

        }

        private void carCost_Click(object sender, EventArgs e)
        {

        }

        private void totalCost_Click(object sender, EventArgs e)
        {

        }
    }
}
