using PdfSharpCore.Pdf.Content.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_TelegraphicTransfer
{
    public partial class UCSender : UserControl
    {

        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion
        public UCSender()
        {
            InitializeComponent();
            dgvSender.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //sender lode
        private void UCSender_Load(object sender, EventArgs e)
        {
            // Set up the DataGridView columns
            dgvSender.ColumnCount = 7;
            dgvSender.Columns[0].Name = "id";
            dgvSender.Columns[1].Name = "name";
            dgvSender.Columns[2].Name = "address";
            dgvSender.Columns[3].Name = "business";
            dgvSender.Columns[4].Name = "tax";
            dgvSender.Columns[5].Name = "tpno"; 
            dgvSender.Columns[6].Name = "tin"; 
            
            LoadSender();
        }


        private void LoadSender()
        {
            try
            {
                connsql.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_SENDER_MASTER;", connsql);
                SqlDataReader reader = cmd.ExecuteReader();

                // Clear existing data in DataGridView
                dgvSender.Rows.Clear();

                // Loop through the data reader and add rows to the DataGridView
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string name = reader["NAME"].ToString();
                    string address = reader["ADDRESS"].ToString();
                    string business = reader["BUSINESS"].ToString();
                    string tax = reader["TAX"].ToString();
                    string tpno = reader["TPNO"].ToString();
                    string tin = reader["TIN"].ToString();

                    dgvSender.Rows.Add(id, name, address, business, tax, tpno, tin);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading  data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connsql.Close();
            }

        }

       
        private void btnSAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string Name = tbName.Text;

                // Check  Name
                if (string.IsNullOrEmpty(Name))
                {
                    MessageBox.Show("Please enter a Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the Name already exists
                connsql.Open();
                SqlCommand cmdCheckName = new SqlCommand("SELECT COUNT(*) FROM tbl_SENDER_MASTER WHERE NAME = @name", connsql);
                cmdCheckName.Parameters.AddWithValue("@name", Name);
                int nameCount = Convert.ToInt32(cmdCheckName.ExecuteScalar());
                connsql.Close();

                if (nameCount > 0)
                {
                    // tbName already exists in the database
                    MessageBox.Show("Name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Addres = tBaddres.Text;

                if (string.IsNullOrEmpty(Addres))
                {
                    MessageBox.Show("Please enter a Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Business = tbBusiness.Text;
                if (string.IsNullOrEmpty(Business))
                {
                    MessageBox.Show("Please enter a Business.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tax = tBtax.Text;
                if (string.IsNullOrEmpty(tax))
                {
                    MessageBox.Show("Please enter a Tax.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string TelNo = tbTN.Text;
                if (string.IsNullOrEmpty(TelNo))
                {
                    MessageBox.Show("Please enter a Telephone No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(TelNo, @"^0[0-9]{9}$") || Regex.IsMatch(TelNo, @"(\d)\1{9}"))
                {
                    MessageBox.Show("Please enter a valid telephone number consisting of 10 digits starting with 0, without repeating the same digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string Tin = tbTin.Text;
                if (string.IsNullOrEmpty(Tin))
                {
                    MessageBox.Show("Please enter a Tin No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               

                // Confirmation popup
                DialogResult result = MessageBox.Show("Do you want to add this sender?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    // Insert data into the database table
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_SENDER_MASTER (NAME, ADDRESS, BUSINESS, TAX, TPNO, TIN) VALUES (@name, @address, @business, @tax, @tpno, @tin);", connsql);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@address", Addres);
                    cmd.Parameters.AddWithValue("@business", Business);
                    cmd.Parameters.AddWithValue("@tax", tax);
                    cmd.Parameters.AddWithValue("@tpno", TelNo);
                    cmd.Parameters.AddWithValue("@tin", Tin);

                    connsql.Open();
                    cmd.ExecuteNonQuery();
                    connsql.Close();

                    MessageBox.Show(tbName + " is successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the data in the fields
                    tbName.Text = string.Empty;
                    tBaddres.Text = string.Empty;
                    tbBusiness.Text = string.Empty;
                    tBtax.Text = string.Empty;
                    tbTN.Text = string.Empty;
                    tbTin.Text = string.Empty;

                    LoadSender();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connsql.Close();
            }
        }


        //========================= update sender
        private void btnSUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dgvSender.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select a sender to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected user's ID
                string id = dgvSender.SelectedRows[0].Cells["id"].Value.ToString();

                // Check tbName.Text
                if (string.IsNullOrEmpty(tbName.Text))
                {
                    MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                if (string.IsNullOrEmpty(tBaddres.Text))
                {
                    MessageBox.Show("Please enter a address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(tbBusiness.Text))
                {
                    MessageBox.Show("Please enter a business.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(tBtax.Text))
                {
                    MessageBox.Show("Please enter a tax.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(tbTN.Text))
                {
                    MessageBox.Show("Please enter a telephone no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string TelNo = tbTN.Text;
                if (!Regex.IsMatch(TelNo, @"^0[0-9]{9}$") || Regex.IsMatch(TelNo, @"(\d)\1{9}"))
                {
                    MessageBox.Show("Please enter a valid telephone number consisting of 10 digits starting with 0, without repeating the same digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrEmpty(tbTin.Text))
                {
                    MessageBox.Show("Please enter a tin no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                

                string name = tbName.Text;
                string address = tBaddres.Text;
                string busi = tbBusiness.Text;
                string tax = tBtax.Text;
                string tpno = tbTN.Text;
                string tin = tbTin.Text;


              

                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to update the user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UpdateSenderInDatabase(id, name, address, busi, tax, tpno, tin);

                    // Refresh the DataGridView with updated data
                    LoadSender();

                    // Clear the input fields
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvSender_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dgvSender.SelectedRows.Count == 0)
                {
                    // Clear the form fields if no row is selected
                    ClearFormFields();
                    return;
                }

                // Get the selected user's data
                string id = dgvSender.SelectedRows[0].Cells["id"].Value.ToString();
                string name = dgvSender.SelectedRows[1].Cells["name"].Value.ToString();
                string address = dgvSender.SelectedRows[2].Cells["address"].Value.ToString();
                string busi = dgvSender.SelectedRows[3].Cells["business"].Value.ToString();
                string tax = dgvSender.SelectedRows[4].Cells["tax"].Value.ToString();
                string tpno = dgvSender.SelectedRows[5].Cells["tpno"].Value.ToString();
                string tin = dgvSender.SelectedRows[6].Cells["tin"].Value.ToString();

                // Display the data in the form fields
                tbName.Text = name;
                tBaddres.Text = address;
                tbBusiness.Text =  busi;
                tBtax.Text = tax;
                tbTN.Text = tpno;
                tbTin.Text = tin;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading  data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFormFields()
        {
            tbName.Text = "";
            tBaddres.Text = "";
            tbBusiness.Text = "";
            tBtax.Text = "";
            tbTN.Text = "";
            tbTin.Text = "";
        }

        private void UpdateSenderInDatabase(string id, string name, string address, string business, string tax, string telNo, string tin)
        {
            try
            {
                connsql.Open();

                // Update the user in the database
                SqlCommand updateCmd = new SqlCommand("UPDATE tbl_SENDER_MASTER SET NAME = @Name, ADDRESS = @addr, BUSINESS = @busi, TAX = @tax, TPNO = @tpno, TIN = @tin WHERE ID = @ID;", connsql);
                updateCmd.Parameters.AddWithValue("@Name", name);
                updateCmd.Parameters.AddWithValue("@addr", address);
                updateCmd.Parameters.AddWithValue("@busi", business);
                updateCmd.Parameters.AddWithValue("@tax", tax);
                updateCmd.Parameters.AddWithValue("@tpno", telNo);
                updateCmd.Parameters.AddWithValue("@tin", tin);
                updateCmd.Parameters.AddWithValue("@ID", id);

                updateCmd.ExecuteNonQuery();

                // Display a success message
                MessageBox.Show("Data updated successfully!", "Sender Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connsql.Close();
            }
        }


        private void dgvSender_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSender.Rows.Count)
            {
                DataGridViewRow row = dgvSender.Rows[e.RowIndex];

                // Get the selected user's data
                string id = row.Cells["id"].Value.ToString();
                string name = row.Cells["name"].Value.ToString();
                string address = row.Cells["address"].Value.ToString();
                string busi = row.Cells["business"].Value.ToString();
                string tax = row.Cells["tax"].Value.ToString();
                string tpno = row.Cells["tpno"].Value.ToString();
                string tin = row.Cells["tin"].Value.ToString();

                // Display the data in the form fields
                tbName.Text = name;
                tBaddres.Text = address;
                tbBusiness.Text = busi;
                tBtax.Text = tax;
                tbTN.Text = tpno;
                tbTin.Text = tin;
            }
        
            else
            {
                // Clear the form fields if no row is selected or an invalid row index is clicked
                ClearFormFields();
            }
        }

        private void dgvSender_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}






