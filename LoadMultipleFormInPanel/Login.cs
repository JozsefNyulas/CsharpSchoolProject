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
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void btnClearFieldsLogin_Click(object sender, EventArgs e)
        {
            txtNameLogin.Text = string.Empty;
            pictureBox.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            
        }

        private void txtPasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public async Task<Patient> foundSearch(string nev)
        {
            pictureBox.Visible = true;
            await System.Threading.Tasks.Task.Delay(2000);
            var db = new PatientManagement();

            Patient temp = db.getPatient(nev);
           
            return temp;

        }
        private async void btnConfirmBmi_Click(object sender, EventArgs e)
        {
            string search = txtNameLogin.Text;
            Patient temp = await foundSearch(search);
            pictureBox.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(temp.PatientName, temp.PatientResults);

            labelFinalResult.Text = temp.PatientResults;

            
        }
    }
}
