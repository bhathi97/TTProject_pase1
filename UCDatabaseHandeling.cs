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
            dgvUser.Columns[0].Name = "ID";
            dgvUser.Columns[1].Name = "Name";
            dgvUser.Columns[2].Name = "Password";
            dgvUser.Columns[3].Name = "User Level";
        }

        private void UserAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string password = tbPW.Text;
            string userLevel = cbUL.SelectedItem.ToString();

            InsertUserToDatabase(name, password, userLevel);

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


