namespace project_TelegraphicTransfer
{
    partial class UCSender
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dGVSender = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TBnic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBname = new System.Windows.Forms.TextBox();
            this.TBaddress = new System.Windows.Forms.TextBox();
            this.tBbn = new System.Windows.Forms.TextBox();
            this.tbbrN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSDelete = new FontAwesome.Sharp.IconButton();
            this.btnSAdd = new FontAwesome.Sharp.IconButton();
            this.btnSUpdate = new FontAwesome.Sharp.IconButton();
            this.dgvEmail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdelete = new FontAwesome.Sharp.IconButton();
            this.btnEAdd = new FontAwesome.Sharp.IconButton();
            this.btnEupdate = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbEpf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSender)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 40);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(707, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "EMAIL HANDLING";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(497, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "SENDER HANDLING";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dGVSender);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEmail);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1234, 848);
            this.splitContainer1.SplitterDistance = 667;
            this.splitContainer1.TabIndex = 8;
            // 
            // dGVSender
            // 
            this.dGVSender.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVSender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.business,
            this.tax,
            this.telNo});
            this.dGVSender.Location = new System.Drawing.Point(22, 265);
            this.dGVSender.Name = "dGVSender";
            this.dGVSender.RowTemplate.Height = 25;
            this.dGVSender.Size = new System.Drawing.Size(642, 227);
            this.dGVSender.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            // 
            // address
            // 
            this.address.HeaderText = "ADDRESS";
            this.address.Name = "address";
            // 
            // business
            // 
            this.business.HeaderText = "BUSINESS";
            this.business.Name = "business";
            // 
            // tax
            // 
            this.tax.HeaderText = "TAX";
            this.tax.Name = "tax";
            // 
            // telNo
            // 
            this.telNo.HeaderText = "TELEPHONE NO";
            this.telNo.Name = "telNo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.34608F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.65392F));
            this.tableLayoutPanel2.Controls.Add(this.TBnic, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TBname, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TBaddress, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tBbn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbbrN, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.47059F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.52941F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(497, 178);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // TBnic
            // 
            this.TBnic.Location = new System.Drawing.Point(124, 3);
            this.TBnic.Name = "TBnic";
            this.TBnic.Size = new System.Drawing.Size(350, 23);
            this.TBnic.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "TAX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEPHONE NO";
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(124, 38);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(350, 23);
            this.TBname.TabIndex = 10;
            // 
            // TBaddress
            // 
            this.TBaddress.Location = new System.Drawing.Point(124, 71);
            this.TBaddress.Name = "TBaddress";
            this.TBaddress.Size = new System.Drawing.Size(350, 23);
            this.TBaddress.TabIndex = 11;
            // 
            // tBbn
            // 
            this.tBbn.Location = new System.Drawing.Point(124, 107);
            this.tBbn.Name = "tBbn";
            this.tBbn.Size = new System.Drawing.Size(350, 23);
            this.tBbn.TabIndex = 12;
            // 
            // tbbrN
            // 
            this.tbbrN.Location = new System.Drawing.Point(124, 142);
            this.tbbrN.Name = "tbbrN";
            this.tbbrN.Size = new System.Drawing.Size(350, 23);
            this.tbbrN.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADDRESS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "BUSINESS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "NAME";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSDelete);
            this.panel4.Controls.Add(this.btnSAdd);
            this.panel4.Controls.Add(this.btnSUpdate);
            this.panel4.Location = new System.Drawing.Point(22, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 49);
            this.panel4.TabIndex = 7;
            // 
            // btnSDelete
            // 
            this.btnSDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.btnSDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSDelete.ForeColor = System.Drawing.Color.White;
            this.btnSDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnSDelete.IconColor = System.Drawing.Color.White;
            this.btnSDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSDelete.IconSize = 20;
            this.btnSDelete.Location = new System.Drawing.Point(344, 0);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(153, 42);
            this.btnSDelete.TabIndex = 2;
            this.btnSDelete.Text = "DELETE";
            this.btnSDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSDelete.UseVisualStyleBackColor = false;
            // 
            // btnSAdd
            // 
            this.btnSAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.btnSAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSAdd.ForeColor = System.Drawing.Color.White;
            this.btnSAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnSAdd.IconColor = System.Drawing.Color.White;
            this.btnSAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSAdd.IconSize = 20;
            this.btnSAdd.Location = new System.Drawing.Point(0, 0);
            this.btnSAdd.Name = "btnSAdd";
            this.btnSAdd.Size = new System.Drawing.Size(153, 42);
            this.btnSAdd.TabIndex = 0;
            this.btnSAdd.Text = "  ADD";
            this.btnSAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSAdd.UseVisualStyleBackColor = false;
            // 
            // btnSUpdate
            // 
            this.btnSUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.btnSUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSUpdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnSUpdate.IconColor = System.Drawing.Color.White;
            this.btnSUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSUpdate.IconSize = 20;
            this.btnSUpdate.Location = new System.Drawing.Point(170, 0);
            this.btnSUpdate.Name = "btnSUpdate";
            this.btnSUpdate.Size = new System.Drawing.Size(153, 42);
            this.btnSUpdate.TabIndex = 1;
            this.btnSUpdate.Text = "  UPDATE";
            this.btnSUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSUpdate.UseVisualStyleBackColor = false;
            // 
            // dgvEmail
            // 
            this.dgvEmail.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.email,
            this.epf,
            this.fid});
            this.dgvEmail.Location = new System.Drawing.Point(33, 173);
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.RowTemplate.Height = 25;
            this.dgvEmail.Size = new System.Drawing.Size(443, 150);
            this.dgvEmail.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // email
            // 
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            // 
            // epf
            // 
            this.epf.HeaderText = "EPF";
            this.epf.Name = "epf";
            // 
            // fid
            // 
            this.fid.HeaderText = "FID";
            this.fid.Name = "fid";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEdelete);
            this.panel2.Controls.Add(this.btnEAdd);
            this.panel2.Controls.Add(this.btnEupdate);
            this.panel2.Location = new System.Drawing.Point(33, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 49);
            this.panel2.TabIndex = 10;
            // 
            // btnEdelete
            // 
            this.btnEdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.btnEdelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEdelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEdelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdelete.ForeColor = System.Drawing.Color.White;
            this.btnEdelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEdelete.IconColor = System.Drawing.Color.White;
            this.btnEdelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEdelete.IconSize = 20;
            this.btnEdelete.Location = new System.Drawing.Point(344, 0);
            this.btnEdelete.Name = "btnEdelete";
            this.btnEdelete.Size = new System.Drawing.Size(153, 42);
            this.btnEdelete.TabIndex = 2;
            this.btnEdelete.Text = "DELETE";
            this.btnEdelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdelete.UseVisualStyleBackColor = false;
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
            this.btnEAdd.Location = new System.Drawing.Point(0, 0);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(153, 42);
            this.btnEAdd.TabIndex = 0;
            this.btnEAdd.Text = "  ADD";
            this.btnEAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEAdd.UseVisualStyleBackColor = false;
            // 
            // btnEupdate
            // 
            this.btnEupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.btnEupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEupdate.ForeColor = System.Drawing.Color.White;
            this.btnEupdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEupdate.IconColor = System.Drawing.Color.White;
            this.btnEupdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEupdate.IconSize = 20;
            this.btnEupdate.Location = new System.Drawing.Point(170, 0);
            this.btnEupdate.Name = "btnEupdate";
            this.btnEupdate.Size = new System.Drawing.Size(153, 42);
            this.btnEupdate.TabIndex = 1;
            this.btnEupdate.Text = "  UPDATE";
            this.btnEupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEupdate.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.90654F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.09346F));
            this.tableLayoutPanel1.Controls.Add(this.tbMail, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbEpf, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 75);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(151, 3);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(343, 23);
            this.tbMail.TabIndex = 9;
            // 
            // tbEpf
            // 
            this.tbEpf.Location = new System.Drawing.Point(151, 37);
            this.tbEpf.Name = "tbEpf";
            this.tbEpf.Size = new System.Drawing.Size(343, 23);
            this.tbEpf.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "EPF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "EMAIL";
            // 
            // UCSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "UCSender";
            this.Size = new System.Drawing.Size(1279, 888);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSender)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label10;
        private SplitContainer splitContainer1;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnSDelete;
        private FontAwesome.Sharp.IconButton btnSUpdate;
        private FontAwesome.Sharp.IconButton btnSAdd;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox TBnic;
        private Label label11;
        private Label label3;
        private Label label5;
        private TextBox TBname;
        private TextBox TBaddress;
        private TextBox tBbn;
        private TextBox tbbrN;
        private Label label12;
        private Label label2;
        private DataGridView dGVSender;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn business;
        private DataGridViewTextBoxColumn tax;
        private DataGridViewTextBoxColumn telNo;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbMail;
        private TextBox tbEpf;
        private Label label7;
        private Label label9;
        private DataGridView dgvEmail;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn epf;
        private DataGridViewTextBoxColumn fid;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnEdelete;
        private FontAwesome.Sharp.IconButton btnEAdd;
        private FontAwesome.Sharp.IconButton btnEupdate;
    }
}
