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
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            control.SetaVolume(trackBar1.Value);
        }
    }
}
