using Microsoft.VisualBasic.ApplicationServices;
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
            string name = tbName.Text;
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

                connsql.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_LOGIN_MASTER (NAME, PASSWORD, USER_LEVEL) VALUES (@Name, @Password, @UserLevel);", connsql);

                // Set the parameter values
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserLevel", userLevel);

                // Execute the query
                cmd.ExecuteNonQuery();

                // Display a success message if needed
                MessageBox.Show("User added successfully!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { 
                connsql.Close(); 
            }

        }
    }
}


