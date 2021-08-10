
namespace YayinciOtomasyonu
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
            this.btnYeniYazarEkle = new System.Windows.Forms.Button();
            this.btnYeniKitapEkle = new System.Windows.Forms.Button();
            this.btnKitapYazariAta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeniYazarEkle
            // 
            this.btnYeniYazarEkle.Location = new System.Drawing.Point(102, 44);
            this.btnYeniYazarEkle.Name = "btnYeniYazarEkle";
            this.btnYeniYazarEkle.Size = new System.Drawing.Size(164, 91);
            this.btnYeniYazarEkle.TabIndex = 5;
            this.btnYeniYazarEkle.Text = "Yeni Yazar Ekle";
            this.btnYeniYazarEkle.UseVisualStyleBackColor = true;
            this.btnYeniYazarEkle.Click += new System.EventHandler(this.btnYeniYazarEkle_Click);
            // 
            // btnYeniKitapEkle
            // 
            this.btnYeniKitapEkle.Location = new System.Drawing.Point(102, 152);
            this.btnYeniKitapEkle.Name = "btnYeniKitapEkle";
            this.btnYeniKitapEkle.Size = new System.Drawing.Size(164, 94);
            this.btnYeniKitapEkle.TabIndex = 6;
            this.btnYeniKitapEkle.Text = "Yeni Kitap Ekle";
            this.btnYeniKitapEkle.UseVisualStyleBackColor = true;
            this.btnYeniKitapEkle.Click += new System.EventHandler(this.btnYeniKitapEkle_Click);
            // 
            // btnKitapYazariAta
            // 
            this.btnKitapYazariAta.Location = new System.Drawing.Point(102, 267);
            this.btnKitapYazariAta.Name = "btnKitapYazariAta";
            this.btnKitapYazariAta.Size = new System.Drawing.Size(164, 107);
            this.btnKitapYazariAta.TabIndex = 7;
            this.btnKitapYazariAta.Text = "Kitap Yazarı Tanımla";
            this.btnKitapYazariAta.UseVisualStyleBackColor = true;
            this.btnKitapYazariAta.Click += new System.EventHandler(this.btnKitapYazariAta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 433);
            this.Controls.Add(this.btnKitapYazariAta);
            this.Controls.Add(this.btnYeniKitapEkle);
            this.Controls.Add(this.btnYeniYazarEkle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYeniYazarEkle;
        private System.Windows.Forms.Button btnYeniKitapEkle;
        private System.Windows.Forms.Button btnKitapYazariAta;
    }
}

