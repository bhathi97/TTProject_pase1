using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


namespace project_TelegraphicTransfer
{
    public partial class UCFileHandeling : UserControl
    {
        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion

        #region properties
        private string _lblTest;
        public string LblTest
        {
            get { return _lblTest; }
            set
            {
                _lblTest = value;
                lblTest.Text = value;
            }
        }

        private UserControl _userControlTTShow;
        public UserControl UserControlTTShow
        {
            get { return _userControlTTShow; }
            set
            {
                _userControlTTShow = value;
                splitContainerTTHandleing.Panel1.Controls.Add(value);
            }
        }


        private UserControl _userControlFormShow;
        public UserControl UserControlFormShow
        {
            get { return _userControlFormShow; }
            set
            {
                _userControlFormShow = value;
                splitContainerTTHandleing.Panel2.Controls.Add(value);
            }
        }

        private int _fileId;
        public int FileId
        {
            get { return _fileId; }
            set { _fileId = value; }
        }

        #endregion

        public UCFileHandeling()
        {
            InitializeComponent();
            //lblTest.Text = _lblTest;

        }



        //++++++++++++++++++++++++++++++++ have to implement
        public void loadItems()
        {
            try
            {
                connsql.Open();
                // Create a SqlCommand to retrieve the rows
                SqlCommand cmdItemLoad = new SqlCommand("SELECT * FROM tbl_TEST_parent", connsql);

                // Execute the query and retrieve the rows
                SqlDataReader reader = cmdItemLoad.ExecuteReader();

                while (reader.Read())
                {
                    UCItems1 uCItem = new UCItems1();
                    uCItem.FileName = reader["Name"].ToString();
                    uCItem.FileId = int.Parse(reader["ID"].ToString());

                    // Add UCItems1 control to the panel
                    flp_fileItemsShowingPanel.Controls.Add(uCItem);
                }

                reader.Close();
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

        private void UCFileHandeling_Load(object sender, EventArgs e)
        {
            loadItems();



        }
    }
}
