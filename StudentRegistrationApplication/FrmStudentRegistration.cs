using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class FrmStudentRegistration : Form
    {
        public string fname, lname, mname, gender;
        int day, month, year;
        public FrmStudentRegistration()
        {
            InitializeComponent();
        }

        private void FrmStudentRegistration_Load(object sender, EventArgs e)
        {
            int day, month, year;
            for (day = 1; day <= 31; day++)
            {
                comboBoxDay.Items.Add(day);
            }

            for (month = 1; month <= 12; month++)
            {
                comboBoxMonth.Items.Add(month);
            }

            for (year = 1900; day <= 2021; year++)
            {
                comboBoxYear.Items.Add(day);
            }
            gender = radioButtonMale.Text;
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            
            bool isChecked = radioButtonFemale.Checked;
            if (isChecked)
            {
                gender = radioButtonFemale.Text;
            }
            else
            {
                gender = radioButtonMale.Text;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            lname = textBoxLastName.Text;
            mname = textBoxMiddleName.Text;
            fname = textBoxFirstName.Text;
            day = Convert.ToInt32(comboBoxDay.SelectedItem);
            month = Convert.ToInt32(comboBoxMonth.SelectedItem);
            year = Convert.ToInt32(comboBoxYear.SelectedItem);




            if (textBoxFirstName.Text == "")
            {
                MessageBox.Show("Enter your first name.");
            }
            else if (textBoxLastName.Text == "")
            {
                MessageBox.Show("Enter your last name.");
            }
            else if (day == 0)
            {
                MessageBox.Show("Fill in the day of your birth.");
            }
            else if (month == 0)
            {
                MessageBox.Show("Fill in the month of your birth.");
            }
            else if (year == 0)
            {
                MessageBox.Show("Fill in the year of your birth.");
            }
            else
            {
                MessageBox.Show("Student name: " +
                fname + " " + mname + "" + lname + "\nGender: " + gender
                + "\nDate of Birth: " + day + "/" + month + "/" + year);
            }
        }        
    }
}
