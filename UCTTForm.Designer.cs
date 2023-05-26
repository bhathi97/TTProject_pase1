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
            label1 = new Label();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            tb_purpose = new TextBox();
            tb_refNo = new TextBox();
            label4 = new Label();
            tb_description = new TextBox();
            label5 = new Label();
            tb_tradeTerm = new TextBox();
            label6 = new Label();
            cb_clear = new ComboBox();
            panel3 = new Panel();
            label7 = new Label();
            tb_hsCodes = new TextBox();
            label8 = new Label();
            tb_custdec = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 34);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 1;
            label1.Text = "PURPOSE OF REMITTANCE :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 4);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "DATE : ";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(218, 7);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(339, 23);
            dtpDate.TabIndex = 3;
            dtpDate.Value = new DateTime(2023, 5, 24, 22, 34, 59, 0);
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
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 515);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.67857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.32143F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpDate, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(tb_purpose, 1, 1);
            tableLayoutPanel1.Controls.Add(tb_refNo, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(tb_description, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(tb_tradeTerm, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(cb_clear, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(tb_hsCodes, 1, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(tb_custdec, 1, 7);
            tableLayoutPanel1.Location = new Point(6, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(4);
            tableLayoutPanel1.RowCount = 15;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(568, 460);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 64);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 5;
            label3.Text = "Inv No / Ref No ";
            // 
            // tb_purpose
            // 
            tb_purpose.Location = new Point(218, 37);
            tb_purpose.Multiline = true;
            tb_purpose.Name = "tb_purpose";
            tb_purpose.Size = new Size(339, 24);
            tb_purpose.TabIndex = 4;
            // 
            // tb_refNo
            // 
            tb_refNo.Location = new Point(218, 67);
            tb_refNo.Multiline = true;
            tb_refNo.Name = "tb_refNo";
            tb_refNo.Size = new Size(339, 23);
            tb_refNo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 94);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 7;
            label4.Text = "DESCRIPTION OF ITEMS";
            // 
            // tb_description
            // 
            tb_description.Location = new Point(218, 97);
            tb_description.Multiline = true;
            tb_description.Name = "tb_description";
            tb_description.Size = new Size(339, 23);
            tb_description.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 124);
            label5.Name = "label5";
            label5.Size = new Size(195, 20);
            label5.TabIndex = 9;
            label5.Text = "TRADE TERMS / INTERCOM";
            // 
            // tb_tradeTerm
            // 
            tb_tradeTerm.Location = new Point(218, 127);
            tb_tradeTerm.Multiline = true;
            tb_tradeTerm.Name = "tb_tradeTerm";
            tb_tradeTerm.Size = new Size(339, 23);
            tb_tradeTerm.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(7, 154);
            label6.Name = "label6";
            label6.Size = new Size(194, 20);
            label6.TabIndex = 11;
            label6.Text = "GOODS (CLEARED OR NOT)";
            // 
            // cb_clear
            // 
            cb_clear.FormattingEnabled = true;
            cb_clear.Items.AddRange(new object[] { "Cleared", "Not Cleared" });
            cb_clear.Location = new Point(218, 157);
            cb_clear.Name = "cb_clear";
            cb_clear.Size = new Size(339, 23);
            cb_clear.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 533);
            panel3.Name = "panel3";
            panel3.Size = new Size(737, 21);
            panel3.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 184);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 13;
            label7.Text = "HS CODES";
            // 
            // tb_hsCodes
            // 
            tb_hsCodes.Location = new Point(218, 187);
            tb_hsCodes.Multiline = true;
            tb_hsCodes.Name = "tb_hsCodes";
            tb_hsCodes.Size = new Size(339, 23);
            tb_hsCodes.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(7, 214);
            label8.Name = "label8";
            label8.Size = new Size(175, 20);
            label8.TabIndex = 15;
            label8.Text = "CUSTDEC / COURIER NO";
            // 
            // tb_custdec
            // 
            tb_custdec.Location = new Point(218, 217);
            tb_custdec.Multiline = true;
            tb_custdec.Name = "tb_custdec";
            tb_custdec.Size = new Size(339, 23);
            tb_custdec.TabIndex = 16;
            // 
            // UCTTForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCTTForm";
            Size = new Size(737, 554);
            Load += UCTTForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFormName;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDate;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox tb_purpose;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tb_refNo;
        private Label label4;
        private TextBox tb_description;
        private Label label5;
        private TextBox tb_tradeTerm;
        private Label label6;
        private ComboBox cb_clear;
        private Label label7;
        private TextBox tb_hsCodes;
        private Label label8;
        private TextBox tb_custdec;
    }
}
