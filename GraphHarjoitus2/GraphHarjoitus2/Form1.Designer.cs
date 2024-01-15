namespace GraphHarjoitus2
{
    partial class Harjoitus2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OtsikkoLB = new Label();
            TulostusLB = new Label();
            ViestiTB = new TextBox();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point);
            OtsikkoLB.Location = new Point(12, 13);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(295, 35);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "anna tulostettava teksti:";
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TulostusLB.Location = new Point(12, 48);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(76, 35);
            TulostusLB.TabIndex = 1;
            TulostusLB.Text = "xxxx";
            TulostusLB.UseMnemonic = false;
            TulostusLB.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ViestiTB.Location = new Point(313, 12);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(185, 36);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            TulostaBT.FlatStyle = FlatStyle.System;
            TulostaBT.Location = new Point(320, 64);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(75, 23);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "Tulosta teksti";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // Harjoitus2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(TulostaBT);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLB);
            Controls.Add(OtsikkoLB);
            ForeColor = Color.MintCream;
            Name = "Harjoitus2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}