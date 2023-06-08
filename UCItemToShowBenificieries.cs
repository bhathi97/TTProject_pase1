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


        #endregion

        public UCItemToShowBenificieries()
        {
            InitializeComponent();
        }
    }
}
