using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_TelegraphicTransfer
{
    public partial class UCPage2 : UserControl
    {


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
                lbl_name.Text = value;
            }
        }


        public string Address
        {
            set
            {
                lbl_address.Text = value;
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
                ldl_phone.Text = value;
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


        private string _insert_by;
        public string INSERT_BY
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






        #endregion




        public UCPage2()
        {
            InitializeComponent();
        }

        private void UCPage1_Load(object sender, EventArgs e)
        {
            lbl_purpose.Text = _purpose;


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
