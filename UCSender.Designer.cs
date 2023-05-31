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
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSDelete = new FontAwesome.Sharp.IconButton();
            this.btnSUpdate = new FontAwesome.Sharp.IconButton();
            this.btnSAdd = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tbbrN = new System.Windows.Forms.TextBox();
            this.tBbn = new System.Windows.Forms.TextBox();
            this.TBaddress = new System.Windows.Forms.TextBox();
            this.TBname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBnic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dGVSender = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSender)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 59);
            this.panel1.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(81, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "SENDER HANDLING";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dGVSender);
            this.splitContainer1.Size = new System.Drawing.Size(1250, 636);
            this.splitContainer1.SplitterDistance = 579;
            this.splitContainer1.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSDelete);
            this.panel4.Controls.Add(this.btnSUpdate);
            this.panel4.Controls.Add(this.btnSAdd);
            this.panel4.Location = new System.Drawing.Point(178, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 145);
            this.panel4.TabIndex = 7;
            // 
            // btnSDelete
            // 
            this.btnSDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSDelete.ForeColor = System.Drawing.Color.White;
            this.btnSDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnSDelete.IconColor = System.Drawing.Color.White;
            this.btnSDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSDelete.IconSize = 20;
            this.btnSDelete.Location = new System.Drawing.Point(3, 99);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(197, 42);
            this.btnSDelete.TabIndex = 2;
            this.btnSDelete.Text = "DELETE";
            this.btnSDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSDelete.UseVisualStyleBackColor = false;
            // 
            // btnSUpdate
            // 
            this.btnSUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSUpdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnSUpdate.IconColor = System.Drawing.Color.White;
            this.btnSUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSUpdate.IconSize = 20;
            this.btnSUpdate.Location = new System.Drawing.Point(3, 51);
            this.btnSUpdate.Name = "btnSUpdate";
            this.btnSUpdate.Size = new System.Drawing.Size(197, 42);
            this.btnSUpdate.TabIndex = 1;
            this.btnSUpdate.Text = "  UPDATE";
            this.btnSUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSAdd
            // 
            this.btnSAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSAdd.ForeColor = System.Drawing.Color.White;
            this.btnSAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnSAdd.IconColor = System.Drawing.Color.White;
            this.btnSAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSAdd.IconSize = 20;
            this.btnSAdd.Location = new System.Drawing.Point(3, 3);
            this.btnSAdd.Name = "btnSAdd";
            this.btnSAdd.Size = new System.Drawing.Size(197, 42);
            this.btnSAdd.TabIndex = 0;
            this.btnSAdd.Text = "  ADD";
            this.btnSAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSAdd.UseVisualStyleBackColor = false;
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
            // tbbrN
            // 
            this.tbbrN.Location = new System.Drawing.Point(156, 190);
            this.tbbrN.Name = "tbbrN";
            this.tbbrN.Size = new System.Drawing.Size(318, 23);
            this.tbbrN.TabIndex = 13;
            // 
            // tBbn
            // 
            this.tBbn.Location = new System.Drawing.Point(156, 141);
            this.tBbn.Name = "tBbn";
            this.tBbn.Size = new System.Drawing.Size(318, 23);
            this.tBbn.TabIndex = 12;
            // 
            // TBaddress
            // 
            this.TBaddress.Location = new System.Drawing.Point(156, 96);
            this.TBaddress.Name = "TBaddress";
            this.TBaddress.Size = new System.Drawing.Size(318, 23);
            this.TBaddress.TabIndex = 11;
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(156, 51);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(318, 23);
            this.TBname.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEPHONE NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "TAX";
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
            // TBnic
            // 
            this.TBnic.Location = new System.Drawing.Point(156, 3);
            this.TBnic.Name = "TBnic";
            this.TBnic.Size = new System.Drawing.Size(318, 23);
            this.TBnic.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADDRESS";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.03226F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.96774F));
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.08696F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.91304F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(527, 236);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // dGVSender
            // 
            this.dGVSender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.business,
            this.tax,
            this.telNo});
            this.dGVSender.Location = new System.Drawing.Point(25, 0);
            this.dGVSender.Name = "dGVSender";
            this.dGVSender.RowTemplate.Height = 25;
            this.dGVSender.Size = new System.Drawing.Size(639, 350);
            this.dGVSender.TabIndex = 0;
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
            // UCSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "UCSender";
            this.Size = new System.Drawing.Size(1125, 606);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSender)).EndInit();
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
        private DataGridView dGVSender;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn business;
        private DataGridViewTextBoxColumn tax;
        private DataGridViewTextBoxColumn telNo;
    }
}
