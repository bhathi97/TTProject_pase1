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
    public partial class UCTTItems : UserControl
    {

        #region Properties
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private int _fileId;
        public int FileId
        {
            get { return _fileId; }
            set { _fileId = value; }
        }


        private string _fName;
        public string FName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        private int _foldId;
        public int FoldId
        {
            get { return _foldId; }
            set { _foldId = value; }
        }


        #endregion

        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion

        public UCTTItems()
        {
            InitializeComponent();
        }

        private void UCTTItems_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(FoldId.ToString());

            lblFormName.Text = FileName;
        }

        private void btn_editForms_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if FormMAIN is already open
                FormMAIN formMain = Application.OpenForms.OfType<FormMAIN>().FirstOrDefault();

                if (formMain != null)
                {
                    formMain.LblTTName = FileName; //to display file name  

                    // FormMAIN is open, check for UCFileHandeling user control
                    UCFileHandeling FileHandelingUserControl = formMain.FileHandelingUserControl;

                    if (FileHandelingUserControl != null)
                    {
                        UCTTForm uCForms = FileHandelingUserControl.UserControlFormShow as UCTTForm;

                        if (uCForms != null && !uCForms.IsDisposed)
                        {
                            uCForms.Dispose();
                        }

                        //MessageBox.Show(_fileId.ToString());
                        //-----------------------------------------------
                        connsql.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_TRANSFER_ORDER_FORM WHERE FILE_REFERENCE = @fl and DOCUMENT = @doc AND ISCONFIRMED != 0", connsql);
                        cmd.Parameters.AddWithValue("@fl", _fName);
                        cmd.Parameters.AddWithValue("@doc", _fileName);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        connsql.Close();

                        if (count > 0)
                        {
                            // Value exists
                            connsql.Open();
                            SqlCommand cmd1 = new SqlCommand("SELECT * FROM tbl_TRANSFER_ORDER_FORM WHERE FILE_REFERENCE = @fl AND DOCUMANT = @doc AND ISCONFIRMED != 0", connsql);
                            cmd1.Parameters.AddWithValue("@fl", _fName);
                            cmd1.Parameters.AddWithValue("@doc", _fileName);

                            using (SqlDataReader reader = cmd1.ExecuteReader())
                            {
                                while (reader.Read())
                                {

                                    //MessageBox.Show(reader["ID"].ToString());
                                    uCForms = new UCTTForm();
                                    uCForms.LblFormName = FileName;
                                    uCForms.LblFormID = FileId;
                                    uCForms.FileName = FName;

                                    uCForms.senderName = reader["SENDER_NAME"].ToString();
                                    uCForms.Purpose = reader["PURPOSE"].ToString();
                                    uCForms.Inv = reader["INV"].ToString();
                                    uCForms.Desc = reader["DESCRIPTION"].ToString();
                                    uCForms.Trade = reader["TRADE_TERMS"].ToString();


                                    uCForms.BtnState = false;

                                    uCForms.Show();
                                    uCForms.Dock = DockStyle.Fill;

                                    FileHandelingUserControl.UserControlFormShow = uCForms;



                                }
                            }


                        }
                        else
                        {
                            uCForms = new UCTTForm();
                            uCForms.LblFormName = FileName;
                            uCForms.LblFormID = FileId;
                            uCForms.FileName = FName;
                            uCForms.Show();
                            uCForms.Dock = DockStyle.Fill;
                            uCForms.BtnState = true;
                            FileHandelingUserControl.UserControlFormShow = uCForms;
                        }

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
            }
        }
    }

}

