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

namespace projectTelegraphicTransfer
{
    public partial class UCSender : UserControl
    {

        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion
        public UCSender()
        {
            InitializeComponent();
        }
        //sender lode
        private void UCSender_Load(object sender, EventArgs e)
        {
            LoadSender();
        }


        private void LoadSender()
        {
            try
            {
                flpLoadSender .Controls.Clear();

                connsql.Open();

                // Create a SqlCommand to retrieve the rows
                SqlCommand cmdItemLoad = new SqlCommand("SELECT * FROM tbl_SENDER_MASTER", connsql);

                // Execute the query and retrieve the rows
                SqlDataReader reader = cmdItemLoad.ExecuteReader();

            

                while (reader.Read())
                {

                    UCItemToShowSender itms = new UCItemToShowSender();

                    itms.Name = reader["NAME"].ToString();
                    itms.Address = reader["ADDRESS"].ToString();
                    itms.Busines = reader["BUSINESS"].ToString();
                    itms.Tax = reader["TAX"].ToString();
                    itms.Tpno = reader["TPNO"].ToString();
                    itms.Tinno = reader["TIN"].ToString();


                    // Add UCItems1 control to the panel
                    flpLoadSender.Controls.Add(itms);
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

        private void AddDataRecord()
        {
            // Code to add the data record to the database

            // Call the LoadSender method to refresh the data in the flpLoadSender control
            LoadSender();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSender();
        }

        private void tbTN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






