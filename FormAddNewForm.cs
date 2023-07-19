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

namespace projectTelegraphicTransfer
{
    public partial class FormAddNewForm : Form
    {
        #region properties
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                lbl_fileName.Text = value + "/";
            }
        }

        private int _fileID;
        public int FileID
        {
            get { return _fileID; }
            set
            {
                _fileID = value;

            }
        }


        private int _creatorID;
        public int CreatorID
        {
            get { return _creatorID; }
            set
            {
                _creatorID = value;

            }
        }

      
     

        #endregion

        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion

        public FormAddNewForm()
        {
            InitializeComponent();
        }

        private void FormAddNewForm_Load(object sender, EventArgs e)
        {

        }

        private void FormAddNewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Enable all previously disabled forms
            foreach (Form form in Application.OpenForms)
            {
                form.Enabled = true;
            }

        }

        private void btn_addForm_Click(object sender, EventArgs e)
        {
            try
            {
                FormMAIN formMain = Application.OpenForms.OfType<FormMAIN>().FirstOrDefault();
                if (formMain != null)
                {
                    string formName = tb_formName.Text;
                    int editorID = formMain.UserID;

                    connsql.Open();

                    // Check if the formName already exists in the database
                    SqlCommand cmdCheckDuplicate = new SqlCommand("SELECT COUNT(*) FROM tbl_TRANSACTION WHERE NAME = @name", connsql);
                    cmdCheckDuplicate.Parameters.AddWithValue("@name", formName);
                    int duplicateCount = (int)cmdCheckDuplicate.ExecuteScalar();

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show("A form with the same name already exists.");
                    }
                    else
                    {
                        SqlCommand cmdItemInsert = new SqlCommand("INSERT INTO tbl_TRANSACTION (NAME, DATE_TIME, FID, EDITOR) VALUES (@name, @time, @fid, @edit)", connsql);
                        cmdItemInsert.Parameters.AddWithValue("@name", formName);
                        cmdItemInsert.Parameters.AddWithValue("@time", DateTime.Now);
                        cmdItemInsert.Parameters.AddWithValue("@fid", FileID);
                        cmdItemInsert.Parameters.AddWithValue("@edit", editorID);
                        cmdItemInsert.ExecuteNonQuery();
                        MessageBox.Show("Form added successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connsql.Close();
                this.Close();
            }
        }



    }
}
