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

        private string _purpose;
        public string Purpose
        {
            get { return _purpose; }
            set
            {
                _purpose = value;
                lbl_purpose.Text = value;
            }
        }

        private string _insertBy;
        public string InsertBy
        {
            get { return _insertBy; }
            set
            {
                _insertBy = value;
                lbl_editor.Text = value;
            }
        }

        private string _addDate;

        public string AddDate
        {
            get { return _addDate; }
            set
            {
                _addDate = value;
                lbl_date.Text = value;
            }

        }




        #endregion



        public UCItemsToConfirm()
        {
            InitializeComponent();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormPrint newForm = new FormPrint())
                {
                    newForm.FormName = _fileName;
                    newForm.Purpose = _purpose;
                    newForm.InsertBy = _insertBy;
                    newForm.AddDate = _addDate;

                    // Disable all other forms
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form != newForm)
                        {

                            form.Enabled = false;
                        }
                    }



                    // Show the new FormMain
                    newForm.ShowDialog();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
