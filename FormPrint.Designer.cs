namespace project_TelegraphicTransfer
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
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(434, 499);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(86, 31);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // FormPrint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(iconButton1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrint";
            Text = "FormPrint";
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
    }
}