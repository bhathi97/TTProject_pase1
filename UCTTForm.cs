using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_TelegraphicTransfer
{
    public partial class UCTTForm : UserControl
    {

        #region properties
        private string _lblFormName;
        public string LblFormName
        {
            get { return _lblFormName; }
            set
            {
                _lblFormName = value;
                lblFormName.Text = value;
            }
        }

        private int _lblFormID;
        public int LblFormID
        {
            get { return _lblFormID; }
            set
            {
                _lblFormID = value;

            }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                
            }
        }



        #endregion

        public UCTTForm()
        {
            InitializeComponent();
        }

        private void UCTTForm_Load(object sender, EventArgs e)
        {

        }

        #region amount Convert

        string[] zeroToNine = { "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };

        string[] elevenToNineteen = { "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };

        string[] tenToNinety = { "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };

        string[] words = { "HUNDRED", "THOUSAND", "MILLION", "BILLION" };

        public string getbelowHundradValues(int value)
        {
            //1-10
            if (value < 10 && value > 0)
            {
                return zeroToNine[value];
            }
            //10
            if (value == 10)
            {
                return tenToNinety[0];
            }
            //11 - 19
            if (value > 10 && value < 20)
            {
                int ones = value % 10;
                return elevenToNineteen[ones - 1];
            }
            //21 - 99
            if (value < 100 && value > 19)
            {
                int ones = value % 10;
                int tens = value / 10;
                if (value % 10 == 0)
                {
                    return tenToNinety[tens - 1];
                }
                else
                {
                    return tenToNinety[tens - 1] + " " + zeroToNine[ones];
                }
            }
            return "";
        }

        public string getbelowthousandValues(int value)
        {
            int hund = value / 100;
            int remain = value % 100;
            if (value / 100 == 0)
            {
                return getbelowHundradValues(remain);
            }
            return zeroToNine[hund] + " " + words[0] + " " + getbelowHundradValues(remain);
        }

        public string getbelowmilionValues(int value)
        {
            int firstPart = value / 1000;
            int secoundPart = value % 1000;

            if (secoundPart == 0)
            {

                if (firstPart < 100)
                {
                    return getbelowHundradValues(firstPart) + " " + words[1];
                }
                if (firstPart >= 100 && firstPart < 1000)
                {
                    return getbelowthousandValues(firstPart) + " " + words[1];
                }

            }
            else
            {
                if (firstPart < 100)
                {
                    return getbelowHundradValues(firstPart) + " " + words[1] + " " + getbelowthousandValues(secoundPart);
                }
                if (firstPart >= 100 && firstPart < 1000)
                {
                    return getbelowthousandValues(firstPart) + " " + words[1] + " " + getbelowthousandValues(secoundPart);
                }
            }
            return "";
        }

        public string getbelowbilionvalues(int value)
        {
            int firstPart = value / 1000000;
            int secAndThirdPart = value % 1000000;
            // int secoundPart = secAndThirdPart % 1000;
            //  int thirdPart = value % 1000;

            if (secAndThirdPart == 0)
            {
                if (firstPart < 100)
                {
                    return getbelowHundradValues(firstPart) + " " + words[2];
                }
                if (firstPart >= 100 && firstPart < 1000)
                {
                    return getbelowthousandValues(firstPart) + " " + words[2];
                }
            }
            else
            {
                if (firstPart < 100)
                {
                    return getbelowHundradValues(firstPart) + " " + words[2] + " " + getbelowmilionValues(secAndThirdPart);
                }
                if (firstPart >= 100 && firstPart < 1000)
                {
                    return getbelowthousandValues(firstPart) + " " + words[2] + " " + getbelowmilionValues(secAndThirdPart);
                }

            }

            return "";

        }

        public string getbelowtrilionvalues(int value)
        {
            int firstPart = value / 1000000000;
            int restPart = value % 1000000000;


            //MessageBox.Show(firstPart.ToString());

            if (restPart == 0)
            {
                if (firstPart < 100)
                {
                    return getbelowHundradValues(firstPart) + " " + words[3];
                }
                if (firstPart >= 100 && firstPart < 1000)
                {
                    return getbelowthousandValues(firstPart) + " " + words[3];
                }

            }
            else
            {
                if (firstPart < 100)
                {
                    return getbelowHundradValues(firstPart) + " " + words[3] + " " + getbelowbilionvalues(restPart);
                }
                if (firstPart >= 100 && firstPart < 1000)
                {
                    return getbelowthousandValues(firstPart) + " " + words[3] + " " + getbelowbilionvalues(restPart);
                }
            }

            return "";
        }

        private void tb_beAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //not considering cens
                if (tb_beAmount.Text != null)
                {
                    double priced = double.Parse(tb_beAmount.Text);

                    // Get only the integer part
                    int price = (int)Math.Floor(priced);

                    // Get the cents
                    int priceCent = (int)Math.Round((priced - price) * 100);

                    if (priceCent == 0) //when no cents
                    {
                        //0
                        //zero
                        if (price == 0)
                        {
                            lbl_amountInWords.Text = zeroToNine[0];
                        }

                        //1-99
                        if (price > 0 && price < 100)
                        {
                            lbl_amountInWords.Text = getbelowHundradValues(price) + " Only";
                        }

                        //100 - 999
                        if (price >= 100 && price < 1000)
                        {

                            lbl_amountInWords.Text = getbelowthousandValues(price) + " Only";
                        }

                        //1000 - 999 999
                        if (price >= 1000 && price <= 999999)
                        {
                            lbl_amountInWords.Text = getbelowmilionValues(price) + " Only";

                        }

                        //1 000 000 - 999 999 999
                        if (price >= 1000000 && price <= 999999999)
                        {
                            lbl_amountInWords.Text = getbelowbilionvalues(price) + " Only";
                        }

                        //1 000 000 000 - 999 999 999 999 //not working after 2 bilion
                        if (price >= 1000000000 && price <= 999999999999)
                        {
                            //MessageBox.Show("dwd"); 
                            lbl_amountInWords.Text = getbelowtrilionvalues(price) + " Only";
                        }


                    }

                    else if (priceCent != 0) //when there is cens
                    {


                        string cents = " and " + getbelowHundradValues(priceCent) + " cents Only";

                        //0
                        //zero
                        if (price == 0)
                        {
                            lbl_amountInWords.Text = zeroToNine[0];
                        }

                        //1-99
                        if (price > 0 && price < 100)
                        {
                            lbl_amountInWords.Text = getbelowHundradValues(price) + cents;
                        }

                        //100 - 999
                        if (price >= 100 && price < 1000)
                        {

                            lbl_amountInWords.Text = getbelowthousandValues(price) + cents;
                        }

                        //1000 - 999 999
                        if (price >= 1000 && price <= 999999)
                        {
                            lbl_amountInWords.Text = getbelowmilionValues(price) + cents;

                        }

                        //1 000 000 - 999 999 999
                        if (price >= 1000000 && price <= 999999999)
                        {
                            lbl_amountInWords.Text = getbelowbilionvalues(price) + cents;
                        }

                        //1 000 000 000 - 999 999 999 999
                        if (price >= 1000000000 && price <= 999999999999)
                        {
                            //MessageBox.Show("dwd");
                            lbl_amountInWords.Text = getbelowtrilionvalues(price) + cents;
                        }

                    }

                }
                else
                {
                    lbl_amountInWords.Text = "";
                }

            }
            catch
            {

            }





        }

        #endregion

        //add table to the database
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                FormMAIN formMain = Application.OpenForms.OfType<FormMAIN>().FirstOrDefault();

                if (formMain != null)
                {
                    string editor = formMain.Lbluser;
                    string fileName = FileName;
                    DateTime date = dtp_date.Value;
                    string purpose = tb_purpose.Text;
                    string inv = tb_inv.Text;
                    string description = tb_description.Text;
                    string terms = tb_terms.Text;
                    string goods = cb_goods.SelectedItem.ToString();
                    string hcCode = tb_hc.Text;
                    string cutrior = tb_curierNo.Text;
                    string applName = lbl_seName.Text;
                    string applAddress = lbl_seAddress.Text;
                    string applMail = cb_email1.SelectedItem.ToString() + "," + cb_email2.SelectedItem.ToString();
                    string applPhone = lbl_sePhone.Text;
                    string beName = tb_beName.Text;
                    string beAddress = lbl_beAddress.Text;
                    string beCurrType = cb_beCurrency.SelectedItem.ToString();
                    decimal roundedAmount = decimal.Parse(tb_beAmount.Text);
                    decimal beAmount = Math.Round(roundedAmount, 2); //---->
                    string beAmountInWords = lbl_amountInWords.Text;
                    string bebankName = lbl_beBankname.Text;
                    string beBranchName = lbl_Branchname.Text;
                    string beCountry = lbl_beBankCountry.Text;
                    string beAccountNo = lbl_beAcc.Text;
                    string beBranchCode = lbl_beSort.Text;
                    string beswiftCode = lbl_beSwiftCode.Text;
                    string beInterBank = lbl_beCorrespondingBank.Text;













                }
            

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


