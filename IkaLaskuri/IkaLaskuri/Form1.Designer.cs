namespace IkaLaskuri
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
            SyntymaAikaDT = new DateTimePicker();
            ikaBT = new Button();
            VuosinaLB = new Label();
            KuukausinaLB = new Label();
            PaivinaLB = new Label();
            TunteinaLB = new Label();
            MinuutteinaLB = new Label();
            SekunteinaLB = new Label();
            SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            SyntymaAikaDT.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SyntymaAikaDT.Location = new Point(22, 12);
            SyntymaAikaDT.Name = "SyntymaAikaDT";
            SyntymaAikaDT.Size = new Size(354, 36);
            SyntymaAikaDT.TabIndex = 0;
            // 
            // ikaBT
            // 
            ikaBT.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ikaBT.Location = new Point(402, 12);
            ikaBT.Name = "ikaBT";
            ikaBT.Size = new Size(109, 36);
            ikaBT.TabIndex = 1;
            ikaBT.Text = "Laske";
            ikaBT.UseVisualStyleBackColor = true;
            ikaBT.Click += ikaBT_Click;
            // 
            // VuosinaLB
            // 
            VuosinaLB.AutoSize = true;
            VuosinaLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            VuosinaLB.Location = new Point(22, 51);
            VuosinaLB.Name = "VuosinaLB";
            VuosinaLB.Size = new Size(83, 30);
            VuosinaLB.TabIndex = 2;
            VuosinaLB.Text = "Vuodet";
            VuosinaLB.Visible = false;
            // 
            // KuukausinaLB
            // 
            KuukausinaLB.AutoSize = true;
            KuukausinaLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            KuukausinaLB.Location = new Point(22, 81);
            KuukausinaLB.Name = "KuukausinaLB";
            KuukausinaLB.Size = new Size(116, 30);
            KuukausinaLB.TabIndex = 3;
            KuukausinaLB.Text = "Kuukaudet";
            KuukausinaLB.Visible = false;
            // 
            // PaivinaLB
            // 
            PaivinaLB.AutoSize = true;
            PaivinaLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PaivinaLB.Location = new Point(22, 111);
            PaivinaLB.Name = "PaivinaLB";
            PaivinaLB.Size = new Size(69, 30);
            PaivinaLB.TabIndex = 4;
            PaivinaLB.Text = "Päivät";
            PaivinaLB.Visible = false;
            // 
            // TunteinaLB
            // 
            TunteinaLB.AutoSize = true;
            TunteinaLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TunteinaLB.Location = new Point(22, 141);
            TunteinaLB.Name = "TunteinaLB";
            TunteinaLB.Size = new Size(73, 30);
            TunteinaLB.TabIndex = 5;
            TunteinaLB.Text = "Tunnit";
            TunteinaLB.Visible = false;
            // 
            // MinuutteinaLB
            // 
            MinuutteinaLB.AutoSize = true;
            MinuutteinaLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            MinuutteinaLB.Location = new Point(22, 171);
            MinuutteinaLB.Name = "MinuutteinaLB";
            MinuutteinaLB.Size = new Size(93, 30);
            MinuutteinaLB.TabIndex = 6;
            MinuutteinaLB.Text = "Minuutit";
            MinuutteinaLB.Visible = false;
            // 
            // SekunteinaLB
            // 
            SekunteinaLB.AutoSize = true;
            SekunteinaLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SekunteinaLB.Location = new Point(22, 201);
            SekunteinaLB.Name = "SekunteinaLB";
            SekunteinaLB.Size = new Size(96, 30);
            SekunteinaLB.TabIndex = 7;
            SekunteinaLB.Text = "Sekunnit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SekunteinaLB);
            Controls.Add(MinuutteinaLB);
            Controls.Add(TunteinaLB);
            Controls.Add(PaivinaLB);
            Controls.Add(KuukausinaLB);
            Controls.Add(VuosinaLB);
            Controls.Add(ikaBT);
            Controls.Add(SyntymaAikaDT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Button ikaBT;
        private Label VuosinaLB;
        private Label KuukausinaLB;
        private Label PaivinaLB;
        private Label TunteinaLB;
        private Label MinuutteinaLB;
        private Label SekunteinaLB;
    }
}