using projectTelegraphicTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_TelegraphicTransfer
{
    public partial class UCItemToShowSender : UserControl
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
                lbl_name1.Text = value;
            }
        }

       
        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                lbl_address.Text = value;
            }
        }

        private string _business;
        public string Busines
        {
            get { return _business; }
            set
            {
                _business = value;
                lbl_business.Text = value;
            }
        }

        private string _tax;
        public string Tax
        {
            get { return _tax; }
            set
            {
                _tax = value;
                lbl_tax.Text = "TAX : " + value;
            }
        }

        private string _tpno;
        public string Tpno
        {
            get { return _tpno; }
            set
            {
                _tpno = value;
                lbl_TN.Text = "Telephone No : " + value;
            }
        }

        private string _tinno;
        public string Tinno
        {
            get { return _tinno; }
            set
            {
                _tinno = value;
                lbl_TinNo.Text = "Tin No : " + value;
            }
        }

   
        #endregion

        public UCItemToShowSender()
        {
            InitializeComponent();
        }

        private void btn_editSender_Click(object sender, EventArgs e)
        {
            try
            {
                FormEditSender formEditSender = new FormEditSender();

                // Disable all other forms
                foreach (Form form in Application.OpenForms)
                {
                    if (form != formEditSender)
                    {
                        form.Enabled = false;
                    }
                }

                formEditSender.ShowDialog();

            }
            catch
            {

            }
            finally
            {

            }
        }

        private void LoadSender(object sender, EventArgs e)
        {

        }
    }
}
