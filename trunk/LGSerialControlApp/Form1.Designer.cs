namespace LGSerialControlApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMainHDMI1 = new System.Windows.Forms.RadioButton();
            this.rdMainAV1 = new System.Windows.Forms.RadioButton();
            this.rdMainTV = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.btnGetInfoFromTV = new System.Windows.Forms.Button();
            this.btnTvON = new System.Windows.Forms.Button();
            this.btnTVOFF = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMainHDMI1);
            this.groupBox1.Controls.Add(this.rdMainAV1);
            this.groupBox1.Controls.Add(this.rdMainTV);
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Principal";
            // 
            // rdMainHDMI1
            // 
            this.rdMainHDMI1.AutoSize = true;
            this.rdMainHDMI1.Location = new System.Drawing.Point(6, 53);
            this.rdMainHDMI1.Name = "rdMainHDMI1";
            this.rdMainHDMI1.Size = new System.Drawing.Size(76, 17);
            this.rdMainHDMI1.TabIndex = 2;
            this.rdMainHDMI1.TabStop = true;
            this.rdMainHDMI1.Text = "HDMI/DVI";
            this.rdMainHDMI1.UseVisualStyleBackColor = true;
            this.rdMainHDMI1.CheckedChanged += new System.EventHandler(this.mainInputRadioChanged);
            // 
            // rdMainAV1
            // 
            this.rdMainAV1.AutoSize = true;
            this.rdMainAV1.Location = new System.Drawing.Point(6, 36);
            this.rdMainAV1.Name = "rdMainAV1";
            this.rdMainAV1.Size = new System.Drawing.Size(48, 17);
            this.rdMainAV1.TabIndex = 1;
            this.rdMainAV1.TabStop = true;
            this.rdMainAV1.Text = "AV 1";
            this.rdMainAV1.UseVisualStyleBackColor = true;
            this.rdMainAV1.CheckedChanged += new System.EventHandler(this.mainInputRadioChanged);
            // 
            // rdMainTV
            // 
            this.rdMainTV.AutoSize = true;
            this.rdMainTV.Location = new System.Drawing.Point(6, 19);
            this.rdMainTV.Name = "rdMainTV";
            this.rdMainTV.Size = new System.Drawing.Size(75, 17);
            this.rdMainTV.TabIndex = 0;
            this.rdMainTV.TabStop = true;
            this.rdMainTV.Text = "Analog TV";
            this.rdMainTV.UseVisualStyleBackColor = true;
            this.rdMainTV.CheckedChanged += new System.EventHandler(this.mainInputRadioChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(12, 109);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(255, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // chkMute
            // 
            this.chkMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMute.AutoSize = true;
            this.chkMute.Location = new System.Drawing.Point(267, 123);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(50, 17);
            this.chkMute.TabIndex = 2;
            this.chkMute.Text = "Mute";
            this.chkMute.UseVisualStyleBackColor = true;
            this.chkMute.CheckedChanged += new System.EventHandler(this.chkMute_CheckedChanged);
            // 
            // btnGetInfoFromTV
            // 
            this.btnGetInfoFromTV.Location = new System.Drawing.Point(72, 12);
            this.btnGetInfoFromTV.Name = "btnGetInfoFromTV";
            this.btnGetInfoFromTV.Size = new System.Drawing.Size(64, 22);
            this.btnGetInfoFromTV.TabIndex = 3;
            this.btnGetInfoFromTV.Text = "Refresh";
            this.btnGetInfoFromTV.UseVisualStyleBackColor = true;
            this.btnGetInfoFromTV.Click += new System.EventHandler(this.btnGetInfoFromTV_Click);
            // 
            // btnTvON
            // 
            this.btnTvON.Location = new System.Drawing.Point(44, 54);
            this.btnTvON.Name = "btnTvON";
            this.btnTvON.Size = new System.Drawing.Size(55, 28);
            this.btnTvON.TabIndex = 4;
            this.btnTvON.Text = "TV ON";
            this.btnTvON.UseVisualStyleBackColor = true;
            this.btnTvON.Click += new System.EventHandler(this.btnTvON_Click);
            // 
            // btnTVOFF
            // 
            this.btnTVOFF.Location = new System.Drawing.Point(107, 54);
            this.btnTVOFF.Name = "btnTVOFF";
            this.btnTVOFF.Size = new System.Drawing.Size(55, 28);
            this.btnTVOFF.TabIndex = 5;
            this.btnTVOFF.Text = "TV OFF";
            this.btnTVOFF.UseVisualStyleBackColor = true;
            this.btnTVOFF.Click += new System.EventHandler(this.btnTVOFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 161);
            this.Controls.Add(this.btnTVOFF);
            this.Controls.Add(this.btnTvON);
            this.Controls.Add(this.btnGetInfoFromTV);
            this.Controls.Add(this.chkMute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LG TV Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMainHDMI1;
        private System.Windows.Forms.RadioButton rdMainAV1;
        private System.Windows.Forms.RadioButton rdMainTV;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.Button btnGetInfoFromTV;
        private System.Windows.Forms.Button btnTvON;
        private System.Windows.Forms.Button btnTVOFF;
    }
}

