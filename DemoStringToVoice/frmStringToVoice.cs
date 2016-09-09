using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoStringToVoice
{
    public partial class frmStringToVoice : Form
    {
        public frmStringToVoice()
        {
            InitializeComponent();
        }

        private static SpeechSynthesizer speech;

        private void btnStringToVoice_Click(object sender, EventArgs e)
        {
            speech = new SpeechSynthesizer();

            speech.Speak(txtString.Text);
            txtString.Text = "";
        }
    }
}
