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
    public partial class FrmDoctors : Form
    {
        public FrmDoctors()
        {
            InitializeComponent();
        }

        private void FrmDoctors_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddPatient frm = new FrmAddPatient();

            frm.ShowDialog();
            PatientManager PatientManager = new PatientManager();
            dgvPatient.DataSource = PatientManager.GetPatients().ToList();
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var p = new Patient();

            if (e.ColumnIndex == dgvPatient.Columns["ColDelete"].Index)
                MessageBox.Show(e.RowIndex.ToString());
        }
    }
}
