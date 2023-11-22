namespace class_ile_basit_hesap_makinesi_836
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.rbT = new System.Windows.Forms.RadioButton();
            this.rbCi = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbBol = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSonuclar = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(46, 212);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(150, 88);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Sonucu Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // rbT
            // 
            this.rbT.AutoSize = true;
            this.rbT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbT.Location = new System.Drawing.Point(46, 117);
            this.rbT.Name = "rbT";
            this.rbT.Size = new System.Drawing.Size(76, 28);
            this.rbT.TabIndex = 1;
            this.rbT.TabStop = true;
            this.rbT.Text = "Topla";
            this.rbT.UseVisualStyleBackColor = false;
            // 
            // rbCi
            // 
            this.rbCi.AutoSize = true;
            this.rbCi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCi.Location = new System.Drawing.Point(229, 117);
            this.rbCi.Name = "rbCi";
            this.rbCi.Size = new System.Drawing.Size(70, 28);
            this.rbCi.TabIndex = 2;
            this.rbCi.TabStop = true;
            this.rbCi.Text = "Çıkar";
            this.rbCi.UseVisualStyleBackColor = false;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbC.Location = new System.Drawing.Point(46, 165);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(68, 28);
            this.rbC.TabIndex = 3;
            this.rbC.TabStop = true;
            this.rbC.Text = "Çarp";
            this.rbC.UseVisualStyleBackColor = false;
            // 
            // rbBol
            // 
            this.rbBol.AutoSize = true;
            this.rbBol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBol.Location = new System.Drawing.Point(229, 165);
            this.rbBol.Name = "rbBol";
            this.rbBol.Size = new System.Drawing.Size(55, 28);
            this.rbBol.TabIndex = 4;
            this.rbBol.TabStop = true;
            this.rbBol.Text = "Böl";
            this.rbBol.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "1.Sayı";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.Red;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSonuc.Location = new System.Drawing.Point(225, 212);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(65, 24);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Sonuç";
            // 
            // txtS1
            // 
            this.txtS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtS1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtS1.Location = new System.Drawing.Point(108, 11);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(203, 26);
            this.txtS1.TabIndex = 7;
            // 
            // txtS2
            // 
            this.txtS2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtS2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtS2.Location = new System.Drawing.Point(108, 62);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(203, 26);
            this.txtS2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "2. Sayı";
            // 
            // lbSonuclar
            // 
            this.lbSonuclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbSonuclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSonuclar.ForeColor = System.Drawing.Color.White;
            this.lbSonuclar.FormattingEnabled = true;
            this.lbSonuclar.ItemHeight = 20;
            this.lbSonuclar.Location = new System.Drawing.Point(532, 40);
            this.lbSonuclar.Name = "lbSonuclar";
            this.lbSonuclar.Size = new System.Drawing.Size(234, 324);
            this.lbSonuclar.TabIndex = 10;
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktar.Location = new System.Drawing.Point(352, 212);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(150, 88);
            this.btnAktar.TabIndex = 11;
            this.btnAktar.Text = "Sonucu Aktar";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(528, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sonuçlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(818, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lbSonuclar);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbBol);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbCi);
            this.Controls.Add(this.rbT);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RadioButton rbT;
        private System.Windows.Forms.RadioButton rbCi;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbBol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbSonuclar;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Label label2;
    }
}

