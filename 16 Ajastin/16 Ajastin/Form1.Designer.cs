namespace _16_Ajastin
{
    partial class ajastinForm
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
            this.minuuttiLB = new System.Windows.Forms.Label();
            this.sekuntiLB = new System.Windows.Forms.Label();
            this.minuutitCB = new System.Windows.Forms.ComboBox();
            this.sekunnitCB = new System.Windows.Forms.ComboBox();
            this.aikaLB = new System.Windows.Forms.Label();
            this.kaynnistaBT = new System.Windows.Forms.Button();
            this.pysaytaBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minuuttiLB
            // 
            this.minuuttiLB.AutoSize = true;
            this.minuuttiLB.Location = new System.Drawing.Point(71, 22);
            this.minuuttiLB.Name = "minuuttiLB";
            this.minuuttiLB.Size = new System.Drawing.Size(88, 25);
            this.minuuttiLB.TabIndex = 0;
            this.minuuttiLB.Text = "Minuutit:";
            // 
            // sekuntiLB
            // 
            this.sekuntiLB.AutoSize = true;
            this.sekuntiLB.Location = new System.Drawing.Point(177, 22);
            this.sekuntiLB.Name = "sekuntiLB";
            this.sekuntiLB.Size = new System.Drawing.Size(89, 25);
            this.sekuntiLB.TabIndex = 1;
            this.sekuntiLB.Text = "Sekunnit:";
            this.sekuntiLB.Click += new System.EventHandler(this.sekuntiLB_Click);
            // 
            // minuutitCB
            // 
            this.minuutitCB.FormattingEnabled = true;
            this.minuutitCB.Location = new System.Drawing.Point(71, 60);
            this.minuutitCB.Name = "minuutitCB";
            this.minuutitCB.Size = new System.Drawing.Size(88, 33);
            this.minuutitCB.TabIndex = 2;
            // 
            // sekunnitCB
            // 
            this.sekunnitCB.FormattingEnabled = true;
            this.sekunnitCB.Location = new System.Drawing.Point(177, 60);
            this.sekunnitCB.Name = "sekunnitCB";
            this.sekunnitCB.Size = new System.Drawing.Size(89, 33);
            this.sekunnitCB.TabIndex = 3;
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(75, 116);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(191, 86);
            this.aikaLB.TabIndex = 4;
            this.aikaLB.Text = "00:00";
            // 
            // kaynnistaBT
            // 
            this.kaynnistaBT.Location = new System.Drawing.Point(71, 205);
            this.kaynnistaBT.Name = "kaynnistaBT";
            this.kaynnistaBT.Size = new System.Drawing.Size(92, 47);
            this.kaynnistaBT.TabIndex = 5;
            this.kaynnistaBT.Text = "Start";
            this.kaynnistaBT.UseVisualStyleBackColor = true;
            this.kaynnistaBT.Click += new System.EventHandler(this.kaynnistaBT_Click);
            // 
            // pysaytaBT
            // 
            this.pysaytaBT.Location = new System.Drawing.Point(179, 205);
            this.pysaytaBT.Name = "pysaytaBT";
            this.pysaytaBT.Size = new System.Drawing.Size(87, 47);
            this.pysaytaBT.TabIndex = 6;
            this.pysaytaBT.Text = "Stop";
            this.pysaytaBT.UseVisualStyleBackColor = true;
            this.pysaytaBT.Click += new System.EventHandler(this.pysaytaBT_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ajastinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 284);
            this.Controls.Add(this.pysaytaBT);
            this.Controls.Add(this.kaynnistaBT);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.sekunnitCB);
            this.Controls.Add(this.minuutitCB);
            this.Controls.Add(this.sekuntiLB);
            this.Controls.Add(this.minuuttiLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ajastinForm";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.ajastinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label minuuttiLB;
        private Label sekuntiLB;
        private ComboBox minuutitCB;
        private ComboBox sekunnitCB;
        private Label aikaLB;
        private Button kaynnistaBT;
        private Button pysaytaBT;
        private System.Windows.Forms.Timer timer1;
    }
}