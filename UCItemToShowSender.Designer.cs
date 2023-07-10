namespace project_TelegraphicTransfer
{
    partial class UCItemToShowSender
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
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_TinNo = new System.Windows.Forms.Label();
            this.lbl_TN = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_business = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.btn_editSender = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name1
            // 
            this.lbl_name1.AutoSize = true;
            this.lbl_name1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name1.ForeColor = System.Drawing.Color.White;
            this.lbl_name1.Location = new System.Drawing.Point(53, 8);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(129, 25);
            this.lbl_name1.TabIndex = 1;
            this.lbl_name1.Text = "Sender name";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 36;
            this.iconPictureBox2.Location = new System.Drawing.Point(11, 5);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(36, 36);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_TinNo, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_TN, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_address, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_business, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_tax, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(452, 106);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lbl_TinNo
            // 
            this.lbl_TinNo.AutoSize = true;
            this.lbl_TinNo.ForeColor = System.Drawing.Color.White;
            this.lbl_TinNo.Location = new System.Drawing.Point(3, 80);
            this.lbl_TinNo.Name = "lbl_TinNo";
            this.lbl_TinNo.Size = new System.Drawing.Size(51, 15);
            this.lbl_TinNo.TabIndex = 4;
            this.lbl_TinNo.Text = "Tin No  :";
            // 
            // lbl_TN
            // 
            this.lbl_TN.AutoSize = true;
            this.lbl_TN.ForeColor = System.Drawing.Color.White;
            this.lbl_TN.Location = new System.Drawing.Point(3, 60);
            this.lbl_TN.Name = "lbl_TN";
            this.lbl_TN.Size = new System.Drawing.Size(89, 15);
            this.lbl_TN.TabIndex = 3;
            this.lbl_TN.Text = "Telephone No  :";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.ForeColor = System.Drawing.Color.White;
            this.lbl_address.Location = new System.Drawing.Point(3, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(61, 15);
            this.lbl_address.TabIndex = 0;
            this.lbl_address.Text = "Address  : ";
            // 
            // lbl_business
            // 
            this.lbl_business.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_business.AutoSize = true;
            this.lbl_business.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_business.ForeColor = System.Drawing.Color.White;
            this.lbl_business.Location = new System.Drawing.Point(3, 21);
            this.lbl_business.Name = "lbl_business";
            this.lbl_business.Size = new System.Drawing.Size(63, 17);
            this.lbl_business.TabIndex = 1;
            this.lbl_business.Text = "Business : ";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.ForeColor = System.Drawing.Color.White;
            this.lbl_tax.Location = new System.Drawing.Point(3, 40);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(33, 15);
            this.lbl_tax.TabIndex = 2;
            this.lbl_tax.Text = "Tax  :";
            // 
            // btn_editSender
            // 
            this.btn_editSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_editSender.FlatAppearance.BorderSize = 0;
            this.btn_editSender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btn_editSender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_editSender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editSender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_editSender.ForeColor = System.Drawing.Color.White;
            this.btn_editSender.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_editSender.IconColor = System.Drawing.Color.White;
            this.btn_editSender.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_editSender.IconSize = 20;
            this.btn_editSender.Location = new System.Drawing.Point(485, 121);
            this.btn_editSender.Name = "btn_editSender";
            this.btn_editSender.Size = new System.Drawing.Size(64, 30);
            this.btn_editSender.TabIndex = 5;
            this.btn_editSender.Text = "EDIT";
            this.btn_editSender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editSender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editSender.UseVisualStyleBackColor = false;
            this.btn_editSender.Click += new System.EventHandler(this.btn_editSender_Click);
            // 
            // UCItemToShowSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.btn_editSender);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.lbl_name1);
            this.Name = "UCItemToShowSender";
            this.Size = new System.Drawing.Size(569, 172);
            this.Load += new System.EventHandler(this.LoadSender);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_name1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbl_TinNo;
        private Label lbl_TN;
        private Label lbl_address;
        private Label lbl_business;
        private Label lbl_tax;
        private FontAwesome.Sharp.IconButton btn_editSender;
    }
}
