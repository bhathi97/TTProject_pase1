
using System.Data.SqlClient;

namespace project_TelegraphicTransfer
{
    public partial class FormAddNewFile : Form
    {
        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
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
                //MessageBox.Show(code + "/" + number + "/" + year);
                SqlCommand cmdItemInsert = new SqlCommand("INSERT INTO tbl_FILE (NAME,DATE_TIME) values (@name,@time)", connsql);
                cmdItemInsert.Parameters.AddWithValue("@name", fileName);
                cmdItemInsert.Parameters.AddWithValue("@time", DateTime.Now);
                cmdItemInsert.ExecuteNonQuery();

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
