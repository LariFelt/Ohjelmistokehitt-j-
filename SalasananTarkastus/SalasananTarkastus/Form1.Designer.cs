namespace SalasananTarkastus
{
    partial class SalasanaForm
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
            SalasanaPanel = new Panel();
            VirheviestiLB = new TextBox();
            SalasanaTB = new TextBox();
            KayttajaTB = new TextBox();
            TarkistaBT = new Button();
            SalasanaLB = new Label();
            KayttajaLB = new Label();
            SalasanaOikeinPanel = new Panel();
            TervetuloaLabel = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(VirheviestiLB);
            SalasanaPanel.Controls.Add(SalasanaTB);
            SalasanaPanel.Controls.Add(KayttajaTB);
            SalasanaPanel.Controls.Add(TarkistaBT);
            SalasanaPanel.Controls.Add(SalasanaLB);
            SalasanaPanel.Controls.Add(KayttajaLB);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SalasanaPanel.ForeColor = Color.Gold;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(1371, 900);
            SalasanaPanel.TabIndex = 0;
            // 
            // VirheviestiLB
            // 
            VirheviestiLB.BackColor = Color.MidnightBlue;
            VirheviestiLB.ForeColor = Color.Gold;
            VirheviestiLB.Location = new Point(40, 174);
            VirheviestiLB.Name = "VirheviestiLB";
            VirheviestiLB.Size = new Size(392, 39);
            VirheviestiLB.TabIndex = 5;
            VirheviestiLB.Text = "Virhe";
            VirheviestiLB.Visible = false;
            VirheviestiLB.TextChanged += VirheviestiLB_TextChanged;
            // 
            // SalasanaTB
            // 
            SalasanaTB.Location = new Point(262, 99);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(248, 39);
            SalasanaTB.TabIndex = 4;
            // 
            // KayttajaTB
            // 
            KayttajaTB.Location = new Point(262, 34);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(248, 39);
            KayttajaTB.TabIndex = 3;
            // 
            // TarkistaBT
            // 
            TarkistaBT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TarkistaBT.ForeColor = Color.Black;
            TarkistaBT.Location = new Point(35, 99);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.RightToLeft = RightToLeft.No;
            TarkistaBT.Size = new Size(105, 39);
            TarkistaBT.TabIndex = 2;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // SalasanaLB
            // 
            SalasanaLB.AutoSize = true;
            SalasanaLB.Location = new Point(146, 106);
            SalasanaLB.Name = "SalasanaLB";
            SalasanaLB.Size = new Size(110, 32);
            SalasanaLB.TabIndex = 1;
            SalasanaLB.Text = "Salasana:";
            // 
            // KayttajaLB
            // 
            KayttajaLB.AutoSize = true;
            KayttajaLB.Location = new Point(79, 41);
            KayttajaLB.Name = "KayttajaLB";
            KayttajaLB.Size = new Size(177, 32);
            KayttajaLB.TabIndex = 0;
            KayttajaLB.Text = "Käyttäjätunnus:";
            KayttajaLB.UseWaitCursor = true;
            // 
            // SalasanaOikeinPanel
            // 
            SalasanaOikeinPanel.BackColor = Color.DarkRed;
            SalasanaOikeinPanel.Controls.Add(TervetuloaLabel);
            SalasanaOikeinPanel.Dock = DockStyle.Fill;
            SalasanaOikeinPanel.Font = new Font("Segoe Script", 32.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SalasanaOikeinPanel.ForeColor = Color.Snow;
            SalasanaOikeinPanel.Location = new Point(0, 0);
            SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            SalasanaOikeinPanel.Size = new Size(1371, 900);
            SalasanaOikeinPanel.TabIndex = 1;
            SalasanaOikeinPanel.Visible = false;
            // 
            // TervetuloaLabel
            // 
            TervetuloaLabel.AutoSize = true;
            TervetuloaLabel.Location = new Point(427, 41);
            TervetuloaLabel.Name = "TervetuloaLabel";
            TervetuloaLabel.Size = new Size(513, 71);
            TervetuloaLabel.TabIndex = 0;
            TervetuloaLabel.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(SalasanaOikeinPanel);
            Controls.Add(SalasanaPanel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SalasanaForm";
            Text = "Salasanan tarkastus";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeinPanel.ResumeLayout(false);
            SalasanaOikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private Button TarkistaBT;
        private Label SalasanaLB;
        private Label KayttajaLB;
        private TextBox VirheviestiLB;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Panel SalasanaOikeinPanel;
        private Label TervetuloaLabel;
    }
}