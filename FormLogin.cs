using PdfSharpCore.Pdf.Content.Objects;
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
                // Check if the fields are empty
                if (string.IsNullOrEmpty(tb_userName.Text))
                {
                    MessageBox.Show("User Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_userName.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(tb_password.Text))
                {
                    MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_password.Focus();
                    return;
                }
                else
                {
                    string userName = tb_userName.Text;
                    string password = tb_password.Text;

                    connsql.Open();
                    SqlCommand cmdLogin = new SqlCommand("SELECT COUNT(*) FROM tbl_LOGIN_MASTER WHERE [NAME] = @name AND PASSWORD = @pw", connsql);
                    cmdLogin.Parameters.AddWithValue("@name", userName);
                    cmdLogin.Parameters.AddWithValue("@pw", password);

                    int count = Convert.ToInt32(cmdLogin.ExecuteScalar());

                    if (count > 0)
                    {
                        // User credentials are valid
                        MessageBox.Show(userName + "  SUCCESSFULLY LOGIN ...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlCommand cmdUser = new SqlCommand("SELECT * FROM tbl_LOGIN_MASTER WHERE [NAME] = @name AND PASSWORD = @pw", connsql);
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
                    else
                    {
                        // Username and password are incorrect
                        MessageBox.Show("Username and password are incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_userName.Focus();
                        tb_userName.SelectAll();
                        tb_password.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //hide password when user typing password 
        private void chb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chb_showPassword.Checked == true) 
            {
                tb_password.UseSystemPasswordChar = false;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
            }
        }
    }
}
