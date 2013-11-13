MercuryPay.PayPal.ShortCode
===========================

VS 2010 integration to MercuryPay PayPal ShortCode Solution

3 step process to integrate.

##Step 1: Build Request

Create a Dictionary&lt;string, object&gt; variable and add all the Key Value Pairs.
  
```
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

```
  
##Step 2: Process the Transaction

a. Create a service reference to our testing URL @ https://w1.mercurycert.net/ws/mobile.asmx.

b. Use XMLHelper.BuildXMLRequest(Dictionary<string, object) to create the XML Request string.

c. Call the CreditTransactionPilot web method with XML Request string and Merchant's Password.

```
string xmlRequest = XMLHelper.BuildXMLRequest(request, "Transaction").ToString();

using (PayPalAlpha.mobileSoapClient client = new PayPalAlpha.mobileSoapClient())
{
  string xmlResponse = client.CreditTransactionPilot(this.rtbRequest.Text, "xyz");
}
```

##Step 3: Parse the XML Response

Parse the XML Response using the XMLHelper.ParseXMLResponse(string xmlResponse) method.

This method returns a Dictionary&lt;string, string&gt;.

Approved transactions will have a CmdStatus equal to "Approved".

```
Dictionary<string, string> responseDictionary = XMLHelper.ParseXMLResponse(xmlResponse);

if (responseDictionary.ContainsKey("CmdStatus")
   && responseDictionary["CmdStatus"] == "Approved")
{
   // Approved logic goes here
}
else
{
   // Declined/Error logic goes here
}
```

###©2013 Mercury Payment Systems, LLC - all rights reserved.

Disclaimer:
This software and all specifications and documentation contained herein or provided to you hereunder (the "Software") are provided free of charge strictly on an "AS IS" basis. No representations or warranties are expressed or implied, including, but not limited to, warranties of suitability, quality, merchantability, or fitness for a particular purpose (irrespective of any course of dealing, custom or usage of trade), and all such warranties are expressly and specifically disclaimed. Mercury Payment Systems shall have no liability or responsibility to you nor any other person or entity with respect to any liability, loss, or damage, including lost profits whether foreseeable or not, or other obligation for any cause whatsoever, caused or alleged to be caused directly or indirectly by the Software. Use of the Software signifies agreement with this disclaimer notice.
