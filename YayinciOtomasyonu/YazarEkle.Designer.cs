
namespace YayinciOtomasyonu
{
    partial class YazarEkle
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
            this.btnYazarSil = new System.Windows.Forms.Button();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvYazarlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYazarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYazarSil
            // 
            this.btnYazarSil.Location = new System.Drawing.Point(319, 409);
            this.btnYazarSil.Name = "btnYazarSil";
            this.btnYazarSil.Size = new System.Drawing.Size(105, 23);
            this.btnYazarSil.TabIndex = 9;
            this.btnYazarSil.Text = "SİL";
            this.btnYazarSil.UseVisualStyleBackColor = true;
            this.btnYazarSil.Click += new System.EventHandler(this.btnYazarSil_Click);
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Location = new System.Drawing.Point(319, 47);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(105, 23);
            this.btnYazarEkle.TabIndex = 7;
            this.btnYazarEkle.Text = "EKLE";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(88, 48);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(167, 22);
            this.txtYazarAd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yazar Adı";
            // 
            // dgvYazarlar
            // 
            this.dgvYazarlar.AllowUserToAddRows = false;
            this.dgvYazarlar.AllowUserToDeleteRows = false;
            this.dgvYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYazarlar.Location = new System.Drawing.Point(88, 76);
            this.dgvYazarlar.MultiSelect = false;
            this.dgvYazarlar.Name = "dgvYazarlar";
            this.dgvYazarlar.RowHeadersVisible = false;
            this.dgvYazarlar.RowHeadersWidth = 51;
            this.dgvYazarlar.RowTemplate.Height = 24;
            this.dgvYazarlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYazarlar.Size = new System.Drawing.Size(336, 327);
            this.dgvYazarlar.TabIndex = 10;
            // 
            // YazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 443);
            this.Controls.Add(this.dgvYazarlar);
            this.Controls.Add(this.btnYazarSil);
            this.Controls.Add(this.btnYazarEkle);
            this.Controls.Add(this.txtYazarAd);
            this.Controls.Add(this.label1);
            this.Name = "YazarEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YazarEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYazarlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYazarSil;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvYazarlar;
    }
}