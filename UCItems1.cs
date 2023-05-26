

namespace project_TelegraphicTransfer
{
    public partial class UCItems1 : UserControl
    {
        public UCItems1()
        {
            InitializeComponent();
        }

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

        private void UCItems1_Load(object sender, EventArgs e)
        {
            lblFileNameShowing.Text = FileName;

        }

        private void btn_editTTs_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if FormMAIN is already open
                FormMAIN formMain = Application.OpenForms.OfType<FormMAIN>().FirstOrDefault();

                if (formMain != null)
                {
                    formMain.LblTest = FileName; //to display file name

                    // FormMAIN is open, check for UCFileHandeling user control
                    UCFileHandeling FileHandelingUserControl = formMain.FileHandelingUserControl;

                    if (FileHandelingUserControl != null)
                    {
                        UCTTsHandeling uCTTsHandeling = FileHandelingUserControl.UserControlTTShow as UCTTsHandeling;

                        if (uCTTsHandeling != null && !uCTTsHandeling.IsDisposed)
                        {
                            uCTTsHandeling.Dispose();
                        }

                        uCTTsHandeling = new UCTTsHandeling();
                        uCTTsHandeling.FileName = FileName;
                        uCTTsHandeling.FileId = FileId;
                        uCTTsHandeling.Show();
                        uCTTsHandeling.Dock = DockStyle.Fill;

                        FileHandelingUserControl.UserControlTTShow = uCTTsHandeling;

                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }




    }
}
