namespace project_TelegraphicTransfer
{
    partial class FormMAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMAIN));


            panelmain = new Panel();
            panelbody = new Panel();
            pnllLoadSpace = new Panel();
            pnlButtons = new Panel();
            btn_Logout = new FontAwesome.Sharp.IconButton();
            btn_DatabaseSender = new FontAwesome.Sharp.IconButton();
            btnDatabaseBenificiary = new FontAwesome.Sharp.IconButton();
            btnDataBaseUser = new FontAwesome.Sharp.IconButton();
            btnConfirmRecord = new FontAwesome.Sharp.IconButton();
            btnNewRecord = new FontAwesome.Sharp.IconButton();
            panelheader = new Panel();
            panel1 = new Panel();
            pnlUserShowing = new Panel();
            label2 = new Label();
            label1 = new Label();
            lbl_TTNameShowing = new Label();
            lblFormNameShow = new Label();
            lblSystemName = new Label();
            panellogo = new Panel();
            pbLOGO = new PictureBox();
            panelmain.SuspendLayout();
            panelbody.SuspendLayout();
            pnlButtons.SuspendLayout();
            panelheader.SuspendLayout();
            panel1.SuspendLayout();
            pnlUserShowing.SuspendLayout();
            panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLOGO).BeginInit();
            SuspendLayout();
            // 
            // panelmain
            // 
            panelmain.BackColor = SystemColors.Menu;
            panelmain.Controls.Add(panelbody);
            panelmain.Controls.Add(panelheader);
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(0, 0);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(800, 487);
            panelmain.TabIndex = 0;
            // 
            // panelbody
            // 
            panelbody.Controls.Add(pnllLoadSpace);
            panelbody.Controls.Add(pnlButtons);
            panelbody.Dock = DockStyle.Fill;
            panelbody.Location = new Point(0, 65);
            panelbody.Name = "panelbody";
            panelbody.Size = new Size(800, 422);
            panelbody.TabIndex = 2;
            // 
            // pnllLoadSpace
            // 
            pnllLoadSpace.Cursor = Cursors.Hand;
            pnllLoadSpace.Dock = DockStyle.Fill;
            pnllLoadSpace.Location = new Point(65, 0);
            pnllLoadSpace.Name = "pnllLoadSpace";
            pnllLoadSpace.Size = new Size(735, 422);
            pnllLoadSpace.TabIndex = 2;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(1, 12, 71);
            pnlButtons.Controls.Add(btn_Logout);
            pnlButtons.Controls.Add(btn_DatabaseSender);
            pnlButtons.Controls.Add(btnDatabaseBenificiary);
            pnlButtons.Controls.Add(btnDataBaseUser);
            pnlButtons.Controls.Add(btnConfirmRecord);
            pnlButtons.Controls.Add(btnNewRecord);
            pnlButtons.Dock = DockStyle.Left;
            pnlButtons.ForeColor = Color.White;
            pnlButtons.Location = new Point(0, 0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(65, 422);
            pnlButtons.TabIndex = 1;
            // 
            // btn_Logout
            // 
            btn_Logout.Cursor = Cursors.Hand;
            btn_Logout.FlatAppearance.BorderSize = 0;
            btn_Logout.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btn_Logout.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            btn_Logout.IconColor = Color.White;
            btn_Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Logout.IconSize = 30;
            btn_Logout.Location = new Point(0, 345);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(65, 65);
            btn_Logout.TabIndex = 5;
            btn_Logout.UseVisualStyleBackColor = true;
            // 
            // btn_DatabaseSender
            // 
            btn_DatabaseSender.Cursor = Cursors.Hand;
            btn_DatabaseSender.FlatAppearance.BorderSize = 0;
            btn_DatabaseSender.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btn_DatabaseSender.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btn_DatabaseSender.FlatStyle = FlatStyle.Flat;
            btn_DatabaseSender.IconChar = FontAwesome.Sharp.IconChar.Building;
            btn_DatabaseSender.IconColor = Color.White;
            btn_DatabaseSender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_DatabaseSender.IconSize = 30;
            btn_DatabaseSender.Location = new Point(0, 277);
            btn_DatabaseSender.Name = "btn_DatabaseSender";
            btn_DatabaseSender.Size = new Size(65, 65);
            btn_DatabaseSender.TabIndex = 4;
            btn_DatabaseSender.UseVisualStyleBackColor = true;
            // 
            // btnDatabaseBenificiary
            // 
            btnDatabaseBenificiary.Cursor = Cursors.Hand;
            btnDatabaseBenificiary.FlatAppearance.BorderSize = 0;
            btnDatabaseBenificiary.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnDatabaseBenificiary.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnDatabaseBenificiary.FlatStyle = FlatStyle.Flat;
            btnDatabaseBenificiary.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            btnDatabaseBenificiary.IconColor = Color.White;
            btnDatabaseBenificiary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDatabaseBenificiary.IconSize = 37;
            btnDatabaseBenificiary.Location = new Point(0, 208);
            btnDatabaseBenificiary.Name = "btnDatabaseBenificiary";
            btnDatabaseBenificiary.Size = new Size(65, 65);
            btnDatabaseBenificiary.TabIndex = 3;
            btnDatabaseBenificiary.UseVisualStyleBackColor = true;
            // 
            // btnDataBaseUser
            // 
            btnDataBaseUser.Cursor = Cursors.Hand;
            btnDataBaseUser.FlatAppearance.BorderSize = 0;
            btnDataBaseUser.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnDataBaseUser.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnDataBaseUser.FlatStyle = FlatStyle.Flat;
            btnDataBaseUser.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            btnDataBaseUser.IconColor = Color.White;
            btnDataBaseUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDataBaseUser.IconSize = 35;
            btnDataBaseUser.Location = new Point(0, 137);
            btnDataBaseUser.Name = "btnDataBaseUser";
            btnDataBaseUser.Size = new Size(65, 65);
            btnDataBaseUser.TabIndex = 2;
            btnDataBaseUser.UseVisualStyleBackColor = true;
            btnDataBaseUser.Click += btnDataBase_Click;
            // 
            // btnConfirmRecord
            // 
            this.btnConfirmRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmRecord.FlatAppearance.BorderSize = 0;
            this.btnConfirmRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirmRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnConfirmRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmRecord.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnConfirmRecord.IconColor = System.Drawing.Color.White;
            this.btnConfirmRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmRecord.IconSize = 35;
            this.btnConfirmRecord.Location = new System.Drawing.Point(0, 69);
            this.btnConfirmRecord.Name = "btnConfirmRecord";
            this.btnConfirmRecord.Size = new System.Drawing.Size(65, 65);
            this.btnConfirmRecord.TabIndex = 1;
            this.btnConfirmRecord.UseVisualStyleBackColor = true;
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRecord.FlatAppearance.BorderSize = 0;
            this.btnNewRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRecord.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnNewRecord.IconColor = System.Drawing.Color.White;
            this.btnNewRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewRecord.IconSize = 28;
            this.btnNewRecord.Location = new System.Drawing.Point(0, 0);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(65, 65);
            this.btnNewRecord.TabIndex = 0;
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.White;
            this.panelheader.Controls.Add(this.panel1);
            this.panelheader.Controls.Add(this.panellogo);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(800, 65);
            this.panelheader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.pnlUserShowing);
            this.panel1.Controls.Add(this.lblSystemName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel1.Location = new System.Drawing.Point(65, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 65);
            this.panel1.TabIndex = 1;
            // 
            // pnlUserShowing
            // 
            this.pnlUserShowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.pnlUserShowing.Controls.Add(this.label2);
            this.pnlUserShowing.Controls.Add(this.label1);
            this.pnlUserShowing.Controls.Add(this.lbl_TTNameShowing);
            this.pnlUserShowing.Controls.Add(this.lblFormNameShow);
            this.pnlUserShowing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserShowing.Location = new System.Drawing.Point(0, 40);
            this.pnlUserShowing.Name = "pnlUserShowing";
            this.pnlUserShowing.Size = new System.Drawing.Size(735, 25);
            this.pnlUserShowing.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(196, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Active Form :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Active File :";
            // 
            // lbl_TTNameShowing
            // 
            this.lbl_TTNameShowing.AutoSize = true;
            this.lbl_TTNameShowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.lbl_TTNameShowing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TTNameShowing.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TTNameShowing.Location = new System.Drawing.Point(287, 4);
            this.lbl_TTNameShowing.Name = "lbl_TTNameShowing";
            this.lbl_TTNameShowing.Size = new System.Drawing.Size(2, 17);
            this.lbl_TTNameShowing.TabIndex = 1;
            this.lbl_TTNameShowing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFormNameShow
            // 
            this.lblFormNameShow.AutoSize = true;
            this.lblFormNameShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.lblFormNameShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormNameShow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFormNameShow.Location = new System.Drawing.Point(90, 4);
            this.lblFormNameShow.Name = "lblFormNameShow";
            this.lblFormNameShow.Size = new System.Drawing.Size(2, 17);
            this.lblFormNameShow.TabIndex = 0;
            this.lblFormNameShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSystemName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSystemName.Location = new System.Drawing.Point(6, 11);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(685, 21);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "TELEGRAPHIC TRANSFER ORDER MANAGEMENT SYSTEM | Ceylon Petroleum Corporation";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.panellogo.Controls.Add(this.pbLOGO);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellogo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(65, 65);
            this.panellogo.TabIndex = 0;
            // 
            // pbLOGO
            // 
            this.pbLOGO.Image = ((System.Drawing.Image)(resources.GetObject("pbLOGO.Image")));
            this.pbLOGO.Location = new System.Drawing.Point(5, 8);
            this.pbLOGO.Name = "pbLOGO";
            this.pbLOGO.Padding = new System.Windows.Forms.Padding(5);
            this.pbLOGO.Size = new System.Drawing.Size(55, 50);
            this.pbLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLOGO.TabIndex = 0;
            this.pbLOGO.TabStop = false;
            // 
            // FormMAIN
            // 

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(panelmain);
            Name = "FormMAIN";
            Text = "HOME";
            Load += FormMAIN_Load;
            panelmain.ResumeLayout(false);
            panelbody.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            panelheader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlUserShowing.ResumeLayout(false);
            pnlUserShowing.PerformLayout();
            panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLOGO).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panelmain;
        private Panel panelheader;
        private Panel panellogo;
        private Panel panel1;
        private Label lblSystemName;
        private Panel pnlButtons;
        private Panel panelbody;
        private Panel pnllLoadSpace;
        private FontAwesome.Sharp.IconButton btnNewRecord;
        private PictureBox pbLOGO;
        private Panel pnlUserShowing;
        private FontAwesome.Sharp.IconButton btnConfirmRecord;
        private FontAwesome.Sharp.IconButton btnDataBaseUser;
        private Label lblFormNameShow;
        private Label lbl_TTNameShowing;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btn_Logout;
        private FontAwesome.Sharp.IconButton btn_DatabaseSender;
        private FontAwesome.Sharp.IconButton btnDatabaseBenificiary;
    }
}