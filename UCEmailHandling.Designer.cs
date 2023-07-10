namespace project_TelegraphicTransfer
{
    partial class UCEmailHandling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tBaddres = new System.Windows.Forms.TextBox();
            this.btnEAdd = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEmail = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(471, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "EMAIL HANDLING";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.34608F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.65392F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tBaddres, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.68421F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.31579F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(471, 90);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "EPF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "EMAIL";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(117, 3);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(317, 32);
            this.tbName.TabIndex = 16;
            // 
            // tBaddres
            // 
            this.tBaddres.Location = new System.Drawing.Point(117, 51);
            this.tBaddres.Multiline = true;
            this.tBaddres.Name = "tBaddres";
            this.tBaddres.Size = new System.Drawing.Size(317, 30);
            this.tBaddres.TabIndex = 17;
            // 
            // btnEAdd
            // 
            this.btnEAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.btnEAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEAdd.ForeColor = System.Drawing.Color.White;
            this.btnEAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnEAdd.IconColor = System.Drawing.Color.White;
            this.btnEAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEAdd.IconSize = 20;
            this.btnEAdd.Location = new System.Drawing.Point(17, 167);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(153, 42);
            this.btnEAdd.TabIndex = 0;
            this.btnEAdd.Text = "  ADD";
            this.btnEAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEAdd.UseVisualStyleBackColor = false;
            this.btnEAdd.Click += new System.EventHandler(this.btnEAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEAdd);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 569);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvEmail);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(531, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 569);
            this.panel2.TabIndex = 1;
            // 
            // dgvEmail
            // 
            this.dgvEmail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmail.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.email,
            this.epf,
            this.fid});
            this.dgvEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvEmail.Location = new System.Drawing.Point(0, 41);
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            this.dgvEmail.RowHeadersWidth = 4;
            this.dgvEmail.RowTemplate.Height = 25;
            this.dgvEmail.Size = new System.Drawing.Size(607, 528);
            this.dgvEmail.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // epf
            // 
            this.epf.HeaderText = "EPF";
            this.epf.Name = "epf";
            this.epf.ReadOnly = true;
            // 
            // fid
            // 
            this.fid.HeaderText = "FID";
            this.fid.Name = "fid";
            this.fid.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 41);
            this.panel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data Table";
            // 
            // UCEmailHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCEmailHandling";
            this.Size = new System.Drawing.Size(1128, 569);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label10;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label12;
        private TextBox tbName;
        private TextBox tBaddres;
        private FontAwesome.Sharp.IconButton btnEAdd;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private DataGridView dgvEmail;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn epf;
        private DataGridViewTextBoxColumn fid;
    }
}
