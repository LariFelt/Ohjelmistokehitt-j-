namespace _15._Sekuntikello
{
    partial class SekuntikelloForm
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
            this.components = new System.ComponentModel.Container();
            this.SekkariLB = new System.Windows.Forms.Label();
            this.kaynnistaBT = new System.Windows.Forms.Button();
            this.pysaytaBT = new System.Windows.Forms.Button();
            this.nollaaBT = new System.Windows.Forms.Button();
            this.ajastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SekkariLB
            // 
            this.SekkariLB.AutoSize = true;
            this.SekkariLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SekkariLB.Location = new System.Drawing.Point(29, 23);
            this.SekkariLB.Name = "SekkariLB";
            this.SekkariLB.Size = new System.Drawing.Size(394, 86);
            this.SekkariLB.TabIndex = 0;
            this.SekkariLB.Text = "00:00:00.000";
            // 
            // kaynnistaBT
            // 
            this.kaynnistaBT.Location = new System.Drawing.Point(56, 150);
            this.kaynnistaBT.Name = "kaynnistaBT";
            this.kaynnistaBT.Size = new System.Drawing.Size(75, 23);
            this.kaynnistaBT.TabIndex = 1;
            this.kaynnistaBT.Text = "Start";
            this.kaynnistaBT.UseVisualStyleBackColor = true;
            this.kaynnistaBT.Click += new System.EventHandler(this.kaynnistaBT_Click);
            // 
            // pysaytaBT
            // 
            this.pysaytaBT.Location = new System.Drawing.Point(194, 150);
            this.pysaytaBT.Name = "pysaytaBT";
            this.pysaytaBT.Size = new System.Drawing.Size(75, 23);
            this.pysaytaBT.TabIndex = 2;
            this.pysaytaBT.Text = "Stop";
            this.pysaytaBT.UseVisualStyleBackColor = true;
            this.pysaytaBT.Click += new System.EventHandler(this.pysaytaBT_Click);
            // 
            // nollaaBT
            // 
            this.nollaaBT.Location = new System.Drawing.Point(329, 150);
            this.nollaaBT.Name = "nollaaBT";
            this.nollaaBT.Size = new System.Drawing.Size(75, 23);
            this.nollaaBT.TabIndex = 3;
            this.nollaaBT.Text = "Reset";
            this.nollaaBT.UseVisualStyleBackColor = true;
            this.nollaaBT.Click += new System.EventHandler(this.nollaaBT_Click);
            // 
            // ajastinTM
            // 
            this.ajastinTM.Enabled = true;
            this.ajastinTM.Tick += new System.EventHandler(this.ajastinTM_Tick);
            // 
            // SekuntikelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 248);
            this.Controls.Add(this.nollaaBT);
            this.Controls.Add(this.pysaytaBT);
            this.Controls.Add(this.kaynnistaBT);
            this.Controls.Add(this.SekkariLB);
            this.Name = "SekuntikelloForm";
            this.Text = "Sekuntikello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SekkariLB;
        private Button kaynnistaBT;
        private Button pysaytaBT;
        private Button nollaaBT;
        private System.Windows.Forms.Timer ajastinTM;
    }
}