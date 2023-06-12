namespace project_TelegraphicTransfer
{
    partial class UCItemsToConfirm
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
            panel1 = new Panel();
            panel3 = new Panel();
            btn_preview = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_date = new Label();
            lbl_editor = new Label();
            lbl_purpose = new Label();
            lbl_date1 = new Label();
            lbl_showFileName1 = new Label();
            lbl_purpose1 = new Label();
            lbl_editor1 = new Label();
            lbl_showFileName = new Label();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 138);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(11, 12, 71);
            panel3.Controls.Add(btn_preview);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(82, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(952, 138);
            panel3.TabIndex = 1;
            // 
            // btn_preview
            // 
            btn_preview.BackColor = Color.FromArgb(76, 175, 80);
            btn_preview.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btn_preview.FlatAppearance.BorderSize = 0;
            btn_preview.FlatAppearance.MouseDownBackColor = Color.Lime;
            btn_preview.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btn_preview.FlatStyle = FlatStyle.Flat;
            btn_preview.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_preview.ForeColor = Color.White;
            btn_preview.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_preview.IconColor = Color.White;
            btn_preview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_preview.IconSize = 25;
            btn_preview.Location = new Point(819, 19);
            btn_preview.Name = "btn_preview";
            btn_preview.Size = new Size(110, 100);
            btn_preview.TabIndex = 2;
            btn_preview.Text = "CONFIRM";
            btn_preview.UseVisualStyleBackColor = false;
            btn_preview.Click += btn_preview_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2992325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.70077F));
            tableLayoutPanel1.Controls.Add(lbl_date, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl_editor, 1, 2);
            tableLayoutPanel1.Controls.Add(lbl_purpose, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl_date1, 0, 3);
            tableLayoutPanel1.Controls.Add(lbl_showFileName1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_purpose1, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_editor1, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_showFileName, 1, 0);
            tableLayoutPanel1.Location = new Point(17, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(782, 123);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_date.ForeColor = SystemColors.ButtonHighlight;
            lbl_date.Location = new Point(107, 90);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(52, 21);
            lbl_date.TabIndex = 7;
            lbl_date.Text = "label1";
            // 
            // lbl_editor
            // 
            lbl_editor.AutoSize = true;
            lbl_editor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_editor.ForeColor = SystemColors.ButtonHighlight;
            lbl_editor.Location = new Point(107, 60);
            lbl_editor.Name = "lbl_editor";
            lbl_editor.Size = new Size(52, 21);
            lbl_editor.TabIndex = 6;
            lbl_editor.Text = "label1";
            // 
            // lbl_purpose
            // 
            lbl_purpose.AutoSize = true;
            lbl_purpose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_purpose.ForeColor = SystemColors.ButtonHighlight;
            lbl_purpose.Location = new Point(107, 30);
            lbl_purpose.Name = "lbl_purpose";
            lbl_purpose.Size = new Size(52, 21);
            lbl_purpose.TabIndex = 5;
            lbl_purpose.Text = "label1";
            // 
            // lbl_date1
            // 
            lbl_date1.AutoSize = true;
            lbl_date1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_date1.ForeColor = SystemColors.ControlLightLight;
            lbl_date1.Location = new Point(3, 90);
            lbl_date1.Name = "lbl_date1";
            lbl_date1.Size = new Size(56, 21);
            lbl_date1.TabIndex = 3;
            lbl_date1.Text = "DATE :";
            // 
            // lbl_showFileName1
            // 
            lbl_showFileName1.AutoSize = true;
            lbl_showFileName1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_showFileName1.ForeColor = SystemColors.ControlLightLight;
            lbl_showFileName1.Location = new Point(3, 0);
            lbl_showFileName1.Name = "lbl_showFileName1";
            lbl_showFileName1.Size = new Size(97, 21);
            lbl_showFileName1.TabIndex = 0;
            lbl_showFileName1.Text = "FILE NAME :";
            // 
            // lbl_purpose1
            // 
            lbl_purpose1.AutoSize = true;
            lbl_purpose1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_purpose1.ForeColor = SystemColors.ControlLightLight;
            lbl_purpose1.Location = new Point(3, 30);
            lbl_purpose1.Name = "lbl_purpose1";
            lbl_purpose1.Size = new Size(86, 21);
            lbl_purpose1.TabIndex = 1;
            lbl_purpose1.Text = "PURPOSE :";
            // 
            // lbl_editor1
            // 
            lbl_editor1.AutoSize = true;
            lbl_editor1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_editor1.ForeColor = SystemColors.ControlLightLight;
            lbl_editor1.Location = new Point(3, 60);
            lbl_editor1.Name = "lbl_editor1";
            lbl_editor1.Size = new Size(94, 21);
            lbl_editor1.TabIndex = 2;
            lbl_editor1.Text = "INSERT BY :";
            // 
            // lbl_showFileName
            // 
            lbl_showFileName.AutoSize = true;
            lbl_showFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_showFileName.ForeColor = SystemColors.ButtonHighlight;
            lbl_showFileName.Location = new Point(107, 0);
            lbl_showFileName.Name = "lbl_showFileName";
            lbl_showFileName.Size = new Size(52, 21);
            lbl_showFileName.TabIndex = 4;
            lbl_showFileName.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 12, 71);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(82, 138);
            panel2.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.FromArgb(11, 12, 71);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 35;
            iconPictureBox1.Location = new Point(26, 54);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(35, 51);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // UCItemsToConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCItemsToConfirm";
            Size = new Size(1034, 138);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_showFileName1;
        private Label lbl_purpose1;
        private Label lbl_editor1;
        private Label lbl_date1;
        private Label lbl_date;
        private Label lbl_editor;
        private Label lbl_purpose;
        private Label lbl_showFileName;
        private FontAwesome.Sharp.IconButton btn_preview;
    }
}
