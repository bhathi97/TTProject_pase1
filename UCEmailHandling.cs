using projectTelegraphicTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                SqlCommand cmd = new SqlCommand("SELECT E.ID, E.EMAIL, E.EPF, S.ID AS FID FROM tbl_EMAIL_MASTER E, tbl_SENDER_MASTER S;", connsql);


                SqlDataReader reader = cmd.ExecuteReader();

                // Clear existing data in DataGridView
                dgvEmail.Rows.Clear();

                // Loop through the data reader and add rows to the DataGridView
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string email = reader["EMAIL"].ToString();
                    string epf = reader["EPF"].ToString();
                    string fid = reader["FID"].ToString();

                    dgvEmail.Rows.Add(id, email, epf, fid);
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
            try
            {
                if (string.IsNullOrEmpty(tbMail.Text))
                {
                    MessageBox.Show("Please enter an email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidateUsingRegex(tbMail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(tBepf.Text))
                {
                    MessageBox.Show("Please enter an EPF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsNumeric(tBepf.Text))
                {
                    MessageBox.Show("EPF number should contain only numeric digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string email = tbMail.Text;
                string epf = tBepf.Text;

                InsertDatabase(email, epf);

                // Refresh the DataGridView with updated data
                LoadEmailData();

                // Clear the input fields
                tbMail.Text = "";
                tBepf.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidateUsingRegex(string email)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private bool IsNumeric(string value)
        {
            // Check if the value contains only numeric digits
            return int.TryParse(value, out _);
        }



        private void InsertDatabase(string email, string epf)
        {
            try
            {
                connsql.Open();

                // Insert the data into tbl_EMAIL_MASTER
                SqlCommand insertCmd = new SqlCommand("INSERT INTO tbl_EMAIL_MASTER (EMAIL, EPF) VALUES (@email, @epf); SELECT SCOPE_IDENTITY();", connsql);
                insertCmd.Parameters.AddWithValue("@email", email);
                insertCmd.Parameters.AddWithValue("@epf", epf);

                int insertedId = Convert.ToInt32(insertCmd.ExecuteScalar());

                // Check if the ID exists in tbl_SENDER_MASTER
                SqlCommand checkCmd = new SqlCommand("SELECT ID FROM tbl_SENDER_MASTER WHERE ID = @id", connsql);
                checkCmd.Parameters.AddWithValue("@id", insertedId);
                object fid = checkCmd.ExecuteScalar();

                // Display a success message
                MessageBox.Show("Data added successfully! FID: " + (fid ?? DBNull.Value), "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Add the new row to the DataGridView
                dgvEmail.Rows.Add(insertedId, email, epf, fid ?? DBNull.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connsql.Close();
            }
        }






    }
}
