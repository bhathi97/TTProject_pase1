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
            panel2 = new Panel();
            lbl_User = new Label();
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
            panel2.SuspendLayout();
            panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLOGO).BeginInit();
            SuspendLayout();

            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.SystemColors.Menu;
            this.panelmain.Controls.Add(this.panelbody);
            this.panelmain.Controls.Add(this.panelheader);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(800, 487);
            this.panelmain.TabIndex = 0;
            // 
            // panelbody
            // 
            this.panelbody.Controls.Add(this.pnllLoadSpace);
            this.panelbody.Controls.Add(this.pnlButtons);
            this.panelbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbody.Location = new System.Drawing.Point(0, 65);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(800, 422);
            this.panelbody.TabIndex = 2;
            // 
            // pnllLoadSpace
            // 
            this.pnllLoadSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnllLoadSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnllLoadSpace.Location = new System.Drawing.Point(65, 0);
            this.pnllLoadSpace.Name = "pnllLoadSpace";
            this.pnllLoadSpace.Size = new System.Drawing.Size(735, 422);
            this.pnllLoadSpace.TabIndex = 2;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.pnlButtons.Controls.Add(this.btn_Logout);
            this.pnlButtons.Controls.Add(this.btn_DatabaseSender);
            this.pnlButtons.Controls.Add(this.btnDatabaseBenificiary);
            this.pnlButtons.Controls.Add(this.btnDataBaseUser);
            this.pnlButtons.Controls.Add(this.btnConfirmRecord);
            this.pnlButtons.Controls.Add(this.btnNewRecord);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.ForeColor = System.Drawing.Color.White;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(65, 422);
            this.pnlButtons.TabIndex = 1;
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
            this.btn_DatabaseSender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DatabaseSender.FlatAppearance.BorderSize = 0;
            this.btn_DatabaseSender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_DatabaseSender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btn_DatabaseSender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DatabaseSender.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btn_DatabaseSender.IconColor = System.Drawing.Color.White;
            this.btn_DatabaseSender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DatabaseSender.IconSize = 30;
            this.btn_DatabaseSender.Location = new System.Drawing.Point(0, 277);
            this.btn_DatabaseSender.Name = "btn_DatabaseSender";
            this.btn_DatabaseSender.Size = new System.Drawing.Size(65, 65);
            this.btn_DatabaseSender.TabIndex = 4;
            this.btn_DatabaseSender.UseVisualStyleBackColor = true;
            this.btn_DatabaseSender.Click += new System.EventHandler(this.btn_DatabaseSender_Click);
            // 
            // btnDatabaseBenificiary
            // 
            this.btnDatabaseBenificiary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatabaseBenificiary.FlatAppearance.BorderSize = 0;
            this.btnDatabaseBenificiary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDatabaseBenificiary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnDatabaseBenificiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatabaseBenificiary.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            this.btnDatabaseBenificiary.IconColor = System.Drawing.Color.White;
            this.btnDatabaseBenificiary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatabaseBenificiary.IconSize = 37;
            this.btnDatabaseBenificiary.Location = new System.Drawing.Point(0, 208);
            this.btnDatabaseBenificiary.Name = "btnDatabaseBenificiary";
            this.btnDatabaseBenificiary.Size = new System.Drawing.Size(65, 65);
            this.btnDatabaseBenificiary.TabIndex = 3;
            this.btnDatabaseBenificiary.UseVisualStyleBackColor = true;
            this.btnDatabaseBenificiary.Click += new System.EventHandler(this.btnDatabaseBenificiary_Click);
            // 
            // btnDataBaseUser
            // 
            this.btnDataBaseUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataBaseUser.FlatAppearance.BorderSize = 0;
            this.btnDataBaseUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDataBaseUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnDataBaseUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataBaseUser.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btnDataBaseUser.IconColor = System.Drawing.Color.White;
            this.btnDataBaseUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDataBaseUser.IconSize = 35;
            this.btnDataBaseUser.Location = new System.Drawing.Point(0, 137);
            this.btnDataBaseUser.Name = "btnDataBaseUser";
            this.btnDataBaseUser.Size = new System.Drawing.Size(65, 65);
            this.btnDataBaseUser.TabIndex = 2;
            this.btnDataBaseUser.UseVisualStyleBackColor = true;
            this.btnDataBaseUser.Click += new System.EventHandler(this.btnDataBase_Click);
            // 
            // btnConfirmRecord
            // 
            btnConfirmRecord.Cursor = Cursors.Hand;
            btnConfirmRecord.FlatAppearance.BorderSize = 0;
            btnConfirmRecord.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnConfirmRecord.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnConfirmRecord.FlatStyle = FlatStyle.Flat;
            btnConfirmRecord.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnConfirmRecord.IconColor = Color.White;
            btnConfirmRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmRecord.IconSize = 35;
            btnConfirmRecord.Location = new Point(0, 69);
            btnConfirmRecord.Name = "btnConfirmRecord";
            btnConfirmRecord.Size = new Size(65, 65);
            btnConfirmRecord.TabIndex = 1;
            btnConfirmRecord.UseVisualStyleBackColor = true;
            // 
            // btnNewRecord
            // 
            btnNewRecord.Cursor = Cursors.Hand;
            btnNewRecord.FlatAppearance.BorderSize = 0;
            btnNewRecord.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnNewRecord.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnNewRecord.FlatStyle = FlatStyle.Flat;
            btnNewRecord.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnNewRecord.IconColor = Color.White;
            btnNewRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewRecord.IconSize = 28;
            btnNewRecord.Location = new Point(0, 0);
            btnNewRecord.Name = "btnNewRecord";
            btnNewRecord.Size = new Size(65, 65);
            btnNewRecord.TabIndex = 0;
            btnNewRecord.UseVisualStyleBackColor = true;
            btnNewRecord.Click += btnNewRecord_Click;
            // 
            // panelheader
            // 
            panelheader.BackColor = Color.White;
            panelheader.Controls.Add(panel1);
            panelheader.Controls.Add(panellogo);
            panelheader.Dock = DockStyle.Top;
            panelheader.Location = new Point(0, 0);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(800, 65);
            panelheader.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 12, 71);
            panel1.Controls.Add(pnlUserShowing);
            panel1.Controls.Add(lblSystemName);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(65, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 65);
            panel1.TabIndex = 1;
            // 
            // pnlUserShowing
            // 
            pnlUserShowing.BackColor = Color.FromArgb(194, 194, 239);
            pnlUserShowing.Controls.Add(panel2);
            pnlUserShowing.Controls.Add(label2);
            pnlUserShowing.Controls.Add(label1);
            pnlUserShowing.Controls.Add(lbl_TTNameShowing);
            pnlUserShowing.Controls.Add(lblFormNameShow);
            pnlUserShowing.Dock = DockStyle.Bottom;
            pnlUserShowing.Location = new Point(0, 40);
            pnlUserShowing.Name = "pnlUserShowing";
            pnlUserShowing.Size = new Size(735, 25);
            pnlUserShowing.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_User);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(535, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 25);
            panel2.TabIndex = 5;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.BackColor = Color.FromArgb(194, 194, 239);
            lbl_User.BorderStyle = BorderStyle.FixedSingle;
            lbl_User.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_User.Location = new Point(15, 4);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(31, 17);
            lbl_User.TabIndex = 4;
            lbl_User.Text = "user";
            lbl_User.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(196, 3);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 3;
            label2.Text = "Active Form :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(7, 3);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 2;
            label1.Text = "Active File :";
            // 
            // lbl_TTNameShowing
            // 
            lbl_TTNameShowing.AutoSize = true;
            lbl_TTNameShowing.BackColor = Color.FromArgb(194, 194, 239);
            lbl_TTNameShowing.BorderStyle = BorderStyle.FixedSingle;
            lbl_TTNameShowing.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TTNameShowing.Location = new Point(287, 4);
            lbl_TTNameShowing.Name = "lbl_TTNameShowing";
            lbl_TTNameShowing.Size = new Size(2, 17);
            lbl_TTNameShowing.TabIndex = 1;
            lbl_TTNameShowing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFormNameShow
            // 
            lblFormNameShow.AutoSize = true;
            lblFormNameShow.BackColor = Color.FromArgb(194, 194, 239);
            lblFormNameShow.BorderStyle = BorderStyle.FixedSingle;
            lblFormNameShow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormNameShow.Location = new Point(90, 4);
            lblFormNameShow.Name = "lblFormNameShow";
            lblFormNameShow.Size = new Size(2, 17);
            lblFormNameShow.TabIndex = 0;
            lblFormNameShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSystemName.ForeColor = SystemColors.Window;
            lblSystemName.Location = new Point(6, 11);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(685, 21);
            lblSystemName.TabIndex = 0;
            lblSystemName.Text = "TELEGRAPHIC TRANSFER ORDER MANAGEMENT SYSTEM | Ceylon Petroleum Corporation";
            lblSystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panellogo
            // 
            panellogo.BackColor = Color.FromArgb(1, 12, 71);
            panellogo.Controls.Add(pbLOGO);
            panellogo.Dock = DockStyle.Left;
            panellogo.ImeMode = ImeMode.Off;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(65, 65);
            panellogo.TabIndex = 0;
            // 
            // pbLOGO
            // 
            pbLOGO.Image = (Image)resources.GetObject("pbLOGO.Image");
            pbLOGO.Location = new Point(5, 8);
            pbLOGO.Name = "pbLOGO";
            pbLOGO.Padding = new Padding(5);
            pbLOGO.Size = new Size(55, 50);
            pbLOGO.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLOGO.TabIndex = 0;
            pbLOGO.TabStop = false;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Label lbl_User;
    }
}