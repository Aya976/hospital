using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Doctor : Form
    {
        public static HmsContext HmsContext = new HmsContext();
        public Doctor()
        {
            InitializeComponent();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = doctorNameTextBox.Text;
            string gender = GenderComboBox.Text;
            int experience = int.Parse(expTextBox.Text);
            string licenceNumber = licenceTextBox.Text;

            Models.Doctor obj = new Models.Doctor { 
                Name = name,
                YearOfexperience = experience,
                MedicalLicenceNumber = licenceNumber,
                Gender = gender == "MALE"
            };

            HmsContext.Doctors.Add(obj);

            HmsContext.SaveChanges();
        }
    }
}
