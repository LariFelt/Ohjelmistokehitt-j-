namespace SuosituimmatNimet
{
    partial class NimetForm
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
            this.NimiLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.TarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NimiLB
            // 
            this.NimiLB.AutoSize = true;
            this.NimiLB.Location = new System.Drawing.Point(14, 13);
            this.NimiLB.Name = "NimiLB";
            this.NimiLB.Size = new System.Drawing.Size(543, 25);
            this.NimiLB.TabIndex = 0;
            this.NimiLB.Text = "Anna nimesi, niin tarkistan , onko se 50 suosituimman joukossa:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(14, 58);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(76, 25);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // NimiTB
            // 
            this.NimiTB.Location = new System.Drawing.Point(563, 10);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(144, 33);
            this.NimiTB.TabIndex = 2;
            // 
            // TarkastaBT
            // 
            this.TarkastaBT.Location = new System.Drawing.Point(604, 51);
            this.TarkastaBT.Name = "TarkastaBT";
            this.TarkastaBT.Size = new System.Drawing.Size(103, 32);
            this.TarkastaBT.TabIndex = 3;
            this.TarkastaBT.Text = "Tarkasta";
            this.TarkastaBT.UseVisualStyleBackColor = true;
            this.TarkastaBT.Click += new System.EventHandler(this.TarkastaBT_Click);
            // 
            // NimetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 372);
            this.Controls.Add(this.TarkastaBT);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.NimiLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "NimetForm";
            this.Text = "Onko nimesi suosittujen joukossa?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NimiLB;
        private Label VastausLB;
        private TextBox NimiTB;
        private Button TarkastaBT;
    }
}