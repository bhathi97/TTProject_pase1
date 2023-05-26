namespace project_TelegraphicTransfer
{
    partial class UCItems1
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
            lblFileNameShowing = new Label();
            btn_editTTs = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblFileNameShowing
            // 
            lblFileNameShowing.AutoSize = true;
            lblFileNameShowing.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFileNameShowing.ForeColor = SystemColors.Window;
            lblFileNameShowing.Location = new Point(2, 13);
            lblFileNameShowing.Name = "lblFileNameShowing";
            lblFileNameShowing.Size = new Size(130, 21);
            lblFileNameShowing.TabIndex = 1;
            lblFileNameShowing.Text = "oooooooooooo";
            // 
            // btn_editTTs
            // 
            btn_editTTs.BackColor = Color.FromArgb(194, 194, 239);
            btn_editTTs.BackgroundImageLayout = ImageLayout.Center;
            btn_editTTs.Cursor = Cursors.Hand;
            btn_editTTs.Dock = DockStyle.Fill;
            btn_editTTs.FlatAppearance.BorderColor = Color.FromArgb(102, 102, 255);
            btn_editTTs.FlatAppearance.BorderSize = 0;
            btn_editTTs.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btn_editTTs.FlatAppearance.MouseOverBackColor = SystemColors.ControlLightLight;
            btn_editTTs.FlatStyle = FlatStyle.Flat;
            btn_editTTs.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editTTs.ForeColor = Color.Coral;
            btn_editTTs.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            btn_editTTs.IconColor = Color.FromArgb(0, 0, 26);
            btn_editTTs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_editTTs.IconSize = 20;
            btn_editTTs.Location = new Point(8, 8);
            btn_editTTs.Name = "btn_editTTs";
            btn_editTTs.Size = new Size(34, 34);
            btn_editTTs.TabIndex = 2;
            btn_editTTs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editTTs.UseVisualStyleBackColor = false;
            btn_editTTs.Click += btn_editTTs_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 12, 71);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(46, 50);
            panel1.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(1, 12, 71);
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(6, 9);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(1, 12, 71);
            panel2.Controls.Add(btn_editTTs);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(160, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8);
            panel2.Size = new Size(50, 50);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(1, 12, 71);
            panel3.Controls.Add(lblFileNameShowing);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(46, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(114, 50);
            panel3.TabIndex = 5;
            // 
            // UCItems1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCItems1";
            Size = new Size(210, 50);
            Load += UCItems1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblFileNameShowing;
        private FontAwesome.Sharp.IconButton btn_editTTs;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
