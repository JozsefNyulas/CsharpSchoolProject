using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadMultipleFormInPanel
{
    public partial class HearingForm : Form
    {
        public static string hearingResult = "";

        public HearingForm()
        {
            InitializeComponent();
        }

        SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\joeny\\Documents\\Info egyetem anyagok\\2ev\\modul2\\.NET\\LoadMultipleFormInPanel\\Resources\\fakop.wav");

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            soundPlayer.Play();

            labelShowUpHearing.Visible = true;
            btnConfirmHeardSound.Visible = true;
            btnNoSoundHeard.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();

            labelShowUpHearing.Visible= false;
            btnConfirmHeardSound.Visible= false;
            btnNoSoundHeard.Visible= false;
        }

        private void btnConfirmHeardSound_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            hearingResult = "Your hearing is in order";

            labelpressForSound.Visible = false;
            btnConfirmHeardSound.Visible = false;
            btnNoSoundHeard.Visible = false;
            btnConfirmHeardSound.Visible = false;
            btnNoSoundHeard.Visible = false;
            btnStartSound.Visible = false;
            btnStopSound.Visible = false;

            labelShowUpHearing.Text = hearingResult;
            labelShowUpHearing.Visible = true;

        }

        private void btnNoSoundHeard_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            hearingResult = "Your hearing needs further chekup. Please see a doctor.";

            labelpressForSound.Visible = false;
            btnConfirmHeardSound.Visible = false;
            btnNoSoundHeard.Visible = false;
            btnConfirmHeardSound.Visible = false;
            btnNoSoundHeard.Visible = false;
            btnStartSound.Visible = false;
            btnStopSound.Visible = false;

            labelShowUpHearing.Text = hearingResult;
            labelShowUpHearing.Visible = true;

        }

        private void HearingForm_Load(object sender, EventArgs e)
        {

        }

        private void labelpressForSound_Click(object sender, EventArgs e)
        {

        }

        private void labelShowUpHearing_Click(object sender, EventArgs e)
        {

        }
    }
}
