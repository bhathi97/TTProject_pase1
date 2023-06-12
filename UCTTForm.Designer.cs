namespace project_TelegraphicTransfer
{
    partial class UCTTForm
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
            lblFormName = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tb_beNicName = new TextBox();
            label32 = new Label();
            panel4 = new Panel();
            tb_spNote = new RichTextBox();
            label33 = new Label();
            btn_add = new FontAwesome.Sharp.IconButton();
            btn_delete = new FontAwesome.Sharp.IconButton();
            btn_edit = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbl_beCorrespondingBank = new Label();
            lbl_beSwiftCode = new Label();
            lbl_beSort = new Label();
            lbl_beAcc = new Label();
            lbl_amountInWords = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            tb_beAmount = new TextBox();
            lbl_beAddress = new Label();
            cb_beCurrency = new ComboBox();
            lbl_beBankname = new Label();
            lbl_Branchname = new Label();
            lbl_beBankCountry = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            rb_beApplicant = new RadioButton();
            rb_beBenificiary = new RadioButton();
            lbl_beName = new Label();
            label13 = new Label();
            label9 = new Label();
            tlp1 = new TableLayoutPanel();
            lbl_seBusiness = new Label();
            lbl_seAddress = new Label();
            lbl_seName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtp_date = new DateTimePicker();
            tb_purpose = new TextBox();
            tb_inv = new TextBox();
            tb_description = new TextBox();
            tb_terms = new TextBox();
            cb_goods = new ComboBox();
            tb_hc = new TextBox();
            tb_curierNo = new TextBox();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            cb_email1 = new ComboBox();
            cb_email2 = new ComboBox();
            label31 = new Label();
            lbl_sePhone = new Label();
            panel3 = new Panel();
            label10 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tlp1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormName
            // 
            lblFormName.AutoSize = true;
            lblFormName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormName.Location = new Point(6, 6);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(108, 25);
            lblFormName.TabIndex = 0;
            lblFormName.Text = "formName";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFormName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 39);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoScrollMargin = new Size(0, 100);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_edit);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(tlp1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 510);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(194, 194, 239);
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 490F));
            tableLayoutPanel3.Controls.Add(tb_beNicName, 0, 0);
            tableLayoutPanel3.Controls.Add(label32, 0, 0);
            tableLayoutPanel3.Location = new Point(6, 486);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(701, 37);
            tableLayoutPanel3.TabIndex = 21;
            // 
            // tb_beNicName
            // 
            tb_beNicName.Location = new Point(214, 3);
            tb_beNicName.Name = "tb_beNicName";
            tb_beNicName.Size = new Size(463, 23);
            tb_beNicName.TabIndex = 17;
            tb_beNicName.KeyPress += tb_beNicName_KeyPress;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(3, 0);
            label32.Name = "label32";
            label32.Size = new Size(76, 15);
            label32.TabIndex = 1;
            label32.Text = "  NIC NAME :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(194, 194, 239);
            panel4.Controls.Add(tb_spNote);
            panel4.Controls.Add(label33);
            panel4.Location = new Point(7, 1003);
            panel4.Name = "panel4";
            panel4.Size = new Size(700, 100);
            panel4.TabIndex = 20;
            // 
            // tb_spNote
            // 
            tb_spNote.BorderStyle = BorderStyle.FixedSingle;
            tb_spNote.Location = new Point(14, 32);
            tb_spNote.Name = "tb_spNote";
            tb_spNote.Size = new Size(670, 55);
            tb_spNote.TabIndex = 4;
            tb_spNote.Text = "";
            // 
            // label33
            // 
            label33.BackColor = Color.FromArgb(11, 12, 71);
            label33.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label33.ForeColor = SystemColors.HighlightText;
            label33.Location = new Point(0, 1);
            label33.Name = "label33";
            label33.Size = new Size(701, 20);
            label33.TabIndex = 3;
            label33.Text = "SPECIAL INSTRUCTIONS AND REMARKS TO SENT";
            // 
            // btn_add
            // 
            btn_add.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_add.IconColor = Color.Black;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.Location = new Point(467, 1118);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(168, 45);
            btn_add.TabIndex = 19;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_delete.IconColor = Color.Black;
            btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_delete.Location = new Point(278, 1118);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(168, 45);
            btn_delete.TabIndex = 18;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            btn_edit.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_edit.IconColor = Color.Black;
            btn_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_edit.Location = new Point(90, 1118);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(168, 45);
            btn_edit.TabIndex = 17;
            btn_edit.Text = "EDIT";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(194, 194, 239);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.95658F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.04342F));
            tableLayoutPanel2.Controls.Add(lbl_beCorrespondingBank, 1, 11);
            tableLayoutPanel2.Controls.Add(lbl_beSwiftCode, 1, 10);
            tableLayoutPanel2.Controls.Add(lbl_beSort, 1, 9);
            tableLayoutPanel2.Controls.Add(lbl_beAcc, 1, 8);
            tableLayoutPanel2.Controls.Add(lbl_amountInWords, 1, 4);
            tableLayoutPanel2.Controls.Add(label14, 0, 0);
            tableLayoutPanel2.Controls.Add(label15, 0, 1);
            tableLayoutPanel2.Controls.Add(label16, 0, 2);
            tableLayoutPanel2.Controls.Add(label17, 0, 3);
            tableLayoutPanel2.Controls.Add(label18, 0, 4);
            tableLayoutPanel2.Controls.Add(label19, 0, 5);
            tableLayoutPanel2.Controls.Add(label20, 0, 6);
            tableLayoutPanel2.Controls.Add(label21, 0, 7);
            tableLayoutPanel2.Controls.Add(tb_beAmount, 1, 3);
            tableLayoutPanel2.Controls.Add(lbl_beAddress, 1, 1);
            tableLayoutPanel2.Controls.Add(cb_beCurrency, 1, 2);
            tableLayoutPanel2.Controls.Add(lbl_beBankname, 1, 5);
            tableLayoutPanel2.Controls.Add(lbl_Branchname, 1, 6);
            tableLayoutPanel2.Controls.Add(lbl_beBankCountry, 1, 7);
            tableLayoutPanel2.Controls.Add(label22, 0, 8);
            tableLayoutPanel2.Controls.Add(label23, 0, 9);
            tableLayoutPanel2.Controls.Add(label24, 0, 10);
            tableLayoutPanel2.Controls.Add(label25, 0, 11);
            tableLayoutPanel2.Controls.Add(label26, 0, 12);
            tableLayoutPanel2.Controls.Add(rb_beApplicant, 1, 12);
            tableLayoutPanel2.Controls.Add(rb_beBenificiary, 1, 13);
            tableLayoutPanel2.Controls.Add(lbl_beName, 1, 0);
            tableLayoutPanel2.Location = new Point(6, 521);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 14;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(701, 473);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // lbl_beCorrespondingBank
            // 
            lbl_beCorrespondingBank.BackColor = Color.White;
            lbl_beCorrespondingBank.BorderStyle = BorderStyle.FixedSingle;
            lbl_beCorrespondingBank.Location = new Point(214, 370);
            lbl_beCorrespondingBank.Name = "lbl_beCorrespondingBank";
            lbl_beCorrespondingBank.Size = new Size(463, 23);
            lbl_beCorrespondingBank.TabIndex = 30;
            lbl_beCorrespondingBank.Text = "label22";
            // 
            // lbl_beSwiftCode
            // 
            lbl_beSwiftCode.BackColor = Color.White;
            lbl_beSwiftCode.BorderStyle = BorderStyle.FixedSingle;
            lbl_beSwiftCode.Location = new Point(214, 340);
            lbl_beSwiftCode.Name = "lbl_beSwiftCode";
            lbl_beSwiftCode.Size = new Size(463, 23);
            lbl_beSwiftCode.TabIndex = 28;
            lbl_beSwiftCode.Text = "label22";
            // 
            // lbl_beSort
            // 
            lbl_beSort.BackColor = Color.White;
            lbl_beSort.BorderStyle = BorderStyle.FixedSingle;
            lbl_beSort.Location = new Point(214, 305);
            lbl_beSort.Name = "lbl_beSort";
            lbl_beSort.Size = new Size(463, 23);
            lbl_beSort.TabIndex = 26;
            lbl_beSort.Text = "label22";
            // 
            // lbl_beAcc
            // 
            lbl_beAcc.BackColor = Color.White;
            lbl_beAcc.BorderStyle = BorderStyle.FixedSingle;
            lbl_beAcc.Location = new Point(214, 275);
            lbl_beAcc.Name = "lbl_beAcc";
            lbl_beAcc.Size = new Size(463, 23);
            lbl_beAcc.TabIndex = 24;
            lbl_beAcc.Text = "label22";
            // 
            // lbl_amountInWords
            // 
            lbl_amountInWords.BackColor = Color.White;
            lbl_amountInWords.BorderStyle = BorderStyle.FixedSingle;
            lbl_amountInWords.Location = new Point(214, 125);
            lbl_amountInWords.Name = "lbl_amountInWords";
            lbl_amountInWords.Size = new Size(463, 48);
            lbl_amountInWords.TabIndex = 19;
            lbl_amountInWords.Text = "label22";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 5);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 0;
            label14.Text = "NAME :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 35);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 1;
            label15.Text = "ADDRESS";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 65);
            label16.Name = "label16";
            label16.Size = new Size(102, 15);
            label16.TabIndex = 2;
            label16.Text = "CURRENCY TYPE :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(8, 95);
            label17.Name = "label17";
            label17.Size = new Size(123, 15);
            label17.TabIndex = 3;
            label17.Text = "AMOUNT OF FIGURES";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 125);
            label18.Name = "label18";
            label18.Size = new Size(123, 15);
            label18.TabIndex = 4;
            label18.Text = "AMOUNT IN WORDS :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 185);
            label19.Name = "label19";
            label19.Size = new Size(81, 15);
            label19.TabIndex = 5;
            label19.Text = "BANK NAME :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(8, 215);
            label20.Name = "label20";
            label20.Size = new Size(61, 15);
            label20.TabIndex = 6;
            label20.Text = "BRANCH :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(8, 245);
            label21.Name = "label21";
            label21.Size = new Size(67, 15);
            label21.TabIndex = 7;
            label21.Text = "COUNTRY :";
            // 
            // tb_beAmount
            // 
            tb_beAmount.Location = new Point(214, 98);
            tb_beAmount.Name = "tb_beAmount";
            tb_beAmount.Size = new Size(463, 23);
            tb_beAmount.TabIndex = 11;
            tb_beAmount.TextChanged += tb_beAmount_TextChanged;
            // 
            // lbl_beAddress
            // 
            lbl_beAddress.BackColor = Color.White;
            lbl_beAddress.BorderStyle = BorderStyle.FixedSingle;
            lbl_beAddress.Location = new Point(214, 35);
            lbl_beAddress.Name = "lbl_beAddress";
            lbl_beAddress.Size = new Size(463, 23);
            lbl_beAddress.TabIndex = 17;
            lbl_beAddress.Text = "label22";
            // 
            // cb_beCurrency
            // 
            cb_beCurrency.FormattingEnabled = true;
            cb_beCurrency.Location = new Point(214, 68);
            cb_beCurrency.Name = "cb_beCurrency";
            cb_beCurrency.Size = new Size(463, 23);
            cb_beCurrency.TabIndex = 18;
            // 
            // lbl_beBankname
            // 
            lbl_beBankname.BackColor = Color.White;
            lbl_beBankname.BorderStyle = BorderStyle.FixedSingle;
            lbl_beBankname.Location = new Point(214, 185);
            lbl_beBankname.Name = "lbl_beBankname";
            lbl_beBankname.Size = new Size(463, 23);
            lbl_beBankname.TabIndex = 20;
            lbl_beBankname.Text = "label22";
            // 
            // lbl_Branchname
            // 
            lbl_Branchname.BackColor = Color.White;
            lbl_Branchname.BorderStyle = BorderStyle.FixedSingle;
            lbl_Branchname.Location = new Point(214, 215);
            lbl_Branchname.Name = "lbl_Branchname";
            lbl_Branchname.Size = new Size(463, 23);
            lbl_Branchname.TabIndex = 21;
            lbl_Branchname.Text = "label22";
            // 
            // lbl_beBankCountry
            // 
            lbl_beBankCountry.BackColor = Color.White;
            lbl_beBankCountry.BorderStyle = BorderStyle.FixedSingle;
            lbl_beBankCountry.Location = new Point(214, 245);
            lbl_beBankCountry.Name = "lbl_beBankCountry";
            lbl_beBankCountry.Size = new Size(463, 23);
            lbl_beBankCountry.TabIndex = 22;
            lbl_beBankCountry.Text = "label22";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(8, 275);
            label22.Name = "label22";
            label22.Size = new Size(146, 15);
            label22.TabIndex = 23;
            label22.Text = "ACCOUNT NO/ IBAN NO :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(8, 305);
            label23.Name = "label23";
            label23.Size = new Size(199, 30);
            label23.TabIndex = 25;
            label23.Text = "SORT/ROUTING/FEDWIRE/ABA/BSB/BANK-BRANCH CODE :";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(8, 340);
            label24.Name = "label24";
            label24.Size = new Size(82, 15);
            label24.TabIndex = 27;
            label24.Text = "SWIFT CODE : ";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(8, 370);
            label25.Name = "label25";
            label25.Size = new Size(189, 30);
            label25.TabIndex = 29;
            label25.Text = "CORRESPONDING/INTERMEDIATE BANK (if Available)";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(8, 405);
            label26.Name = "label26";
            label26.Size = new Size(174, 30);
            label26.TabIndex = 31;
            label26.Text = "FORIGN BANK CHARGES TO BE BORNE BY :";
            // 
            // rb_beApplicant
            // 
            rb_beApplicant.AutoSize = true;
            rb_beApplicant.Location = new Point(214, 408);
            rb_beApplicant.Name = "rb_beApplicant";
            rb_beApplicant.Size = new Size(87, 19);
            rb_beApplicant.TabIndex = 32;
            rb_beApplicant.TabStop = true;
            rb_beApplicant.Text = "APPLICANT";
            rb_beApplicant.UseVisualStyleBackColor = true;
            // 
            // rb_beBenificiary
            // 
            rb_beBenificiary.AutoSize = true;
            rb_beBenificiary.Location = new Point(214, 438);
            rb_beBenificiary.Name = "rb_beBenificiary";
            rb_beBenificiary.Size = new Size(95, 19);
            rb_beBenificiary.TabIndex = 33;
            rb_beBenificiary.TabStop = true;
            rb_beBenificiary.Text = "BENEFICIARY";
            rb_beBenificiary.UseVisualStyleBackColor = true;
            // 
            // lbl_beName
            // 
            lbl_beName.BackColor = SystemColors.ButtonHighlight;
            lbl_beName.BorderStyle = BorderStyle.FixedSingle;
            lbl_beName.Location = new Point(214, 5);
            lbl_beName.Name = "lbl_beName";
            lbl_beName.Size = new Size(463, 23);
            lbl_beName.TabIndex = 34;
            lbl_beName.Text = "label34";
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(11, 12, 71);
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.HighlightText;
            label13.Location = new Point(6, 465);
            label13.Name = "label13";
            label13.Size = new Size(701, 20);
            label13.TabIndex = 2;
            label13.Text = "RECEIVER (BENEFICIARY)";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(11, 12, 71);
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HighlightText;
            label9.Location = new Point(6, 2);
            label9.Name = "label9";
            label9.Size = new Size(701, 20);
            label9.TabIndex = 1;
            label9.Text = "SENDER (APPLICANT)";
            // 
            // tlp1
            // 
            tlp1.BackColor = Color.FromArgb(194, 194, 239);
            tlp1.ColumnCount = 2;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.1013F));
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.8987F));
            tlp1.Controls.Add(lbl_seBusiness, 1, 10);
            tlp1.Controls.Add(lbl_seAddress, 1, 9);
            tlp1.Controls.Add(lbl_seName, 1, 8);
            tlp1.Controls.Add(label1, 0, 0);
            tlp1.Controls.Add(label2, 0, 1);
            tlp1.Controls.Add(label3, 0, 2);
            tlp1.Controls.Add(label4, 0, 3);
            tlp1.Controls.Add(label5, 0, 4);
            tlp1.Controls.Add(label6, 0, 5);
            tlp1.Controls.Add(label7, 0, 6);
            tlp1.Controls.Add(label8, 0, 7);
            tlp1.Controls.Add(dtp_date, 1, 0);
            tlp1.Controls.Add(tb_purpose, 1, 1);
            tlp1.Controls.Add(tb_inv, 1, 2);
            tlp1.Controls.Add(tb_description, 1, 3);
            tlp1.Controls.Add(tb_terms, 1, 4);
            tlp1.Controls.Add(cb_goods, 1, 5);
            tlp1.Controls.Add(tb_hc, 1, 6);
            tlp1.Controls.Add(tb_curierNo, 1, 7);
            tlp1.Controls.Add(label27, 0, 8);
            tlp1.Controls.Add(label28, 0, 9);
            tlp1.Controls.Add(label29, 0, 10);
            tlp1.Controls.Add(label30, 0, 11);
            tlp1.Controls.Add(cb_email1, 1, 11);
            tlp1.Controls.Add(cb_email2, 1, 12);
            tlp1.Controls.Add(label31, 0, 13);
            tlp1.Controls.Add(lbl_sePhone, 1, 13);
            tlp1.Location = new Point(6, 23);
            tlp1.Name = "tlp1";
            tlp1.Padding = new Padding(5);
            tlp1.RowCount = 15;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.Size = new Size(701, 427);
            tlp1.TabIndex = 0;
            // 
            // lbl_seBusiness
            // 
            lbl_seBusiness.BackColor = Color.White;
            lbl_seBusiness.BorderStyle = BorderStyle.FixedSingle;
            lbl_seBusiness.Location = new Point(215, 305);
            lbl_seBusiness.Name = "lbl_seBusiness";
            lbl_seBusiness.Size = new Size(477, 23);
            lbl_seBusiness.TabIndex = 22;
            lbl_seBusiness.Text = "label22";
            // 
            // lbl_seAddress
            // 
            lbl_seAddress.BackColor = Color.White;
            lbl_seAddress.BorderStyle = BorderStyle.FixedSingle;
            lbl_seAddress.Location = new Point(215, 275);
            lbl_seAddress.Name = "lbl_seAddress";
            lbl_seAddress.Size = new Size(477, 23);
            lbl_seAddress.TabIndex = 20;
            lbl_seAddress.Text = "label22";
            // 
            // lbl_seName
            // 
            lbl_seName.BackColor = Color.White;
            lbl_seName.BorderStyle = BorderStyle.FixedSingle;
            lbl_seName.Location = new Point(215, 245);
            lbl_seName.Name = "lbl_seName";
            lbl_seName.Size = new Size(477, 23);
            lbl_seName.TabIndex = 18;
            lbl_seName.Text = "label22";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "DATE :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 35);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 1;
            label2.Text = "PURPOSE OF REMITTANCE :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 65);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Inv No / Ref No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 95);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 3;
            label4.Text = "DESCRIPTION OF ITEMS :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 125);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 4;
            label5.Text = "TRADE TERMS / INCOTERM :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 155);
            label6.Name = "label6";
            label6.Size = new Size(158, 15);
            label6.TabIndex = 5;
            label6.Text = "GOODS (CLEARED OR NOT) :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 185);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 6;
            label7.Text = "HS CODES :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 215);
            label8.Name = "label8";
            label8.Size = new Size(146, 15);
            label8.TabIndex = 7;
            label8.Text = "CUSTDEC / COURIER NO : ";
            // 
            // dtp_date
            // 
            dtp_date.Format = DateTimePickerFormat.Short;
            dtp_date.Location = new Point(215, 8);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(477, 23);
            dtp_date.TabIndex = 8;
            // 
            // tb_purpose
            // 
            tb_purpose.Location = new Point(215, 38);
            tb_purpose.Name = "tb_purpose";
            tb_purpose.Size = new Size(477, 23);
            tb_purpose.TabIndex = 9;
            // 
            // tb_inv
            // 
            tb_inv.Location = new Point(215, 68);
            tb_inv.Name = "tb_inv";
            tb_inv.Size = new Size(477, 23);
            tb_inv.TabIndex = 10;
            // 
            // tb_description
            // 
            tb_description.Location = new Point(215, 98);
            tb_description.Name = "tb_description";
            tb_description.Size = new Size(477, 23);
            tb_description.TabIndex = 11;
            // 
            // tb_terms
            // 
            tb_terms.Location = new Point(215, 128);
            tb_terms.Name = "tb_terms";
            tb_terms.Size = new Size(477, 23);
            tb_terms.TabIndex = 12;
            // 
            // cb_goods
            // 
            cb_goods.FormattingEnabled = true;
            cb_goods.Items.AddRange(new object[] { "CLEARED", "NOT CLEARED" });
            cb_goods.Location = new Point(215, 158);
            cb_goods.Name = "cb_goods";
            cb_goods.Size = new Size(477, 23);
            cb_goods.TabIndex = 13;
            // 
            // tb_hc
            // 
            tb_hc.Location = new Point(215, 188);
            tb_hc.Name = "tb_hc";
            tb_hc.Size = new Size(477, 23);
            tb_hc.TabIndex = 14;
            // 
            // tb_curierNo
            // 
            tb_curierNo.Location = new Point(215, 218);
            tb_curierNo.Name = "tb_curierNo";
            tb_curierNo.Size = new Size(477, 23);
            tb_curierNo.TabIndex = 15;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(8, 245);
            label27.Name = "label27";
            label27.Size = new Size(154, 15);
            label27.TabIndex = 16;
            label27.Text = "NAME OF THE APPLICANT :";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(8, 275);
            label28.Name = "label28";
            label28.Size = new Size(62, 15);
            label28.TabIndex = 19;
            label28.Text = "ADDRESS :";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(8, 305);
            label29.Name = "label29";
            label29.Size = new Size(137, 15);
            label29.TabIndex = 21;
            label29.Text = "BUSINESS/PROFESSION :";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(8, 335);
            label30.Name = "label30";
            label30.Size = new Size(47, 15);
            label30.TabIndex = 23;
            label30.Text = "EMAIL :";
            // 
            // cb_email1
            // 
            cb_email1.FormattingEnabled = true;
            cb_email1.Location = new Point(215, 338);
            cb_email1.Name = "cb_email1";
            cb_email1.Size = new Size(477, 23);
            cb_email1.TabIndex = 24;
            // 
            // cb_email2
            // 
            cb_email2.FormattingEnabled = true;
            cb_email2.Location = new Point(215, 368);
            cb_email2.Name = "cb_email2";
            cb_email2.Size = new Size(477, 23);
            cb_email2.TabIndex = 25;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(8, 395);
            label31.Name = "label31";
            label31.Size = new Size(53, 15);
            label31.TabIndex = 26;
            label31.Text = "PHONE :";
            // 
            // lbl_sePhone
            // 
            lbl_sePhone.BackColor = Color.White;
            lbl_sePhone.BorderStyle = BorderStyle.FixedSingle;
            lbl_sePhone.Location = new Point(215, 395);
            lbl_sePhone.Name = "lbl_sePhone";
            lbl_sePhone.Size = new Size(477, 23);
            lbl_sePhone.TabIndex = 27;
            lbl_sePhone.Text = "label22";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 526);
            panel3.Name = "panel3";
            panel3.Size = new Size(737, 23);
            panel3.TabIndex = 6;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(11, 12, 71);
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HighlightText;
            label10.Location = new Point(8, 245);
            label10.Name = "label10";
            label10.Size = new Size(701, 20);
            label10.TabIndex = 17;
            label10.Text = "SENDER (APPLICANT)";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(194, 194, 239);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2482166F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.7517853F));
            tableLayoutPanel1.Controls.Add(label11, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 0;
            label11.Text = "DATE :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 15);
            label12.Name = "label12";
            label12.Size = new Size(46, 60);
            label12.TabIndex = 1;
            label12.Text = "PURPOSE OF REMITTANCE :";
            // 
            // UCTTForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCTTForm";
            Size = new Size(737, 549);
            Load += UCTTForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tlp1.ResumeLayout(false);
            tlp1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFormName;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tlp1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtp_date;
        private TextBox tb_purpose;
        private TextBox tb_inv;
        private TextBox tb_description;
        private TextBox tb_terms;
        private ComboBox cb_goods;
        private TextBox tb_hc;
        private TextBox tb_curierNo;
        private Label label9;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private Label label12;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox tb_beAmount;
        private Label lbl_beAddress;
        private ComboBox cb_beCurrency;
        private Label lbl_amountInWords;
        private Label lbl_beBankname;
        private Label lbl_Branchname;
        private Label lbl_beBankCountry;
        private Label lbl_beAcc;
        private Label label22;
        private Label lbl_beSwiftCode;
        private Label lbl_beSort;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label lbl_beCorrespondingBank;
        private Label label26;
        private RadioButton rb_beApplicant;
        private RadioButton rb_beBenificiary;
        private Label lbl_seName;
        private Label label27;
        private Label lbl_seAddress;
        private Label label28;
        private Label lbl_seBusiness;
        private Label label29;
        private Label label30;
        private ComboBox cb_email1;
        private ComboBox cb_email2;
        private Label label31;
        private Label lbl_sePhone;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_delete;
        private FontAwesome.Sharp.IconButton btn_edit;
        private Panel panel4;
        private RichTextBox tb_spNote;
        private Label label33;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox tb_beNicName;
        private Label label32;
        private Label lbl_beName;
    }
}
