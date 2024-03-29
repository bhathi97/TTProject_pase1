﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace projectTelegraphicTransfer


{
    public partial class UCPage2 : UserControl
    {
        public String HsCode { get; set; }

        #region properties
        private string _formName;
        public string FormName
        {
            get
            {
                return _formName;
            }
            set
            {
                _formName = value;
                //lbl_formName.Text = _formName;
            }
        }


        public string Name
        {
            set
            {
                lbl_bname.Text = value;
            }
        }


        public string Address
        {
            set
            {
                lb_address.Text = value;
            }
        }

        public string business
        {
            set
            {
                lbl_business.Text = value;
            }
        }

        public string Phone
        {
            set
            {
                lb_phone.Text = value;
            }
        }

        public string Purpose
        {
            set
            {
                lbl_purpose.Text = value;
            }
        }



        private string _purpose;
        public string purpose
        {
            get
            {
                return _purpose;
            }
            set
            {
                _purpose = value;
                lbl_purpose.Text = _purpose;
            }
        }

        private string _InNo;
        public string InNo
        {
            get
            {
                return _InNo;
            }
            set
            {
                _InNo = value;
                lbl_Ivno.Text = _InNo;
            }
        }


        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                lbl_bname.Text = _name;
            }
        }

        private string _address;
        public string address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                lbl_baddress.Text = _address;
            }
        }

        private string _business;
        public string Business
        {
            get
            {
                return _business;
            }
            set
            {
                _business = value;
                lbl_profession.Text = _business;
            }
        }

        private string _phone;
        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
                lb_phone.Text = _phone;
            }
        }

        private string _vat;
        public string vat
        {
            get
            {
                return _vat;
            }
            set
            {
                _vat = value;
                lbl_vat.Text = _vat;
            }
        }

        private string _tin;
        public string Tin
        {
            get
            {
                return _tin;
            }
            set
            {
                _tin = value;
                lbl_tin.Text = _tin;
            }
        }

        private string _email1;
        public string email1
        {
            get
            {
                return _email1;
            }
            set
            {
                _email1 = value;
                lb_email1.Text = _email1;
            }
        }

        private string _email2;
        public string email2
        {
            get
            {
                return _email2;
            }
            set
            {
                _email2 = value;
                lb_email2.Text = _email2;
            }
        }

        private string _goods;
        public string goods
        {
            get
            {
                return _goods;
            }
            set
            {
                _goods= value;
                lbl_goods.Text = _goods;
            }
        }


        private string _code;
        public string code
        {
            get
            {
                return _code;
            }
            set
            {
                _code= value;
                lbl_code.Text = _code;
            }
        }

        private string _courier;
        public string courier
        {
            get
            {
                return _courier;
            }
            set
            {
                _courier= value;
                lbl_courier.Text = _courier;
            }
        }

        private string _Description;
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                lbl_incotern.Text = _Description;
            }
        }

        private string _Trede;
        public string Trede
        {
            get
            {
                return _Trede;
            }
            set
            {
                _Trede = value;
                lbl_trade.Text = _Trede;
            }
        }


        private string _bname;
        public string Bname
        {
            get
            {
                return _bname;
            }
            set
            {
                _bname = value;
                lb_bname.Text = _bname;
            }
        }

        private string _badress;
        public string Badress
        {
            get
            {
                return _badress;
            }
            set
            {
                _badress = value;
                lb_badress.Text = _badress;
            }
        }

        private string _amount;
        public string Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                lbl_amount.Text = _amount;
            }
        }

        private string _words;
        public string words
        {
            get
            {
                return _words;
            }
            set
            {
                _words = value;
                lbl_words.Text = _words;
            }
        }

        private string _bank;
        public string Bank
        {
            get
            {
                return _bank;
            }
            set
            {
                _bank = value;
                lbl_bank.Text = _bank;
            }
        }

        private string _branch;
        public string branch
        {
            get
            {
                return _branch;
            }
            set
            {
                _branch = value;
                lbl_branch.Text = _branch;
            }
        }


        private string _BBCode;
        public string BBCode
        {
            get
            {
                return _BBCode;
            }
            set
            {
                _BBCode = value;
                lbl_bcode.Text = _BBCode;
            }
        }

        private string _BSCode;
        public string BSCode
        {
            get
            {
                return _BSCode;
            }
            set
            {
                _BSCode = value;
                lbl_swiftcode.Text = _BSCode;
            }
        }

        private string _BCountry;
        public string BCountry
        {
            get
            {
                return _BCountry;
            }
            set
            {
                _BCountry = value;
                lbl_country.Text = _BCountry;
            }
        }

        private string _BANo;
        public string BANo
        {
            get
            {
                return _BANo;
            }
            set
            {
                _BANo = value;
                lbl_accountno.Text = _BANo;
            }
        }

        private string _BIBank;
        public string BIBank
        {
            get
            {
                return _BIBank;
            }
            set
            {
                _BIBank = value;
                lb_ibank.Text = _BIBank;
            }
        }

        private string _CType;
        public string CType
        {
            get
            {
                return _CType;
            }
            set
            {
                _CType = value;
                lbl_amount.Text = _CType;
            }
        }

        private string _AWords;
        public string AWords
        {
            get
            {
                return _AWords;
            }
            set
            {
                _AWords= value;
                lbl_words.Text = _AWords;
            }
        }




        private string _country;
        public string country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
                lbl_country.Text = _country;
            }
        }


        private string _insert_by;
        private SqlConnection connsql;

        public string INSERTBY
        {
            get
            {
                return _insert_by;
            }
            set
            {
                _insert_by = value;
                //lbl_Purpose.Text = _insert_by;
            }
        }

        public object NIC { get; private set; }






        #endregion




        public UCPage2()
        {
            InitializeComponent();
        }

        private void UCPage1_Load(object sender, EventArgs e)
        {
            lbl_purpose.Text = _purpose;
            lbl_bname.Text = _name;
            lb_address.Text = _address;
            lbl_profession.Text = _business;
            lb_phone.Text =_phone;
            lbl_vat.Text = _vat;
            lbl_tin.Text = _tin;
            lb_email1.Text = _email1;
            lb_email2.Text = _email2;

            lb_bname.Text = _bname;
            lb_badress.Text = _badress;
            lbl_amount.Text = _amount;
            lbl_words.Text = _words;
            lbl_bank.Text = _bank;
            lbl_branch.Text = _branch;
            lbl_country.Text = _country;

            //SqlCommand cmdItemLoad = new SqlCommand("SELECT * FROM tbl_BENEFICIART_TABLE WHERE FID = @nic ORDER BY DATE_TIME DESC", connsql);
            // cmdItemLoad.Parameters.AddWithValue("@nic", NIC);



            //sql
            //reader>>>



        }


        private void lbl_swiftcode_Click(object sender, EventArgs e)
        {

        }

        private void UCPage2_Load(object sender, EventArgs e)
        {

        }


    }
}
