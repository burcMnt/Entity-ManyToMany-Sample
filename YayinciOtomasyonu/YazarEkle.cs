using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YayinciOtomasyonu.Models;

namespace YayinciOtomasyonu
{
    public partial class YazarEkle : Form
    {
        ProjeContext db = new ProjeContext();
        public YazarEkle()
        {
            InitializeComponent();
            YazarlariListele();
            YazarFormuResetle();
        }

        private void YazarFormuResetle()
        {
            txtYazarAd.Clear();
            

        }

        private void YazarlariListele()
        {
            dgvYazarlar.DataSource = db.Yazarlar.ToList();
            dgvYazarlar.Columns[2].Visible = false;
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            string ad = txtYazarAd.Text.Trim();
            if (ad == "")
            {
                MessageBox.Show("Lütfen yazar adı alanını doldurun.");
                return;
            }
            db.Yazarlar.Add(new Yazar()
            {
                Ad = ad
            });
            db.SaveChanges();
            YazarlariListele();
            YazarFormuResetle();
        }

        private void btnYazarSil_Click(object sender, EventArgs e)
        {
            if (dgvYazarlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek yazar adını seçiniz.");
                return;
            }

            Yazar yazar = (Yazar)dgvYazarlar.SelectedRows[0].DataBoundItem;
            db.Yazarlar.Remove(yazar);
            db.SaveChanges();
            YazarlariListele();
        }
    }
}
