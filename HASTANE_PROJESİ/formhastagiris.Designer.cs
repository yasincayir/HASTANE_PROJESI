﻿
namespace HASTANE_PROJESİ
{
    partial class formhastagiris
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
            this.butongirisyap = new System.Windows.Forms.Button();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.linküyeol = new System.Windows.Forms.LinkLabel();
            this.maskedtcno = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(120, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "HASTA GİRİŞ PANELİ";
            // 
            // butongirisyap
            // 
            this.butongirisyap.Location = new System.Drawing.Point(170, 133);
            this.butongirisyap.Name = "butongirisyap";
            this.butongirisyap.Size = new System.Drawing.Size(129, 23);
            this.butongirisyap.TabIndex = 6;
            this.butongirisyap.Text = "GİRİŞ YAP";
            this.butongirisyap.UseVisualStyleBackColor = true;
            this.butongirisyap.Click += new System.EventHandler(this.butongirisyap_Click);
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(170, 97);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(203, 20);
            this.textsifre.TabIndex = 5;
            this.textsifre.UseSystemPasswordChar = true;
            // 
            // linküyeol
            // 
            this.linküyeol.AutoSize = true;
            this.linküyeol.Location = new System.Drawing.Point(379, 104);
            this.linküyeol.Name = "linküyeol";
            this.linküyeol.Size = new System.Drawing.Size(46, 13);
            this.linküyeol.TabIndex = 7;
            this.linküyeol.TabStop = true;
            this.linküyeol.Text = "ÜYE OL";
            this.linküyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linküyeol_LinkClicked);
            // 
            // maskedtcno
            // 
            this.maskedtcno.Location = new System.Drawing.Point(171, 66);
            this.maskedtcno.Mask = "00000000000";
            this.maskedtcno.Name = "maskedtcno";
            this.maskedtcno.Size = new System.Drawing.Size(202, 20);
            this.maskedtcno.TabIndex = 4;
            this.maskedtcno.ValidatingType = typeof(int);
            // 
            // formhastagiris
            // 
            this.AcceptButton = this.butongirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(510, 206);
            this.Controls.Add(this.maskedtcno);
            this.Controls.Add(this.butongirisyap);
            this.Controls.Add(this.linküyeol);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formhastagiris";
            this.Text = "formhastagiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butongirisyap;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.LinkLabel linküyeol;
        private System.Windows.Forms.MaskedTextBox maskedtcno;
    }
}