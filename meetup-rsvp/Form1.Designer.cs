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
            this.txbCommand = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblTADdate = new System.Windows.Forms.Label();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLocalDate = new System.Windows.Forms.Label();
            this.dtpEventTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblTADtime = new System.Windows.Forms.Label();
            this.lblLocalTime = new System.Windows.Forms.Label();
            this.tmrLocalDateTime = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.btnanother = new System.Windows.Forms.Button();
            this.txbmeetupurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbmeetupconvenientcommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnconveniencemeetupthing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCommand
            // 
            this.txbCommand.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCommand.Location = new System.Drawing.Point(16, 44);
            this.txbCommand.Multiline = true;
            this.txbCommand.Name = "txbCommand";
            this.txbCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCommand.Size = new System.Drawing.Size(390, 77);
            this.txbCommand.TabIndex = 0;
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
            // lblTADdate
            // 
            this.lblTADdate.AutoSize = true;
            this.lblTADdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTADdate.Location = new System.Drawing.Point(611, 301);
            this.lblTADdate.Name = "lblTADdate";
            this.lblTADdate.Size = new System.Drawing.Size(15, 15);
            this.lblTADdate.TabIndex = 0;
            this.lblTADdate.Text = "::";
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDate.Location = new System.Drawing.Point(611, 281);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(206, 15);
            this.lblTimeDate.TabIndex = 0;
            this.lblTimeDate.Text = "timeanddate.com (for curiosity)";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(10, 21);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(237, 20);
            this.lblUrl.TabIndex = 7;
            this.lblUrl.Text = "Command or can say GET ...";
            // 
            // txbStatus
            // 
            this.txbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.Location = new System.Drawing.Point(12, 177);
            this.txbStatus.Multiline = true;
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbStatus.Size = new System.Drawing.Size(394, 209);
            this.txbStatus.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Application Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date and Time \r\n(we\'re using. obtained locally)";
            // 
            // lblLocalDate
            // 
            this.lblLocalDate.AutoSize = true;
            this.lblLocalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDate.Location = new System.Drawing.Point(436, 158);
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
            this.lblTADtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTADtime.Location = new System.Drawing.Point(611, 321);
            this.lblTADtime.Name = "lblTADtime";
            this.lblTADtime.Size = new System.Drawing.Size(15, 15);
            this.lblTADtime.TabIndex = 0;
            this.lblTADtime.Text = "::";
            // 
            // lblLocalTime
            // 
            this.lblLocalTime.AutoSize = true;
            this.lblLocalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalTime.Location = new System.Drawing.Point(436, 191);
            this.lblLocalTime.Name = "lblLocalTime";
            this.lblLocalTime.Size = new System.Drawing.Size(19, 20);
            this.lblLocalTime.TabIndex = 11;
            this.lblLocalTime.Text = "::";
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
            this.lnkClear.Location = new System.Drawing.Point(175, 150);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(137, 20);
            this.lnkClear.TabIndex = 14;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "Clear Messages";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClear_LinkClicked);
            // 
            // btnanother
            // 
            this.btnanother.Location = new System.Drawing.Point(339, 1);
            this.btnanother.Name = "btnanother";
            this.btnanother.Size = new System.Drawing.Size(213, 23);
            this.btnanother.TabIndex = 15;
            this.btnanother.Text = "ANOTHER INSTANCE OF EXE";
            this.btnanother.UseVisualStyleBackColor = true;
            this.btnanother.Click += new System.EventHandler(this.btnanother_Click);
            // 
            // txbmeetupurl
            // 
            this.txbmeetupurl.Location = new System.Drawing.Point(97, 405);
            this.txbmeetupurl.Name = "txbmeetupurl";
            this.txbmeetupurl.Size = new System.Drawing.Size(419, 20);
            this.txbmeetupurl.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "paste meetupurl";
            // 
            // txbmeetupconvenientcommand
            // 
            this.txbmeetupconvenientcommand.Location = new System.Drawing.Point(97, 437);
            this.txbmeetupconvenientcommand.Name = "txbmeetupconvenientcommand";
            this.txbmeetupconvenientcommand.Size = new System.Drawing.Size(419, 20);
            this.txbmeetupconvenientcommand.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "receive command";
            // 
            // btnconveniencemeetupthing
            // 
            this.btnconveniencemeetupthing.Location = new System.Drawing.Point(522, 405);
            this.btnconveniencemeetupthing.Name = "btnconveniencemeetupthing";
            this.btnconveniencemeetupthing.Size = new System.Drawing.Size(258, 23);
            this.btnconveniencemeetupthing.TabIndex = 20;
            this.btnconveniencemeetupthing.Text = "click to put < in box below for convenience";
            this.btnconveniencemeetupthing.UseVisualStyleBackColor = true;
            this.btnconveniencemeetupthing.Click += new System.EventHandler(this.btnconveniencemeetupthing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 469);
            this.Controls.Add(this.btnconveniencemeetupthing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbmeetupconvenientcommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbmeetupurl);
            this.Controls.Add(this.btnanother);
            this.Controls.Add(this.lnkClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLocalTime);
            this.Controls.Add(this.lblTADtime);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.dtpEventTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLocalDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.lblTADdate);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txbCommand);
            this.Name = "Form1";
            this.Text = "meetup-rsvp-demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCommand;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblTADdate;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLocalDate;
        private System.Windows.Forms.DateTimePicker dtpEventTime;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label lblTADtime;
        private System.Windows.Forms.Label lblLocalTime;
        private System.Windows.Forms.Timer tmrLocalDateTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lnkClear;
        private System.Windows.Forms.Button btnanother;
        private System.Windows.Forms.TextBox txbmeetupurl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbmeetupconvenientcommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnconveniencemeetupthing;
    }
}

