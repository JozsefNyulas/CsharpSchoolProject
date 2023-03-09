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
    public partial class BmiForm : Form
    {
        public static string bmiResult = "";

        public BmiForm()
        {
            InitializeComponent();
        }

        private void BmiForm_Load(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmBmi_Click(object sender, EventArgs e)
        {

            double height = double.Parse(txtHeight.Text);
            double weight = double.Parse(textWeight.Text);

            double bmi = (weight / height / height) * 1000;

            textWeight.Visible= false;
            txtHeight.Visible= false;
            labelHeight.Visible= false;
            labelWeight.Visible= false;

           

            if (bmi < 18.5)
            {
                bmiResult = "underweight";
            }
            else if (bmi > 18.5 && bmi < 24.9)
            {
                bmiResult = "normal weight";
            }
            else if (bmi > 25 && bmi < 29.9)
            {
                bmiResult = "overweight";
            }
            else
            {
                bmiResult = "obesity";
            }


            labelShowUp.Text = "Your Bmi is in the: " + bmiResult + " range";
           
            labelShowUp.Visible = true;
        }
    }
}
