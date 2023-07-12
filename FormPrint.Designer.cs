namespace projectTelegraphicTransfer
{
    partial class FormPrint
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            iconButton1 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            pnlt = new Panel();
            lbl_Purpose = new Label();
            lbl_formName = new Label();
            panel2.SuspendLayout();
            pnlt.SuspendLayout();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(800, 65);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(149, 31);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "PRINT";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(313, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 644);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 109);
            panel2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(497, 16);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(405, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 0;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pnlt
            // 
            pnlt.Controls.Add(lbl_Purpose);
            pnlt.Controls.Add(lbl_formName);
            pnlt.Dock = DockStyle.Fill;
            pnlt.Location = new Point(0, 0);
            pnlt.Margin = new Padding(3, 4, 3, 4);
            pnlt.Name = "pnlt";
            pnlt.Size = new Size(982, 644);
            pnlt.TabIndex = 3;
            // 
            // lbl_Purpose
            // 
            lbl_Purpose.AutoSize = true;
            lbl_Purpose.Location = new Point(441, 323);
            lbl_Purpose.Name = "lbl_Purpose";
            lbl_Purpose.Size = new Size(50, 20);
            lbl_Purpose.TabIndex = 1;
            lbl_Purpose.Text = "label1";
            // 
            // lbl_formName
            // 
            lbl_formName.AutoSize = true;
            lbl_formName.Location = new Point(440, 293);
            lbl_formName.Name = "lbl_formName";
            lbl_formName.Size = new Size(50, 20);
            lbl_formName.TabIndex = 0;
            lbl_formName.Text = "label1";
            // 
            // FormPrint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(pnlt);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1000, 800);
            MinimumSize = new Size(1000, 800);
            Name = "FormPrint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrint";
            FormClosed += FormPrint_FormClosed;
            Load += FormPrint_Load;
            panel2.ResumeLayout(false);
            pnlt.ResumeLayout(false);
            pnlt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Panel pnlt;
        private Label lbl_Purpose;
        private Label lbl_formName;
    }
}