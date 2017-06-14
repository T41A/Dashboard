namespace MQTTDash
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCupStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIncommingMQTT = new System.Windows.Forms.ListBox();
            this.mqttMsgUnsubscribeEventArgsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBACLatest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBACStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMixer = new System.Windows.Forms.GroupBox();
            this.lblMixerWarning = new System.Windows.Forms.Label();
            this.pbWeight = new System.Windows.Forms.ProgressBar();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatusMixer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTempWarning = new System.Windows.Forms.Label();
            this.pbTemp = new System.Windows.Forms.ProgressBar();
            this.lblTemp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConcentration2 = new System.Windows.Forms.Label();
            this.lblConcentration1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCupSize = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mqttMsgUnsubscribeEventArgsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbMixer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCupStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CupChecker";
            // 
            // lblCupStatus
            // 
            this.lblCupStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCupStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCupStatus.Location = new System.Drawing.Point(101, 16);
            this.lblCupStatus.Name = "lblCupStatus";
            this.lblCupStatus.Size = new System.Drawing.Size(92, 13);
            this.lblCupStatus.TabIndex = 1;
            this.lblCupStatus.Text = "Cup not present.";
            this.lblCupStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cup:";
            // 
            // lbIncommingMQTT
            // 
            this.lbIncommingMQTT.FormattingEnabled = true;
            this.lbIncommingMQTT.Location = new System.Drawing.Point(496, 13);
            this.lbIncommingMQTT.Name = "lbIncommingMQTT";
            this.lbIncommingMQTT.Size = new System.Drawing.Size(307, 485);
            this.lbIncommingMQTT.TabIndex = 1;
            // 
            // mqttMsgUnsubscribeEventArgsBindingSource
            // 
            this.mqttMsgUnsubscribeEventArgsBindingSource.DataSource = typeof(uPLibrary.Networking.M2Mqtt.Messages.MqttMsgUnsubscribeEventArgs);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBACLatest);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblBACStatus);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Breathalyzer";
            // 
            // lblBACLatest
            // 
            this.lblBACLatest.ForeColor = System.Drawing.Color.Red;
            this.lblBACLatest.Location = new System.Drawing.Point(165, 29);
            this.lblBACLatest.Name = "lblBACLatest";
            this.lblBACLatest.Size = new System.Drawing.Size(29, 13);
            this.lblBACLatest.TabIndex = 3;
            this.lblBACLatest.Text = "NaN";
            this.lblBACLatest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Latest BAC";
            // 
            // lblBACStatus
            // 
            this.lblBACStatus.ForeColor = System.Drawing.Color.Red;
            this.lblBACStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBACStatus.Location = new System.Drawing.Point(131, 16);
            this.lblBACStatus.Name = "lblBACStatus";
            this.lblBACStatus.Size = new System.Drawing.Size(63, 13);
            this.lblBACStatus.TabIndex = 1;
            this.lblBACStatus.Text = "Not Present";
            this.lblBACStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // gbMixer
            // 
            this.gbMixer.Controls.Add(this.lblMixerWarning);
            this.gbMixer.Controls.Add(this.pbWeight);
            this.gbMixer.Controls.Add(this.lblWeight);
            this.gbMixer.Controls.Add(this.label5);
            this.gbMixer.Controls.Add(this.lblStatusMixer);
            this.gbMixer.Controls.Add(this.label7);
            this.gbMixer.Location = new System.Drawing.Point(219, 13);
            this.gbMixer.Name = "gbMixer";
            this.gbMixer.Size = new System.Drawing.Size(200, 100);
            this.gbMixer.TabIndex = 3;
            this.gbMixer.TabStop = false;
            this.gbMixer.Text = "Mixer";
            // 
            // lblMixerWarning
            // 
            this.lblMixerWarning.ForeColor = System.Drawing.Color.Red;
            this.lblMixerWarning.Location = new System.Drawing.Point(37, 72);
            this.lblMixerWarning.Name = "lblMixerWarning";
            this.lblMixerWarning.Size = new System.Drawing.Size(127, 13);
            this.lblMixerWarning.TabIndex = 6;
            this.lblMixerWarning.Text = "Warning - System fault!";
            this.lblMixerWarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMixerWarning.Visible = false;
            // 
            // pbWeight
            // 
            this.pbWeight.Location = new System.Drawing.Point(9, 46);
            this.pbWeight.Maximum = 110;
            this.pbWeight.Name = "pbWeight";
            this.pbWeight.Size = new System.Drawing.Size(185, 23);
            this.pbWeight.TabIndex = 4;
            // 
            // lblWeight
            // 
            this.lblWeight.ForeColor = System.Drawing.Color.Red;
            this.lblWeight.Location = new System.Drawing.Point(165, 29);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(29, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "NaN";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ML:";
            // 
            // lblStatusMixer
            // 
            this.lblStatusMixer.ForeColor = System.Drawing.Color.Red;
            this.lblStatusMixer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatusMixer.Location = new System.Drawing.Point(66, 16);
            this.lblStatusMixer.Name = "lblStatusMixer";
            this.lblStatusMixer.Size = new System.Drawing.Size(128, 13);
            this.lblStatusMixer.TabIndex = 1;
            this.lblStatusMixer.Text = "Not Present";
            this.lblStatusMixer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTempWarning);
            this.groupBox3.Controls.Add(this.pbTemp);
            this.groupBox3.Controls.Add(this.lblTemp);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(219, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cooling";
            // 
            // lblTempWarning
            // 
            this.lblTempWarning.ForeColor = System.Drawing.Color.Red;
            this.lblTempWarning.Location = new System.Drawing.Point(37, 58);
            this.lblTempWarning.Name = "lblTempWarning";
            this.lblTempWarning.Size = new System.Drawing.Size(127, 13);
            this.lblTempWarning.TabIndex = 5;
            this.lblTempWarning.Text = "Warning - System fault!";
            this.lblTempWarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTempWarning.Visible = false;
            // 
            // pbTemp
            // 
            this.pbTemp.Location = new System.Drawing.Point(9, 32);
            this.pbTemp.Maximum = 30;
            this.pbTemp.Name = "pbTemp";
            this.pbTemp.Size = new System.Drawing.Size(185, 23);
            this.pbTemp.TabIndex = 5;
            // 
            // lblTemp
            // 
            this.lblTemp.ForeColor = System.Drawing.Color.Red;
            this.lblTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTemp.Location = new System.Drawing.Point(131, 16);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(63, 13);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Not Present";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Temperature";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblConcentration2);
            this.groupBox4.Controls.Add(this.lblConcentration1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblCupSize);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(12, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Concentration 2";
            // 
            // lblConcentration2
            // 
            this.lblConcentration2.ForeColor = System.Drawing.Color.Red;
            this.lblConcentration2.Location = new System.Drawing.Point(165, 42);
            this.lblConcentration2.Name = "lblConcentration2";
            this.lblConcentration2.Size = new System.Drawing.Size(29, 13);
            this.lblConcentration2.TabIndex = 4;
            this.lblConcentration2.Text = "NaN";
            this.lblConcentration2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConcentration1
            // 
            this.lblConcentration1.ForeColor = System.Drawing.Color.Red;
            this.lblConcentration1.Location = new System.Drawing.Point(165, 29);
            this.lblConcentration1.Name = "lblConcentration1";
            this.lblConcentration1.Size = new System.Drawing.Size(29, 13);
            this.lblConcentration1.TabIndex = 3;
            this.lblConcentration1.Text = "NaN";
            this.lblConcentration1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Concentration 1";
            // 
            // lblCupSize
            // 
            this.lblCupSize.ForeColor = System.Drawing.Color.Red;
            this.lblCupSize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCupSize.Location = new System.Drawing.Point(131, 16);
            this.lblCupSize.Name = "lblCupSize";
            this.lblCupSize.Size = new System.Drawing.Size(63, 13);
            this.lblCupSize.TabIndex = 1;
            this.lblCupSize.Text = "Not Present";
            this.lblCupSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cup Size (ml)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbMixer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbIncommingMQTT);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dashboard";
            this.Text = "DRINQ Dash";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mqttMsgUnsubscribeEventArgsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbMixer.ResumeLayout(false);
            this.gbMixer.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCupStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbIncommingMQTT;
        private System.Windows.Forms.BindingSource mqttMsgUnsubscribeEventArgsBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBACLatest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBACStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMixer;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatusMixer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pbWeight;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar pbTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTempWarning;
        private System.Windows.Forms.Label lblMixerWarning;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblConcentration1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCupSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblConcentration2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

