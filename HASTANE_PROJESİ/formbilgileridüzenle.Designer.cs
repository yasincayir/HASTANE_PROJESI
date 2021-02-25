
namespace HASTANE_PROJESİ
{
    partial class formbilgileridüzenle
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
            this.butongüncelle = new System.Windows.Forms.Button();
            this.combocinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedcepno = new System.Windows.Forms.MaskedTextBox();
            this.maskedtc = new System.Windows.Forms.MaskedTextBox();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.textad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butongüncelle
            // 
            this.butongüncelle.BackColor = System.Drawing.Color.DarkMagenta;
            this.butongüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butongüncelle.Location = new System.Drawing.Point(134, 187);
            this.butongüncelle.Name = "butongüncelle";
            this.butongüncelle.Size = new System.Drawing.Size(100, 23);
            this.butongüncelle.TabIndex = 26;
            this.butongüncelle.Text = "GÜNCELLE";
            this.butongüncelle.UseVisualStyleBackColor = false;
            this.butongüncelle.Click += new System.EventHandler(this.butongüncelle_Click);
            // 
            // combocinsiyet
            // 
            this.combocinsiyet.FormattingEnabled = true;
            this.combocinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.combocinsiyet.Location = new System.Drawing.Point(348, 138);
            this.combocinsiyet.Name = "combocinsiyet";
            this.combocinsiyet.Size = new System.Drawing.Size(100, 21);
            this.combocinsiyet.TabIndex = 25;
            // 
            // maskedcepno
            // 
            this.maskedcepno.Location = new System.Drawing.Point(348, 93);
            this.maskedcepno.Mask = "(999) 000-0000";
            this.maskedcepno.Name = "maskedcepno";
            this.maskedcepno.Size = new System.Drawing.Size(100, 20);
            this.maskedcepno.TabIndex = 24;
            // 
            // maskedtc
            // 
            this.maskedtc.Location = new System.Drawing.Point(134, 91);
            this.maskedtc.Mask = "00000000000";
            this.maskedtc.Name = "maskedtc";
            this.maskedtc.Size = new System.Drawing.Size(100, 20);
            this.maskedtc.TabIndex = 23;
            this.maskedtc.ValidatingType = typeof(int);
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(134, 138);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(100, 20);
            this.textsifre.TabIndex = 22;
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(348, 47);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(100, 20);
            this.textsoyad.TabIndex = 21;
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(134, 47);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(100, 20);
            this.textad.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(60, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "ŞİFRE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(246, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "CİNSİYET:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(262, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "CEP NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(81, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(266, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "AD:";
            // 
            // formbilgileridüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(517, 266);
            this.Controls.Add(this.butongüncelle);
            this.Controls.Add(this.combocinsiyet);
            this.Controls.Add(this.maskedcepno);
            this.Controls.Add(this.maskedtc);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formbilgileridüzenle";
            this.Text = "formbilgileridüzenle";
            this.Load += new System.EventHandler(this.formbilgileridüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butongüncelle;
        private System.Windows.Forms.ComboBox combocinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedcepno;
        private System.Windows.Forms.MaskedTextBox maskedtc;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}