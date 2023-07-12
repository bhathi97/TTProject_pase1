using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectTelegraphicTransfer
{
    public partial class FormEditBenificiary : Form
    {
        public FormEditBenificiary()
        {
            InitializeComponent();
        }

        private void FormEditBenificiary_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                // Enable all previously disabled forms
                foreach (Form form in Application.OpenForms)
                {
                    form.Enabled = true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
