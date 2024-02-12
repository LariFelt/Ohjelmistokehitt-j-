namespace _20_CRUD
{
    partial class opiskelijaForm
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
            this.idLB = new System.Windows.Forms.Label();
            this.etuLB = new System.Windows.Forms.Label();
            this.sukuLB = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.EnimiTB = new System.Windows.Forms.TextBox();
            this.SnimiTB = new System.Windows.Forms.TextBox();
            this.ONroTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PuhTB = new System.Windows.Forms.TextBox();
            this.opisnroLB = new System.Windows.Forms.Label();
            this.sapoLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.PaivitaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLB.Location = new System.Drawing.Point(9, 8);
            this.idLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(35, 20);
            this.idLB.TabIndex = 0;
            this.idLB.Text = "ID:";
            // 
            // etuLB
            // 
            this.etuLB.AutoSize = true;
            this.etuLB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etuLB.Location = new System.Drawing.Point(9, 35);
            this.etuLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etuLB.Name = "etuLB";
            this.etuLB.Size = new System.Drawing.Size(88, 20);
            this.etuLB.TabIndex = 1;
            this.etuLB.Text = "Etunimi:";
            // 
            // sukuLB
            // 
            this.sukuLB.AutoSize = true;
            this.sukuLB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukuLB.Location = new System.Drawing.Point(9, 62);
            this.sukuLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sukuLB.Name = "sukuLB";
            this.sukuLB.Size = new System.Drawing.Size(104, 20);
            this.sukuLB.TabIndex = 2;
            this.sukuLB.Text = "Sukunimi:";
            this.sukuLB.Click += new System.EventHandler(this.sukuLB_Click);
            // 
            // IdTB
            // 
            this.IdTB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(117, -1);
            this.IdTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(132, 26);
            this.IdTB.TabIndex = 3;
            // 
            // EnimiTB
            // 
            this.EnimiTB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnimiTB.Location = new System.Drawing.Point(117, 29);
            this.EnimiTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnimiTB.Name = "EnimiTB";
            this.EnimiTB.Size = new System.Drawing.Size(132, 26);
            this.EnimiTB.TabIndex = 4;
            // 
            // SnimiTB
            // 
            this.SnimiTB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnimiTB.Location = new System.Drawing.Point(117, 59);
            this.SnimiTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SnimiTB.Name = "SnimiTB";
            this.SnimiTB.Size = new System.Drawing.Size(132, 26);
            this.SnimiTB.TabIndex = 5;
            // 
            // ONroTB
            // 
            this.ONroTB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ONroTB.Location = new System.Drawing.Point(463, 59);
            this.ONroTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ONroTB.Name = "ONroTB";
            this.ONroTB.Size = new System.Drawing.Size(156, 26);
            this.ONroTB.TabIndex = 11;
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.Location = new System.Drawing.Point(463, 29);
            this.EmailTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(156, 26);
            this.EmailTB.TabIndex = 10;
            // 
            // PuhTB
            // 
            this.PuhTB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuhTB.Location = new System.Drawing.Point(463, -1);
            this.PuhTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PuhTB.Name = "PuhTB";
            this.PuhTB.Size = new System.Drawing.Size(156, 26);
            this.PuhTB.TabIndex = 9;
            // 
            // opisnroLB
            // 
            this.opisnroLB.AutoSize = true;
            this.opisnroLB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisnroLB.Location = new System.Drawing.Point(317, 62);
            this.opisnroLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.opisnroLB.Name = "opisnroLB";
            this.opisnroLB.Size = new System.Drawing.Size(141, 20);
            this.opisnroLB.TabIndex = 8;
            this.opisnroLB.Text = "Opiskelijanro:";
            // 
            // sapoLB
            // 
            this.sapoLB.AutoSize = true;
            this.sapoLB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sapoLB.Location = new System.Drawing.Point(317, 35);
            this.sapoLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sapoLB.Name = "sapoLB";
            this.sapoLB.Size = new System.Drawing.Size(118, 20);
            this.sapoLB.TabIndex = 7;
            this.sapoLB.Text = "Sähköposti:";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelinLB.Location = new System.Drawing.Point(317, 8);
            this.puhelinLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(86, 20);
            this.puhelinLB.TabIndex = 6;
            this.puhelinLB.Text = "Puhelin:";
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(13, 95);
            this.TyhjennaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(137, 37);
            this.TyhjennaBT.TabIndex = 12;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // TallennaBT
            // 
            this.TallennaBT.Location = new System.Drawing.Point(164, 95);
            this.TallennaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(117, 37);
            this.TallennaBT.TabIndex = 13;
            this.TallennaBT.Text = "Tallenna";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.Location = new System.Drawing.Point(296, 95);
            this.PaivitaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(118, 37);
            this.PaivitaBT.TabIndex = 14;
            this.PaivitaBT.Text = "Päivitä";
            this.PaivitaBT.UseVisualStyleBackColor = true;
            this.PaivitaBT.Click += new System.EventHandler(this.PaivitaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(428, 95);
            this.PoistaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(118, 37);
            this.PoistaBT.TabIndex = 15;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(13, 148);
            this.TietotauluDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(748, 344);
            this.TietotauluDG.TabIndex = 16;
            this.TietotauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellContentClick);
            // 
            // opiskelijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 433);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.ONroTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PuhTB);
            this.Controls.Add(this.opisnroLB);
            this.Controls.Add(this.sapoLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.SnimiTB);
            this.Controls.Add(this.EnimiTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.sukuLB);
            this.Controls.Add(this.etuLB);
            this.Controls.Add(this.idLB);
            this.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.Name = "opiskelijaForm";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.opiskelijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.Label etuLB;
        private System.Windows.Forms.Label sukuLB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox EnimiTB;
        private System.Windows.Forms.TextBox SnimiTB;
        private System.Windows.Forms.TextBox ONroTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PuhTB;
        private System.Windows.Forms.Label opisnroLB;
        private System.Windows.Forms.Label sapoLB;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.Button PaivitaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.DataGridView TietotauluDG;
    }
}

