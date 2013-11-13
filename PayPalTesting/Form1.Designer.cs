namespace PayPalTesting
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
            this.btnPreAuthPayPal = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblMessaging = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbRequest = new System.Windows.Forms.RichTextBox();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.btnPreAuthCaptureDSIClientX = new System.Windows.Forms.Button();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.lblInvoiceNO = new System.Windows.Forms.Label();
            this.lblAcctNo = new System.Windows.Forms.Label();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.lblAuthCode = new System.Windows.Forms.Label();
            this.txtAuthCode = new System.Windows.Forms.TextBox();
            this.lblAcqRefData = new System.Windows.Forms.Label();
            this.txtAcqRefData = new System.Windows.Forms.TextBox();
            this.lblShortCode = new System.Windows.Forms.Label();
            this.txtShortCode = new System.Windows.Forms.TextBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreAuthPayPal
            // 
            this.btnPreAuthPayPal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreAuthPayPal.Location = new System.Drawing.Point(176, 12);
            this.btnPreAuthPayPal.Name = "btnPreAuthPayPal";
            this.btnPreAuthPayPal.Size = new System.Drawing.Size(158, 50);
            this.btnPreAuthPayPal.TabIndex = 0;
            this.btnPreAuthPayPal.Text = "PreAuth\r\nPayPal";
            this.btnPreAuthPayPal.UseVisualStyleBackColor = true;
            this.btnPreAuthPayPal.Click += new System.EventHandler(this.btnPreAuthPayPal_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Location = new System.Drawing.Point(12, 84);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(158, 20);
            this.txtInvoiceNo.TabIndex = 3;
            // 
            // lblMessaging
            // 
            this.lblMessaging.AutoSize = true;
            this.lblMessaging.Location = new System.Drawing.Point(12, 520);
            this.lblMessaging.Name = "lblMessaging";
            this.lblMessaging.Size = new System.Drawing.Size(0, 13);
            this.lblMessaging.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 347);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbRequest);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbResponse);
            this.splitContainer1.Size = new System.Drawing.Size(808, 328);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 0;
            // 
            // rtbRequest
            // 
            this.rtbRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRequest.Location = new System.Drawing.Point(0, 0);
            this.rtbRequest.Name = "rtbRequest";
            this.rtbRequest.Size = new System.Drawing.Size(396, 328);
            this.rtbRequest.TabIndex = 0;
            this.rtbRequest.Text = "";
            this.rtbRequest.WordWrap = false;
            // 
            // rtbResponse
            // 
            this.rtbResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResponse.Location = new System.Drawing.Point(0, 0);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(408, 328);
            this.rtbResponse.TabIndex = 0;
            this.rtbResponse.Text = "";
            this.rtbResponse.WordWrap = false;
            // 
            // btnPreAuthCaptureDSIClientX
            // 
            this.btnPreAuthCaptureDSIClientX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreAuthCaptureDSIClientX.Location = new System.Drawing.Point(340, 12);
            this.btnPreAuthCaptureDSIClientX.Name = "btnPreAuthCaptureDSIClientX";
            this.btnPreAuthCaptureDSIClientX.Size = new System.Drawing.Size(158, 50);
            this.btnPreAuthCaptureDSIClientX.TabIndex = 34;
            this.btnPreAuthCaptureDSIClientX.Text = "PreAuthCapture\r\nDSIClientX";
            this.btnPreAuthCaptureDSIClientX.UseVisualStyleBackColor = true;
            this.btnPreAuthCaptureDSIClientX.Click += new System.EventHandler(this.btnPreAuthCaptureDSIClientX_Click);
            // 
            // btnStartOver
            // 
            this.btnStartOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOver.Location = new System.Drawing.Point(671, 12);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(158, 50);
            this.btnStartOver.TabIndex = 35;
            this.btnStartOver.Text = "Start Over";
            this.btnStartOver.UseVisualStyleBackColor = true;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // lblInvoiceNO
            // 
            this.lblInvoiceNO.AutoSize = true;
            this.lblInvoiceNO.Location = new System.Drawing.Point(12, 65);
            this.lblInvoiceNO.Name = "lblInvoiceNO";
            this.lblInvoiceNO.Size = new System.Drawing.Size(56, 13);
            this.lblInvoiceNO.TabIndex = 36;
            this.lblInvoiceNO.Text = "InvoiceNo";
            // 
            // lblAcctNo
            // 
            this.lblAcctNo.AutoSize = true;
            this.lblAcctNo.Location = new System.Drawing.Point(176, 65);
            this.lblAcctNo.Name = "lblAcctNo";
            this.lblAcctNo.Size = new System.Drawing.Size(43, 13);
            this.lblAcctNo.TabIndex = 38;
            this.lblAcctNo.Text = "AcctNo";
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Enabled = false;
            this.txtAcctNo.Location = new System.Drawing.Point(176, 84);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(158, 20);
            this.txtAcctNo.TabIndex = 37;
            // 
            // lblAuthCode
            // 
            this.lblAuthCode.AutoSize = true;
            this.lblAuthCode.Location = new System.Drawing.Point(504, 65);
            this.lblAuthCode.Name = "lblAuthCode";
            this.lblAuthCode.Size = new System.Drawing.Size(54, 13);
            this.lblAuthCode.TabIndex = 40;
            this.lblAuthCode.Text = "AuthCode";
            // 
            // txtAuthCode
            // 
            this.txtAuthCode.Enabled = false;
            this.txtAuthCode.Location = new System.Drawing.Point(504, 84);
            this.txtAuthCode.Name = "txtAuthCode";
            this.txtAuthCode.Size = new System.Drawing.Size(158, 20);
            this.txtAuthCode.TabIndex = 39;
            // 
            // lblAcqRefData
            // 
            this.lblAcqRefData.AutoSize = true;
            this.lblAcqRefData.Location = new System.Drawing.Point(668, 65);
            this.lblAcqRefData.Name = "lblAcqRefData";
            this.lblAcqRefData.Size = new System.Drawing.Size(66, 13);
            this.lblAcqRefData.TabIndex = 42;
            this.lblAcqRefData.Text = "AcqRefData";
            // 
            // txtAcqRefData
            // 
            this.txtAcqRefData.Enabled = false;
            this.txtAcqRefData.Location = new System.Drawing.Point(668, 84);
            this.txtAcqRefData.Name = "txtAcqRefData";
            this.txtAcqRefData.Size = new System.Drawing.Size(158, 20);
            this.txtAcqRefData.TabIndex = 41;
            // 
            // lblShortCode
            // 
            this.lblShortCode.AutoSize = true;
            this.lblShortCode.Location = new System.Drawing.Point(12, 12);
            this.lblShortCode.Name = "lblShortCode";
            this.lblShortCode.Size = new System.Drawing.Size(57, 13);
            this.lblShortCode.TabIndex = 44;
            this.lblShortCode.Text = "ShortCode";
            // 
            // txtShortCode
            // 
            this.txtShortCode.Location = new System.Drawing.Point(12, 31);
            this.txtShortCode.Name = "txtShortCode";
            this.txtShortCode.Size = new System.Drawing.Size(158, 20);
            this.txtShortCode.TabIndex = 43;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(340, 65);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(48, 13);
            this.lblExpDate.TabIndex = 46;
            this.lblExpDate.Text = "ExpDate";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Enabled = false;
            this.txtExpDate.Location = new System.Drawing.Point(340, 84);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(158, 20);
            this.txtExpDate.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 468);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.lblShortCode);
            this.Controls.Add(this.txtShortCode);
            this.Controls.Add(this.lblAcqRefData);
            this.Controls.Add(this.txtAcqRefData);
            this.Controls.Add(this.lblAuthCode);
            this.Controls.Add(this.txtAuthCode);
            this.Controls.Add(this.lblAcctNo);
            this.Controls.Add(this.txtAcctNo);
            this.Controls.Add(this.lblInvoiceNO);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.btnPreAuthCaptureDSIClientX);
            this.Controls.Add(this.lblMessaging);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.btnPreAuthPayPal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreAuthPayPal;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblMessaging;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbRequest;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.Button btnPreAuthCaptureDSIClientX;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.Label lblInvoiceNO;
        private System.Windows.Forms.Label lblAcctNo;
        private System.Windows.Forms.TextBox txtAcctNo;
        private System.Windows.Forms.Label lblAuthCode;
        private System.Windows.Forms.TextBox txtAuthCode;
        private System.Windows.Forms.Label lblAcqRefData;
        private System.Windows.Forms.TextBox txtAcqRefData;
        private System.Windows.Forms.Label lblShortCode;
        private System.Windows.Forms.TextBox txtShortCode;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtExpDate;
    }
}

