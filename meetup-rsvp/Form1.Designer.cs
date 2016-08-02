namespace meetup_rsvp
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
            this.components = new System.ComponentModel.Container();
            this.txbCurlCommand = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.txbResponse = new System.Windows.Forms.TextBox();
            this.lblTADdate = new System.Windows.Forms.Label();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNtpDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLocalDate = new System.Windows.Forms.Label();
            this.dtpEventTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblTADtime = new System.Windows.Forms.Label();
            this.lblLocalTime = new System.Windows.Forms.Label();
            this.lblNtpTime = new System.Windows.Forms.Label();
            this.tmrLocalDateTime = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txbCurlCommand
            // 
            this.txbCurlCommand.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurlCommand.Location = new System.Drawing.Point(56, 44);
            this.txbCurlCommand.Multiline = true;
            this.txbCurlCommand.Name = "txbCurlCommand";
            this.txbCurlCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCurlCommand.Size = new System.Drawing.Size(350, 77);
            this.txbCurlCommand.TabIndex = 0;
            // 
            // btnSet
            // 
            this.btnSet.AutoSize = true;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(676, 42);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(93, 30);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "&Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txbResponse
            // 
            this.txbResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResponse.Location = new System.Drawing.Point(12, 156);
            this.txbResponse.Multiline = true;
            this.txbResponse.Name = "txbResponse";
            this.txbResponse.ReadOnly = true;
            this.txbResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbResponse.Size = new System.Drawing.Size(394, 94);
            this.txbResponse.TabIndex = 0;
            // 
            // lblTADdate
            // 
            this.lblTADdate.AutoSize = true;
            this.lblTADdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTADdate.Location = new System.Drawing.Point(436, 121);
            this.lblTADdate.Name = "lblTADdate";
            this.lblTADdate.Size = new System.Drawing.Size(19, 20);
            this.lblTADdate.TabIndex = 0;
            this.lblTADdate.Text = "::";
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDate.Location = new System.Drawing.Point(436, 101);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(147, 20);
            this.lblTimeDate.TabIndex = 0;
            this.lblTimeDate.Text = "timeanddate.com";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(12, 47);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(38, 20);
            this.lblUrl.TabIndex = 7;
            this.lblUrl.Text = "curl";
            // 
            // txbStatus
            // 
            this.txbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.Location = new System.Drawing.Point(12, 294);
            this.txbStatus.Multiline = true;
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbStatus.Size = new System.Drawing.Size(394, 108);
            this.txbStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Response";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Application Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "time.windows.com";
            // 
            // lblNtpDate
            // 
            this.lblNtpDate.AutoSize = true;
            this.lblNtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNtpDate.Location = new System.Drawing.Point(436, 224);
            this.lblNtpDate.Name = "lblNtpDate";
            this.lblNtpDate.Size = new System.Drawing.Size(19, 20);
            this.lblNtpDate.TabIndex = 0;
            this.lblNtpDate.Text = "::";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Local Date and Time";
            // 
            // lblLocalDate
            // 
            this.lblLocalDate.AutoSize = true;
            this.lblLocalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDate.Location = new System.Drawing.Point(436, 307);
            this.lblLocalDate.Name = "lblLocalDate";
            this.lblLocalDate.Size = new System.Drawing.Size(19, 20);
            this.lblLocalDate.TabIndex = 0;
            this.lblLocalDate.Text = "::";
            // 
            // dtpEventTime
            // 
            this.dtpEventTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEventTime.Location = new System.Drawing.Point(551, 44);
            this.dtpEventTime.Name = "dtpEventTime";
            this.dtpEventTime.ShowUpDown = true;
            this.dtpEventTime.Size = new System.Drawing.Size(119, 26);
            this.dtpEventTime.TabIndex = 2;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventDate.Location = new System.Drawing.Point(412, 44);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(133, 26);
            this.dtpEventDate.TabIndex = 1;
            // 
            // lblTADtime
            // 
            this.lblTADtime.AutoSize = true;
            this.lblTADtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTADtime.Location = new System.Drawing.Point(436, 141);
            this.lblTADtime.Name = "lblTADtime";
            this.lblTADtime.Size = new System.Drawing.Size(19, 20);
            this.lblTADtime.TabIndex = 0;
            this.lblTADtime.Text = "::";
            // 
            // lblLocalTime
            // 
            this.lblLocalTime.AutoSize = true;
            this.lblLocalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalTime.Location = new System.Drawing.Point(436, 341);
            this.lblLocalTime.Name = "lblLocalTime";
            this.lblLocalTime.Size = new System.Drawing.Size(19, 20);
            this.lblLocalTime.TabIndex = 11;
            this.lblLocalTime.Text = "::";
            // 
            // lblNtpTime
            // 
            this.lblNtpTime.AutoSize = true;
            this.lblNtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNtpTime.Location = new System.Drawing.Point(436, 253);
            this.lblNtpTime.Name = "lblNtpTime";
            this.lblNtpTime.Size = new System.Drawing.Size(19, 20);
            this.lblNtpTime.TabIndex = 12;
            this.lblNtpTime.Text = "::";
            // 
            // tmrLocalDateTime
            // 
            this.tmrLocalDateTime.Interval = 1000;
            this.tmrLocalDateTime.Tick += new System.EventHandler(this.tmrLocalDateTime_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(775, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lnkClear
            // 
            this.lnkClear.AutoSize = true;
            this.lnkClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClear.Location = new System.Drawing.Point(175, 267);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(137, 20);
            this.lnkClear.TabIndex = 14;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "Clear Messages";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClear_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 414);
            this.Controls.Add(this.lnkClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNtpTime);
            this.Controls.Add(this.lblLocalTime);
            this.Controls.Add(this.lblTADtime);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.dtpEventTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLocalDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.lblTADdate);
            this.Controls.Add(this.txbResponse);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txbCurlCommand);
            this.Name = "Form1";
            this.Text = "meetup-rsvp-demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCurlCommand;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txbResponse;
        private System.Windows.Forms.Label lblTADdate;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLocalDate;
        private System.Windows.Forms.DateTimePicker dtpEventTime;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label lblTADtime;
        private System.Windows.Forms.Label lblLocalTime;
        private System.Windows.Forms.Label lblNtpTime;
        private System.Windows.Forms.Timer tmrLocalDateTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lnkClear;
    }
}

