using System;
using System.Windows.Forms;

namespace LGSerialControlApp {
    public partial class Form1 : Form {
        private LGTVControl control;
        private Boolean readingValues = true;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            control = new LGTVControl();
            readFromTVAndApplyToInterface();
        }

        private void readFromTVAndApplyToInterface() {
            readingValues = true;
            control.readAllCurrentValues();

            trackBar1.Value = control.currentVol;
            switch (control.currentMainInput) {
                case LGTVInput.TVCable:
                    rdMainTV.Checked = true;
                    break;

                case LGTVInput.HDMIDVI1:
                    rdMainHDMI1.Checked = true;
                    break;

                case LGTVInput.AV1:
                    rdMainAV1.Checked = true;
                    break;
            }

            readingValues = false;
        }

        #region Interface handlers
        private void trackBar1_Scroll(object sender, EventArgs e) {
            if (readingValues) return;
            chkMute.Checked = false;
            control.SetaVolume(trackBar1.Value);
        }

        private void mainInputRadioChanged(object sender, EventArgs e) {
            if (readingValues) return;
            if (rdMainTV.Checked) {
                control.setMainInputSource(LGTVInput.TVCable);
            }
            else if (rdMainAV1.Checked) {
                control.setMainInputSource(LGTVInput.AV1);
            }
            else if (rdMainHDMI1.Checked) {
                control.setMainInputSource(LGTVInput.HDMIDVI1);
            }
        }

        private void chkMute_CheckedChanged(object sender, EventArgs e) {
            if (readingValues) return;
            control.setVolumeMuted(chkMute.Checked);
        }
        #endregion

        private void btnGetInfoFromTV_Click(object sender, EventArgs e)
        {
            this.readFromTVAndApplyToInterface();
        }

        private void btnTVOFF_Click(object sender, EventArgs e)
        {
            control.setPower(false);
        }

        private void btnTvON_Click(object sender, EventArgs e)
        {
            control.setPower(true);
        }

    }
}