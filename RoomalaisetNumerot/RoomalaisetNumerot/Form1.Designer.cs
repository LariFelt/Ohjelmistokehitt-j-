namespace RoomalaisetNumerot
{
    partial class RoomalaisiksiForm
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
            numeroLB = new Label();
            OtsikkoLB = new Label();
            TekstiTB = new TextBox();
            VastausLB = new Label();
            MuutaBT = new Button();
            SuspendLayout();
            // 
            // numeroLB
            // 
            numeroLB.AutoSize = true;
            numeroLB.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numeroLB.Location = new Point(34, 110);
            numeroLB.Name = "numeroLB";
            numeroLB.Size = new Size(519, 19);
            numeroLB.TabIndex = 0;
            numeroLB.Text = "Anna numero välillä 1-3999, niin muutan sen roomalaiseksi:";
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            OtsikkoLB.Location = new Point(202, 32);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(386, 38);
            OtsikkoLB.TabIndex = 1;
            OtsikkoLB.Text = "Roomalaiset numerot";
            // 
            // TekstiTB
            // 
            TekstiTB.Location = new Point(559, 105);
            TekstiTB.Name = "TekstiTB";
            TekstiTB.Size = new Size(100, 30);
            TekstiTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            VastausLB.Location = new Point(34, 168);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(138, 34);
            VastausLB.TabIndex = 3;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            MuutaBT.Location = new Point(559, 165);
            MuutaBT.Name = "MuutaBT";
            MuutaBT.Size = new Size(100, 37);
            MuutaBT.TabIndex = 4;
            MuutaBT.Text = "Muuta";
            MuutaBT.UseVisualStyleBackColor = true;
            MuutaBT.Click += MuutaBT_Click;
            // 
            // RoomalaisiksiForm
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 236);
            Controls.Add(MuutaBT);
            Controls.Add(VastausLB);
            Controls.Add(TekstiTB);
            Controls.Add(OtsikkoLB);
            Controls.Add(numeroLB);
            Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "RoomalaisiksiForm";
            Text = "Numeroiden muutos  roomalaisiksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numeroLB;
        private Label OtsikkoLB;
        private TextBox TekstiTB;
        private Label VastausLB;
        private Button MuutaBT;
    }
}