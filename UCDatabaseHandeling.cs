using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;

namespace project_TelegraphicTransfer
{
    public partial class UCDatabaseHandeling : UserControl
    {
        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion
        public UCDatabaseHandeling()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                SqlCommand cmd = new SqlCommand("SELECT ID, NAME, PASSWORD, USER_LEVEL FROM tbl_LOGIN_MASTER;", connsql);
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

        }
    }

                // Show confirmation message with OK and Cancel options







