namespace Autokululaskuri
{
    partial class KustannusForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            LainaTB = new TextBox();
            NesteetTB = new TextBox();
            VakuutuksetTB = new TextBox();
            MuutKulutTB = new TextBox();
            PolttonesteTB = new TextBox();
            PesutTB = new TextBox();
            HuollotTB = new TextBox();
            RenkaatTB = new TextBox();
            KilometritCB = new ComboBox();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 39);
            label1.TabIndex = 0;
            label1.Text = "Auton kustannuslaskuri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 85);
            label2.Name = "label2";
            label2.Size = new Size(202, 39);
            label2.TabIndex = 1;
            label2.Text = "Lainan lyhennys korkoineen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 124);
            label3.Name = "label3";
            label3.Size = new Size(161, 39);
            label3.TabIndex = 2;
            label3.Text = "Lisättävät nesteet yms:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 163);
            label4.Name = "label4";
            label4.Size = new Size(133, 39);
            label4.TabIndex = 3;
            label4.Text = "Vakuutusmaksut:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 202);
            label5.Name = "label5";
            label5.Size = new Size(97, 39);
            label5.TabIndex = 4;
            label5.Text = "Muut kulut:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 241);
            label6.Name = "label6";
            label6.Size = new Size(88, 39);
            label6.TabIndex = 5;
            label6.Text = "Polttoneste:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 85);
            label7.Name = "label7";
            label7.Size = new Size(55, 39);
            label7.TabIndex = 6;
            label7.Text = "Pesut:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 124);
            label8.Name = "label8";
            label8.Size = new Size(69, 39);
            label8.TabIndex = 7;
            label8.Text = "Huollot:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(473, 163);
            label9.Name = "label9";
            label9.Size = new Size(75, 39);
            label9.TabIndex = 8;
            label9.Text = "Renkaat:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(473, 202);
            label10.Name = "label10";
            label10.Size = new Size(120, 39);
            label10.TabIndex = 9;
            label10.Text = "Kilometrit/vuosi";
            // 
            // LainaTB
            // 
            LainaTB.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LainaTB.Location = new Point(296, 88);
            LainaTB.Name = "LainaTB";
            LainaTB.Size = new Size(77, 35);
            LainaTB.TabIndex = 10;
            // 
            // NesteetTB
            // 
            NesteetTB.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NesteetTB.Location = new Point(296, 127);
            NesteetTB.Name = "NesteetTB";
            NesteetTB.Size = new Size(77, 35);
            NesteetTB.TabIndex = 11;
            // 
            // VakuutuksetTB
            // 
            VakuutuksetTB.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            VakuutuksetTB.Location = new Point(296, 166);
            VakuutuksetTB.Name = "VakuutuksetTB";
            VakuutuksetTB.Size = new Size(77, 35);
            VakuutuksetTB.TabIndex = 12;
            // 
            // MuutKulutTB
            // 
            MuutKulutTB.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MuutKulutTB.Location = new Point(296, 205);
            MuutKulutTB.Name = "MuutKulutTB";
            MuutKulutTB.Size = new Size(77, 35);
            MuutKulutTB.TabIndex = 13;
            // 
            // PolttonesteTB
            // 
            PolttonesteTB.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PolttonesteTB.Location = new Point(296, 244);
            PolttonesteTB.Name = "PolttonesteTB";
            PolttonesteTB.Size = new Size(77, 35);
            PolttonesteTB.TabIndex = 14;
            // 
            // PesutTB
            // 
            PesutTB.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PesutTB.Location = new Point(599, 89);
            PesutTB.Name = "PesutTB";
            PesutTB.Size = new Size(78, 35);
            PesutTB.TabIndex = 15;
            // 
            // HuollotTB
            // 
            HuollotTB.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HuollotTB.Location = new Point(599, 129);
            HuollotTB.Name = "HuollotTB";
            HuollotTB.Size = new Size(78, 35);
            HuollotTB.TabIndex = 16;
            // 
            // RenkaatTB
            // 
            RenkaatTB.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RenkaatTB.Location = new Point(599, 166);
            RenkaatTB.Name = "RenkaatTB";
            RenkaatTB.Size = new Size(78, 35);
            RenkaatTB.TabIndex = 17;
            // 
            // KilometritCB
            // 
            KilometritCB.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KilometritCB.FormattingEnabled = true;
            KilometritCB.Items.AddRange(new object[] { "5000", "10000", "15000", "20000", "25000", "30000", "35000", "40000", "45000", "50000", "55000", "60000", "65000", "70000", "75000", "80000", "85000", "90000", "95000", "100000" });
            KilometritCB.Location = new Point(599, 207);
            KilometritCB.Name = "KilometritCB";
            KilometritCB.Size = new Size(78, 37);
            KilometritCB.TabIndex = 18;
            KilometritCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(88, 303);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(68, 39);
            VastausLB.TabIndex = 19;
            VastausLB.Text = "Vastaus";
            VastausLB.TextAlign = ContentAlignment.BottomRight;
            VastausLB.Visible = false;
            // 
            // KustannusForm
            // 
            AutoScaleDimensions = new SizeF(9F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 420);
            Controls.Add(VastausLB);
            Controls.Add(KilometritCB);
            Controls.Add(RenkaatTB);
            Controls.Add(HuollotTB);
            Controls.Add(PesutTB);
            Controls.Add(PolttonesteTB);
            Controls.Add(MuutKulutTB);
            Controls.Add(VakuutuksetTB);
            Controls.Add(NesteetTB);
            Controls.Add(LainaTB);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Gabriola", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 8, 4, 8);
            Name = "KustannusForm";
            Text = "v";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox LainaTB;
        private TextBox NesteetTB;
        private TextBox VakuutuksetTB;
        private TextBox MuutKulutTB;
        private TextBox PolttonesteTB;
        private TextBox PesutTB;
        private TextBox HuollotTB;
        private TextBox RenkaatTB;
        private ComboBox KilometritCB;
        private Label VastausLB;
    }
}