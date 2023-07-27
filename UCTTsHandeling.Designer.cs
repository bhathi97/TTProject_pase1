namespace project_TelegraphicTransfer
{
    partial class UCTTsHandeling
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
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btn_CreateNewFORM = new FontAwesome.Sharp.IconButton();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.flp_ItemViewver = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHead.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHead.Controls.Add(this.btn_CreateNewFORM);
            this.pnlHead.Controls.Add(this.lblFolderName);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.pnlHead.Size = new System.Drawing.Size(222, 105);
            this.pnlHead.TabIndex = 0;
            // 
            // btn_CreateNewFORM
            // 
            this.btn_CreateNewFORM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_CreateNewFORM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CreateNewFORM.FlatAppearance.BorderSize = 0;
            this.btn_CreateNewFORM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_CreateNewFORM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_CreateNewFORM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateNewFORM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateNewFORM.ForeColor = System.Drawing.Color.White;
            this.btn_CreateNewFORM.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_CreateNewFORM.IconColor = System.Drawing.Color.White;
            this.btn_CreateNewFORM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CreateNewFORM.IconSize = 25;
            this.btn_CreateNewFORM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateNewFORM.Location = new System.Drawing.Point(10, 63);
            this.btn_CreateNewFORM.Name = "btn_CreateNewFORM";
            this.btn_CreateNewFORM.Size = new System.Drawing.Size(202, 37);
            this.btn_CreateNewFORM.TabIndex = 2;
            this.btn_CreateNewFORM.Text = "New Form";
            this.btn_CreateNewFORM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CreateNewFORM.UseVisualStyleBackColor = false;
            this.btn_CreateNewFORM.Click += new System.EventHandler(this.btn_CreateNewFORM_Click);
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFolderName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFolderName.Location = new System.Drawing.Point(10, 38);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(43, 17);
            this.lblFolderName.TabIndex = 0;
            this.lblFolderName.Text = "name";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.flp_ItemViewver);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 105);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBody.Size = new System.Drawing.Size(222, 365);
            this.pnlBody.TabIndex = 1;
            // 
            // flp_ItemViewver
            // 
            this.flp_ItemViewver.AutoScroll = true;
            this.flp_ItemViewver.BackColor = System.Drawing.SystemColors.Control;
            this.flp_ItemViewver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_ItemViewver.Location = new System.Drawing.Point(5, 5);
            this.flp_ItemViewver.Name = "flp_ItemViewver";
            this.flp_ItemViewver.Size = new System.Drawing.Size(212, 355);
            this.flp_ItemViewver.TabIndex = 0;
            this.flp_ItemViewver.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_ItemViewver_Paint);
            // 
            // UCTTsHandeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHead);
            this.Name = "UCTTsHandeling";
            this.Size = new System.Drawing.Size(222, 470);
            this.Load += new System.EventHandler(this.UCTTsHandeling_Load);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHead;
        private Panel pnlBody;
        private Label lblFolderName;
        private FontAwesome.Sharp.IconButton btn_CreateNewFORM;
        private FlowLayoutPanel flp_ItemViewver;
    }
}
