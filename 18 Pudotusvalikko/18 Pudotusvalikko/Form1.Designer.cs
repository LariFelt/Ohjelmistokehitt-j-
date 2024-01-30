namespace _18_Pudotusvalikko
{
    partial class AvainhenkilotForm
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
            this.oppilaitoksetCB = new System.Windows.Forms.ComboBox();
            this.vastuuhloCB = new System.Windows.Forms.ComboBox();
            this.oppilaitosLB = new System.Windows.Forms.Label();
            this.henkiloLB = new System.Windows.Forms.Label();
            this.katuosoiteLB = new System.Windows.Forms.Label();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.sijaintiLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oppilaitoksetCB
            // 
            this.oppilaitoksetCB.FormattingEnabled = true;
            this.oppilaitoksetCB.Location = new System.Drawing.Point(12, 42);
            this.oppilaitoksetCB.Name = "oppilaitoksetCB";
            this.oppilaitoksetCB.Size = new System.Drawing.Size(121, 23);
            this.oppilaitoksetCB.TabIndex = 0;
            this.oppilaitoksetCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitoksetCB_SelectedIndexChanged);
            // 
            // vastuuhloCB
            // 
            this.vastuuhloCB.FormattingEnabled = true;
            this.vastuuhloCB.Location = new System.Drawing.Point(248, 42);
            this.vastuuhloCB.Name = "vastuuhloCB";
            this.vastuuhloCB.Size = new System.Drawing.Size(121, 23);
            this.vastuuhloCB.TabIndex = 1;
            this.vastuuhloCB.SelectedIndexChanged += new System.EventHandler(this.vastuuhloCB_SelectedIndexChanged);
            this.vastuuhloCB.TextChanged += new System.EventHandler(this.vastuuhloCB_TextChanged);
            // 
            // oppilaitosLB
            // 
            this.oppilaitosLB.AutoSize = true;
            this.oppilaitosLB.Location = new System.Drawing.Point(12, 9);
            this.oppilaitosLB.Name = "oppilaitosLB";
            this.oppilaitosLB.Size = new System.Drawing.Size(98, 15);
            this.oppilaitosLB.TabIndex = 2;
            this.oppilaitosLB.Text = "Valitse oppilaitos:";
            // 
            // henkiloLB
            // 
            this.henkiloLB.AutoSize = true;
            this.henkiloLB.Location = new System.Drawing.Point(248, 9);
            this.henkiloLB.Name = "henkiloLB";
            this.henkiloLB.Size = new System.Drawing.Size(120, 15);
            this.henkiloLB.TabIndex = 3;
            this.henkiloLB.Text = "Valitse vastuuhenkilö:";
            // 
            // katuosoiteLB
            // 
            this.katuosoiteLB.AutoSize = true;
            this.katuosoiteLB.Location = new System.Drawing.Point(12, 79);
            this.katuosoiteLB.Name = "katuosoiteLB";
            this.katuosoiteLB.Size = new System.Drawing.Size(41, 15);
            this.katuosoiteLB.TabIndex = 4;
            this.katuosoiteLB.Text = "Osoite";
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Location = new System.Drawing.Point(12, 109);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.Size = new System.Drawing.Size(75, 15);
            this.PostinumeroLB.TabIndex = 5;
            this.PostinumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(12, 139);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(95, 15);
            this.PostitoimipaikkaLB.TabIndex = 6;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(12, 169);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(47, 15);
            this.PuhelinLB.TabIndex = 7;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Location = new System.Drawing.Point(248, 79);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(36, 15);
            this.titteliLB.TabIndex = 8;
            this.titteliLB.Text = "Titteli";
            // 
            // sijaintiLB
            // 
            this.sijaintiLB.AutoSize = true;
            this.sijaintiLB.Location = new System.Drawing.Point(248, 109);
            this.sijaintiLB.Name = "sijaintiLB";
            this.sijaintiLB.Size = new System.Drawing.Size(43, 15);
            this.sijaintiLB.TabIndex = 9;
            this.sijaintiLB.Text = "Osasto";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(248, 139);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(65, 15);
            this.emailLB.TabIndex = 10;
            this.emailLB.Text = "Sähköposti";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Location = new System.Drawing.Point(248, 169);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(47, 15);
            this.phoneLB.TabIndex = 11;
            this.phoneLB.Text = "Puhelin";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 289);
            this.Controls.Add(this.phoneLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.sijaintiLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.PostinumeroLB);
            this.Controls.Add(this.katuosoiteLB);
            this.Controls.Add(this.henkiloLB);
            this.Controls.Add(this.oppilaitosLB);
            this.Controls.Add(this.vastuuhloCB);
            this.Controls.Add(this.oppilaitoksetCB);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox oppilaitoksetCB;
        private ComboBox vastuuhloCB;
        private Label oppilaitosLB;
        private Label henkiloLB;
        private Label katuosoiteLB;
        private Label PostinumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label titteliLB;
        private Label sijaintiLB;
        private Label emailLB;
        private Label phoneLB;
    }
}