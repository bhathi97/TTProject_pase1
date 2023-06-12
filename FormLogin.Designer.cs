namespace project_TelegraphicTransfer
{
    partial class FormLogin
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
            label1 = new Label();
            tb_userName = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tb_password = new TextBox();
            label2 = new Label();
            chb_showPassword = new CheckBox();
            btn_login = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "USER NAME :";
            // 
            // tb_userName
            // 
            tb_userName.Location = new Point(136, 3);
            tb_userName.Name = "tb_userName";
            tb_userName.Size = new Size(345, 23);
            tb_userName.TabIndex = 1;
            tb_userName.KeyPress += tb_userName_KeyPress;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(11, 12, 71);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5229359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.477066F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tb_password, 1, 1);
            tableLayoutPanel1.Controls.Add(tb_userName, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(9, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(484, 60);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(136, 33);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(345, 23);
            tb_password.TabIndex = 3;
            tb_password.KeyPress += tb_password_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD :";
            // 
            // chb_showPassword
            // 
            chb_showPassword.AutoSize = true;
            chb_showPassword.BackColor = Color.FromArgb(11, 12, 71);
            chb_showPassword.ForeColor = SystemColors.ButtonHighlight;
            chb_showPassword.Location = new Point(145, 110);
            chb_showPassword.Name = "chb_showPassword";
            chb_showPassword.Size = new Size(108, 19);
            chb_showPassword.TabIndex = 3;
            chb_showPassword.Text = "Show Password";
            chb_showPassword.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(76, 175, 80);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btn_login.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_login.IconColor = Color.Black;
            btn_login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_login.Location = new Point(145, 156);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(239, 36);
            btn_login.TabIndex = 4;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.1165047F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.88349F));
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 45);
            label3.Name = "label3";
            label3.Size = new Size(34, 45);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(35, 45);
            label4.TabIndex = 0;
            label4.Text = "USER NAME :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(11, 12, 71);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(chb_showPassword);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(31, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 232);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(11, 12, 71);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(504, 18);
            label5.TabIndex = 7;
            label5.Text = "TELEGRAPHIC TRANSFER ORDER MANAGEMENT SYSTEM | Ceylon Petroleum Corporation";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 424);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tb_userName;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox tb_password;
        private CheckBox chb_showPassword;
        private FontAwesome.Sharp.IconButton btn_login;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
    }
}