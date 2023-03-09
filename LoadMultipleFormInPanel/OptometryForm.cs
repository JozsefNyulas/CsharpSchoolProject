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
    public partial class OptometryForm : Form
    {
        public static string optometryResult = "";
        public OptometryForm()
        {
            InitializeComponent();
        }

        private void OptometryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmOptometry_Click(object sender, EventArgs e)
        {
            optometryResult = "Your eyesight is healthy";
            pictureBox.Visible = false;
            labelOptometry.Text = optometryResult;
        }

        private void btnNoOptometry_Click(object sender, EventArgs e)
        {
            optometryResult = "You require further eye check. Please see a doctor.";
            pictureBox.Visible = false;
            labelOptometry.Text = optometryResult;
        }
    }
}
