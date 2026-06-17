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
    public partial class FrmAddBimar : Form
    {
    
        public string FName { get; set; }

        public FrmAddBimar()
        {
            InitializeComponent();
        }


        private void FrmAddBimar_Load(object sender, EventArgs e)
        {
           
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Bimar bimar = new Bimar();
            bimar.FirstName = txtName.Text;
            bimar.LastName = txtLastName.Text;
            bimar.NationalCode = txtNationalCode.Text;
            bimar.MobileNumber = txtMobileNumber.Text;

            BimarManager bimarManager = new BimarManager();
            bimarManager.AddBimar(bimar);
        }


    }
}
