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
            btn_formsControl = new FontAwesome.Sharp.IconButton();
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
            panelmain.BackColor = SystemColors.Menu;
            panelmain.Controls.Add(panelbody);
            panelmain.Controls.Add(panelheader);
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(0, 0);
            panelmain.Margin = new Padding(3, 4, 3, 4);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(914, 733);
            panelmain.TabIndex = 0;
            // 
            // panelbody
            // 
            panelbody.Controls.Add(pnllLoadSpace);
            panelbody.Controls.Add(pnlButtons);
            panelbody.Dock = DockStyle.Fill;
            panelbody.Location = new Point(0, 87);
            panelbody.Margin = new Padding(3, 4, 3, 4);
            panelbody.Name = "panelbody";
            panelbody.Size = new Size(914, 646);
            panelbody.TabIndex = 2;
            // 
            // pnllLoadSpace
            // 
            pnllLoadSpace.Cursor = Cursors.Hand;
            pnllLoadSpace.Dock = DockStyle.Fill;
            pnllLoadSpace.Location = new Point(74, 0);
            pnllLoadSpace.Margin = new Padding(3, 4, 3, 4);
            pnllLoadSpace.Name = "pnllLoadSpace";
            pnllLoadSpace.Size = new Size(840, 646);
            pnllLoadSpace.TabIndex = 2;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(1, 12, 71);
            pnlButtons.Controls.Add(btn_formsControl);
            pnlButtons.Controls.Add(btn_Logout);
            pnlButtons.Controls.Add(btn_DatabaseSender);
            pnlButtons.Controls.Add(btnDatabaseBenificiary);
            pnlButtons.Controls.Add(btnDataBaseUser);
            pnlButtons.Controls.Add(btnConfirmRecord);
            pnlButtons.Controls.Add(btnNewRecord);
            pnlButtons.Dock = DockStyle.Left;
            pnlButtons.ForeColor = Color.White;
            pnlButtons.Location = new Point(0, 0);
            pnlButtons.Margin = new Padding(3, 4, 3, 4);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(74, 646);
            pnlButtons.TabIndex = 1;
            // 
            // btn_formsControl
            // 
            btn_formsControl.Cursor = Cursors.Hand;
            btn_formsControl.FlatAppearance.BorderSize = 0;
            btn_formsControl.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btn_formsControl.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btn_formsControl.FlatStyle = FlatStyle.Flat;
            btn_formsControl.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            btn_formsControl.IconColor = Color.White;
            btn_formsControl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_formsControl.IconSize = 30;
            btn_formsControl.Location = new Point(0, 459);
            btn_formsControl.Margin = new Padding(3, 4, 3, 4);
            btn_formsControl.Name = "btn_formsControl";
            btn_formsControl.Size = new Size(74, 87);
            btn_formsControl.TabIndex = 6;
            btn_formsControl.UseVisualStyleBackColor = true;
            btn_formsControl.Click += btn_formsControl_Click;
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
            btn_Logout.Location = new Point(0, 553);
            btn_Logout.Margin = new Padding(3, 4, 3, 4);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(74, 87);
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
            btn_DatabaseSender.Location = new Point(0, 369);
            btn_DatabaseSender.Margin = new Padding(3, 4, 3, 4);
            btn_DatabaseSender.Name = "btn_DatabaseSender";
            btn_DatabaseSender.Size = new Size(74, 87);
            btn_DatabaseSender.TabIndex = 4;
            btn_DatabaseSender.UseVisualStyleBackColor = true;
            btn_DatabaseSender.Click += btnDataBase_Click;
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
            btnDatabaseBenificiary.Location = new Point(0, 277);
            btnDatabaseBenificiary.Margin = new Padding(3, 4, 3, 4);
            btnDatabaseBenificiary.Name = "btnDatabaseBenificiary";
            btnDatabaseBenificiary.Size = new Size(74, 87);
            btnDatabaseBenificiary.TabIndex = 3;
            btnDatabaseBenificiary.UseVisualStyleBackColor = true;
            btnDatabaseBenificiary.Click += btnDatabaseBenificiary_Click;
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
            btnDataBaseUser.Location = new Point(0, 183);
            btnDataBaseUser.Margin = new Padding(3, 4, 3, 4);
            btnDataBaseUser.Name = "btnDataBaseUser";
            btnDataBaseUser.Size = new Size(74, 87);
            btnDataBaseUser.TabIndex = 2;
            btnDataBaseUser.UseVisualStyleBackColor = true;
            btnDataBaseUser.Click += btn_DatabaseSender_Click;
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
            btnConfirmRecord.Location = new Point(0, 92);
            btnConfirmRecord.Margin = new Padding(3, 4, 3, 4);
            btnConfirmRecord.Name = "btnConfirmRecord";
            btnConfirmRecord.Size = new Size(74, 87);
            btnConfirmRecord.TabIndex = 1;
            btnConfirmRecord.UseVisualStyleBackColor = true;
            btnConfirmRecord.Click += btnConfirmRecord_Click;
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
            btnNewRecord.Margin = new Padding(3, 4, 3, 4);
            btnNewRecord.Name = "btnNewRecord";
            btnNewRecord.Size = new Size(74, 87);
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
            panelheader.Margin = new Padding(3, 4, 3, 4);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(914, 87);
            panelheader.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 12, 71);
            panel1.Controls.Add(pnlUserShowing);
            panel1.Controls.Add(lblSystemName);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(74, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 87);
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
            pnlUserShowing.Location = new Point(0, 54);
            pnlUserShowing.Margin = new Padding(3, 4, 3, 4);
            pnlUserShowing.Name = "pnlUserShowing";
            pnlUserShowing.Size = new Size(840, 33);
            pnlUserShowing.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_User);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(611, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 33);
            panel2.TabIndex = 5;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.BackColor = Color.FromArgb(194, 194, 239);
            lbl_User.BorderStyle = BorderStyle.FixedSingle;
            lbl_User.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_User.Location = new Point(17, 5);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(40, 22);
            lbl_User.TabIndex = 4;
            lbl_User.Text = "user";
            lbl_User.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(224, 4);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 3;
            label2.Text = "Active Form :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(8, 4);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "Active File :";
            // 
            // lbl_TTNameShowing
            // 
            lbl_TTNameShowing.AutoSize = true;
            lbl_TTNameShowing.BackColor = Color.FromArgb(194, 194, 239);
            lbl_TTNameShowing.BorderStyle = BorderStyle.FixedSingle;
            lbl_TTNameShowing.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TTNameShowing.Location = new Point(328, 5);
            lbl_TTNameShowing.Name = "lbl_TTNameShowing";
            lbl_TTNameShowing.Size = new Size(2, 22);
            lbl_TTNameShowing.TabIndex = 1;
            lbl_TTNameShowing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFormNameShow
            // 
            lblFormNameShow.AutoSize = true;
            lblFormNameShow.BackColor = Color.FromArgb(194, 194, 239);
            lblFormNameShow.BorderStyle = BorderStyle.FixedSingle;
            lblFormNameShow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormNameShow.Location = new Point(103, 5);
            lblFormNameShow.Name = "lblFormNameShow";
            lblFormNameShow.Size = new Size(2, 22);
            lblFormNameShow.TabIndex = 0;
            lblFormNameShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSystemName.ForeColor = SystemColors.Window;
            lblSystemName.Location = new Point(7, 15);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(860, 28);
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
            panellogo.Margin = new Padding(3, 4, 3, 4);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(74, 87);
            panellogo.TabIndex = 0;
            // 
            // pbLOGO
            // 
            pbLOGO.Image = (Image)resources.GetObject("pbLOGO.Image");
            pbLOGO.Location = new Point(6, 11);
            pbLOGO.Margin = new Padding(3, 4, 3, 4);
            pbLOGO.Name = "pbLOGO";
            pbLOGO.Padding = new Padding(6, 7, 6, 7);
            pbLOGO.Size = new Size(63, 67);
            pbLOGO.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLOGO.TabIndex = 0;
            pbLOGO.TabStop = false;
            // 
            // FormMAIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 733);
            Controls.Add(panelmain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMAIN";
            Text = "HOME";
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
        private FontAwesome.Sharp.IconButton btn_formsControl;
    }
}