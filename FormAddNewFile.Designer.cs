namespace projectTelegraphicTransfer
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
            this.btn_CreateNewFORM = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.cb_code = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CreateNewFORM
            // 
            this.btn_CreateNewFORM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_CreateNewFORM.FlatAppearance.BorderSize = 0;
            this.btn_CreateNewFORM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_CreateNewFORM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_CreateNewFORM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateNewFORM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateNewFORM.ForeColor = System.Drawing.Color.White;
            this.btn_CreateNewFORM.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_CreateNewFORM.IconColor = System.Drawing.Color.White;
            this.btn_CreateNewFORM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CreateNewFORM.IconSize = 25;
            this.btn_CreateNewFORM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateNewFORM.Location = new System.Drawing.Point(154, 227);
            this.btn_CreateNewFORM.Name = "btn_CreateNewFORM";
            this.btn_CreateNewFORM.Size = new System.Drawing.Size(117, 37);
            this.btn_CreateNewFORM.TabIndex = 3;
            this.btn_CreateNewFORM.Text = "ADD FILE";
            this.btn_CreateNewFORM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CreateNewFORM.UseVisualStyleBackColor = false;
            this.btn_CreateNewFORM.Click += new System.EventHandler(this.btn_CreateNewFORM_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btn_CreateNewFORM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 353);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.45122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.54878F));
            this.tableLayoutPanel1.Controls.Add(this.tb_number, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_year, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_code, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 126);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(116, 43);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(209, 23);
            this.tb_number.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "YEAR :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "NO :";
            // 
            // cb_year
            // 
            this.cb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Items.AddRange(new object[] {
            "2030",
            "2029",
            "2028",
            "2027",
            "2026",
            "2025",
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000"});
            this.cb_year.Location = new System.Drawing.Point(116, 83);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(209, 23);
            this.cb_year.TabIndex = 8;
            // 
            // cb_code
            // 
            this.cb_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_code.FormattingEnabled = true;
            this.cb_code.Items.AddRange(new object[] {
            "BK",
            "CR",
            "BC",
            "PB"});
            this.cb_code.Location = new System.Drawing.Point(116, 3);
            this.cb_code.Name = "cb_code";
            this.cb_code.Size = new System.Drawing.Size(209, 23);
            this.cb_code.TabIndex = 7;
            // 
            // FormAddNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 353);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddNewFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New File";
            this.Load += new System.EventHandler(this.FormAddNewFile_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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