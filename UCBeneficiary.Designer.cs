namespace project_TelegraphicTransfer
{
    partial class UCBeneficiary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label10 = new Label();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            TBnic = new TextBox();
            label11 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TBname = new TextBox();
            TBaddress = new TextBox();
            tBbn = new TextBox();
            tbbrN = new TextBox();
            tBAN = new TextBox();
            label12 = new Label();
            cbC = new ComboBox();
            label9 = new Label();
            tBIN = new TextBox();
            label8 = new Label();
            tBSC = new TextBox();
            label15 = new Label();
            tbBranchCode = new TextBox();
            panel4 = new Panel();
            btnBDelete = new FontAwesome.Sharp.IconButton();
            btnBUpdate = new FontAwesome.Sharp.IconButton();
            BTNbAdd = new FontAwesome.Sharp.IconButton();
            dGVbenificiary = new DataGridView();
            NC = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            BN = new DataGridViewTextBoxColumn();
            BrName = new DataGridViewTextBoxColumn();
            country = new DataGridViewTextBoxColumn();
            AN = new DataGridViewTextBoxColumn();
            SC = new DataGridViewTextBoxColumn();
            IB = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label13 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVbenificiary).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 40);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(11, 12, 71);
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 17);
            label10.Name = "label10";
            label10.Size = new Size(403, 21);
            label10.TabIndex = 0;
            label10.Text = "BENEFICIARY HANDLING";
            label10.Click += label10_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 40);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dGVbenificiary);
            splitContainer1.Panel2.Padding = new Padding(5);
            splitContainer1.Size = new Size(1210, 924);
            splitContainer1.SplitterDistance = 423;
            splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 10, 10);
            panel2.Size = new Size(423, 924);
            panel2.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.51992F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.48008F));
            tableLayoutPanel2.Controls.Add(label1, 0, 2);
            tableLayoutPanel2.Controls.Add(TBnic, 1, 0);
            tableLayoutPanel2.Controls.Add(label11, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(label7, 0, 6);
            tableLayoutPanel2.Controls.Add(TBname, 1, 1);
            tableLayoutPanel2.Controls.Add(TBaddress, 1, 2);
            tableLayoutPanel2.Controls.Add(tBbn, 1, 3);
            tableLayoutPanel2.Controls.Add(tbbrN, 1, 4);
            tableLayoutPanel2.Controls.Add(tBAN, 1, 6);
            tableLayoutPanel2.Controls.Add(label12, 0, 1);
            tableLayoutPanel2.Controls.Add(cbC, 1, 5);
            tableLayoutPanel2.Controls.Add(label9, 0, 9);
            tableLayoutPanel2.Controls.Add(tBIN, 1, 9);
            tableLayoutPanel2.Controls.Add(label8, 0, 8);
            tableLayoutPanel2.Controls.Add(tBSC, 1, 8);
            tableLayoutPanel2.Controls.Add(label15, 0, 7);
            tableLayoutPanel2.Controls.Add(tbBranchCode, 1, 7);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(10, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5753441F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.4246559F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(403, 468);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 83);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 1;
            label1.Text = "ADDRESS";
            // 
            // TBnic
            // 
            TBnic.Location = new Point(158, 3);
            TBnic.Name = "TBnic";
            TBnic.Size = new Size(242, 23);
            TBnic.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(70, 17);
            label11.TabIndex = 0;
            label11.Text = "NIC NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 121);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 3;
            label3.Text = "BANK NAME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 163);
            label5.Name = "label5";
            label5.Size = new Size(99, 17);
            label5.TabIndex = 4;
            label5.Text = "BRANCH NAME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 207);
            label6.Name = "label6";
            label6.Size = new Size(67, 17);
            label6.TabIndex = 5;
            label6.Text = "COUNTRY";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 248);
            label7.Name = "label7";
            label7.Size = new Size(137, 34);
            label7.TabIndex = 6;
            label7.Text = "ACCOUNT NO / IBAN NO";
            // 
            // TBname
            // 
            TBname.Location = new Point(158, 42);
            TBname.Name = "TBname";
            TBname.Size = new Size(242, 23);
            TBname.TabIndex = 10;
            // 
            // TBaddress
            // 
            TBaddress.Location = new Point(158, 86);
            TBaddress.Name = "TBaddress";
            TBaddress.Size = new Size(242, 23);
            TBaddress.TabIndex = 11;
            // 
            // tBbn
            // 
            tBbn.Location = new Point(158, 124);
            tBbn.Name = "tBbn";
            tBbn.Size = new Size(242, 23);
            tBbn.TabIndex = 12;
            // 
            // tbbrN
            // 
            tbbrN.Location = new Point(158, 166);
            tbbrN.Name = "tbbrN";
            tbbrN.Size = new Size(242, 23);
            tbbrN.TabIndex = 13;
            // 
            // tBAN
            // 
            tBAN.Location = new Point(158, 251);
            tBAN.Name = "tBAN";
            tBAN.Size = new Size(242, 23);
            tBAN.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(3, 39);
            label12.Name = "label12";
            label12.Size = new Size(45, 17);
            label12.TabIndex = 2;
            label12.Text = "NAME";
            // 
            // cbC
            // 
            cbC.FormattingEnabled = true;
            cbC.Location = new Point(158, 210);
            cbC.Name = "cbC";
            cbC.Size = new Size(242, 23);
            cbC.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 414);
            label9.Name = "label9";
            label9.Size = new Size(132, 34);
            label9.TabIndex = 8;
            label9.Text = "CORRESPONDING / INTERMEDIATE BANK";
            // 
            // tBIN
            // 
            tBIN.Location = new Point(158, 417);
            tBIN.Name = "tBIN";
            tBIN.Size = new Size(242, 23);
            tBIN.TabIndex = 17;
            tBIN.TextChanged += tBIN_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 364);
            label8.Name = "label8";
            label8.Size = new Size(81, 17);
            label8.TabIndex = 7;
            label8.Text = "SWIFT CODE";
            // 
            // tBSC
            // 
            tBSC.Location = new Point(158, 367);
            tBSC.Name = "tBSC";
            tBSC.Size = new Size(242, 23);
            tBSC.TabIndex = 16;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 296);
            label15.Name = "label15";
            label15.Size = new Size(130, 45);
            label15.TabIndex = 19;
            label15.Text = "SORT / ROUTING / FEDWIRE / ABA / BSB / BANK-BRANCH CODE";
            // 
            // tbBranchCode
            // 
            tbBranchCode.Location = new Point(158, 299);
            tbBranchCode.Name = "tbBranchCode";
            tbBranchCode.Size = new Size(242, 23);
            tbBranchCode.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnBDelete);
            panel4.Controls.Add(btnBUpdate);
            panel4.Controls.Add(BTNbAdd);
            panel4.Location = new Point(9, 484);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 155);
            panel4.TabIndex = 7;
            // 
            // btnBDelete
            // 
            btnBDelete.BackColor = Color.FromArgb(11, 12, 71);
            btnBDelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btnBDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnBDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBDelete.ForeColor = Color.White;
            btnBDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnBDelete.IconColor = Color.White;
            btnBDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnBDelete.IconSize = 20;
            btnBDelete.Location = new Point(0, 101);
            btnBDelete.Name = "btnBDelete";
            btnBDelete.Size = new Size(201, 42);
            btnBDelete.TabIndex = 2;
            btnBDelete.Text = "DELETE";
            btnBDelete.TextAlign = ContentAlignment.MiddleRight;
            btnBDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBDelete.UseVisualStyleBackColor = false;
            // 
            // btnBUpdate
            // 
            btnBUpdate.BackColor = Color.FromArgb(11, 12, 71);
            btnBUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBUpdate.ForeColor = Color.White;
            btnBUpdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnBUpdate.IconColor = Color.White;
            btnBUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnBUpdate.IconSize = 20;
            btnBUpdate.Location = new Point(0, 53);
            btnBUpdate.Name = "btnBUpdate";
            btnBUpdate.Size = new Size(201, 42);
            btnBUpdate.TabIndex = 1;
            btnBUpdate.Text = "  UPDATE";
            btnBUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnBUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBUpdate.UseVisualStyleBackColor = false;
            // 
            // BTNbAdd
            // 
            BTNbAdd.BackColor = Color.FromArgb(11, 12, 71);
            BTNbAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTNbAdd.ForeColor = Color.White;
            BTNbAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            BTNbAdd.IconColor = Color.White;
            BTNbAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNbAdd.IconSize = 20;
            BTNbAdd.Location = new Point(0, 5);
            BTNbAdd.Name = "BTNbAdd";
            BTNbAdd.Size = new Size(201, 42);
            BTNbAdd.TabIndex = 0;
            BTNbAdd.Text = "  ADD";
            BTNbAdd.TextAlign = ContentAlignment.MiddleRight;
            BTNbAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNbAdd.UseVisualStyleBackColor = false;
            // 
            // dGVbenificiary
            // 
            dGVbenificiary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dGVbenificiary.BackgroundColor = SystemColors.ActiveCaption;
            dGVbenificiary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVbenificiary.Columns.AddRange(new DataGridViewColumn[] { NC, name, address, BN, BrName, country, AN, SC, IB });
            dGVbenificiary.Dock = DockStyle.Fill;
            dGVbenificiary.Location = new Point(5, 5);
            dGVbenificiary.Name = "dGVbenificiary";
            dGVbenificiary.RowHeadersWidth = 4;
            dGVbenificiary.RowTemplate.Height = 25;
            dGVbenificiary.Size = new Size(773, 914);
            dGVbenificiary.TabIndex = 8;
            dGVbenificiary.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NC
            // 
            NC.HeaderText = "NIC NAME";
            NC.Name = "NC";
            NC.Width = 82;
            // 
            // name
            // 
            name.HeaderText = "NAME";
            name.Name = "name";
            name.Width = 66;
            // 
            // address
            // 
            address.HeaderText = "ADDRESS";
            address.Name = "address";
            address.Width = 81;
            // 
            // BN
            // 
            BN.HeaderText = "BANK NAME";
            BN.Name = "BN";
            BN.Width = 92;
            // 
            // BrName
            // 
            BrName.HeaderText = "BRANCH NAME";
            BrName.Name = "BrName";
            BrName.Width = 107;
            // 
            // country
            // 
            country.HeaderText = "COUNTRY";
            country.Name = "country";
            country.Width = 86;
            // 
            // AN
            // 
            AN.HeaderText = "ACCOUNT NO";
            AN.Name = "AN";
            // 
            // SC
            // 
            SC.HeaderText = "SWIFT CODE";
            SC.Name = "SC";
            SC.Width = 90;
            // 
            // IB
            // 
            IB.HeaderText = "INTERMEDIATE BANK";
            IB.Name = "IB";
            IB.Width = 132;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.85034F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.14966F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 34);
            label2.TabIndex = 1;
            label2.Text = "ADDRESS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 34);
            label4.Name = "label4";
            label4.Size = new Size(45, 34);
            label4.TabIndex = 3;
            label4.Text = "BANK NAME";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.85034F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.14966F));
            tableLayoutPanel3.Controls.Add(label13, 0, 2);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 9;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(42, 34);
            label13.TabIndex = 1;
            label13.Text = "ADDRESS";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(3, 34);
            label14.Name = "label14";
            label14.Size = new Size(45, 34);
            label14.TabIndex = 3;
            label14.Text = "BANK NAME";
            // 
            // UCBeneficiary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "UCBeneficiary";
            Size = new Size(1210, 964);
            Load += UCBeneficiary_Load;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGVbenificiary).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label10;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label4;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox TBnic;
        private TextBox TBname;
        private TextBox TBaddress;
        private TextBox tBbn;
        private TextBox tbbrN;
        private TextBox tBAN;
        private TextBox tBSC;
        private TextBox tBIN;
        private Label label11;
        private Label label12;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnBDelete;
        private FontAwesome.Sharp.IconButton btnBUpdate;
        private FontAwesome.Sharp.IconButton BTNbAdd;
        private DataGridView dGVbenificiary;
        private DataGridViewTextBoxColumn NC;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn BN;
        private DataGridViewTextBoxColumn BrName;
        private DataGridViewTextBoxColumn country;
        private DataGridViewTextBoxColumn AN;
        private DataGridViewTextBoxColumn SC;
        private DataGridViewTextBoxColumn IB;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label13;
        private Label label14;
        private ComboBox cbC;
        private Label label15;
        private TextBox tbBranchCode;
        private Panel panel2;
    }
}
