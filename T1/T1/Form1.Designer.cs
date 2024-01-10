namespace T1
{
    partial class T1form
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
            this.otsikkolb = new System.Windows.Forms.Label();
            this.vaihdabt = new System.Windows.Forms.Button();
            this.laskurilb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otsikkolb
            // 
            this.otsikkolb.AutoSize = true;
            this.otsikkolb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkolb.Location = new System.Drawing.Point(64, 45);
            this.otsikkolb.Name = "otsikkolb";
            this.otsikkolb.Size = new System.Drawing.Size(94, 32);
            this.otsikkolb.TabIndex = 0;
            this.otsikkolb.Text = "Otsikko\r\n";
            // 
            // vaihdabt
            // 
            this.vaihdabt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vaihdabt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaihdabt.ForeColor = System.Drawing.Color.Red;
            this.vaihdabt.Location = new System.Drawing.Point(66, 91);
            this.vaihdabt.Name = "vaihdabt";
            this.vaihdabt.Size = new System.Drawing.Size(189, 46);
            this.vaihdabt.TabIndex = 1;
            this.vaihdabt.Text = "Muuta teksti";
            this.vaihdabt.UseVisualStyleBackColor = false;
            this.vaihdabt.Click += new System.EventHandler(this.vaihdabt_Click);
            // 
            // laskurilb
            // 
            this.laskurilb.AutoSize = true;
            this.laskurilb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskurilb.Location = new System.Drawing.Point(253, 45);
            this.laskurilb.Name = "laskurilb";
            this.laskurilb.Size = new System.Drawing.Size(87, 32);
            this.laskurilb.TabIndex = 2;
            this.laskurilb.Text = "Laskuri";
            this.laskurilb.Click += new System.EventHandler(this.label1_Click);
            // 
            // T1form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laskurilb);
            this.Controls.Add(this.vaihdabt);
            this.Controls.Add(this.otsikkolb);
            this.Name = "T1form";
            this.Text = "Tehtävä 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkolb;
        private Button vaihdabt;
        private Label laskurilb;
    }
}