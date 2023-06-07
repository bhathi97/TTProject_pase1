namespace project_TelegraphicTransfer
{
    partial class UCDatabaseHandeling
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel5 = new Panel();
            dgvUser = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            PW = new DataGridViewTextBoxColumn();
            UL = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel4 = new Panel();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            UserAdd = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbName = new TextBox();
            tbPW = new TextBox();
            cbUL = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Cursor = Cursors.Hand;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1197, 572);
            panel2.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvUser);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(570, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(627, 572);
            panel5.TabIndex = 2;
            // 
            // dgvUser
            // 
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { id, name, PW, UL });
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.Location = new Point(10, 10);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 4;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(607, 552);
            dgvUser.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "NAME";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // PW
            // 
            PW.HeaderText = "PASSWORD";
            PW.Name = "PW";
            PW.ReadOnly = true;
            // 
            // UL
            // 
            UL.HeaderText = "USER LEVEL";
            UL.Name = "UL";
            UL.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(570, 572);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(UserAdd);
            panel4.Location = new Point(25, 155);
            panel4.Name = "panel4";
            panel4.Size = new Size(510, 49);
            panel4.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(11, 12, 71);
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnDelete.IconSize = 20;
            btnDelete.Location = new Point(357, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(153, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(11, 12, 71);
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnUpdate.IconColor = Color.White;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnUpdate.IconSize = 20;
            btnUpdate.Location = new Point(180, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(153, 42);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "  UPDATE";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // UserAdd
            // 
            UserAdd.BackColor = Color.FromArgb(11, 12, 71);
            UserAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserAdd.ForeColor = Color.White;
            UserAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            UserAdd.IconColor = Color.White;
            UserAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UserAdd.IconSize = 20;
            UserAdd.Location = new Point(0, 2);
            UserAdd.Name = "UserAdd";
            UserAdd.Size = new Size(153, 42);
            UserAdd.TabIndex = 0;
            UserAdd.Text = "  ADD";
            UserAdd.TextAlign = ContentAlignment.MiddleRight;
            UserAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            UserAdd.UseVisualStyleBackColor = false;
            UserAdd.Click += UserAdd_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.98608F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.01392F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(tbName, 1, 0);
            tableLayoutPanel1.Controls.Add(tbPW, 1, 1);
            tableLayoutPanel1.Controls.Add(cbUL, 1, 2);
            tableLayoutPanel1.Location = new Point(25, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(510, 122);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 0;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 1;
            label3.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 85);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 2;
            label4.Text = "USER LEVEL";
            // 
            // tbName
            // 
            tbName.Location = new Point(135, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(337, 23);
            tbName.TabIndex = 3;
            // 
            // tbPW
            // 
            tbPW.Location = new Point(135, 44);
            tbPW.Name = "tbPW";
            tbPW.Size = new Size(337, 23);
            tbPW.TabIndex = 4;
            // 
            // cbUL
            // 
            cbUL.FormattingEnabled = true;
            cbUL.Items.AddRange(new object[] { "Data Entry Operator", "Auditor", "Approver", "Editor" });
            cbUL.Location = new Point(135, 88);
            cbUL.Name = "cbUL";
            cbUL.Size = new Size(337, 23);
            cbUL.TabIndex = 5;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(11, 12, 71);
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(510, 21);
            label1.TabIndex = 0;
            label1.Text = "HANDLING USER";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 40);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(580, 13);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 1;
            label5.Text = "Data Table";
            // 
            // UCDatabaseHandeling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCDatabaseHandeling";
            Size = new Size(1197, 612);
            Load += UCDatabaseHandeling_Load;
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton UserAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbName;
        private TextBox tbPW;
        private ComboBox cbUL;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private DataGridView dgvUser;
        private Label label1;
        private Panel panel1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn PW;
        private DataGridViewTextBoxColumn UL;
        private Panel panel5;
        private Label label5;
    }
}
