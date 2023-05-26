
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

            try
            {
                connsql.Open();

                // Create a SqlCommand to retrieve the rows
                SqlCommand cmdItemLoad = new SqlCommand("SELECT * FROM tbl_TEST_child WHERE fk_ID = @fid", connsql);
                cmdItemLoad.Parameters.AddWithValue("@fid", FileId);

                // Execute the query and retrieve the rows
                SqlDataReader reader = cmdItemLoad.ExecuteReader();

                while (reader.Read())
                {
                    UCTTItems uCTTItems = new UCTTItems();
                    uCTTItems.FileName = reader["Name"].ToString();
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
