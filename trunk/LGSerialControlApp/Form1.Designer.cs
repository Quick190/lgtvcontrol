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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMainTV = new System.Windows.Forms.RadioButton();
            this.tdMainAV1 = new System.Windows.Forms.RadioButton();
            this.tdMainHDMI1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(19, 193);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(295, 35);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tdMainHDMI1);
            this.groupBox1.Controls.Add(this.tdMainAV1);
            this.groupBox1.Controls.Add(this.rdMainTV);
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Principal";
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
            // 
            // tdMainAV1
            // 
            this.tdMainAV1.AutoSize = true;
            this.tdMainAV1.Location = new System.Drawing.Point(6, 36);
            this.tdMainAV1.Name = "tdMainAV1";
            this.tdMainAV1.Size = new System.Drawing.Size(48, 17);
            this.tdMainAV1.TabIndex = 1;
            this.tdMainAV1.TabStop = true;
            this.tdMainAV1.Text = "AV 1";
            this.tdMainAV1.UseVisualStyleBackColor = true;
            // 
            // tdMainHDMI1
            // 
            this.tdMainHDMI1.AutoSize = true;
            this.tdMainHDMI1.Location = new System.Drawing.Point(6, 53);
            this.tdMainHDMI1.Name = "tdMainHDMI1";
            this.tdMainHDMI1.Size = new System.Drawing.Size(76, 17);
            this.tdMainHDMI1.TabIndex = 2;
            this.tdMainHDMI1.TabStop = true;
            this.tdMainHDMI1.Text = "HDMI/DVI";
            this.tdMainHDMI1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 246);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tdMainHDMI1;
        private System.Windows.Forms.RadioButton tdMainAV1;
        private System.Windows.Forms.RadioButton rdMainTV;
    }
}

