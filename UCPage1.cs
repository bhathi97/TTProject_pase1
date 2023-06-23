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


        private string _purpose;
        public string Purpose
        {
            get
            {
                return _purpose;
            }
            set
            {
                _purpose = value;
                //lbl_Purpose.Text = _purpose;
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




    }
}
