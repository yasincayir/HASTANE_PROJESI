
namespace HASTANE_PROJESİ
{
    partial class formbranspanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butongüncelle = new System.Windows.Forms.Button();
            this.butonsil = new System.Windows.Forms.Button();
            this.butonekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textbransad = new System.Windows.Forms.TextBox();
            this.textbransid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(260, 200);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // butongüncelle
            // 
            this.butongüncelle.Location = new System.Drawing.Point(97, 183);
            this.butongüncelle.Name = "butongüncelle";
            this.butongüncelle.Size = new System.Drawing.Size(121, 23);
            this.butongüncelle.TabIndex = 28;
            this.butongüncelle.Text = "GÜNCELLE";
            this.butongüncelle.UseVisualStyleBackColor = true;
            this.butongüncelle.Click += new System.EventHandler(this.butongüncelle_Click);
            // 
            // butonsil
            // 
            this.butonsil.Location = new System.Drawing.Point(165, 142);
            this.butonsil.Name = "butonsil";
            this.butonsil.Size = new System.Drawing.Size(53, 23);
            this.butonsil.TabIndex = 27;
            this.butonsil.Text = "SİL";
            this.butonsil.UseVisualStyleBackColor = true;
            this.butonsil.Click += new System.EventHandler(this.butonsil_Click);
            // 
            // butonekle
            // 
            this.butonekle.Location = new System.Drawing.Point(97, 142);
            this.butonekle.Name = "butonekle";
            this.butonekle.Size = new System.Drawing.Size(62, 23);
            this.butonekle.TabIndex = 26;
            this.butonekle.Text = "EKLE";
            this.butonekle.UseVisualStyleBackColor = true;
            this.butonekle.Click += new System.EventHandler(this.butonekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(157, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "BRANŞ PANELİ";
            // 
            // textbransad
            // 
            this.textbransad.Location = new System.Drawing.Point(97, 80);
            this.textbransad.Name = "textbransad";
            this.textbransad.Size = new System.Drawing.Size(121, 20);
            this.textbransad.TabIndex = 21;
            // 
            // textbransid
            // 
            this.textbransid.Location = new System.Drawing.Point(97, 45);
            this.textbransid.Name = "textbransid";
            this.textbransid.Size = new System.Drawing.Size(121, 20);
            this.textbransid.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "BRANŞ AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "BRANŞ İD:";
            // 
            // formbranspanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(510, 270);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butongüncelle);
            this.Controls.Add(this.butonsil);
            this.Controls.Add(this.butonekle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbransad);
            this.Controls.Add(this.textbransid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formbranspanel";
            this.Text = "formbranspanel";
            this.Load += new System.EventHandler(this.formbranspanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butongüncelle;
        private System.Windows.Forms.Button butonsil;
        private System.Windows.Forms.Button butonekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbransad;
        private System.Windows.Forms.TextBox textbransid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}