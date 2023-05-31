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
    public partial class UCTTItems : UserControl
    {

        #region Properties
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private int _fileId;
        public int FileId
        {
            get { return _fileId; }
            set { _fileId = value; }
        }
        #endregion



        public UCTTItems()
        {
            InitializeComponent();
        }

        private void UCTTItems_Load(object sender, EventArgs e)
        {
            lblFormName.Text = FileName;
        }

        private void btn_editForms_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if FormMAIN is already open
                FormMAIN formMain = Application.OpenForms.OfType<FormMAIN>().FirstOrDefault();

                if (formMain != null)
                { 
                    formMain.LblTTName = FileName; //to display file name  

                    // FormMAIN is open, check for UCFileHandeling user control
                    UCFileHandeling FileHandelingUserControl = formMain.FileHandelingUserControl;

                    if (FileHandelingUserControl != null)
                    {
                        UCTTForm uCForms= FileHandelingUserControl.UserControlFormShow as UCTTForm;

                        if (uCForms != null && !uCForms.IsDisposed)
                        {
                            uCForms.Dispose();
                        }

                        uCForms = new UCTTForm();
                        uCForms.LblFormName = FileName;
                        uCForms.LblFormID = FileId;
                        uCForms.Show();
                        uCForms.Dock = DockStyle.Fill;

                        FileHandelingUserControl.UserControlFormShow = uCForms;

                    }

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
