namespace AsteMuunnin
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
            groupBox1 = new GroupBox();
            CelsiusRB = new RadioButton();
            FahrenheitRB = new RadioButton();
            label1 = new Label();
            AsteetTB = new TextBox();
            MuunnaBT = new Button();
            VastausLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FahrenheitRB);
            groupBox1.Controls.Add(CelsiusRB);
            groupBox1.Location = new Point(235, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(178, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Miten muunnat?";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // CelsiusRB
            // 
            CelsiusRB.AutoSize = true;
            CelsiusRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CelsiusRB.Location = new Point(6, 32);
            CelsiusRB.Name = "CelsiusRB";
            CelsiusRB.Size = new Size(90, 29);
            CelsiusRB.TabIndex = 0;
            CelsiusRB.TabStop = true;
            CelsiusRB.Text = "Celsius";
            CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FahrenheitRB.Location = new Point(6, 67);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(123, 29);
            FahrenheitRB.TabIndex = 1;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 1;
            label1.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            AsteetTB.Location = new Point(130, 57);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(99, 33);
            AsteetTB.TabIndex = 2;
            // 
            // MuunnaBT
            // 
            MuunnaBT.Location = new Point(419, 56);
            MuunnaBT.Name = "MuunnaBT";
            MuunnaBT.Size = new Size(100, 34);
            MuunnaBT.TabIndex = 3;
            MuunnaBT.Text = "Muunna";
            MuunnaBT.UseVisualStyleBackColor = true;
            MuunnaBT.Click += MuunnaBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(12, 160);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(76, 25);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 394);
            Controls.Add(VastausLB);
            Controls.Add(MuunnaBT);
            Controls.Add(AsteetTB);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Aste Muunnin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton FahrenheitRB;
        private RadioButton CelsiusRB;
        private Label label1;
        private TextBox AsteetTB;
        private Button MuunnaBT;
        private Label VastausLB;
    }
}