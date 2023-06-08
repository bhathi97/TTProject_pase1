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
    public partial class UCBeneficiary : UserControl
    {

        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion





        public UCBeneficiary()
        {
            InitializeComponent();
        }


        private void UCBeneficiary_Load(object sender, EventArgs e)
        {
            LoadItems();
        }






        //load items
        public void LoadItems()
        {
            try
            {

                flp_LoadItems.Controls.Clear();

                connsql.Open();

                // Create a SqlCommand to retrieve the rows
                SqlCommand cmdItemLoad = new SqlCommand("SELECT * FROM tbl_BENIFICIARY_MASTER ", connsql);

                // Execute the query and retrieve the rows
                SqlDataReader reader = cmdItemLoad.ExecuteReader();

                while (reader.Read())
                {

                    UCItemToShowBenificieries itms = new UCItemToShowBenificieries();
                    itms.Name = reader["NAME"].ToString();
                    itms.NicName = reader["NIC_NAME"].ToString();
                    itms.Address = reader["ADDRESS"].ToString();
                    itms.Country = reader["COUNTRY"].ToString();
                    itms.BankName = reader["BANK_NAME"].ToString();
                    itms.Acc = reader["ACC_NO"].ToString();
                    itms.BranchCode = reader["BRANCH_CODE"].ToString();
                    itms.BranchName = reader["BRANCH_NAME"].ToString();
                    itms.Swift = reader["SWIFT_CODE"].ToString();
                    itms.CorBank = reader["INTERMEDIATE_BANK"].ToString();

                    // Add UCItems1 control to the panel
                    flp_LoadItems.Controls.Add(itms);
                }

                reader.Close();
                connsql.Close();

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

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string nicName = tb_nic.Text;
                string name = tb_name.Text;
                string address = tb_address.Text;
                string bankName = tb_bank.Text;
                string branchName = tb_branchName.Text;
                string country = cb_country.Text;
                string account = tb_accountNo.Text;
                string sort = tb_sort.Text; //branch code
                string swift = tb_swiftCode.Text;
                string corBank = tb_corBank.Text;

                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_BENIFICIARY_MASTER (NIC_NAME, [NAME], [ADDRESS], BANK_NAME, BRANCH_NAME, BRANCH_CODE, SWIFT_CODE, COUNTRY, ACC_NO, INTERMEDIATE_BANK) VALUES (@nic, @name, @addr, @bankName, @brName , @brCode , @swftCode, @country, @acc, @interBank); ", connsql);
                cmd.Parameters.AddWithValue("@nic", nicName);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@addr", address);
                cmd.Parameters.AddWithValue("@bankName", bankName);
                cmd.Parameters.AddWithValue("@brName", branchName);
                cmd.Parameters.AddWithValue("@brCode", sort);
                cmd.Parameters.AddWithValue("@swftCode", swift);
                cmd.Parameters.AddWithValue("@country", country);
                cmd.Parameters.AddWithValue("@acc", account);
                cmd.Parameters.AddWithValue("@interBank", corBank);

                connsql.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(name + " IS SUCCESSFULLY ADDED TO THE DATABASE");
                connsql.Close();


                LoadItems();
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
    }
}
