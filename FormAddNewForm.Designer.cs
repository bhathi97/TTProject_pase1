namespace projectTelegraphicTransfer
{
    partial class FormAddNewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fileName = new System.Windows.Forms.Label();
            this.tb_formName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_addForm = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM NAME";
            // 
            // lbl_fileName
            // 
            this.lbl_fileName.AutoSize = true;
            this.lbl_fileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fileName.Location = new System.Drawing.Point(3, 0);
            this.lbl_fileName.Name = "lbl_fileName";
            this.lbl_fileName.Size = new System.Drawing.Size(88, 21);
            this.lbl_fileName.TabIndex = 1;
            this.lbl_fileName.Text = "file name / ";
            // 
            // tb_formName
            // 
            this.tb_formName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_formName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_formName.Location = new System.Drawing.Point(97, 3);
            this.tb_formName.Name = "tb_formName";
            this.tb_formName.Size = new System.Drawing.Size(223, 29);
            this.tb_formName.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.10217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.89783F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_fileName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_addForm, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_formName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(61, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 40);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_addForm
            // 
            this.btn_addForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_addForm.FlatAppearance.BorderSize = 0;
            this.btn_addForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_addForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addForm.ForeColor = System.Drawing.Color.White;
            this.btn_addForm.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btn_addForm.IconColor = System.Drawing.Color.White;
            this.btn_addForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_addForm.IconSize = 20;
            this.btn_addForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addForm.Location = new System.Drawing.Point(326, 3);
            this.btn_addForm.Name = "btn_addForm";
            this.btn_addForm.Size = new System.Drawing.Size(86, 29);
            this.btn_addForm.TabIndex = 3;
            this.btn_addForm.TabStop = false;
            this.btn_addForm.Text = "CREATE";
            this.btn_addForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addForm.UseVisualStyleBackColor = false;
            this.btn_addForm.Click += new System.EventHandler(this.btn_addForm_Click);
            // 
            // FormAddNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 121);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(530, 160);
            this.MinimumSize = new System.Drawing.Size(530, 160);
            this.Name = "FormAddNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Form";
            this.Load += new System.EventHandler(this.FormAddNewForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_fileName;
        private TextBox tb_formName;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btn_addForm;
    }
}