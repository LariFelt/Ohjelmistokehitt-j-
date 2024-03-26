namespace PizzaTilaus
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tilaaBT = new System.Windows.Forms.Button();
            this.poisBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza tilaus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tilaaBT
            // 
            this.tilaaBT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tilaaBT.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilaaBT.Location = new System.Drawing.Point(125, 161);
            this.tilaaBT.Name = "tilaaBT";
            this.tilaaBT.Size = new System.Drawing.Size(208, 69);
            this.tilaaBT.TabIndex = 1;
            this.tilaaBT.Text = "Tilaamaan";
            this.tilaaBT.UseVisualStyleBackColor = false;
            this.tilaaBT.Click += new System.EventHandler(this.tilaaBT_Click);
            // 
            // poisBT
            // 
            this.poisBT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.poisBT.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poisBT.Location = new System.Drawing.Point(125, 264);
            this.poisBT.Name = "poisBT";
            this.poisBT.Size = new System.Drawing.Size(208, 77);
            this.poisBT.TabIndex = 2;
            this.poisBT.Text = "Poistu";
            this.poisBT.UseVisualStyleBackColor = false;
            this.poisBT.Click += new System.EventHandler(this.poisBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(451, 414);
            this.Controls.Add(this.poisBT);
            this.Controls.Add(this.tilaaBT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tilaaBT;
        private System.Windows.Forms.Button poisBT;
    }
}

