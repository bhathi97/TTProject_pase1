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
        private UCFileHandeling _fileHandelingUserControl;
        public UCFileHandeling FileHandelingUserControl
        {
            get { return _fileHandelingUserControl; }
            set { _fileHandelingUserControl = value; }
        }
        //databaseHAndeling button
        private UCDatabaseHandeling _databaseHandelingUserControl;

        public UCDatabaseHandeling DatabaseHandelingUserControl
        {
            get { return _databaseHandelingUserControl; }
            set { _databaseHandelingUserControl = value; }
        }

        private void FormMAIN_Load(object sender, EventArgs e)
        {
            //make the Window maximize
            this.WindowState = FormWindowState.Maximized;

            // Create a ToolTip instance
            ToolTip toolTip = new ToolTip();

            // Set the tooltip text for buttons
            toolTip.SetToolTip(btnNewRecord, "Add new TELEGRAPHIC TRANSFER");
            toolTip.SetToolTip(btnConfirmRecord, "Confirm typed TELEGRAPHIC TRANSFER");
            toolTip.SetToolTip(btnDataBaseUser, "Database Manager");

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
    }
}
