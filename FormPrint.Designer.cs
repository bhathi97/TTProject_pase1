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
            iconButton1=new FontAwesome.Sharp.IconButton();
            button1=new Button();
            pnlt=new Panel();
            panel2=new Panel();
            button2=new Button();
            button3=new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.IconChar=FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor=Color.Black;
            iconButton1.IconFont=FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location=new Point(309, 37);
            iconButton1.Name="iconButton1";
            iconButton1.Size=new Size(75, 23);
            iconButton1.TabIndex=0;
            iconButton1.Text="iconButton1";
            iconButton1.UseVisualStyleBackColor=true;
            // 
            // button1
            // 
            button1.Location=new Point(470, 37);
            button1.Name="button1";
            button1.Size=new Size(75, 23);
            button1.TabIndex=1;
            button1.Text="button1";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // pnlt
            // 
            pnlt.Dock=DockStyle.Fill;
            pnlt.Location=new Point(0, 0);
            pnlt.Name="pnlt";
            pnlt.Size=new Size(841, 545);
            pnlt.TabIndex=2;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(button1);
            panel2.Dock=DockStyle.Bottom;
            panel2.Location=new Point(0, 457);
            panel2.Name="panel2";
            panel2.Size=new Size(841, 88);
            panel2.TabIndex=3;
            // 
            // button2
            // 
            button2.Location=new Point(565, 37);
            button2.Name="button2";
            button2.Size=new Size(75, 23);
            button2.TabIndex=0;
            button2.Text="button2";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Location=new Point(656, 36);
            button3.Name="button3";
            button3.Size=new Size(75, 23);
            button3.TabIndex=2;
            button3.Text="button3";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // FormPrint
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(841, 545);
            Controls.Add(panel2);
            Controls.Add(pnlt);
            Name="FormPrint";
            Text="FormPrint";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button1;
        private Panel pnlt;
        private Panel panel2;
        private Button button2;
        private Button button3;
    }
}