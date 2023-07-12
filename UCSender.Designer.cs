namespace projectTelegraphicTransfer
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
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBusiness = new System.Windows.Forms.TextBox();
            this.tBtax = new System.Windows.Forms.TextBox();
            this.tbTN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tBaddres = new System.Windows.Forms.TextBox();
            this.tbTin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSDelete = new FontAwesome.Sharp.IconButton();
            this.btnSAdd = new FontAwesome.Sharp.IconButton();
            this.btnSUpdate = new FontAwesome.Sharp.IconButton();
            this.flpLoadSender = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_LoadSender = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 43);
            this.panel1.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            this.btnRefresh.IconColor = System.Drawing.Color.White;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 20;
            this.btnRefresh.Location = new System.Drawing.Point(674, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(623, 21);
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flpLoadSender);
            this.splitContainer1.Size = new System.Drawing.Size(1234, 848);
            this.splitContainer1.SplitterDistance = 667;
            this.splitContainer1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.34608F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.65392F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbBusiness, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tBtax, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbTN, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tBaddres, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbTin, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.74757F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.25243F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 224);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "TIN NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEPHONE NO";
            // 
            // tbBusiness
            // 
            this.tbBusiness.Location = new System.Drawing.Point(154, 96);
            this.tbBusiness.Name = "tbBusiness";
            this.tbBusiness.Size = new System.Drawing.Size(437, 23);
            this.tbBusiness.TabIndex = 11;
            // 
            // tBtax
            // 
            this.tBtax.Location = new System.Drawing.Point(154, 128);
            this.tBtax.Name = "tBtax";
            this.tBtax.Size = new System.Drawing.Size(437, 23);
            this.tBtax.TabIndex = 12;
            // 
            // tbTN
            // 
            this.tbTN.Location = new System.Drawing.Point(154, 159);
            this.tbTN.Name = "tbTN";
            this.tbTN.Size = new System.Drawing.Size(437, 23);
            this.tbTN.TabIndex = 13;
            this.tbTN.TextChanged += new System.EventHandler(this.tbTN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADDRESS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 93);
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
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(154, 3);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(437, 33);
            this.tbName.TabIndex = 16;
            // 
            // tBaddres
            // 
            this.tBaddres.Location = new System.Drawing.Point(154, 42);
            this.tBaddres.Multiline = true;
            this.tBaddres.Name = "tBaddres";
            this.tBaddres.Size = new System.Drawing.Size(437, 48);
            this.tBaddres.TabIndex = 17;
            // 
            // tbTin
            // 
            this.tbTin.Location = new System.Drawing.Point(154, 192);
            this.tbTin.Name = "tbTin";
            this.tbTin.Size = new System.Drawing.Size(437, 23);
            this.tbTin.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "TAX";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSDelete);
            this.panel4.Controls.Add(this.btnSAdd);
            this.panel4.Controls.Add(this.btnSUpdate);
            this.panel4.Location = new System.Drawing.Point(22, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(623, 49);
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
            this.btnSDelete.Location = new System.Drawing.Point(467, 3);
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
            this.btnSAdd.Location = new System.Drawing.Point(3, 4);
            this.btnSAdd.Name = "btnSAdd";
            this.btnSAdd.Size = new System.Drawing.Size(153, 42);
            this.btnSAdd.TabIndex = 0;
            this.btnSAdd.Text = "  ADD";
            this.btnSAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSAdd.UseVisualStyleBackColor = false;
            this.btnSAdd.Click += new System.EventHandler(this.btnSAdd_Click);
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
            this.btnSUpdate.Location = new System.Drawing.Point(239, 3);
            this.btnSUpdate.Name = "btnSUpdate";
            this.btnSUpdate.Size = new System.Drawing.Size(153, 42);
            this.btnSUpdate.TabIndex = 1;
            this.btnSUpdate.Text = "  UPDATE";
            this.btnSUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSUpdate.UseVisualStyleBackColor = false;
            // 
            // flpLoadSender
            // 
            this.flpLoadSender.AutoScroll = true;
            this.flpLoadSender.BackColor = System.Drawing.SystemColors.Menu;
            this.flpLoadSender.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpLoadSender.Location = new System.Drawing.Point(0, 0);
            this.flpLoadSender.Name = "flpLoadSender";
            this.flpLoadSender.Size = new System.Drawing.Size(563, 848);
            this.flpLoadSender.TabIndex = 10;
            // 
            // flp_LoadSender
            // 
            this.flp_LoadSender.Location = new System.Drawing.Point(0, 0);
            this.flp_LoadSender.Name = "flp_LoadSender";
            this.flp_LoadSender.Size = new System.Drawing.Size(200, 100);
            this.flp_LoadSender.TabIndex = 0;
            // 
            // UCSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "UCSender";
            this.Size = new System.Drawing.Size(1279, 888);
            this.Load += new System.EventHandler(this.UCSender_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnSDelete;
        private FontAwesome.Sharp.IconButton btnSUpdate;
        private FontAwesome.Sharp.IconButton btnSAdd;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label11;
        private Label label3;
        private Label label5;
        private TextBox tbBusiness;
        private TextBox tBtax;
        private TextBox tbTN;
        private Label label12;
        private DataGridView dGVSender;
        private Label label4;
        private TextBox tbName;
        private TextBox tBaddres;
        private TextBox tbTin;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn business;
        private DataGridViewTextBoxColumn tax;
        private DataGridViewTextBoxColumn telNo;
        private DataGridViewTextBoxColumn TinNo;
        //private FlowLayoutPanel flp_LoadSender;
        private System.Windows.Forms.FlowLayoutPanel flp_LoadSender;
        private Label label10;
        private FlowLayoutPanel flpLoadSender;
        private FontAwesome.Sharp.IconButton btnRefresh;
    }
}
