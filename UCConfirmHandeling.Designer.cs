﻿namespace project_TelegraphicTransfer
{
    partial class UCConfirmHandeling
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
            flp_confirmItemLoade = new FlowLayoutPanel();
            panel1 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flp_confirmItemLoade
            // 
            flp_confirmItemLoade.Dock = DockStyle.Fill;
            flp_confirmItemLoade.Location = new Point(0, 31);
            flp_confirmItemLoade.Name = "flp_confirmItemLoade";
            flp_confirmItemLoade.Size = new Size(713, 435);
            flp_confirmItemLoade.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 31);
            panel1.TabIndex = 1;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(11, 12, 71);
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(709, 27);
            label10.TabIndex = 0;
            label10.Text = "CONFORMATION HANDLING";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 12, 71);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 466);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 42);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.442028F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.557972F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(552, 27);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(298, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 27);
            label2.TabIndex = 1;
            label2.Text = "309";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of Telegraphic Transfer Forms To Confirm :";
            // 
            // UCConfirmHandeling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(flp_confirmItemLoade);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCConfirmHandeling";
            Size = new Size(713, 508);
            Load += UCConfirmHandeling_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_confirmItemLoade;
        private Panel panel1;
        private Label label10;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
    }
}
