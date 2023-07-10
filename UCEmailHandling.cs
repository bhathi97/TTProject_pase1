using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_TelegraphicTransfer
{
    public partial class UCEmailHandling : UserControl
    {
        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion
        public UCEmailHandling()
        {
            InitializeComponent();
        }

        private void UCEmailHandling_Load(object sender, EventArgs e)
        {
            // Set up the DataGridView columns
            dgvEmail.ColumnCount = 4;
            dgvEmail.Columns[0].Name = "id";
            dgvEmail.Columns[1].Name = "email";
            dgvEmail.Columns[2].Name = "epf";
            dgvEmail.Columns[3].Name = "fid";


            // Load data from the database
            LoadEmailData();

        }

        private void LoadEmailData()
        {
            try
            {
                connsql.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_EMAIL_MASTER;", connsql);
                SqlDataReader reader = cmd.ExecuteReader();

                // Clear existing data in DataGridView
                dgvEmail.Rows.Clear();

                // Loop through the data reader and add rows to the DataGridView
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string emaill = reader["EMAIL"].ToString();
                    string epff = reader["EPF"].ToString();
                    string fiid = reader["FID"].ToString();

                    dgvEmail.Rows.Add(id, emaill, epff, fiid);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connsql.Close();
            }
        }


        private void btnEAdd_Click(object sender, EventArgs e)
        {
            
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEmail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
