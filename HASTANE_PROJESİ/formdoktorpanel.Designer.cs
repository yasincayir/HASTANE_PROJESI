
namespace HASTANE_PROJESİ
{
    partial class formdoktorpanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.combobrans = new System.Windows.Forms.ComboBox();
            this.maskedtc = new System.Windows.Forms.MaskedTextBox();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butonekle = new System.Windows.Forms.Button();
            this.butonsil = new System.Windows.Forms.Button();
            this.butongüncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "BRANŞ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ŞİFRE:";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(60, 47);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(121, 20);
            this.textad.TabIndex = 5;
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(60, 82);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(121, 20);
            this.textsoyad.TabIndex = 6;
            // 
            // combobrans
            // 
            this.combobrans.FormattingEnabled = true;
            this.combobrans.Location = new System.Drawing.Point(60, 119);
            this.combobrans.Name = "combobrans";
            this.combobrans.Size = new System.Drawing.Size(121, 21);
            this.combobrans.TabIndex = 7;
            // 
            // maskedtc
            // 
            this.maskedtc.Location = new System.Drawing.Point(60, 156);
            this.maskedtc.Mask = "00000000000";
            this.maskedtc.Name = "maskedtc";
            this.maskedtc.Size = new System.Drawing.Size(121, 20);
            this.maskedtc.TabIndex = 8;
            this.maskedtc.ValidatingType = typeof(int);
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(60, 188);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(121, 20);
            this.textsifre.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(154, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "DOKTOR PANELİ";
            // 
            // butonekle
            // 
            this.butonekle.Location = new System.Drawing.Point(60, 214);
            this.butonekle.Name = "butonekle";
            this.butonekle.Size = new System.Drawing.Size(62, 23);
            this.butonekle.TabIndex = 11;
            this.butonekle.Text = "EKLE";
            this.butonekle.UseVisualStyleBackColor = true;
            this.butonekle.Click += new System.EventHandler(this.butonekle_Click);
            // 
            // butonsil
            // 
            this.butonsil.Location = new System.Drawing.Point(128, 214);
            this.butonsil.Name = "butonsil";
            this.butonsil.Size = new System.Drawing.Size(53, 23);
            this.butonsil.TabIndex = 12;
            this.butonsil.Text = "SİL";
            this.butonsil.UseVisualStyleBackColor = true;
            this.butonsil.Click += new System.EventHandler(this.butonsil_Click);
            // 
            // butongüncelle
            // 
            this.butongüncelle.Location = new System.Drawing.Point(60, 243);
            this.butongüncelle.Name = "butongüncelle";
            this.butongüncelle.Size = new System.Drawing.Size(121, 23);
            this.butongüncelle.TabIndex = 13;
            this.butongüncelle.Text = "GÜNCELLE";
            this.butongüncelle.UseVisualStyleBackColor = true;
            this.butongüncelle.Click += new System.EventHandler(this.butongüncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(249, 219);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // formdoktorpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(452, 267);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butongüncelle);
            this.Controls.Add(this.butonsil);
            this.Controls.Add(this.butonekle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.maskedtc);
            this.Controls.Add(this.combobrans);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formdoktorpanel";
            this.Text = "formdoktorpanel";
            this.Load += new System.EventHandler(this.formdoktorpanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.ComboBox combobrans;
        private System.Windows.Forms.MaskedTextBox maskedtc;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butonekle;
        private System.Windows.Forms.Button butonsil;
        private System.Windows.Forms.Button butongüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}