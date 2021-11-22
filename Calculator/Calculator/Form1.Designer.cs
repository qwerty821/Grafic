namespace Calculator {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.zero = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.trei = new System.Windows.Forms.Button();
            this.doi = new System.Windows.Forms.Button();
            this.unu = new System.Windows.Forms.Button();
            this.inmultit = new System.Windows.Forms.Button();
            this.sase = new System.Windows.Forms.Button();
            this.cinci = new System.Windows.Forms.Button();
            this.patru = new System.Windows.Forms.Button();
            this.impartit = new System.Windows.Forms.Button();
            this.noua = new System.Windows.Forms.Button();
            this.opt = new System.Windows.Forms.Button();
            this.sapte = new System.Windows.Forms.Button();
            this.egal = new System.Windows.Forms.Button();
            this.button_c = new System.Windows.Forms.Button();
            this.button_ce = new System.Windows.Forms.Button();
            this.ecran = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zero
            // 
            this.zero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Location = new System.Drawing.Point(44, 283);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(106, 50);
            this.zero.TabIndex = 0;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cifra);
            // 
            // virgula
            // 
            this.virgula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.virgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.virgula.Location = new System.Drawing.Point(156, 283);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(50, 50);
            this.virgula.TabIndex = 2;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.plus.Location = new System.Drawing.Point(212, 283);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 50);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.semn_click);
            // 
            // minus
            // 
            this.minus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.minus.Location = new System.Drawing.Point(212, 227);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 50);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.semn_click);
            // 
            // trei
            // 
            this.trei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trei.Location = new System.Drawing.Point(156, 227);
            this.trei.Name = "trei";
            this.trei.Size = new System.Drawing.Size(50, 50);
            this.trei.TabIndex = 6;
            this.trei.Text = "3";
            this.trei.UseVisualStyleBackColor = true;
            this.trei.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cifra);
            // 
            // doi
            // 
            this.doi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doi.Location = new System.Drawing.Point(100, 227);
            this.doi.Name = "doi";
            this.doi.Size = new System.Drawing.Size(50, 50);
            this.doi.TabIndex = 5;
            this.doi.Text = "2";
            this.doi.UseVisualStyleBackColor = true;
            this.doi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cifra);
            // 
            // unu
            // 
            this.unu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unu.Location = new System.Drawing.Point(44, 227);
            this.unu.Name = "unu";
            this.unu.Size = new System.Drawing.Size(50, 50);
            this.unu.TabIndex = 4;
            this.unu.Text = "1";
            this.unu.UseVisualStyleBackColor = true;
            this.unu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cifra);
            // 
            // inmultit
            // 
            this.inmultit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inmultit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inmultit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inmultit.Location = new System.Drawing.Point(212, 171);
            this.inmultit.Name = "inmultit";
            this.inmultit.Size = new System.Drawing.Size(50, 50);
            this.inmultit.TabIndex = 11;
            this.inmultit.Text = "*";
            this.inmultit.UseVisualStyleBackColor = true;
            this.inmultit.Click += new System.EventHandler(this.semn_click);
            // 
            // sase
            // 
            this.sase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sase.Location = new System.Drawing.Point(156, 171);
            this.sase.Name = "sase";
            this.sase.Size = new System.Drawing.Size(50, 50);
            this.sase.TabIndex = 10;
            this.sase.Text = "6";
            this.sase.UseVisualStyleBackColor = true;
            this.sase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cifra);
            // 
            // cinci
            // 
            this.cinci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cinci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinci.Location = new System.Drawing.Point(100, 171);
            this.cinci.Name = "cinci";
            this.cinci.Size = new System.Drawing.Size(50, 50);
            this.cinci.TabIndex = 9;
            this.cinci.Text = "5";
            this.cinci.UseVisualStyleBackColor = true;
            this.cinci.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cifra);
            // 
            // patru
            // 
            this.patru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patru.Location = new System.Drawing.Point(44, 171);
            this.patru.Name = "patru";
            this.patru.Size = new System.Drawing.Size(50, 50);
            this.patru.TabIndex = 8;
            this.patru.Text = "4";
            this.patru.UseVisualStyleBackColor = true;
            this.patru.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cifra);
            // 
            // impartit
            // 
            this.impartit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.impartit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impartit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.impartit.Location = new System.Drawing.Point(212, 115);
            this.impartit.Name = "impartit";
            this.impartit.Size = new System.Drawing.Size(50, 50);
            this.impartit.TabIndex = 15;
            this.impartit.Text = "/";
            this.impartit.UseVisualStyleBackColor = true;
            this.impartit.Click += new System.EventHandler(this.semn_click);
            // 
            // noua
            // 
            this.noua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noua.Location = new System.Drawing.Point(156, 115);
            this.noua.Name = "noua";
            this.noua.Size = new System.Drawing.Size(50, 50);
            this.noua.TabIndex = 14;
            this.noua.Text = "9";
            this.noua.UseVisualStyleBackColor = true;
            this.noua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cifra);
            // 
            // opt
            // 
            this.opt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt.Location = new System.Drawing.Point(100, 115);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(50, 50);
            this.opt.TabIndex = 13;
            this.opt.Text = "8";
            this.opt.UseVisualStyleBackColor = true;
            this.opt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cifra);
            // 
            // sapte
            // 
            this.sapte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sapte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sapte.Location = new System.Drawing.Point(44, 115);
            this.sapte.Name = "sapte";
            this.sapte.Size = new System.Drawing.Size(50, 50);
            this.sapte.TabIndex = 12;
            this.sapte.Text = "7";
            this.sapte.UseVisualStyleBackColor = true;
            this.sapte.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cifra);
            // 
            // egal
            // 
            this.egal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.egal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.egal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.egal.Location = new System.Drawing.Point(268, 227);
            this.egal.Name = "egal";
            this.egal.Size = new System.Drawing.Size(50, 106);
            this.egal.TabIndex = 16;
            this.egal.Text = "=";
            this.egal.UseVisualStyleBackColor = true;
            this.egal.Click += new System.EventHandler(this.rezultat);
            // 
            // button_c
            // 
            this.button_c.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c.Location = new System.Drawing.Point(268, 171);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(50, 50);
            this.button_c.TabIndex = 17;
            this.button_c.Text = "C";
            this.button_c.UseVisualStyleBackColor = true;
            this.button_c.Click += new System.EventHandler(this.button_c_Click);
            // 
            // button_ce
            // 
            this.button_ce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ce.Location = new System.Drawing.Point(268, 115);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(50, 50);
            this.button_ce.TabIndex = 18;
            this.button_ce.Text = "CE";
            this.button_ce.UseVisualStyleBackColor = true;
            // 
            // ecran
            // 
            this.ecran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ecran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ecran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ecran.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ecran.Location = new System.Drawing.Point(44, 43);
            this.ecran.Name = "ecran";
            this.ecran.Size = new System.Drawing.Size(274, 69);
            this.ecran.TabIndex = 19;
            this.ecran.Text = "0";
            this.ecran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 360);
            this.Controls.Add(this.ecran);
            this.Controls.Add(this.button_ce);
            this.Controls.Add(this.button_c);
            this.Controls.Add(this.egal);
            this.Controls.Add(this.impartit);
            this.Controls.Add(this.noua);
            this.Controls.Add(this.opt);
            this.Controls.Add(this.sapte);
            this.Controls.Add(this.inmultit);
            this.Controls.Add(this.sase);
            this.Controls.Add(this.cinci);
            this.Controls.Add(this.patru);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.trei);
            this.Controls.Add(this.doi);
            this.Controls.Add(this.unu);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.zero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button trei;
        private System.Windows.Forms.Button doi;
        private System.Windows.Forms.Button unu;
        private System.Windows.Forms.Button inmultit;
        private System.Windows.Forms.Button sase;
        private System.Windows.Forms.Button cinci;
        private System.Windows.Forms.Button patru;
        private System.Windows.Forms.Button impartit;
        private System.Windows.Forms.Button noua;
        private System.Windows.Forms.Button opt;
        private System.Windows.Forms.Button sapte;
        private System.Windows.Forms.Button egal;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Button button_ce;
        private System.Windows.Forms.Label ecran;
    }
}

