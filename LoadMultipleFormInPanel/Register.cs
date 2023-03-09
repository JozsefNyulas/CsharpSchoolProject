using Adatbazis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadMultipleFormInPanel
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_BackgroundImageChanged(object sender, EventArgs e)
        {


        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtNameRegist.Text= string.Empty;
            txtPasswordRegist.Text= string.Empty;
            txtRePassRegist.Text= string.Empty;
        }

        private void btnConfirmBmi_Click(object sender, EventArgs e)
        {

            Patient temp= new Patient
            {
                PatientName= txtNameRegist.Text,
                Password= txtPasswordRegist.Text,
            };

            var managePatient = new PatientManagement();
            managePatient.AddPatient(temp);

            txtNameRegist.Visible=false;
            txtPasswordRegist.Visible = false;
            txtRePassRegist.Visible = false;
            btnClearFields.Visible = false;
            btnRegister.Visible = false;
            labelNameRegist.Visible = false;
            labelPasswordRegist.Visible = false;
            labelPassworRetypeRegist.Visible = false;

            MessageBox.Show("Succesful registration. Click on the checkup you want","Confirmation");


        }
    }
}
