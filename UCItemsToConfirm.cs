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
    public partial class UCItemsToConfirm : UserControl
    {
        #region properties

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                lbl_showFileName.Text = value;
            }
        }


        #endregion



        public UCItemsToConfirm()
        {
            InitializeComponent();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {

        }
    }
}
