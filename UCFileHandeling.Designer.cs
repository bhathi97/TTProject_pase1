﻿namespace project_TelegraphicTransfer
{
    partial class UCFileHandeling
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

            splitContainerToShowFiles = new SplitContainer();
            pnlFilesShow = new Panel();
            flp_fileItemsShowingPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            tb_search = new TextBox();
            btn_search = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel3 = new Panel();
            btn_CreateNEwTTs = new FontAwesome.Sharp.IconButton();
            splitContainerTTHandleing = new SplitContainer();
            panel2 = new Panel();
            label2 = new Label();
            lblTest = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainerToShowFiles).BeginInit();
            splitContainerToShowFiles.Panel1.SuspendLayout();
            splitContainerToShowFiles.Panel2.SuspendLayout();
            splitContainerToShowFiles.SuspendLayout();
            pnlFilesShow.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTTHandleing).BeginInit();
            splitContainerTTHandleing.Panel1.SuspendLayout();
            splitContainerTTHandleing.Panel2.SuspendLayout();
            splitContainerTTHandleing.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();

            // splitContainerToShowFiles
            // 
            this.splitContainerToShowFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.splitContainerToShowFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerToShowFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerToShowFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainerToShowFiles.Location = new System.Drawing.Point(0, 0);
            this.splitContainerToShowFiles.Name = "splitContainerToShowFiles";
            // 
            // splitContainerToShowFiles.Panel1
            // 
            this.splitContainerToShowFiles.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainerToShowFiles.Panel1.Controls.Add(this.pnlFilesShow);
            this.splitContainerToShowFiles.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainerToShowFiles.Panel2
            // 
            this.splitContainerToShowFiles.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerToShowFiles.Panel2.Controls.Add(this.splitContainerTTHandleing);
            this.splitContainerToShowFiles.Size = new System.Drawing.Size(781, 505);
            this.splitContainerToShowFiles.SplitterDistance = 150;
            this.splitContainerToShowFiles.TabIndex = 0;
            // 
            // pnlFilesShow
            // 

            pnlFilesShow.BackColor = SystemColors.Control;
            pnlFilesShow.Controls.Add(flp_fileItemsShowingPanel);
            pnlFilesShow.Dock = DockStyle.Fill;
            pnlFilesShow.Location = new Point(0, 137);
            pnlFilesShow.Name = "pnlFilesShow";
            pnlFilesShow.Padding = new Padding(3);
            pnlFilesShow.Size = new Size(146, 364);
            pnlFilesShow.TabIndex = 1;
            // 
            // flp_fileItemsShowingPanel
            // 
            flp_fileItemsShowingPanel.AutoScroll = true;
            flp_fileItemsShowingPanel.BackColor = SystemColors.Control;
            flp_fileItemsShowingPanel.Dock = DockStyle.Fill;
            flp_fileItemsShowingPanel.Location = new Point(3, 3);
            flp_fileItemsShowingPanel.Name = "flp_fileItemsShowingPanel";
            flp_fileItemsShowingPanel.Size = new Size(140, 358);
            flp_fileItemsShowingPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(146, 137);
            panel1.TabIndex = 0;

            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(5, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(136, 79);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btn_search);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 33);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(136, 46);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(tb_search);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(5, 5);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(93, 36);
            panel6.TabIndex = 3;
            // 
            // tb_search
            // 
            tb_search.Dock = DockStyle.Fill;
            tb_search.Location = new Point(5, 5);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(83, 23);
            tb_search.TabIndex = 1;
            // 
            // btn_search
            // 
            btn_search.Dock = DockStyle.Right;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_search.IconColor = Color.Black;
            btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_search.IconSize = 28;
            btn_search.Location = new Point(98, 5);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(33, 36);
            btn_search.TabIndex = 2;
            btn_search.TextAlign = ContentAlignment.BottomCenter;
            btn_search.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 0;
            label1.Text = "Files";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(btn_CreateNEwTTs);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(5, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 39);
            panel3.TabIndex = 2;
            // 
            // btn_CreateNEwTTs
            // 


            btn_CreateNEwTTs.BackColor = Color.FromArgb(76, 175, 80);
            btn_CreateNEwTTs.Dock = DockStyle.Fill;
            btn_CreateNEwTTs.FlatAppearance.BorderSize = 0;
            btn_CreateNEwTTs.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btn_CreateNEwTTs.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btn_CreateNEwTTs.FlatStyle = FlatStyle.Flat;
            btn_CreateNEwTTs.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CreateNEwTTs.ForeColor = Color.White;
            btn_CreateNEwTTs.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btn_CreateNEwTTs.IconColor = Color.White;
            btn_CreateNEwTTs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CreateNEwTTs.IconSize = 25;
            btn_CreateNEwTTs.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CreateNEwTTs.Location = new Point(0, 0);
            btn_CreateNEwTTs.Name = "btn_CreateNEwTTs";
            btn_CreateNEwTTs.Size = new Size(136, 39);
            btn_CreateNEwTTs.TabIndex = 1;
            btn_CreateNEwTTs.Text = "New File";
            btn_CreateNEwTTs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CreateNEwTTs.UseVisualStyleBackColor = false;
            btn_CreateNEwTTs.Click += btn_CreateNEwTTs_Click;

            // 

            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Files";
            // 

            // splitContainerTTHandleing
            // 
            this.splitContainerTTHandleing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.splitContainerTTHandleing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerTTHandleing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTTHandleing.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.splitContainerTTHandleing.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTTHandleing.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerTTHandleing.Name = "splitContainerTTHandleing";
            // 
            // splitContainerTTHandleing.Panel1
            // 
            this.splitContainerTTHandleing.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerTTHandleing.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainerTTHandleing.Panel2
            // 
            this.splitContainerTTHandleing.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerTTHandleing.Panel2.Controls.Add(this.lblTest);
            this.splitContainerTTHandleing.Size = new System.Drawing.Size(627, 505);
            this.splitContainerTTHandleing.SplitterDistance = 150;
            this.splitContainerTTHandleing.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(146, 57);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telegraphic Transfer Orders";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTest.Location = new System.Drawing.Point(104, 110);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 27);
            this.lblTest.TabIndex = 0;
            // 
            // UCFileHandeling

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerToShowFiles);
            Name = "UCFileHandeling";
            Size = new Size(781, 505);
            Load += UCFileHandeling_Load;
            splitContainerToShowFiles.Panel1.ResumeLayout(false);
            splitContainerToShowFiles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerToShowFiles).EndInit();
            splitContainerToShowFiles.ResumeLayout(false);
            pnlFilesShow.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            splitContainerTTHandleing.Panel1.ResumeLayout(false);
            splitContainerTTHandleing.Panel2.ResumeLayout(false);
            splitContainerTTHandleing.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTTHandleing).EndInit();
            splitContainerTTHandleing.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainerToShowFiles;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_CreateNEwTTs;
        private Label label1;
        private Panel pnlFilesShow;
        private FlowLayoutPanel flp_fileItemsShowingPanel;
        private SplitContainer splitContainerTTHandleing;
        private Label lblTest;
        private Panel panel2;
        private Label label2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btn_search;
        private TextBox tb_search;
    }
}
