namespace project_TelegraphicTransfer
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
            label1 = new Label();
            lbl_fileName = new Label();
            tb_formName = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_addForm = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "FORM NAME";
            // 
            // lbl_fileName
            // 
            lbl_fileName.AutoSize = true;
            lbl_fileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fileName.Location = new Point(3, 0);
            lbl_fileName.Name = "lbl_fileName";
            lbl_fileName.Size = new Size(88, 21);
            lbl_fileName.TabIndex = 1;
            lbl_fileName.Text = "file name / ";
            // 
            // tb_formName
            // 
            tb_formName.BorderStyle = BorderStyle.FixedSingle;
            tb_formName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_formName.Location = new Point(97, 3);
            tb_formName.Name = "tb_formName";
            tb_formName.Size = new Size(223, 29);
            tb_formName.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.1021671F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.8978348F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.Controls.Add(lbl_fileName, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_addForm, 2, 0);
            tableLayoutPanel1.Controls.Add(tb_formName, 1, 0);
            tableLayoutPanel1.Location = new Point(61, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(415, 40);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_addForm
            // 
            btn_addForm.BackColor = Color.FromArgb(76, 175, 80);
            btn_addForm.FlatAppearance.BorderSize = 0;
            btn_addForm.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btn_addForm.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btn_addForm.FlatStyle = FlatStyle.Flat;
            btn_addForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addForm.ForeColor = Color.White;
            btn_addForm.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_addForm.IconColor = Color.White;
            btn_addForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addForm.IconSize = 20;
            btn_addForm.ImageAlign = ContentAlignment.MiddleRight;
            btn_addForm.Location = new Point(326, 3);
            btn_addForm.Name = "btn_addForm";
            btn_addForm.Size = new Size(86, 29);
            btn_addForm.TabIndex = 3;
            btn_addForm.TabStop = false;
            btn_addForm.Text = "CREATE";
            btn_addForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_addForm.UseVisualStyleBackColor = false;
            btn_addForm.Click += btn_addForm_Click;
            // 
            // FormAddNewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 121);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            MaximumSize = new Size(530, 160);
            MinimumSize = new Size(530, 160);
            Name = "FormAddNewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Form";
            FormClosed += FormAddNewForm_FormClosed;
            Load += FormAddNewForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_fileName;
        private TextBox tb_formName;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btn_addForm;
    }
}