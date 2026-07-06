using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmDoctor : Form
    {
        DoctorManager DoctorManager = new DoctorManager();

        public FrmDoctor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] errors = DoctorManager.Validation(
                firstName: txtName.Text,
                lastName: txtLastName.Text,
                medicalCouncilNumber: txtMedicalCouncilNumber.Text
            );

            if (errors.Length > 0)
            {
                MessageBox.Show(
                    errors[0],
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            Doctor Doctor = new Doctor();
            Doctor.FirstName = txtName.Text;
            Doctor.LastName = txtLastName.Text;
            Doctor.MedicalCouncilNumber = txtMedicalCouncilNumber.Text;
            Doctor.Specialties = richTextBox1.Text.Split('\n');

            DoctorManager.AddDoctor(Doctor);
        }
    }
}
