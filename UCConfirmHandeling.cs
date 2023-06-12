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
    public partial class UCConfirmHandeling : UserControl
    {
        public UCConfirmHandeling()
        {
            InitializeComponent();
        }

        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion

        #region properties

        private int _count;
        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                lbl_count.Text = _count.ToString();
            }
        }

        #endregion

        private void UCConfirmHandeling_Load(object sender, EventArgs e)
        {

            loadItems();



        }


        private void loadItems()
        {
            int count = 0;

            try
            {

                flp_confirmItemLoade.Controls.Clear();

                connsql.Open();

                // Create a SqlCommand to retrieve the rows
                SqlCommand cmdItemLoad = new SqlCommand("SELECT * FROM tbl_BENIFICIARY_MASTER ", connsql);

                // Execute the query and retrieve the rows
                SqlDataReader reader = cmdItemLoad.ExecuteReader();

                while (reader.Read())
                {

                    UCItemsToConfirm itms = new UCItemsToConfirm();

                    itms.FileName = reader["NAME"].ToString();

                    // Add UCItems1 control to the panel
                    flp_confirmItemLoade.Controls.Add(itms);
                    count++;
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
                this.Count = count;
            }
        }
    }



}
