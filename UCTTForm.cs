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


        #endregion

        public UCTTForm()
        {
            InitializeComponent();
        }

        private void UCTTForm_Load(object sender, EventArgs e)
        {

        }
    }
}

//--
