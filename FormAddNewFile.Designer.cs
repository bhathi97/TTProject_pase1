namespace project_TelegraphicTransfer
{
    partial class FormAddNewFile
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
            btn_CreateNewFORM = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tb_number = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            cb_code = new ComboBox();
            cb_year = new ComboBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CreateNewFORM
            // 
            btn_CreateNewFORM.BackColor = Color.FromArgb(76, 175, 80);
            btn_CreateNewFORM.FlatAppearance.BorderSize = 0;
            btn_CreateNewFORM.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btn_CreateNewFORM.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btn_CreateNewFORM.FlatStyle = FlatStyle.Flat;
            btn_CreateNewFORM.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CreateNewFORM.ForeColor = Color.White;
            btn_CreateNewFORM.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btn_CreateNewFORM.IconColor = Color.White;
            btn_CreateNewFORM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CreateNewFORM.IconSize = 25;
            btn_CreateNewFORM.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CreateNewFORM.Location = new Point(154, 227);
            btn_CreateNewFORM.Name = "btn_CreateNewFORM";
            btn_CreateNewFORM.Size = new Size(117, 37);
            btn_CreateNewFORM.TabIndex = 3;
            btn_CreateNewFORM.Text = "ADD FILE";
            btn_CreateNewFORM.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CreateNewFORM.UseVisualStyleBackColor = false;
            btn_CreateNewFORM.Click += btn_CreateNewFORM_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(btn_CreateNewFORM);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 353);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4512177F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.54878F));
            tableLayoutPanel1.Controls.Add(tb_number, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(cb_code, 1, 0);
            tableLayoutPanel1.Controls.Add(cb_year, 1, 2);
            tableLayoutPanel1.Location = new Point(56, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(328, 126);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tb_number
            // 
            tb_number.Location = new Point(115, 43);
            tb_number.Name = "tb_number";
            tb_number.Size = new Size(210, 23);
            tb_number.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "CODE :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 80);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "YEAR :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 2;
            label3.Text = "NO :";
            // 
            // cb_code
            // 
            cb_code.FormattingEnabled = true;
            cb_code.Items.AddRange(new object[] { "BK", "CR", "BC", "PB" });
            cb_code.Location = new Point(115, 3);
            cb_code.Name = "cb_code";
            cb_code.Size = new Size(210, 23);
            cb_code.TabIndex = 7;
            // 
            // cb_year
            // 
            cb_year.FormattingEnabled = true;
            cb_year.Location = new Point(115, 83);
            cb_year.Name = "cb_year";
            cb_year.Size = new Size(210, 23);
            cb_year.TabIndex = 8;
            // 
            // FormAddNewFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 353);
            Controls.Add(panel1);
            Name = "FormAddNewFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New File";
            FormClosed += FormAddNewFile_FormClosed;
            Load += FormAddNewFile_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_CreateNewFORM;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private TextBox tb_number;
        private ComboBox cb_code;
        private ComboBox cb_year;
    }
}