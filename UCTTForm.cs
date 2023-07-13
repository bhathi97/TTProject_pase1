using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_TelegraphicTransfer
{
    public partial class UCTTForm : UserControl
    {

        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion



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


        private int _seID;
        public int SEID
        {
            get { return _seID; }
            set
            {
                _seID = value;

            }
        }



        #endregion

        #region labelLoad

        public string senderName 
        {
            set 
            {
                lbl_seName.Text = value;
            }        
        }

        public string Purpose
        {
            set
            {
                tb_purpose.Text = value;
            }
        }

        private bool _btnState;
        public bool BtnState
        {
            set
            {
                _btnState = value;
            }
        }

        public string Inv
        {
            set
            {
                tb_inv.Text = value;
            }
        }

        public string Desc
        {
            set
            {
                tb_description.Text = value;
            }
        }

        public string Trade
        {
            set
            {
                tb_terms.Text = value;
            }
        }

        #endregion

        public UCTTForm()
        {
            InitializeComponent();
        }

        private void UCTTForm_Load(object sender, EventArgs e)
        {
            loadSeData();
            if(_btnState == false)
            {
                btn_add.Visible = false;
            }
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
                    int editorID = formMain.UserID;
                    DateTime dateTime = DateTime.Now;
                    string formName = _lblFormName;
                    string fileName = FileName;

                    DateTime date = dtp_date.Value;
                    string purpose = tb_purpose.Text;
                    string inv = tb_inv.Text;

                    // Validation for tb_inv.Text
                    if (!HasAlphanumericCharacter(tb_inv.Text))
                    {
                        MessageBox.Show("Invalid reference number. Please enter at least one alphanumeric character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string description = tb_description.Text;
                    string terms = tb_terms.Text;
                    string goods = cb_goods.SelectedItem.ToString();
                    string hcCode = tb_hc.Text;
                    string curior = tb_curierNo.Text;

                    string applName = lbl_seName.Text;
                    int appID = _seID;
                    string applAddress = lbl_seAddress.Text;
                    string appBusiness = lbl_seBusiness.Text;
                    string applMail = cb_email1.SelectedItem.ToString() + "," + cb_email2.SelectedItem.ToString();
                    string email1 = cb_email1.SelectedItem.ToString();
                    string email2 = cb_email2.SelectedItem.ToString();

                    string applPhone = lbl_sePhone.Text;
                    string appTax = lbl_seVAT.Text;

                    string beNIC = tb_beNicName.Text;
                    string beName = lbl_beName.Text;
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

                    string charges = "";
                    if (rb_beApplicant.Checked)
                    {
                        charges = "Applicant";
                    }
                    else if (rb_beBenificiary.Checked)
                    {
                        charges = "Benificiary";
                    }

                    string doEvent = "ADD";
                    int isConfirmed = 0;

                    DialogResult result = MessageBox.Show("Are you sure you want to add the record to the database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        connsql.Open();
                       string sqlQToInsertTo_TOF_Table = "insert into tbl_TRANSFER_ORDER_FORM(FILE_REFERENCE, DOCUMENT, SENDER_ID, SENDER_NAME, SENDER_ADDRESS, SENDER_BUSINESS, SENDER_TAX, SENDER_TPNO, SENDER_EMAIL1, SENDER_EMAIL2, PURPOSE, INV, DESCRIPTION, TRADE_TERMS, GOOD_STATE, HS_CODES, COURIER_NO, BENEFICIARY_NIC_NAME, BENEFICIARY_NAME, BENEFICIARY_ADDRESS, BENEFICIARY_BANK_NAME, BENEFICIARY_BRANCH_NAME, BENEFICIARY_BRANCH_CODE, BENEFICIARY_SWIFT_CODE, BENEFICIARY_COUNTRY, BENEFICIARY_ACC_NO, BENEFICIARY_INTERMEDIATE_BANK, CURRENCY_TYPE, AMOUNT, AMOUNT_WORDS, CHARGES, ADD_EDITOR, ADD_TIME, ADD_EVENT, ISCONFIRMED) values (@FileName, @formName, @appID, @applName, @applAddress, @appBusiness, @appTax, @applPhone, @email1, @email2, @purpose, @inv, @description, @terms, @goods, @hcCode, @curior, @beNIC, @beName, @beAddress, @bebankName, @beBranchName, @beBranchCode, @beswiftCode, @beCountry, @beAccountNo, @beInterBank, @beCurrType, @beAmount, @beAmountInWords, @charges, @editor, @dateTime, @doEvent, @isConfirmed)";

                    using (SqlCommand command = new SqlCommand(sqlQToInsertTo_TOF_Table, connsql))
                    {

                        command.Parameters.AddWithValue("@FileName", fileName);
                        command.Parameters.AddWithValue("@formName", formName);
                        command.Parameters.AddWithValue("@appID", appID);
                        command.Parameters.AddWithValue("@applName", applName);
                        command.Parameters.AddWithValue("@applAddress", applAddress);
                        command.Parameters.AddWithValue("@appBusiness", appBusiness);
                        command.Parameters.AddWithValue("@appTax", appTax);
                        command.Parameters.AddWithValue("@applPhone", applPhone);
                        command.Parameters.AddWithValue("@email1", email1);
                        command.Parameters.AddWithValue("@email2", email2);
                        command.Parameters.AddWithValue("@purpose", purpose);
                        command.Parameters.AddWithValue("@inv", inv);

                            if (!HasAlphanumericCharacter(tb_inv.Text))
                            {
                                MessageBox.Show("Invalid reference number. Please enter at least one alphanumeric character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@terms", terms);
                        command.Parameters.AddWithValue("@goods", goods);
                        command.Parameters.AddWithValue("@hcCode", hcCode);
                        command.Parameters.AddWithValue("@curior", curior);
                        command.Parameters.AddWithValue("@beNIC", beNIC);
                        command.Parameters.AddWithValue("@beName", beName);
                        command.Parameters.AddWithValue("@beAddress", beAddress);
                        command.Parameters.AddWithValue("@bebankName", bebankName);
                        command.Parameters.AddWithValue("@beBranchName", beBranchName);
                        command.Parameters.AddWithValue("@beBranchCode", beBranchCode);
                        command.Parameters.AddWithValue("@beswiftCode", beswiftCode);
                        command.Parameters.AddWithValue("@beCountry", beCountry);
                        command.Parameters.AddWithValue("@beAccountNo", beAccountNo);
                        command.Parameters.AddWithValue("@beInterBank", beInterBank);
                        command.Parameters.AddWithValue("@beCurrType", beCurrType);
                        command.Parameters.AddWithValue("@beAmount", beAmount);
                        command.Parameters.AddWithValue("@beAmountInWords", beAmountInWords);
                        command.Parameters.AddWithValue("@charges", charges);
                        command.Parameters.AddWithValue("@editor", editor);
                        command.Parameters.AddWithValue("@dateTime", dateTime);
                        command.Parameters.AddWithValue("@doEvent", doEvent);
                        command.Parameters.AddWithValue("@isConfirmed", isConfirmed);


                        command.ExecuteNonQuery();

                        MessageBox.Show("Successfully Added to the database");
                    }

                }
             }
                else
                {

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connsql.Close();
            }
        }

        private bool HasAlphanumericCharacter(string input)
        {
            // Check if the input contains at least one alphanumeric character
            return Regex.IsMatch(input, @"[a-zA-Z0-9]");
        }



        //TO LOAD BENEFICIARY DATA
        private void tb_beNicName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == (char)Keys.Enter)
                {
                    // Perform your desired action here
                    string be_name = tb_beNicName.Text;

                    connsql.Open();

                    SqlCommand cmdItemLoad = new SqlCommand("SELECT * FROM tbl_BENEFICIARY_MASTER WHERE NIC_NAME = @id", connsql);
                    cmdItemLoad.Parameters.AddWithValue("@id", be_name);

                    // Execute the query and retrieve the rows


                    SqlDataReader reader = cmdItemLoad.ExecuteReader();

                    while (reader.Read())
                    {
                        //_seID = int.Parse(reader.GetInt32("ID").ToString());
                        lbl_beName.Text = reader["NAME"].ToString();
                        lbl_beAddress.Text = reader["ADDRESS"].ToString();
                        lbl_beBankname.Text = reader["BANK_NAME"].ToString();
                        lbl_Branchname.Text = reader["BRANCH_NAME"].ToString();
                        lbl_beBankCountry.Text = reader["COUNTRY"].ToString();
                        lbl_beAcc.Text = reader["ACC_NO"].ToString();
                        lbl_beSort.Text = reader["BRANCH_CODE"].ToString();
                        lbl_beSwiftCode.Text = reader["SWIFT_CODE"].ToString();
                        lbl_beCorrespondingBank.Text = reader["INTERMEDIATE_BANK"].ToString();

                    }

                    reader.Close();

                }

            }
            catch
            {

            }
            finally
            {
                connsql.Close();
            }
        }

        //TO LOAD SENDER DETAILS
        private void loadSeData()
        {
            try
            {
                string id = "";
                connsql.Open();

                SqlCommand cmdItemLoad = new SqlCommand("SELECT TOP 1 * FROM tbl_SENDER_MASTER", connsql);

                // Execute the query and retrieve the rows
                SqlDataReader reader = cmdItemLoad.ExecuteReader();

                while (reader.Read())
                {
                    id = reader["ID"].ToString();
                    lbl_seName.Text = reader["NAME"].ToString();
                    lbl_seAddress.Text = reader["ADDRESS"].ToString();
                    lbl_seBusiness.Text = reader["BUSINESS"].ToString();
                    lbl_seTIN.Text = reader["TIN"].ToString();
                    lbl_sePhone.Text = reader["TPNO"].ToString();
                    lbl_seVAT.Text = reader["TAX"].ToString();

                }

                reader.Close();

                SqlCommand cmdEmailLoad = new SqlCommand("SELECT * FROM tbl_EMAIL_MASTER where FID = @fid", connsql);
                cmdEmailLoad.Parameters.AddWithValue("fid", id);

                // Execute the query and retrieve the rows
                SqlDataReader reader1 = cmdEmailLoad.ExecuteReader();

                while (reader1.Read())
                {
                    string mails = reader1["EMAIL"].ToString();
                    cb_email1.Items.Add(mails);
                    cb_email2.Items.Add(mails);


                }

                reader1.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connsql.Close();
            }
        }

        private void cb_goods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_inv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


