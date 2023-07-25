
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace projectTelegraphicTransfer
{
    public partial class UCDatabaseHandeling : UserControl
    {
        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion
        public UCDatabaseHandeling()
        {
            InitializeComponent();
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }


        private void UCDatabaseHandeling_Load(object sender, EventArgs e)
        {
            // Set up the DataGridView columns
            dgvUser.ColumnCount = 4;
            dgvUser.Columns[0].Name = "id";
            dgvUser.Columns[1].Name = "name";
            dgvUser.Columns[2].Name = "PW";
            dgvUser.Columns[3].Name = "UL";


            // Load data from the database
            LoadUserData();

        }

        private void LoadUserData()
        {
            try
            {
                connsql.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_LOGIN_MASTER;", connsql);
                SqlDataReader reader = cmd.ExecuteReader();

                // Clear existing data in DataGridView
                dgvUser.Rows.Clear();

                // Loop through the data reader and add rows to the DataGridView
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string name = reader["NAME"].ToString();
                    string password = reader["PASSWORD"].ToString();
                    string userLevel = reader["USER_LEVEL"].ToString();

                    dgvUser.Rows.Add(id, name, password, userLevel);
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

       
        private void UserAdd_Click(object sender, EventArgs e)
        {
            // Check tbName.Text
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check tbName.Text
            string name = tbName.Text.Trim();

            // Validate name using regular expression
            if (!Regex.IsMatch(name, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a valid name containing only uppercase and lowercase letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check tbPW.Text
            if (string.IsNullOrEmpty(tbPW.Text))
            {
                MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check cbUL.SelectedIndex
            if (cbUL.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = tbPW.Text;
            string userLevel = cbUL.SelectedItem.ToString();

            InsertUserToDatabase(name, password, userLevel);

            // Refresh the DataGridView with updated data
            LoadUserData();

            // Clear the input fields
            tbName.Text = "";
            tbPW.Text = "";
            cbUL.SelectedIndex = -1;



        }

        private void InsertUserToDatabase(string name, string password, string userLevel)
        {
            try
            {
                // Check if the name already exists in the database
                connsql.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbl_LOGIN_MASTER WHERE NAME = @Name", connsql);
                checkCmd.Parameters.AddWithValue("@Name", name);
                int nameCount = (int)checkCmd.ExecuteScalar();

                if (nameCount > 0)
                {
                    // Name already exists, display an error message
                    MessageBox.Show("The name already exists in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmation message before inserting the user
                DialogResult result = MessageBox.Show("Do you want to add this user?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    // Insert the user into the database
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO tbl_LOGIN_MASTER (NAME, PASSWORD, USER_LEVEL) VALUES (@Name, @Password, @UserLevel);", connsql);
                    insertCmd.Parameters.AddWithValue("@Name", name);
                    insertCmd.Parameters.AddWithValue("@Password", password);
                    insertCmd.Parameters.AddWithValue("@UserLevel", userLevel);
                    insertCmd.ExecuteNonQuery();

                    // Display a success message
                    MessageBox.Show("User added successfully!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connsql.Close();
            }
        }

        //============================================= UPDATE USER

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dgvUser.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select a user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected user's ID
                string id = dgvUser.SelectedRows[0].Cells["id"].Value.ToString();

                // Check tbName.Text
                if (string.IsNullOrEmpty(tbName.Text))
                {
                    MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check tbName.Text
                string name = tbName.Text.Trim();

                // Validate name using regular expression
                if (!Regex.IsMatch(name, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Please enter a valid name containing only uppercase and lowercase letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check cbUL.SelectedIndex
                if (cbUL.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a user level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check tbPW.Text
                if (string.IsNullOrEmpty(tbPW.Text))
                {
                    MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string password = tbPW.Text;
                string userLevel = cbUL.SelectedItem.ToString();

                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to update the user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UpdateUserInDatabase(id, name, password, userLevel);

                    // Refresh the DataGridView with updated data
                    LoadUserData();

                    // Clear the input fields
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void DgvUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dgvUser.SelectedRows.Count == 0)
                {
                    // Clear the form fields if no row is selected
                    ClearFormFields();
                    return;
                }

                // Get the selected user's data
                string id = dgvUser.SelectedRows[0].Cells["id"].Value.ToString();
                string name = dgvUser.SelectedRows[1].Cells["name"].Value.ToString();
                string password = dgvUser.SelectedRows[2].Cells["PW"].Value.ToString();
                string userLevel = dgvUser.SelectedRows[3].Cells["UL"].Value.ToString();

                // Display the data in the form fields
                tbName.Text = name;
                tbPW.Text = password;
                cbUL.SelectedItem = userLevel;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearFormFields()
        {
            tbName.Text = "";
            tbPW.Text = "";
            cbUL.SelectedIndex = -1;
        }


        private void UpdateUserInDatabase(string id, string name, string password, string userLevel)
        {
            try
            {
                connsql.Open();

                // Update the user in the database
                SqlCommand updateCmd = new SqlCommand("UPDATE tbl_LOGIN_MASTER SET NAME = @Name, PASSWORD = @Password, USER_LEVEL = @UserLevel WHERE ID = @ID;", connsql);
                updateCmd.Parameters.AddWithValue("@Name", name);
                updateCmd.Parameters.AddWithValue("@Password", password);
                updateCmd.Parameters.AddWithValue("@UserLevel", userLevel);
                updateCmd.Parameters.AddWithValue("@ID", id);

                updateCmd.ExecuteNonQuery();

                // Display a success message
                MessageBox.Show("User updated successfully!", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connsql.Close();
            }
        }


        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvUser.Rows.Count)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];

                // Get the selected user's data
                string id = row.Cells["id"].Value.ToString();
                string name = row.Cells["name"].Value.ToString();
                string password = row.Cells["PW"].Value.ToString();
                string userLevel = row.Cells["UL"].Value.ToString();

                // Display the data in the form fields
                tbName.Text = name;
                tbPW.Text = password;
                cbUL.SelectedItem = userLevel;
            }
            else
            {
                // Clear the form fields if no row is selected or an invalid row index is clicked
                ClearFormFields();
            }
        }

        //================================= delete user

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dgvUser.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected user's ID
                string id = dgvUser.SelectedRows[0].Cells["id"].Value.ToString();

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete the user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Call the method to delete the user from the database
                    DeleteUserFromDatabase(id);

                    // Refresh the DataGridView with updated data
                    LoadUserData();

                    // Clear the form fields
                    ClearFormFields();

                    MessageBox.Show("User deleted successfully!", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUserFromDatabase(string id)
        {
            try
            {
                connsql.Open();

                // Delete the user from the database
                SqlCommand deleteCmd = new SqlCommand("DELETE FROM tbl_LOGIN_MASTER WHERE ID = @ID;", connsql);
                deleteCmd.Parameters.AddWithValue("@ID", id);

                deleteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the user from the database: " + ex.Message);
            }
            finally
            {
                connsql.Close();
            }
        }


    }
}

// Show confirmation message with OK and Cancel options







