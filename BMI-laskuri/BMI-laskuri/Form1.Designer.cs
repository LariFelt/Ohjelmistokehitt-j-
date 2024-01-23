namespace BMI_laskuri
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            PainoTB = new TextBox();
            PituusTB = new TextBox();
            LaskeBT = new Button();
            VastausLB = new Label();
            KuvausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna paino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 49);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Anna pituus:";
            // 
            // PainoTB
            // 
            PainoTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PainoTB.Location = new Point(131, 9);
            PainoTB.Name = "PainoTB";
            PainoTB.Size = new Size(100, 29);
            PainoTB.TabIndex = 2;
            // 
            // PituusTB
            // 
            PituusTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PituusTB.Location = new Point(131, 45);
            PituusTB.Name = "PituusTB";
            PituusTB.Size = new Size(100, 29);
            PituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(16, 89);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(215, 47);
            LaskeBT.TabIndex = 4;
            LaskeBT.Text = "Laske painoindeksi";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(12, 148);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(76, 25);
            VastausLB.TabIndex = 5;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // KuvausLB
            // 
            KuvausLB.AutoSize = true;
            KuvausLB.Location = new Point(16, 191);
            KuvausLB.Name = "KuvausLB";
            KuvausLB.Size = new Size(72, 25);
            KuvausLB.TabIndex = 6;
            KuvausLB.Text = "Kuvaus";
            KuvausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 260);
            Controls.Add(KuvausLB);
            Controls.Add(VastausLB);
            Controls.Add(LaskeBT);
            Controls.Add(PituusTB);
            Controls.Add(PainoTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Painoindeksilaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Button LaskeBT;
        private Label VastausLB;
        private Label KuvausLB;
    }
}