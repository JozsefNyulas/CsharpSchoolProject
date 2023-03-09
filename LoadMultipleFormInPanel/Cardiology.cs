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
    public partial class Cardiology : Form
    {
        public static string cardioResult = "out of bounds";
        public Cardiology()
        {
            InitializeComponent();
        }

        private void Cardiology_Load(object sender, EventArgs e)
        {

        }

        public string bloodPressTest(int sys, int dias)
        {
            // normal blood pressure between 90/60 and  120/80

            

       
            if (sys < 90 || dias < 60) 
            {
                cardioResult = "Low";
            }
            else if (sys > 120 || dias > 80)
            {
                cardioResult = "High";
            }
            else
            {
                cardioResult = "Normal";
            }

            return cardioResult;

        }


        private void btnConfirmCardio_Click(object sender, EventArgs e)
        {
            int systolic = int.Parse(txtSystolic.Text);
            int diastolic = int.Parse(txtDiastolic.Text);

            cardioResult = bloodPressTest(systolic, diastolic);

           // string result = systolic.ToString() + " /" +  diastolic.ToString();

            labelDiastolic.Visible = false;
            txtDiastolic.Visible = false;
            txtSystolic.Visible = false;
            labelSystolic.Visible = false;


            labelShowUpCardio.Text = "Your blood pressure is: " + cardioResult;
            labelShowUpCardio.Visible = true;

        }
    }
}
