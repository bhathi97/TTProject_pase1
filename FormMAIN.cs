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
    public partial class FormMAIN : Form
    {

        #region properties

        private string _lblTest; //to Show Opened Item Name
        public string LblTest
        {
            get { return _lblTest; }
            set
            {
                _lblTest = value;
                lblFormNameShow.Text = value; // set the value to the Label
            }
        }


        private string _lblTTName;
        public string LblTTName
        {
            get { return _lblTTName; }
            set
            {
                _lblTTName = value;
                lbl_TTNameShowing.Text = value;
            }
        }

        private string _lbluser;
        public string Lbluser
        {
            get { return _lbluser; }
            set
            {
                _lbluser = value;
                lbl_User.Text = value;
            }
        }

        private int _userID;
        public int UserID
        {
            get { return _userID; }
            set
            {
                _userID = value;

            }
        }


        #endregion


        public FormMAIN()
        {
            InitializeComponent();
        }

        #region Property to show FileName
        public string LabelToShowFileName { get; set; }
        #endregion
        //public string LabelToShowFileName { get; set; }
        public string LabelToShowTTName { get; set; }


        //to save usercontrols **********************************
        //FileHandeling button

        #region userControl
        private UCFileHandeling _fileHandelingUserControl;
        public UCFileHandeling FileHandelingUserControl
        {
            get { return _fileHandelingUserControl; }
            set { _fileHandelingUserControl = value; }
        }


        private UCConfirmHandeling _confirmHandelingUserControl;
        public UCConfirmHandeling ConfirmHandelingUserControl
        {
            get { return _confirmHandelingUserControl; }
            set { _confirmHandelingUserControl = value; }
        }


        //databaseHAndeling button
        private UCDatabaseHandeling _databaseHandelingUserControl;

        public UCDatabaseHandeling DatabaseHandelingUserControl
        {
            get { return _databaseHandelingUserControl; }
            set { _databaseHandelingUserControl = value; }
        }



        //BENEFICIARY button
        private UCBeneficiary _BenificiaryUserControl;

        public UCBeneficiary BenificiaryUserControl
        {
            get { return _BenificiaryUserControl; }
            set { _BenificiaryUserControl = value; }
        }

        //Sender button
        private UCSender _SenderUserControl;

        public UCSender SenderUserControl
        {
            get { return _SenderUserControl; }
            set { _SenderUserControl = value; }
        }


        //File button
        private UCFileEditsHandeling _fileControl;
        public UCFileEditsHandeling FileControl
        {
            get { return _fileControl; }
            set { _fileControl = value; }

        }



        #endregion



        private void FormMAIN_Load(object sender, EventArgs e)
        {
            //make the Window maximize
            this.WindowState = FormWindowState.Maximized;

            // Create a ToolTip instance
            ToolTip toolTip = new ToolTip();

            // Set the tooltip text for buttons
            toolTip.SetToolTip(btnNewRecord, "Add new TELEGRAPHIC TRANSFER");
            toolTip.SetToolTip(btnConfirmRecord, "Confirm typed TELEGRAPHIC TRANSFER");
            toolTip.SetToolTip(btnDataBaseUser, "Users Database Manager");
            toolTip.SetToolTip(btn_DatabaseSender, "Sender Database Manager");
            toolTip.SetToolTip(btn_Logout, "Logout from the system");
            lblFormNameShow.Text = LabelToShowFileName;
            lbl_TTNameShowing.Text = LabelToShowTTName;

        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (_fileHandelingUserControl == null)
                {
                    FileHandelingUserControl = new UCFileHandeling();

                }

                // Hide all other controls within panel1
                foreach (Control control in pnllLoadSpace.Controls)
                {
                    control.Visible = false;
                }

                //show this
                FileHandelingUserControl.Show();

                //change the dock property
                FileHandelingUserControl.Dock = DockStyle.Fill;

                //add to the panal
                pnllLoadSpace.Controls.Add(FileHandelingUserControl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                if (_databaseHandelingUserControl == null)
                {
                    DatabaseHandelingUserControl = new UCDatabaseHandeling();

                }

                // Hide all other controls within panel1
                foreach (Control control in pnllLoadSpace.Controls)
                {
                    control.Visible = false;
                }

                //show this
                DatabaseHandelingUserControl.Show();

                //change the dock property
                DatabaseHandelingUserControl.Dock = DockStyle.Fill;

                //add to the panal
                pnllLoadSpace.Controls.Add(DatabaseHandelingUserControl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnDatabaseBenificiary_Click(object sender, EventArgs e)
        {
            try
            {
                if (_BenificiaryUserControl == null)
                {
                    BenificiaryUserControl = new UCBeneficiary();

                }

                // Hide all other controls within panel1
                foreach (Control control in pnllLoadSpace.Controls)
                {
                    control.Visible = false;
                }

                //show this
                BenificiaryUserControl.Show();

                //change the dock property
                BenificiaryUserControl.Dock = DockStyle.Fill;

                //add to the panal
                pnllLoadSpace.Controls.Add(BenificiaryUserControl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DatabaseSender_Click(object sender, EventArgs e)
        {
            try
            {
                if (_SenderUserControl == null)
                {
                    SenderUserControl = new UCSender();

                }

                // Hide all other controls within panel1
                foreach (Control control in pnllLoadSpace.Controls)
                {
                    control.Visible = false;
                }

                //show this
                SenderUserControl.Show();

                //change the dock property
                SenderUserControl.Dock = DockStyle.Fill;

                //add to the panal
                pnllLoadSpace.Controls.Add(SenderUserControl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormMAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FormLogin formLogin = Application.OpenForms.OfType<FormLogin>().FirstOrDefault();
                if (formLogin != null)
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form != formLogin)
                        {
                            form.Enabled = false;
                        }
                        else
                        {
                            form.Show();
                        }
                    }
                }


            }
            //exception handling
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (_confirmHandelingUserControl == null)
                {
                    ConfirmHandelingUserControl = new UCConfirmHandeling();

                }

                // Hide all other controls within panel1
                foreach (Control control in pnllLoadSpace.Controls)
                {
                    control.Visible = false;
                }

                //show this
                ConfirmHandelingUserControl.Show();

                //change the dock property
                ConfirmHandelingUserControl.Dock = DockStyle.Fill;

                //add to the panal
                pnllLoadSpace.Controls.Add(ConfirmHandelingUserControl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_formsControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (_fileControl == null)
                {
                    FileControl = new UCFileEditsHandeling();

                }

                // Hide all other controls within panel1
                foreach (Control control in pnllLoadSpace.Controls)
                {
                    control.Visible = false;
                }

                //show this
                FileControl.Show();

                //change the dock property
                FileControl.Dock = DockStyle.Fill;

                //add to the panal
                pnllLoadSpace.Controls.Add(FileControl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
