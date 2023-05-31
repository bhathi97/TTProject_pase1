using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_TelegraphicTransfer
{
    public partial class UCDatabaseHandeling : UserControl
    {
        private List<User> userList = new List<User>();
        private int nextId = 1;
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
            string id = nextId.ToString();
            string name = tbName.Text;
            string password = tbPW.Text;
            string userLevel = cbUL.SelectedItem.ToString();

            User newUser = new User(id, name, password, userLevel);
            userList.Add(newUser);

            dgvUser.Rows.Add(id, name, password, userLevel);

            // Increment the nextId for the next user
            nextId++;

            // Clear the input fields
            tbName.Text = "";
            tbPW.Text = "";
            cbUL.SelectedIndex = -1;
        }

        public class User
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public string UserLevel { get; set; }


            public User(string id, string name, string password, string userLevel)
            {
                ID = id;
                Name = name;
                Password = password;
                UserLevel = userLevel;
            }
        }
    }
}
