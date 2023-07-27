using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_TelegraphicTransfer
{
    public partial class UCItemToShowBenificieries : UserControl
    {
        
       


        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion

        #region properties
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                lbl_name.Text = value;
            }
        }

        private string _nicName;
        public string NicName
        {
            get { return _nicName; }
            set
            {
                _nicName = value;
                lbl_nicName.Text = value;
            }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                lbl_addr.Text = value;
            }
        }

        private string _country;
        public string Country
        {
            get { return _country; }
            set
            {
                _country = value;
                lbl_country.Text = value;
            }
        }

        private string _bankName;
        public string BankName
        {
            get { return _bankName; }
            set
            {
                _bankName = value;
                lbl_bankName.Text = "BANK NAME : " + value;
            }
        }

        private string _acc;
        public string Acc
        {
            get { return _acc; }
            set
            {
                _acc = value;
                lbl_accNo.Text = "BANK ACCOUNT : " + value;
            }
        }

        private string _branchName;
        public string BranchName
        {
            get { return _branchName; }
            set
            {
                _branchName = value;
                lbl_branchName.Text = "BRANCH NAME : " + value;
            }
        }

        private string _branchCode;
        public string BranchCode
        {
            get { return _branchCode; }
            set
            {
                _branchCode = value;
                lbl_branchCode.Text = "SORT/ROUTING/FEDWIRE/ABA/BSB/BANK-BRANCH CODE : " + value;
            }
        }


        private string _swift;
        public string Swift
        {
            get { return _swift; }
            set
            {
                _swift = value;
                lbl_swift.Text = "SWIFT CODE : " + value;
            }
        }

        private string _corBank;
        public string CorBank
        {
            get { return _corBank; }
            set
            {
                _corBank = value;
                lbl_corBank.Text = "CORRESPONDING / INTERMEDIATE BANK : " + value;
            }
        }



        #endregion

        public UCItemToShowBenificieries()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                
                FormEditBenificiary formEditBenificiary = new FormEditBenificiary();
              

                // Disable all other forms
                foreach (Form form in Application.OpenForms)
                {
                    if (form != formEditBenificiary)
                    {
                        form.Enabled = false;
                    }
                }

                formEditBenificiary.ShowDialog();

            }
            catch 
            {
                
            }
            finally
            {

            }
        }

       
    }
}
