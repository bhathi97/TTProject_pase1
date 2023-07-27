
using System.Data.SqlClient;

namespace project_TelegraphicTransfer
{
    public partial class FormAddNewFile : Form
    {
        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion


        #region properties
        private int _creatorID;
        public int CreatorID
        {
            get { return _creatorID; }
            set
            {
                _creatorID = value;

            }
        }
        #endregion

        public FormAddNewFile()
        {
            InitializeComponent();
        }

        private void FormAddNewFile_Load(object sender, EventArgs e)
        {
            // Clear any existing items in the ComboBox
            cb_year.Items.Clear();

            // Add years from 2000 to 2030 to the ComboBox
            for (int year = 2000; year <= 2030; year++)
            {
                cb_year.Items.Add(year);
            }
        }

        private void FormAddNewFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Enable all previously disabled forms
            foreach (Form form in Application.OpenForms)
            {
                form.Enabled = true;
            }



        }

        private void btn_CreateNewFORM_Click(object sender, EventArgs e)
        {
            try
            {
                connsql.Open();

                string code = cb_code.Text;
                string number = tb_number.Text;
                string year = cb_year.Text;

                string fileName = code + "/" + number + "/" + year;

                // Check if the fileName already exists in the database
                SqlCommand cmdCheckDuplicate = new SqlCommand("SELECT COUNT(*) FROM tbl_FILE WHERE NAME = @name", connsql);
                cmdCheckDuplicate.Parameters.AddWithValue("@name", fileName);
                int duplicateCount = (int)cmdCheckDuplicate.ExecuteScalar();

                if (duplicateCount > 0)
                {
                    MessageBox.Show("A file with the same name already exists.");
                }
                else
                {
                    SqlCommand cmdItemInsert = new SqlCommand("INSERT INTO tbl_FILE (NAME, DATE_TIME, EDITOR) VALUES (@name, @time, @editor)", connsql);
                    cmdItemInsert.Parameters.AddWithValue("@name", fileName);
                    cmdItemInsert.Parameters.AddWithValue("@time", DateTime.Now);
                    cmdItemInsert.Parameters.AddWithValue("@editor", CreatorID);
                    cmdItemInsert.ExecuteNonQuery();
                    MessageBox.Show("File created successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connsql.Close();
                this.Close();
            }
        }





    }
}
