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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            tb_userName = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            tb_password = new TextBox();
            chb_showPassword = new CheckBox();
            btn_login = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "USER NAME :";
            // 
            // tb_userName
            // 
            tb_userName.Location = new Point(123, 3);
            tb_userName.Name = "tb_userName";
            tb_userName.Size = new Size(310, 23);
            tb_userName.TabIndex = 1;
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
            tableLayoutPanel1.Location = new Point(70, 151);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(436, 60);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD :";
            // 
            // tb_password
            // 
            tb_password.Location = new Point(123, 33);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(310, 23);
            tb_password.TabIndex = 3;
            // 
            // chb_showPassword
            // 
            chb_showPassword.AutoSize = true;
            chb_showPassword.BackColor = Color.FromArgb(11, 12, 71);
            chb_showPassword.ForeColor = SystemColors.ButtonHighlight;
            chb_showPassword.Location = new Point(70, 217);
            chb_showPassword.Name = "chb_showPassword";
            chb_showPassword.Size = new Size(108, 19);
            chb_showPassword.TabIndex = 3;
            chb_showPassword.Text = "Show Password";
            chb_showPassword.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            btn_login.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_login.IconColor = Color.Black;
            btn_login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_login.Location = new Point(340, 217);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(166, 23);
            btn_login.TabIndex = 4;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
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
            panel1.BackColor = Color.FromArgb(11, 12, 71);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(59, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 143);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 424);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(193, 400);
            label5.Name = "label5";
            label5.Size = new Size(172, 15);
            label5.TabIndex = 7;
            label5.Text = "Ceylon Petroleum Corporation ";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 424);
            Controls.Add(label5);
            Controls.Add(btn_login);
            Controls.Add(chb_showPassword);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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