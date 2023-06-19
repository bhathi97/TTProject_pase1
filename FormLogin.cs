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
    public partial class FormLogin : Form
    {
        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {

                //check the fields are empty or not
                if (string.IsNullOrEmpty(tb_userName.Text))
                {
                    MessageBox.Show("User Name Is Required");
                    tb_userName.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(tb_password.Text))
                {
                    MessageBox.Show("Password Is Required");
                    tb_password.Focus();
                    return;
                }
                else
                {
                    string userName = tb_userName.Text;
                    string password = tb_password.Text;

                    
                      /*  try
                        {
                            connsql.Open();
                            MessageBox.Show("Connection successful!", "Success");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Connection failed: {ex.Message}", "Error");
                        }
                    */

                    connsql.Open();
                    SqlCommand cmdLogin = new SqlCommand("SELECT COUNT(*) FROM tbl_LOGIN_MASTER WHERE [NAME] = @name AND PASSWORD = @pw", connsql);
                    cmdLogin.Parameters.AddWithValue("@name", userName);
                    cmdLogin.Parameters.AddWithValue("@pw", password);

                    int count = Convert.ToInt32(cmdLogin.ExecuteScalar());

                    MessageBox.Show(count.ToString());

                    if (count > 0)
                    {
                        SqlCommand cmdUser = new SqlCommand("select * from tbl_LOGIN_MASTER where [NAME] = @name and PASSWORD = @pw", connsql);
                        cmdUser.Parameters.AddWithValue("@name", userName);
                        cmdUser.Parameters.AddWithValue("@pw", password);

                        SqlDataReader reader = cmdUser.ExecuteReader();

                        if (reader.Read())
                        {
                            string nameShow = reader["NAME"].ToString();
                            int idShow = int.Parse(reader["ID"].ToString());

                            FormMAIN formMAIN = new FormMAIN();
                            formMAIN.Lbluser = nameShow;
                            formMAIN.UserID = idShow;
                            formMAIN.Show();

                            this.tb_userName.Text = "";
                            this.tb_password.Text = "";
                            this.Hide();

                        }


                    }



                }




            }
            catch (Exception ex)
            {

            }
            finally
            {
                connsql.Close();
            }
        }

        private void tb_userName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    tb_password.Focus();
                }
            }
            catch
            {

            }
        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btn_login.Focus();
                    btn_login.BackColor = SystemColors.Control;
                    btn_login.ForeColor = SystemColors.ControlText;
                   
                }
            }
            catch
            {

            }

        }
    }
}
