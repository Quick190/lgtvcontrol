using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LGSerialControlApp
{
    public partial class Form1 : Form
    {
        private LGTVControl control;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            control = new LGTVControl();
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
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            chkMute.Checked = false;
            control.SetaVolume(trackBar1.Value);
        }

        private void mainInputRadioChanged(object sender, EventArgs e)
        {
            if (rdMainTV.Checked) {
                control.setMainInputSource(LGTVInput.TVCable);
            } else if (rdMainAV1.Checked) {
                control.setMainInputSource(LGTVInput.AV1);
            } else if (rdMainHDMI1.Checked) {
                control.setMainInputSource(LGTVInput.HDMIDVI1);
            }
        }

        private void chkMute_CheckedChanged(object sender, EventArgs e)
        {
            control.setVolumeMuted(chkMute.Checked);
        }
    }
}
