
namespace HASTANE_PROJESİ
{
    partial class formgirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formgirisler));
            this.butonhastagiris = new System.Windows.Forms.Button();
            this.butondoktorgiris = new System.Windows.Forms.Button();
            this.butonsekretergiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butonhastagiris
            // 
            this.butonhastagiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butonhastagiris.BackgroundImage")));
            this.butonhastagiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butonhastagiris.Location = new System.Drawing.Point(74, 33);
            this.butonhastagiris.Name = "butonhastagiris";
            this.butonhastagiris.Size = new System.Drawing.Size(150, 116);
            this.butonhastagiris.TabIndex = 0;
            this.butonhastagiris.UseVisualStyleBackColor = true;
            this.butonhastagiris.Click += new System.EventHandler(this.butonhastagiris_Click);
            // 
            // butondoktorgiris
            // 
            this.butondoktorgiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butondoktorgiris.BackgroundImage")));
            this.butondoktorgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butondoktorgiris.Location = new System.Drawing.Point(288, 33);
            this.butondoktorgiris.Name = "butondoktorgiris";
            this.butondoktorgiris.Size = new System.Drawing.Size(150, 116);
            this.butondoktorgiris.TabIndex = 1;
            this.butondoktorgiris.UseVisualStyleBackColor = true;
            this.butondoktorgiris.Click += new System.EventHandler(this.butondoktorgiris_Click);
            // 
            // butonsekretergiris
            // 
            this.butonsekretergiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butonsekretergiris.BackgroundImage")));
            this.butonsekretergiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butonsekretergiris.Location = new System.Drawing.Point(482, 33);
            this.butonsekretergiris.Name = "butonsekretergiris";
            this.butonsekretergiris.Size = new System.Drawing.Size(150, 116);
            this.butonsekretergiris.TabIndex = 2;
            this.butonsekretergiris.UseVisualStyleBackColor = true;
            this.butonsekretergiris.Click += new System.EventHandler(this.butonsekretergiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(121, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(337, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(528, 155);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEKRETER";
            // 
            // formgirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(681, 219);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butonsekretergiris);
            this.Controls.Add(this.butondoktorgiris);
            this.Controls.Add(this.butonhastagiris);
            this.MaximizeBox = false;
            this.Name = "formgirisler";
            this.Text = "GİRİŞ EKRANI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonhastagiris;
        private System.Windows.Forms.Button butondoktorgiris;
        private System.Windows.Forms.Button butonsekretergiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

