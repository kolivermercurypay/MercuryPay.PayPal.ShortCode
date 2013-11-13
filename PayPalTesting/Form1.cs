using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace PayPalTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ResetControls();
        }

        private void ResetControls()
        {
            this.txtShortCode.Clear();
            this.btnPreAuthPayPal.Enabled = true;
            this.btnPreAuthCaptureDSIClientX.Enabled = false;
            this.btnStartOver.Enabled = false;
            this.txtInvoiceNo.Clear();
            this.txtAcctNo.Clear();
            this.txtExpDate.Clear();
            this.txtAuthCode.Clear();
            this.txtAcqRefData.Clear();
            this.rtbRequest.Clear();
            this.rtbResponse.Clear();
        }

        private void btnPreAuthPayPal_Click(object sender, EventArgs e)
        {
            this.txtInvoiceNo.Text = DateTime.Now.ToString("yyMMddHHmmss");
            
            Dictionary<string, object> request = new Dictionary<string, object>();
            request.Add("MerchantID", "595901");
            request.Add("TranType", "Credit");
            request.Add("TranCode", "PreAuth");
            request.Add("InvoiceNo", this.txtInvoiceNo.Text);
            request.Add("RefNo", this.txtInvoiceNo.Text);
            request.Add("Memo", "PayPalTesting PayPalPilot");
            request.Add("OperatorID", "test");

            Dictionary<string, object> accountData = new Dictionary<string, object>();
            accountData.Add("EncryptedFormat", "MercuryPayPalPilot");
            accountData.Add("AccountSource", "Keyed");
            accountData.Add("EncryptedBlock", this.txtShortCode.Text);
            accountData.Add("EncryptedKey", "");
            request.Add("Account", accountData);

            Dictionary<string, object> amountData = new Dictionary<string, object>();
            amountData.Add("Purchase", "2.25");
            amountData.Add("Authorize", "2.25");
            request.Add("Amount", amountData);

            string xmlRequest = XMLHelper.BuildXMLRequest(request, "Transaction").ToString();
            this.rtbRequest.Text = xmlRequest;

            using (PayPalAlpha.mobileSoapClient client = new PayPalAlpha.mobileSoapClient())
            {
                string xmlResponse = client.CreditTransactionPilot(this.rtbRequest.Text, "xyz");
                this.rtbResponse.Text = xmlResponse;
            }

            Dictionary<string, string> response = XMLHelper.ParseXMLResponse(this.rtbResponse.Text);
            
            this.txtAcctNo.Text = response.ContainsKey("AcctNo") ? response["AcctNo"] : string.Empty;
            this.txtExpDate.Text = response.ContainsKey("ExpDate") ? response["ExpDate"] : string.Empty;
            this.txtAuthCode.Text = response.ContainsKey("AuthCode") ? response["AuthCode"] : string.Empty;
            this.txtAcqRefData.Text = response.ContainsKey("AcqRefData") ? response["AcqRefData"] : string.Empty;

            if (response.ContainsKey("CmdStatus")
                && response["CmdStatus"] == "Approved")
            {
                this.btnPreAuthPayPal.Enabled = false;
                this.btnPreAuthCaptureDSIClientX.Enabled = true;
                this.btnStartOver.Enabled = true;
            }
        }

        private void btnPreAuthCaptureDSIClientX_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> request = new Dictionary<string, object>();
            request.Add("MerchantID", "595901");
            request.Add("TranType", "Credit");
            request.Add("TranCode", "PreAuthCapture");
            request.Add("InvoiceNo", this.txtInvoiceNo.Text);
            request.Add("RefNo", this.txtInvoiceNo.Text);
            request.Add("Memo", "PayPalTesting PayPalPilot");
            request.Add("OperatorID", "test");

            Dictionary<string, object> accountData = new Dictionary<string, object>();
            accountData.Add("AcctNo", this.txtAcctNo.Text);
            accountData.Add("ExpDate", this.txtExpDate.Text);
            request.Add("Account", accountData);

            Dictionary<string, object> amountData = new Dictionary<string, object>();
            amountData.Add("Purchase", "2.25");
            amountData.Add("Authorize", "2.25");
            amountData.Add("Gratuity", "1.00");
            request.Add("Amount", amountData);

            Dictionary<string, object> tranInfoData = new Dictionary<string, object>();
            tranInfoData.Add("AuthCode", this.txtAuthCode.Text);
            tranInfoData.Add("AcqRefData", this.txtAcqRefData.Text);
            request.Add("TranInfo", tranInfoData);

            string xmlRequest = XMLHelper.BuildXMLRequest(request, "Transaction").ToString();
            this.rtbRequest.Text = xmlRequest;

            DSICLIENTXLib.DSICLientX dsiClientX = new DSICLIENTXLib.DSICLientX();
            dsiClientX.ServerIPConfig(ConfigurationManager.AppSettings["NETePayHostList"], 0);
            string xmlResponse = dsiClientX.ProcessTransaction(this.rtbRequest.Text, 1, null, null);
            this.rtbResponse.Text = xmlResponse;

            Dictionary<string, string> response = XMLHelper.ParseXMLResponse(this.rtbResponse.Text);

            if (response.ContainsKey("CmdStatus")
                && response["CmdStatus"] == "Approved")
            {
                this.btnPreAuthCaptureDSIClientX.Enabled = false;
            }
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            this.ResetControls();
        }
    }
}
