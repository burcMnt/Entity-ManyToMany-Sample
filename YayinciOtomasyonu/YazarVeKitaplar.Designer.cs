
namespace YayinciOtomasyonu
{
    partial class YazarVeKitaplar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.lstYazarinKitaplari = new System.Windows.Forms.ListBox();
            this.btnKitapAta = new System.Windows.Forms.Button();
            this.cboYazar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKitap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKitapSil);
            this.groupBox1.Controls.Add(this.lstYazarinKitaplari);
            this.groupBox1.Controls.Add(this.btnKitapAta);
            this.groupBox1.Controls.Add(this.cboYazar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboKitap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 498);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kütüphane";
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Location = new System.Drawing.Point(484, 433);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(148, 28);
            this.btnKitapSil.TabIndex = 6;
            this.btnKitapSil.Text = "Kitap Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // lstYazarinKitaplari
            // 
            this.lstYazarinKitaplari.DisplayMember = "Ad";
            this.lstYazarinKitaplari.FormattingEnabled = true;
            this.lstYazarinKitaplari.ItemHeight = 16;
            this.lstYazarinKitaplari.Location = new System.Drawing.Point(55, 87);
            this.lstYazarinKitaplari.Name = "lstYazarinKitaplari";
            this.lstYazarinKitaplari.Size = new System.Drawing.Size(577, 340);
            this.lstYazarinKitaplari.TabIndex = 5;
            this.lstYazarinKitaplari.ValueMember = "Id";
            // 
            // btnKitapAta
            // 
            this.btnKitapAta.Location = new System.Drawing.Point(473, 53);
            this.btnKitapAta.Name = "btnKitapAta";
            this.btnKitapAta.Size = new System.Drawing.Size(159, 28);
            this.btnKitapAta.TabIndex = 4;
            this.btnKitapAta.Text = "Yazara Kitap Ata";
            this.btnKitapAta.UseVisualStyleBackColor = true;
            this.btnKitapAta.Click += new System.EventHandler(this.btnKitapAta_Click);
            // 
            // cboYazar
            // 
            this.cboYazar.DisplayMember = "Ad";
            this.cboYazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYazar.FormattingEnabled = true;
            this.cboYazar.Location = new System.Drawing.Point(55, 52);
            this.cboYazar.Name = "cboYazar";
            this.cboYazar.Size = new System.Drawing.Size(203, 24);
            this.cboYazar.TabIndex = 1;
            this.cboYazar.ValueMember = "Id";
            this.cboYazar.SelectedIndexChanged += new System.EventHandler(this.cboYazar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar";
            // 
            // cboKitap
            // 
            this.cboKitap.DisplayMember = "Ad";
            this.cboKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKitap.FormattingEnabled = true;
            this.cboKitap.Location = new System.Drawing.Point(264, 53);
            this.cboKitap.Name = "cboKitap";
            this.cboKitap.Size = new System.Drawing.Size(203, 24);
            this.cboKitap.TabIndex = 3;
            this.cboKitap.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap";
            // 
            // YazarVeKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 512);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "YazarVeKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YazarVeKitaplar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstYazarinKitaplari;
        private System.Windows.Forms.Button btnKitapAta;
        private System.Windows.Forms.ComboBox cboYazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKitapSil;
    }
}