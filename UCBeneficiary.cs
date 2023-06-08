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



    }
}
