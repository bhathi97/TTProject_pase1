namespace projectTelegraphicTransfer
{
    partial class UCTTItems
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblFormName = new Label();
            btn_editForms = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(48, 50);
            panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(1, 12, 71);
            iconPictureBox1.ForeColor = SystemColors.Window;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileText;
            iconPictureBox1.IconColor = SystemColors.Window;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(9, 14);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 28);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // lblFormName
            // 
            lblFormName.AutoSize = true;
            lblFormName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormName.ForeColor = SystemColors.ButtonHighlight;
            lblFormName.Location = new Point(46, 14);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(57, 21);
            lblFormName.TabIndex = 1;
            lblFormName.Text = "label1";
            // 
            // btn_editForms
            // 
            btn_editForms.BackColor = Color.FromArgb(194, 194, 239);
            btn_editForms.BackgroundImageLayout = ImageLayout.Center;
            btn_editForms.Cursor = Cursors.Hand;
            btn_editForms.Dock = DockStyle.Fill;
            btn_editForms.FlatAppearance.BorderColor = Color.FromArgb(102, 102, 255);
            btn_editForms.FlatAppearance.BorderSize = 0;
            btn_editForms.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btn_editForms.FlatAppearance.MouseOverBackColor = SystemColors.ControlLightLight;
            btn_editForms.FlatStyle = FlatStyle.Flat;
            btn_editForms.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editForms.ForeColor = Color.Coral;
            btn_editForms.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            btn_editForms.IconColor = Color.FromArgb(0, 0, 26);
            btn_editForms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_editForms.IconSize = 20;
            btn_editForms.Location = new Point(8, 8);
            btn_editForms.Name = "btn_editForms";
            btn_editForms.Size = new Size(33, 34);
            btn_editForms.TabIndex = 2;
            btn_editForms.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editForms.UseVisualStyleBackColor = false;
            btn_editForms.Click += btn_editForms_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(1, 12, 71);
            panel2.Controls.Add(btn_editForms);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(161, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8);
            panel2.Size = new Size(49, 50);
            panel2.TabIndex = 5;
            // 
            // UCTTItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 12, 71);
            Controls.Add(panel2);
            Controls.Add(lblFormName);
            Controls.Add(panel1);
            Name = "UCTTItems";
            Size = new Size(210, 50);
            Load += UCTTItems_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblFormName;
        private FontAwesome.Sharp.IconButton btn_editForms;
        private Panel panel2;
    }
}
