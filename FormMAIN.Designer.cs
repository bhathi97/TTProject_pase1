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

            // 
            // panelmain
            // 
            panelmain.BackColor = SystemColors.Menu;
            panelmain.Controls.Add(panelbody);
            panelmain.Controls.Add(panelheader);
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(0, 0);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(800, 550);
            panelmain.TabIndex = 0;
            // 
            // panelbody
            // 
            panelbody.Controls.Add(pnllLoadSpace);
            panelbody.Controls.Add(pnlButtons);
            panelbody.Dock = DockStyle.Fill;
            panelbody.Location = new Point(0, 65);
            panelbody.Name = "panelbody";
            panelbody.Size = new Size(800, 485);
            panelbody.TabIndex = 2;
            // 
            // pnllLoadSpace
            // 
            pnllLoadSpace.Cursor = Cursors.Hand;
            pnllLoadSpace.Dock = DockStyle.Fill;
            pnllLoadSpace.Location = new Point(65, 0);
            pnllLoadSpace.Name = "pnllLoadSpace";
            pnllLoadSpace.Size = new Size(735, 485);
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
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(65, 485);
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
            btn_formsControl.Location = new Point(0, 344);
            btn_formsControl.Name = "btn_formsControl";
            btn_formsControl.Size = new Size(65, 65);
            btn_formsControl.TabIndex = 6;
            btn_formsControl.UseVisualStyleBackColor = true;
            btn_formsControl.Click += btn_formsControl_Click;
            // 
            // btn_formsControl
            // 
            this.btn_formsControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_formsControl.FlatAppearance.BorderSize = 0;
            this.btn_formsControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_formsControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btn_formsControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_formsControl.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            this.btn_formsControl.IconColor = System.Drawing.Color.White;
            this.btn_formsControl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_formsControl.IconSize = 30;
            this.btn_formsControl.Location = new System.Drawing.Point(0, 344);
            this.btn_formsControl.Name = "btn_formsControl";
            this.btn_formsControl.Size = new System.Drawing.Size(65, 65);
            this.btn_formsControl.TabIndex = 6;
            this.btn_formsControl.UseVisualStyleBackColor = true;
            this.btn_formsControl.Click += new System.EventHandler(this.btn_formsControl_Click);
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
            btn_Logout.Location = new Point(0, 415);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(65, 65);
            btn_Logout.TabIndex = 5;
            btn_Logout.UseVisualStyleBackColor = true;
            // 
            // btn_DatabaseSender
            // 

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