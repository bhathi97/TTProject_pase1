
using System.Data.SqlClient;


namespace project_TelegraphicTransfer
{
    public partial class UCTTsHandeling : UserControl
    {
        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion


        #region Properties
        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                //lblFolderName.Text = value;
            }
        }

        private int _fileId;
        public int FileId
        {
            get { return _fileId; }
            set { _fileId = value; }
        }




        #endregion



        public UCTTsHandeling()
        {
            InitializeComponent();
        }

        private void UCTTsHandeling_Load(object sender, EventArgs e)
        {
            //lblFolderName.Text = FileId.ToString();
            lblFolderName.Text = FileName;

            LoadItems();


        }

        private void btn_CreateNewFORM_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddNewForm formAddNewForm = new FormAddNewForm();
                formAddNewForm.FileName = FileName;
                formAddNewForm.FileID = FileId;

                // Disable all other forms
                foreach (Form form in Application.OpenForms)
                {
                    if (form != formAddNewForm)
                    {

                        form.Enabled = false;
                    }
                }



                // Show the new FormMain
                formAddNewForm.ShowDialog();
                //after form closed
                LoadItems();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void LoadItems()
        {
            try
            {
                flp_ItemViewver.Controls.Clear();

                connsql.Open();

                // Create a SqlCommand to retrieve the rows


                SqlCommand cmdItemLoad = new SqlCommand("SELECT * FROM tbl_TRANSACTION WHERE FID = @fid ORDER BY DATE_TIME DESC", connsql);
                cmdItemLoad.Parameters.AddWithValue("@fid", FileId);

                // Execute the query and retrieve the rows
                SqlDataReader reader = cmdItemLoad.ExecuteReader();

                while (reader.Read())
                {
                    UCTTItems uCTTItems = new UCTTItems();
                    uCTTItems.FileName = reader["NAME"].ToString();
                    uCTTItems.FName = FileName;
                    //MessageBox.Show(FileName);

                    // Add UCItems1 control to the panel
                    flp_ItemViewver.Controls.Add(uCTTItems);
                }

                reader.Close();
                connsql.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connsql.Close();
            }

        }
    }
}
