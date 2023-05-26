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
            pnlHead = new Panel();
            btn_CreateNewFORM = new FontAwesome.Sharp.IconButton();
            lblFolderName = new Label();
            pnlBody = new Panel();
            flp_ItemViewver = new FlowLayoutPanel();
            pnlHead.SuspendLayout();
            pnlBody.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHead
            // 
            pnlHead.BackColor = SystemColors.Control;
            pnlHead.Controls.Add(btn_CreateNewFORM);
            pnlHead.Controls.Add(lblFolderName);
            pnlHead.Dock = DockStyle.Top;
            pnlHead.Location = new Point(0, 0);
            pnlHead.Name = "pnlHead";
            pnlHead.Padding = new Padding(10);
            pnlHead.Size = new Size(222, 129);
            pnlHead.TabIndex = 0;
            // 
            // btn_CreateNewFORM
            // 
            btn_CreateNewFORM.BackColor = Color.FromArgb(76, 175, 80);
            btn_CreateNewFORM.Dock = DockStyle.Bottom;
            btn_CreateNewFORM.FlatAppearance.BorderSize = 0;
            btn_CreateNewFORM.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btn_CreateNewFORM.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btn_CreateNewFORM.FlatStyle = FlatStyle.Flat;
            btn_CreateNewFORM.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CreateNewFORM.ForeColor = Color.White;
            btn_CreateNewFORM.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btn_CreateNewFORM.IconColor = Color.White;
            btn_CreateNewFORM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CreateNewFORM.IconSize = 25;
            btn_CreateNewFORM.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CreateNewFORM.Location = new Point(10, 82);
            btn_CreateNewFORM.Name = "btn_CreateNewFORM";
            btn_CreateNewFORM.Size = new Size(202, 37);
            btn_CreateNewFORM.TabIndex = 2;
            btn_CreateNewFORM.Text = "New Form";
            btn_CreateNewFORM.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CreateNewFORM.UseVisualStyleBackColor = false;
            // 
            // lblFolderName
            // 
            lblFolderName.AutoSize = true;
            lblFolderName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFolderName.ForeColor = SystemColors.ActiveCaptionText;
            lblFolderName.Location = new Point(8, 62);
            lblFolderName.Name = "lblFolderName";
            lblFolderName.Size = new Size(42, 17);
            lblFolderName.TabIndex = 0;
            lblFolderName.Text = "name";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = SystemColors.Control;
            pnlBody.Controls.Add(flp_ItemViewver);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 129);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(5);
            pnlBody.Size = new Size(222, 341);
            pnlBody.TabIndex = 1;
            // 
            // flp_ItemViewver
            // 
            flp_ItemViewver.AutoScroll = true;
            flp_ItemViewver.BackColor = SystemColors.Control;
            flp_ItemViewver.Dock = DockStyle.Fill;
            flp_ItemViewver.Location = new Point(5, 5);
            flp_ItemViewver.Name = "flp_ItemViewver";
            flp_ItemViewver.Size = new Size(212, 331);
            flp_ItemViewver.TabIndex = 0;
            // 
            // UCTTsHandeling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(pnlBody);
            Controls.Add(pnlHead);
            Name = "UCTTsHandeling";
            Size = new Size(222, 470);
            Load += UCTTsHandeling_Load;
            pnlHead.ResumeLayout(false);
            pnlHead.PerformLayout();
            pnlBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHead;
        private Panel pnlBody;
        private Label lblFolderName;
        private FontAwesome.Sharp.IconButton btn_CreateNewFORM;
        private FlowLayoutPanel flp_ItemViewver;
    }
}
