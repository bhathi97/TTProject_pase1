namespace project_TelegraphicTransfer
{
    partial class UCItemToShowBenificieries
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
            lbl_name = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lbl_nicName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_corBank = new Label();
            lbl_branchName = new Label();
            lbl_bankName = new Label();
            lbl_addr = new Label();
            lbl_country = new Label();
            lbl_accNo = new Label();
            lbl_branchCode = new Label();
            lbl_swift = new Label();
            btn_edit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.White;
            lbl_name.Location = new Point(51, 9);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(160, 25);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "benificiary name";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(11, 12, 71);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 36;
            iconPictureBox1.Location = new Point(11, 13);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(36, 36);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // lbl_nicName
            // 
            lbl_nicName.AutoSize = true;
            lbl_nicName.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_nicName.ForeColor = Color.White;
            lbl_nicName.Location = new Point(55, 35);
            lbl_nicName.Name = "lbl_nicName";
            lbl_nicName.Size = new Size(55, 15);
            lbl_nicName.TabIndex = 2;
            lbl_nicName.Text = "nic name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lbl_corBank, 0, 7);
            tableLayoutPanel1.Controls.Add(lbl_branchName, 0, 4);
            tableLayoutPanel1.Controls.Add(lbl_bankName, 0, 3);
            tableLayoutPanel1.Controls.Add(lbl_addr, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_country, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_accNo, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_branchCode, 0, 5);
            tableLayoutPanel1.Controls.Add(lbl_swift, 0, 6);
            tableLayoutPanel1.Location = new Point(26, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(518, 162);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lbl_corBank
            // 
            lbl_corBank.AutoSize = true;
            lbl_corBank.ForeColor = Color.White;
            lbl_corBank.Location = new Point(3, 140);
            lbl_corBank.Name = "lbl_corBank";
            lbl_corBank.Size = new Size(113, 15);
            lbl_corBank.TabIndex = 7;
            lbl_corBank.Text = "corresponding bank";
            // 
            // lbl_branchName
            // 
            lbl_branchName.AutoSize = true;
            lbl_branchName.ForeColor = Color.White;
            lbl_branchName.Location = new Point(3, 80);
            lbl_branchName.Name = "lbl_branchName";
            lbl_branchName.Size = new Size(77, 15);
            lbl_branchName.TabIndex = 4;
            lbl_branchName.Text = "branch name";
            // 
            // lbl_bankName
            // 
            lbl_bankName.AutoSize = true;
            lbl_bankName.ForeColor = Color.White;
            lbl_bankName.Location = new Point(3, 60);
            lbl_bankName.Name = "lbl_bankName";
            lbl_bankName.Size = new Size(66, 15);
            lbl_bankName.TabIndex = 3;
            lbl_bankName.Text = "bank name";
            // 
            // lbl_addr
            // 
            lbl_addr.AutoSize = true;
            lbl_addr.ForeColor = Color.White;
            lbl_addr.Location = new Point(3, 0);
            lbl_addr.Name = "lbl_addr";
            lbl_addr.Size = new Size(47, 15);
            lbl_addr.TabIndex = 0;
            lbl_addr.Text = "address";
            // 
            // lbl_country
            // 
            lbl_country.Anchor = AnchorStyles.Left;
            lbl_country.AutoSize = true;
            lbl_country.BorderStyle = BorderStyle.FixedSingle;
            lbl_country.ForeColor = Color.White;
            lbl_country.Location = new Point(3, 21);
            lbl_country.Name = "lbl_country";
            lbl_country.Size = new Size(50, 17);
            lbl_country.TabIndex = 1;
            lbl_country.Text = "country";
            // 
            // lbl_accNo
            // 
            lbl_accNo.AutoSize = true;
            lbl_accNo.ForeColor = Color.White;
            lbl_accNo.Location = new Point(3, 40);
            lbl_accNo.Name = "lbl_accNo";
            lbl_accNo.Size = new Size(95, 15);
            lbl_accNo.TabIndex = 2;
            lbl_accNo.Text = "account number";
            // 
            // lbl_branchCode
            // 
            lbl_branchCode.AutoSize = true;
            lbl_branchCode.ForeColor = Color.White;
            lbl_branchCode.Location = new Point(3, 100);
            lbl_branchCode.Name = "lbl_branchCode";
            lbl_branchCode.Size = new Size(73, 15);
            lbl_branchCode.TabIndex = 5;
            lbl_branchCode.Text = "branch code";
            // 
            // lbl_swift
            // 
            lbl_swift.AutoSize = true;
            lbl_swift.ForeColor = Color.White;
            lbl_swift.Location = new Point(3, 120);
            lbl_swift.Name = "lbl_swift";
            lbl_swift.Size = new Size(61, 15);
            lbl_swift.TabIndex = 6;
            lbl_swift.Text = "swift code";
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(76, 175, 80);
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatAppearance.MouseDownBackColor = Color.PaleGreen;
            btn_edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_edit.ForeColor = Color.White;
            btn_edit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btn_edit.IconColor = Color.White;
            btn_edit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn_edit.IconSize = 20;
            btn_edit.Location = new Point(560, 192);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(64, 30);
            btn_edit.TabIndex = 4;
            btn_edit.Text = "EDIT";
            btn_edit.TextAlign = ContentAlignment.MiddleRight;
            btn_edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_edit.UseVisualStyleBackColor = false;
            // 
            // UCItemToShowBenificieries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(11, 12, 71);
            Controls.Add(btn_edit);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lbl_nicName);
            Controls.Add(iconPictureBox1);
            Controls.Add(lbl_name);
            Name = "UCItemToShowBenificieries";
            Size = new Size(636, 235);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lbl_nicName;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_addr;
        private Label lbl_country;
        private Label lbl_accNo;
        private Label lbl_branchName;
        private Label lbl_bankName;
        private Label lbl_branchCode;
        private Label lbl_swift;
        private Label lbl_corBank;
        private FontAwesome.Sharp.IconButton btn_edit;
    }
}
