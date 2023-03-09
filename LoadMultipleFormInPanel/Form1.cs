using Adatbazis;

namespace LoadMultipleFormInPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void loadForm(object form)
        {
            panelMain.Controls.Clear();

            Form frm = form as Form;

            frm.TopLevel = false;
            frm.Dock= DockStyle.Fill;

            panelMain.Controls.Add(frm);
            
            panelMain.Tag = frm;
            frm.Show();

        }

      

        private void btnBmi_Click(object sender, EventArgs e)
        {
            loadForm(new BmiForm());
        }

        private void btnOptometry_Click(object sender, EventArgs e)
        {
            loadForm(new OptometryForm());
        }


        private void btnResults_Click(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm();

            string finalResult = "Results: "
                + "\nBody Mass Index is : " + BmiForm.bmiResult.ToString()
                + "\n Hearing: " + HearingForm.hearingResult.ToString()
                + "\nBlood pressure is: " + Cardiology.cardioResult.ToString()
                + "\nEye checkup: " + OptometryForm.optometryResult.ToString();


            resultsForm.labelResults.Text = finalResult;

            var managePatient = new PatientManagement();

            managePatient.addResult(finalResult);
            
            



            loadForm(resultsForm);

            
            
        }

        private void btnHearing_Click(object sender, EventArgs e)
        {
            loadForm(new HearingForm());
        }

        private void btnCardiology_Click(object sender, EventArgs e)
        {
            loadForm(new Cardiology());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            loadForm(new Register());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loadForm(new Login());
        }
    }
}