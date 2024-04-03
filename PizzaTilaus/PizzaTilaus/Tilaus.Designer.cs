namespace PizzaTilaus
{
    partial class TilausForm
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
            this.kokoGB = new System.Windows.Forms.GroupBox();
            this.mediumCB = new System.Windows.Forms.CheckBox();
            this.smallCB = new System.Windows.Forms.CheckBox();
            this.largeCB = new System.Windows.Forms.CheckBox();
            this.tayteGB = new System.Windows.Forms.GroupBox();
            this.valkoCB = new System.Windows.Forms.CheckBox();
            this.mozzaCB = new System.Windows.Forms.CheckBox();
            this.parmeCB = new System.Windows.Forms.CheckBox();
            this.juustoCB = new System.Windows.Forms.CheckBox();
            this.FetaCB = new System.Windows.Forms.CheckBox();
            this.auraCB = new System.Windows.Forms.CheckBox();
            this.oliiviCB = new System.Windows.Forms.CheckBox();
            this.sipaliCB = new System.Windows.Forms.CheckBox();
            this.paprikaCB = new System.Windows.Forms.CheckBox();
            this.salaattiCB = new System.Windows.Forms.CheckBox();
            this.rucolaCB = new System.Windows.Forms.CheckBox();
            this.tomaattiCB = new System.Windows.Forms.CheckBox();
            this.jalapenoCB = new System.Windows.Forms.CheckBox();
            this.sieniCB = new System.Windows.Forms.CheckBox();
            this.avokadoCB = new System.Windows.Forms.CheckBox();
            this.ananasCB = new System.Windows.Forms.CheckBox();
            this.kebabCB = new System.Windows.Forms.CheckBox();
            this.tonnikalaCB = new System.Windows.Forms.CheckBox();
            this.kanaCB = new System.Windows.Forms.CheckBox();
            this.katkarapuCB = new System.Windows.Forms.CheckBox();
            this.poroCB = new System.Windows.Forms.CheckBox();
            this.pekoniCB = new System.Windows.Forms.CheckBox();
            this.jauhelihaCB = new System.Windows.Forms.CheckBox();
            this.pepperoniCB = new System.Windows.Forms.CheckBox();
            this.salamiCB = new System.Windows.Forms.CheckBox();
            this.kinkkuCB = new System.Windows.Forms.CheckBox();
            this.juomaGB = new System.Windows.Forms.GroupBox();
            this.vichyCB = new System.Windows.Forms.CheckBox();
            this.vesiCB = new System.Windows.Forms.CheckBox();
            this.pienivichyCB = new System.Windows.Forms.CheckBox();
            this.pienivesiCB = new System.Windows.Forms.CheckBox();
            this.dewCB = new System.Windows.Forms.CheckBox();
            this.upCB = new System.Windows.Forms.CheckBox();
            this.fantaCB = new System.Windows.Forms.CheckBox();
            this.pepemakeCB = new System.Windows.Forms.CheckBox();
            this.pepeCB = new System.Windows.Forms.CheckBox();
            this.pienidewCB = new System.Windows.Forms.CheckBox();
            this.pieniupCB = new System.Windows.Forms.CheckBox();
            this.pienifantaCB = new System.Windows.Forms.CheckBox();
            this.pienpepemakeCB = new System.Windows.Forms.CheckBox();
            this.pienpepeCB = new System.Windows.Forms.CheckBox();
            this.kassaBT = new System.Windows.Forms.Button();
            this.poistuBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.summaTB = new System.Windows.Forms.TextBox();
            this.kokoGB.SuspendLayout();
            this.tayteGB.SuspendLayout();
            this.juomaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // kokoGB
            // 
            this.kokoGB.Controls.Add(this.mediumCB);
            this.kokoGB.Controls.Add(this.smallCB);
            this.kokoGB.Controls.Add(this.largeCB);
            this.kokoGB.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kokoGB.Location = new System.Drawing.Point(12, 12);
            this.kokoGB.Name = "kokoGB";
            this.kokoGB.Size = new System.Drawing.Size(367, 48);
            this.kokoGB.TabIndex = 0;
            this.kokoGB.TabStop = false;
            this.kokoGB.Text = "Koko";
            // 
            // mediumCB
            // 
            this.mediumCB.AutoSize = true;
            this.mediumCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumCB.Location = new System.Drawing.Point(119, 19);
            this.mediumCB.Name = "mediumCB";
            this.mediumCB.Size = new System.Drawing.Size(121, 18);
            this.mediumCB.TabIndex = 1;
            this.mediumCB.Tag = "10.00€";
            this.mediumCB.Text = "Medium (10,00€)";
            this.mediumCB.UseVisualStyleBackColor = true;
            // 
            // smallCB
            // 
            this.smallCB.AutoSize = true;
            this.smallCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallCB.Location = new System.Drawing.Point(8, 19);
            this.smallCB.Name = "smallCB";
            this.smallCB.Size = new System.Drawing.Size(99, 18);
            this.smallCB.TabIndex = 0;
            this.smallCB.Tag = "7.00€";
            this.smallCB.Text = "Small (7,00€)";
            this.smallCB.UseVisualStyleBackColor = true;
            this.smallCB.CheckedChanged += new System.EventHandler(this.smallCB_CheckedChanged);
            // 
            // largeCB
            // 
            this.largeCB.AutoSize = true;
            this.largeCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeCB.Location = new System.Drawing.Point(249, 19);
            this.largeCB.Name = "largeCB";
            this.largeCB.Size = new System.Drawing.Size(106, 18);
            this.largeCB.TabIndex = 2;
            this.largeCB.Tag = "15.00€";
            this.largeCB.Text = "Large (15,00€)";
            this.largeCB.UseVisualStyleBackColor = true;
            // 
            // tayteGB
            // 
            this.tayteGB.Controls.Add(this.valkoCB);
            this.tayteGB.Controls.Add(this.mozzaCB);
            this.tayteGB.Controls.Add(this.parmeCB);
            this.tayteGB.Controls.Add(this.juustoCB);
            this.tayteGB.Controls.Add(this.FetaCB);
            this.tayteGB.Controls.Add(this.auraCB);
            this.tayteGB.Controls.Add(this.oliiviCB);
            this.tayteGB.Controls.Add(this.sipaliCB);
            this.tayteGB.Controls.Add(this.paprikaCB);
            this.tayteGB.Controls.Add(this.salaattiCB);
            this.tayteGB.Controls.Add(this.rucolaCB);
            this.tayteGB.Controls.Add(this.tomaattiCB);
            this.tayteGB.Controls.Add(this.jalapenoCB);
            this.tayteGB.Controls.Add(this.sieniCB);
            this.tayteGB.Controls.Add(this.avokadoCB);
            this.tayteGB.Controls.Add(this.ananasCB);
            this.tayteGB.Controls.Add(this.kebabCB);
            this.tayteGB.Controls.Add(this.tonnikalaCB);
            this.tayteGB.Controls.Add(this.kanaCB);
            this.tayteGB.Controls.Add(this.katkarapuCB);
            this.tayteGB.Controls.Add(this.poroCB);
            this.tayteGB.Controls.Add(this.pekoniCB);
            this.tayteGB.Controls.Add(this.jauhelihaCB);
            this.tayteGB.Controls.Add(this.pepperoniCB);
            this.tayteGB.Controls.Add(this.salamiCB);
            this.tayteGB.Controls.Add(this.kinkkuCB);
            this.tayteGB.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tayteGB.Location = new System.Drawing.Point(12, 66);
            this.tayteGB.Name = "tayteGB";
            this.tayteGB.Size = new System.Drawing.Size(367, 314);
            this.tayteGB.TabIndex = 1;
            this.tayteGB.TabStop = false;
            this.tayteGB.Text = "Täytteet (+1,00€ per)";
            // 
            // valkoCB
            // 
            this.valkoCB.AutoSize = true;
            this.valkoCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valkoCB.Location = new System.Drawing.Point(241, 166);
            this.valkoCB.Name = "valkoCB";
            this.valkoCB.Size = new System.Drawing.Size(90, 18);
            this.valkoCB.TabIndex = 31;
            this.valkoCB.Tag = "1,00€";
            this.valkoCB.Text = "Valkosipuli";
            this.valkoCB.UseVisualStyleBackColor = true;
            this.valkoCB.CheckedChanged += new System.EventHandler(this.valkoCB_CheckedChanged);
            // 
            // mozzaCB
            // 
            this.mozzaCB.AutoSize = true;
            this.mozzaCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mozzaCB.Location = new System.Drawing.Point(241, 140);
            this.mozzaCB.Name = "mozzaCB";
            this.mozzaCB.Size = new System.Drawing.Size(87, 18);
            this.mozzaCB.TabIndex = 30;
            this.mozzaCB.Tag = "1,00€";
            this.mozzaCB.Text = "Mozzarella";
            this.mozzaCB.UseVisualStyleBackColor = true;
            this.mozzaCB.CheckedChanged += new System.EventHandler(this.mozzaCB_CheckedChanged);
            // 
            // parmeCB
            // 
            this.parmeCB.AutoSize = true;
            this.parmeCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parmeCB.Location = new System.Drawing.Point(241, 114);
            this.parmeCB.Name = "parmeCB";
            this.parmeCB.Size = new System.Drawing.Size(87, 18);
            this.parmeCB.TabIndex = 29;
            this.parmeCB.Tag = "1,00€";
            this.parmeCB.Text = "Parmesaani";
            this.parmeCB.UseVisualStyleBackColor = true;
            this.parmeCB.CheckedChanged += new System.EventHandler(this.parmeCB_CheckedChanged);
            // 
            // juustoCB
            // 
            this.juustoCB.AutoSize = true;
            this.juustoCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juustoCB.Location = new System.Drawing.Point(241, 88);
            this.juustoCB.Name = "juustoCB";
            this.juustoCB.Size = new System.Drawing.Size(83, 18);
            this.juustoCB.TabIndex = 28;
            this.juustoCB.Tag = "1,00€";
            this.juustoCB.Text = "Lisäjuusto";
            this.juustoCB.UseVisualStyleBackColor = true;
            this.juustoCB.CheckedChanged += new System.EventHandler(this.juustoCB_CheckedChanged);
            // 
            // FetaCB
            // 
            this.FetaCB.AutoSize = true;
            this.FetaCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FetaCB.Location = new System.Drawing.Point(241, 62);
            this.FetaCB.Name = "FetaCB";
            this.FetaCB.Size = new System.Drawing.Size(49, 18);
            this.FetaCB.TabIndex = 27;
            this.FetaCB.Tag = "1,00€";
            this.FetaCB.Text = "Feta";
            this.FetaCB.UseVisualStyleBackColor = true;
            this.FetaCB.CheckedChanged += new System.EventHandler(this.FetaCB_CheckedChanged);
            // 
            // auraCB
            // 
            this.auraCB.AutoSize = true;
            this.auraCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auraCB.Location = new System.Drawing.Point(241, 36);
            this.auraCB.Name = "auraCB";
            this.auraCB.Size = new System.Drawing.Size(86, 18);
            this.auraCB.TabIndex = 26;
            this.auraCB.Tag = "1,00€";
            this.auraCB.Text = "Aurajuusto";
            this.auraCB.UseVisualStyleBackColor = true;
            this.auraCB.CheckedChanged += new System.EventHandler(this.auraCB_CheckedChanged);
            // 
            // oliiviCB
            // 
            this.oliiviCB.AutoSize = true;
            this.oliiviCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oliiviCB.Location = new System.Drawing.Point(126, 166);
            this.oliiviCB.Name = "oliiviCB";
            this.oliiviCB.Size = new System.Drawing.Size(58, 18);
            this.oliiviCB.TabIndex = 25;
            this.oliiviCB.Tag = "1,00€";
            this.oliiviCB.Text = "Oliivi";
            this.oliiviCB.UseVisualStyleBackColor = true;
            this.oliiviCB.CheckedChanged += new System.EventHandler(this.oliiviCB_CheckedChanged);
            // 
            // sipaliCB
            // 
            this.sipaliCB.AutoSize = true;
            this.sipaliCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sipaliCB.Location = new System.Drawing.Point(126, 192);
            this.sipaliCB.Name = "sipaliCB";
            this.sipaliCB.Size = new System.Drawing.Size(84, 18);
            this.sipaliCB.TabIndex = 24;
            this.sipaliCB.Tag = "1,00€";
            this.sipaliCB.Text = "Punasipuli";
            this.sipaliCB.UseVisualStyleBackColor = true;
            this.sipaliCB.CheckedChanged += new System.EventHandler(this.sipaliCB_CheckedChanged);
            // 
            // paprikaCB
            // 
            this.paprikaCB.AutoSize = true;
            this.paprikaCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paprikaCB.Location = new System.Drawing.Point(126, 218);
            this.paprikaCB.Name = "paprikaCB";
            this.paprikaCB.Size = new System.Drawing.Size(67, 18);
            this.paprikaCB.TabIndex = 23;
            this.paprikaCB.Tag = "1,00€";
            this.paprikaCB.Text = "Paprika";
            this.paprikaCB.UseVisualStyleBackColor = true;
            this.paprikaCB.CheckedChanged += new System.EventHandler(this.paprikaCB_CheckedChanged);
            // 
            // salaattiCB
            // 
            this.salaattiCB.AutoSize = true;
            this.salaattiCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaattiCB.Location = new System.Drawing.Point(126, 243);
            this.salaattiCB.Name = "salaattiCB";
            this.salaattiCB.Size = new System.Drawing.Size(67, 18);
            this.salaattiCB.TabIndex = 22;
            this.salaattiCB.Tag = "1,00€";
            this.salaattiCB.Text = "Salaatti";
            this.salaattiCB.UseVisualStyleBackColor = true;
            this.salaattiCB.CheckedChanged += new System.EventHandler(this.salaattiCB_CheckedChanged);
            // 
            // rucolaCB
            // 
            this.rucolaCB.AutoSize = true;
            this.rucolaCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rucolaCB.Location = new System.Drawing.Point(126, 269);
            this.rucolaCB.Name = "rucolaCB";
            this.rucolaCB.Size = new System.Drawing.Size(65, 18);
            this.rucolaCB.TabIndex = 21;
            this.rucolaCB.Tag = "1,00€";
            this.rucolaCB.Text = "Rucola";
            this.rucolaCB.UseVisualStyleBackColor = true;
            this.rucolaCB.CheckedChanged += new System.EventHandler(this.rucolaCB_CheckedChanged);
            // 
            // tomaattiCB
            // 
            this.tomaattiCB.AutoSize = true;
            this.tomaattiCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomaattiCB.Location = new System.Drawing.Point(126, 140);
            this.tomaattiCB.Name = "tomaattiCB";
            this.tomaattiCB.Size = new System.Drawing.Size(75, 18);
            this.tomaattiCB.TabIndex = 19;
            this.tomaattiCB.Tag = "1,00€";
            this.tomaattiCB.Text = "Tomaatti";
            this.tomaattiCB.UseVisualStyleBackColor = true;
            this.tomaattiCB.CheckedChanged += new System.EventHandler(this.tomaattiCB_CheckedChanged);
            // 
            // jalapenoCB
            // 
            this.jalapenoCB.AutoSize = true;
            this.jalapenoCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jalapenoCB.Location = new System.Drawing.Point(126, 114);
            this.jalapenoCB.Name = "jalapenoCB";
            this.jalapenoCB.Size = new System.Drawing.Size(74, 18);
            this.jalapenoCB.TabIndex = 18;
            this.jalapenoCB.Tag = "1,00€";
            this.jalapenoCB.Text = "Jalapeno";
            this.jalapenoCB.UseVisualStyleBackColor = true;
            this.jalapenoCB.CheckedChanged += new System.EventHandler(this.jalapenoCB_CheckedChanged);
            // 
            // sieniCB
            // 
            this.sieniCB.AutoSize = true;
            this.sieniCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sieniCB.Location = new System.Drawing.Point(126, 88);
            this.sieniCB.Name = "sieniCB";
            this.sieniCB.Size = new System.Drawing.Size(92, 18);
            this.sieniCB.TabIndex = 17;
            this.sieniCB.Tag = "1,00€";
            this.sieniCB.Text = "Herkkusieni";
            this.sieniCB.UseVisualStyleBackColor = true;
            this.sieniCB.CheckedChanged += new System.EventHandler(this.sieniCB_CheckedChanged);
            // 
            // avokadoCB
            // 
            this.avokadoCB.AutoSize = true;
            this.avokadoCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avokadoCB.Location = new System.Drawing.Point(126, 62);
            this.avokadoCB.Name = "avokadoCB";
            this.avokadoCB.Size = new System.Drawing.Size(76, 18);
            this.avokadoCB.TabIndex = 16;
            this.avokadoCB.Tag = "1,00€";
            this.avokadoCB.Text = "Avokado";
            this.avokadoCB.UseVisualStyleBackColor = true;
            this.avokadoCB.CheckedChanged += new System.EventHandler(this.avokadoCB_CheckedChanged);
            // 
            // ananasCB
            // 
            this.ananasCB.AutoSize = true;
            this.ananasCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ananasCB.Location = new System.Drawing.Point(126, 36);
            this.ananasCB.Name = "ananasCB";
            this.ananasCB.Size = new System.Drawing.Size(66, 18);
            this.ananasCB.TabIndex = 15;
            this.ananasCB.Tag = "1,00€";
            this.ananasCB.Text = "Ananas";
            this.ananasCB.UseVisualStyleBackColor = true;
            this.ananasCB.CheckedChanged += new System.EventHandler(this.ananasCB_CheckedChanged);
            // 
            // kebabCB
            // 
            this.kebabCB.AutoSize = true;
            this.kebabCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kebabCB.Location = new System.Drawing.Point(21, 166);
            this.kebabCB.Name = "kebabCB";
            this.kebabCB.Size = new System.Drawing.Size(61, 18);
            this.kebabCB.TabIndex = 14;
            this.kebabCB.Tag = "1,00€";
            this.kebabCB.Text = "Kebab";
            this.kebabCB.UseVisualStyleBackColor = true;
            this.kebabCB.CheckedChanged += new System.EventHandler(this.kebabCB_CheckedChanged);
            // 
            // tonnikalaCB
            // 
            this.tonnikalaCB.AutoSize = true;
            this.tonnikalaCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tonnikalaCB.Location = new System.Drawing.Point(21, 192);
            this.tonnikalaCB.Name = "tonnikalaCB";
            this.tonnikalaCB.Size = new System.Drawing.Size(82, 18);
            this.tonnikalaCB.TabIndex = 13;
            this.tonnikalaCB.Tag = "1,00€";
            this.tonnikalaCB.Text = "Tonnikala";
            this.tonnikalaCB.UseVisualStyleBackColor = true;
            this.tonnikalaCB.CheckedChanged += new System.EventHandler(this.tonnikalaCB_CheckedChanged);
            // 
            // kanaCB
            // 
            this.kanaCB.AutoSize = true;
            this.kanaCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kanaCB.Location = new System.Drawing.Point(21, 217);
            this.kanaCB.Name = "kanaCB";
            this.kanaCB.Size = new System.Drawing.Size(102, 18);
            this.kanaCB.TabIndex = 12;
            this.kanaCB.Tag = "1,00€";
            this.kanaCB.Text = "Pariloitu kana";
            this.kanaCB.UseVisualStyleBackColor = true;
            this.kanaCB.CheckedChanged += new System.EventHandler(this.kanaCB_CheckedChanged);
            // 
            // katkarapuCB
            // 
            this.katkarapuCB.AutoSize = true;
            this.katkarapuCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.katkarapuCB.Location = new System.Drawing.Point(21, 243);
            this.katkarapuCB.Name = "katkarapuCB";
            this.katkarapuCB.Size = new System.Drawing.Size(82, 18);
            this.katkarapuCB.TabIndex = 11;
            this.katkarapuCB.Tag = "1,00€";
            this.katkarapuCB.Text = "Katkarapu";
            this.katkarapuCB.UseVisualStyleBackColor = true;
            this.katkarapuCB.CheckedChanged += new System.EventHandler(this.katkarapuCB_CheckedChanged);
            // 
            // poroCB
            // 
            this.poroCB.AutoSize = true;
            this.poroCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poroCB.Location = new System.Drawing.Point(21, 269);
            this.poroCB.Name = "poroCB";
            this.poroCB.Size = new System.Drawing.Size(78, 18);
            this.poroCB.TabIndex = 10;
            this.poroCB.Tag = "1,00€";
            this.poroCB.Text = "Savuporo";
            this.poroCB.UseVisualStyleBackColor = true;
            this.poroCB.CheckedChanged += new System.EventHandler(this.poroCB_CheckedChanged);
            // 
            // pekoniCB
            // 
            this.pekoniCB.AutoSize = true;
            this.pekoniCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pekoniCB.Location = new System.Drawing.Point(21, 140);
            this.pekoniCB.Name = "pekoniCB";
            this.pekoniCB.Size = new System.Drawing.Size(64, 18);
            this.pekoniCB.TabIndex = 7;
            this.pekoniCB.Tag = "1,00€";
            this.pekoniCB.Text = "Pekoni";
            this.pekoniCB.UseVisualStyleBackColor = true;
            this.pekoniCB.CheckedChanged += new System.EventHandler(this.pekoniCB_CheckedChanged);
            // 
            // jauhelihaCB
            // 
            this.jauhelihaCB.AutoSize = true;
            this.jauhelihaCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jauhelihaCB.Location = new System.Drawing.Point(21, 114);
            this.jauhelihaCB.Name = "jauhelihaCB";
            this.jauhelihaCB.Size = new System.Drawing.Size(78, 18);
            this.jauhelihaCB.TabIndex = 6;
            this.jauhelihaCB.Tag = "1,00€";
            this.jauhelihaCB.Text = "Jauheliha";
            this.jauhelihaCB.UseVisualStyleBackColor = true;
            this.jauhelihaCB.CheckedChanged += new System.EventHandler(this.jauhelihaCB_CheckedChanged);
            // 
            // pepperoniCB
            // 
            this.pepperoniCB.AutoSize = true;
            this.pepperoniCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pepperoniCB.Location = new System.Drawing.Point(21, 88);
            this.pepperoniCB.Name = "pepperoniCB";
            this.pepperoniCB.Size = new System.Drawing.Size(81, 18);
            this.pepperoniCB.TabIndex = 5;
            this.pepperoniCB.Tag = "1.00€";
            this.pepperoniCB.Text = "Pepperoni";
            this.pepperoniCB.UseVisualStyleBackColor = true;
            this.pepperoniCB.CheckedChanged += new System.EventHandler(this.pepperoniCB_CheckedChanged);
            // 
            // salamiCB
            // 
            this.salamiCB.AutoSize = true;
            this.salamiCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salamiCB.Location = new System.Drawing.Point(21, 62);
            this.salamiCB.Name = "salamiCB";
            this.salamiCB.Size = new System.Drawing.Size(63, 18);
            this.salamiCB.TabIndex = 4;
            this.salamiCB.Tag = "1.00€";
            this.salamiCB.Text = "Salami";
            this.salamiCB.UseVisualStyleBackColor = true;
            this.salamiCB.CheckedChanged += new System.EventHandler(this.salamiCB_CheckedChanged);
            // 
            // kinkkuCB
            // 
            this.kinkkuCB.AutoSize = true;
            this.kinkkuCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kinkkuCB.Location = new System.Drawing.Point(21, 36);
            this.kinkkuCB.Name = "kinkkuCB";
            this.kinkkuCB.Size = new System.Drawing.Size(67, 18);
            this.kinkkuCB.TabIndex = 3;
            this.kinkkuCB.Tag = "1.00€";
            this.kinkkuCB.Text = "Kinkku";
            this.kinkkuCB.UseVisualStyleBackColor = true;
            this.kinkkuCB.CheckedChanged += new System.EventHandler(this.kinkkuCB_CheckedChanged);
            // 
            // juomaGB
            // 
            this.juomaGB.Controls.Add(this.vichyCB);
            this.juomaGB.Controls.Add(this.vesiCB);
            this.juomaGB.Controls.Add(this.pienivichyCB);
            this.juomaGB.Controls.Add(this.pienivesiCB);
            this.juomaGB.Controls.Add(this.dewCB);
            this.juomaGB.Controls.Add(this.upCB);
            this.juomaGB.Controls.Add(this.fantaCB);
            this.juomaGB.Controls.Add(this.pepemakeCB);
            this.juomaGB.Controls.Add(this.pepeCB);
            this.juomaGB.Controls.Add(this.pienidewCB);
            this.juomaGB.Controls.Add(this.pieniupCB);
            this.juomaGB.Controls.Add(this.pienifantaCB);
            this.juomaGB.Controls.Add(this.pienpepemakeCB);
            this.juomaGB.Controls.Add(this.pienpepeCB);
            this.juomaGB.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juomaGB.Location = new System.Drawing.Point(385, 12);
            this.juomaGB.Name = "juomaGB";
            this.juomaGB.Size = new System.Drawing.Size(395, 240);
            this.juomaGB.TabIndex = 2;
            this.juomaGB.TabStop = false;
            this.juomaGB.Text = "Juomat";
            // 
            // vichyCB
            // 
            this.vichyCB.AutoSize = true;
            this.vichyCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vichyCB.Location = new System.Drawing.Point(206, 201);
            this.vichyCB.Name = "vichyCB";
            this.vichyCB.Size = new System.Drawing.Size(129, 18);
            this.vichyCB.TabIndex = 33;
            this.vichyCB.Tag = "5,50€";
            this.vichyCB.Text = "Vichy 1,5L (5,50€)";
            this.vichyCB.UseVisualStyleBackColor = true;
            // 
            // vesiCB
            // 
            this.vesiCB.AutoSize = true;
            this.vesiCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vesiCB.Location = new System.Drawing.Point(206, 175);
            this.vesiCB.Name = "vesiCB";
            this.vesiCB.Size = new System.Drawing.Size(152, 18);
            this.vesiCB.TabIndex = 32;
            this.vesiCB.Tag = "5,00€";
            this.vesiCB.Text = "Lähdevesi 1,5L (5,00€)";
            this.vesiCB.UseVisualStyleBackColor = true;
            // 
            // pienivichyCB
            // 
            this.pienivichyCB.AutoSize = true;
            this.pienivichyCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pienivichyCB.Location = new System.Drawing.Point(21, 201);
            this.pienivichyCB.Name = "pienivichyCB";
            this.pienivichyCB.Size = new System.Drawing.Size(129, 18);
            this.pienivichyCB.TabIndex = 31;
            this.pienivichyCB.Tag = "2,50€";
            this.pienivichyCB.Text = "Vichy 0,5L (2,50€)";
            this.pienivichyCB.UseVisualStyleBackColor = true;
            // 
            // pienivesiCB
            // 
            this.pienivesiCB.AutoSize = true;
            this.pienivesiCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pienivesiCB.Location = new System.Drawing.Point(21, 175);
            this.pienivesiCB.Name = "pienivesiCB";
            this.pienivesiCB.Size = new System.Drawing.Size(152, 18);
            this.pienivesiCB.TabIndex = 30;
            this.pienivesiCB.Tag = "2,00€";
            this.pienivesiCB.Text = "Lähdevesi 0,5L (2,00€)";
            this.pienivesiCB.UseVisualStyleBackColor = true;
            // 
            // dewCB
            // 
            this.dewCB.AutoSize = true;
            this.dewCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dewCB.Location = new System.Drawing.Point(206, 149);
            this.dewCB.Name = "dewCB";
            this.dewCB.Size = new System.Drawing.Size(177, 18);
            this.dewCB.TabIndex = 29;
            this.dewCB.Tag = "5,50€";
            this.dewCB.Text = "Mountain Dew 1,5L (5,50€)";
            this.dewCB.UseVisualStyleBackColor = true;
            // 
            // upCB
            // 
            this.upCB.AutoSize = true;
            this.upCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upCB.Location = new System.Drawing.Point(206, 123);
            this.upCB.Name = "upCB";
            this.upCB.Size = new System.Drawing.Size(117, 18);
            this.upCB.TabIndex = 28;
            this.upCB.Tag = "5,50€";
            this.upCB.Text = "7up 1,5L (5,50€)";
            this.upCB.UseVisualStyleBackColor = true;
            // 
            // fantaCB
            // 
            this.fantaCB.AutoSize = true;
            this.fantaCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fantaCB.Location = new System.Drawing.Point(206, 97);
            this.fantaCB.Name = "fantaCB";
            this.fantaCB.Size = new System.Drawing.Size(126, 18);
            this.fantaCB.TabIndex = 27;
            this.fantaCB.Tag = "5,50€";
            this.fantaCB.Text = "Fanta 1,5L (5,50€)";
            this.fantaCB.UseVisualStyleBackColor = true;
            // 
            // pepemakeCB
            // 
            this.pepemakeCB.AutoSize = true;
            this.pepemakeCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pepemakeCB.Location = new System.Drawing.Point(206, 71);
            this.pepemakeCB.Name = "pepemakeCB";
            this.pepemakeCB.Size = new System.Drawing.Size(153, 18);
            this.pepemakeCB.TabIndex = 26;
            this.pepemakeCB.Tag = "5,50€";
            this.pepemakeCB.Text = "Pepsi Max 1,5L (5,50€)";
            this.pepemakeCB.UseVisualStyleBackColor = true;
            // 
            // pepeCB
            // 
            this.pepeCB.AutoSize = true;
            this.pepeCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pepeCB.Location = new System.Drawing.Point(206, 45);
            this.pepeCB.Name = "pepeCB";
            this.pepeCB.Size = new System.Drawing.Size(125, 18);
            this.pepeCB.TabIndex = 25;
            this.pepeCB.Tag = "5,50€";
            this.pepeCB.Text = "Pepsi 1,5L (5,50€)";
            this.pepeCB.UseVisualStyleBackColor = true;
            // 
            // pienidewCB
            // 
            this.pienidewCB.AutoSize = true;
            this.pienidewCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pienidewCB.Location = new System.Drawing.Point(21, 149);
            this.pienidewCB.Name = "pienidewCB";
            this.pienidewCB.Size = new System.Drawing.Size(177, 18);
            this.pienidewCB.TabIndex = 24;
            this.pienidewCB.Tag = "2,50€";
            this.pienidewCB.Text = "Mountain Dew 0,5L (2,50€)";
            this.pienidewCB.UseVisualStyleBackColor = true;
            // 
            // pieniupCB
            // 
            this.pieniupCB.AutoSize = true;
            this.pieniupCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieniupCB.Location = new System.Drawing.Point(21, 123);
            this.pieniupCB.Name = "pieniupCB";
            this.pieniupCB.Size = new System.Drawing.Size(117, 18);
            this.pieniupCB.TabIndex = 23;
            this.pieniupCB.Tag = "2,50€";
            this.pieniupCB.Text = "7up 0,5L (2,50€)";
            this.pieniupCB.UseVisualStyleBackColor = true;
            // 
            // pienifantaCB
            // 
            this.pienifantaCB.AutoSize = true;
            this.pienifantaCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pienifantaCB.Location = new System.Drawing.Point(21, 97);
            this.pienifantaCB.Name = "pienifantaCB";
            this.pienifantaCB.Size = new System.Drawing.Size(126, 18);
            this.pienifantaCB.TabIndex = 22;
            this.pienifantaCB.Tag = "2,50€";
            this.pienifantaCB.Text = "Fanta 0,5L (2,50€)";
            this.pienifantaCB.UseVisualStyleBackColor = true;
            // 
            // pienpepemakeCB
            // 
            this.pienpepemakeCB.AutoSize = true;
            this.pienpepemakeCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pienpepemakeCB.Location = new System.Drawing.Point(21, 71);
            this.pienpepemakeCB.Name = "pienpepemakeCB";
            this.pienpepemakeCB.Size = new System.Drawing.Size(153, 18);
            this.pienpepemakeCB.TabIndex = 21;
            this.pienpepemakeCB.Tag = "2,50€";
            this.pienpepemakeCB.Text = "Pepsi Max 0,5L (2,50€)";
            this.pienpepemakeCB.UseVisualStyleBackColor = true;
            // 
            // pienpepeCB
            // 
            this.pienpepeCB.AutoSize = true;
            this.pienpepeCB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pienpepeCB.Location = new System.Drawing.Point(21, 45);
            this.pienpepeCB.Name = "pienpepeCB";
            this.pienpepeCB.Size = new System.Drawing.Size(125, 18);
            this.pienpepeCB.TabIndex = 20;
            this.pienpepeCB.Tag = "2,50€";
            this.pienpepeCB.Text = "Pepsi 0,5L (2,50€)";
            this.pienpepeCB.UseVisualStyleBackColor = true;
            // 
            // kassaBT
            // 
            this.kassaBT.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kassaBT.Location = new System.Drawing.Point(435, 309);
            this.kassaBT.Name = "kassaBT";
            this.kassaBT.Size = new System.Drawing.Size(93, 32);
            this.kassaBT.TabIndex = 3;
            this.kassaBT.Text = "Kassalle";
            this.kassaBT.UseVisualStyleBackColor = true;
            this.kassaBT.Click += new System.EventHandler(this.kassaBT_Click);
            // 
            // poistuBT
            // 
            this.poistuBT.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistuBT.Location = new System.Drawing.Point(534, 348);
            this.poistuBT.Name = "poistuBT";
            this.poistuBT.Size = new System.Drawing.Size(93, 32);
            this.poistuBT.TabIndex = 4;
            this.poistuBT.Text = "Poistu";
            this.poistuBT.UseVisualStyleBackColor = true;
            this.poistuBT.Click += new System.EventHandler(this.poistuBT_Click);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaBT.Location = new System.Drawing.Point(435, 348);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(93, 32);
            this.tyhjennaBT.TabIndex = 5;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yhteensä:";
            // 
            // summaTB
            // 
            this.summaTB.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaTB.Location = new System.Drawing.Point(523, 258);
            this.summaTB.Name = "summaTB";
            this.summaTB.Size = new System.Drawing.Size(80, 26);
            this.summaTB.TabIndex = 7;
            this.summaTB.TextChanged += new System.EventHandler(this.summaTB_TextChanged);
            // 
            // TilausForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(791, 477);
            this.Controls.Add(this.summaTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.poistuBT);
            this.Controls.Add(this.kassaBT);
            this.Controls.Add(this.juomaGB);
            this.Controls.Add(this.tayteGB);
            this.Controls.Add(this.kokoGB);
            this.Name = "TilausForm";
            this.Text = "Tilaus";
            this.kokoGB.ResumeLayout(false);
            this.kokoGB.PerformLayout();
            this.tayteGB.ResumeLayout(false);
            this.tayteGB.PerformLayout();
            this.juomaGB.ResumeLayout(false);
            this.juomaGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox kokoGB;
        private System.Windows.Forms.CheckBox mediumCB;
        private System.Windows.Forms.CheckBox smallCB;
        private System.Windows.Forms.CheckBox largeCB;
        private System.Windows.Forms.GroupBox tayteGB;
        private System.Windows.Forms.CheckBox kebabCB;
        private System.Windows.Forms.CheckBox tonnikalaCB;
        private System.Windows.Forms.CheckBox kanaCB;
        private System.Windows.Forms.CheckBox katkarapuCB;
        private System.Windows.Forms.CheckBox poroCB;
        private System.Windows.Forms.CheckBox pekoniCB;
        private System.Windows.Forms.CheckBox jauhelihaCB;
        private System.Windows.Forms.CheckBox pepperoniCB;
        private System.Windows.Forms.CheckBox salamiCB;
        private System.Windows.Forms.CheckBox kinkkuCB;
        private System.Windows.Forms.GroupBox juomaGB;
        private System.Windows.Forms.CheckBox mozzaCB;
        private System.Windows.Forms.CheckBox parmeCB;
        private System.Windows.Forms.CheckBox juustoCB;
        private System.Windows.Forms.CheckBox FetaCB;
        private System.Windows.Forms.CheckBox auraCB;
        private System.Windows.Forms.CheckBox oliiviCB;
        private System.Windows.Forms.CheckBox sipaliCB;
        private System.Windows.Forms.CheckBox paprikaCB;
        private System.Windows.Forms.CheckBox salaattiCB;
        private System.Windows.Forms.CheckBox rucolaCB;
        private System.Windows.Forms.CheckBox tomaattiCB;
        private System.Windows.Forms.CheckBox jalapenoCB;
        private System.Windows.Forms.CheckBox sieniCB;
        private System.Windows.Forms.CheckBox avokadoCB;
        private System.Windows.Forms.CheckBox ananasCB;
        private System.Windows.Forms.CheckBox vichyCB;
        private System.Windows.Forms.CheckBox vesiCB;
        private System.Windows.Forms.CheckBox pienivichyCB;
        private System.Windows.Forms.CheckBox pienivesiCB;
        private System.Windows.Forms.CheckBox dewCB;
        private System.Windows.Forms.CheckBox upCB;
        private System.Windows.Forms.CheckBox fantaCB;
        private System.Windows.Forms.CheckBox pepemakeCB;
        private System.Windows.Forms.CheckBox pepeCB;
        private System.Windows.Forms.CheckBox pienidewCB;
        private System.Windows.Forms.CheckBox pieniupCB;
        private System.Windows.Forms.CheckBox pienifantaCB;
        private System.Windows.Forms.CheckBox pienpepemakeCB;
        private System.Windows.Forms.CheckBox pienpepeCB;
        private System.Windows.Forms.Button kassaBT;
        private System.Windows.Forms.Button poistuBT;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.CheckBox valkoCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox summaTB;
    }
}