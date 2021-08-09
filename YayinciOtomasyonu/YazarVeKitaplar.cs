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
    public partial class YazarVeKitaplar : Form
    {
        ProjeContext db = new ProjeContext();
        public YazarVeKitaplar()
        {
            InitializeComponent();
            Listele();
            formuResetle();
        }

        private void formuResetle()
        {
            cboKitap.SelectedIndex = cboYazar.SelectedIndex = -1;
            lstYazarinKitaplari.SelectedIndex = -1;
        }

        private void Listele()
        {
            cboKitap.DataSource = db.Kitaplar.ToList();
            cboYazar.DataSource = db.Yazarlar.ToList();
        }

        private void btnKitapAta_Click(object sender, EventArgs e)
        {
            lstYazarinKitaplari.DisplayMember = "Ad";
            Yazar yazar = (Yazar)cboYazar.SelectedItem;
            Kitap kitap = (Kitap)cboKitap.SelectedItem;
            if (yazar == null || kitap == null)
            {
                MessageBox.Show("Lütfen eklenicek yazar ve kitabı seçiniz.");
                return;
            }
            yazar.Kitaplar.Add(kitap);
            db.SaveChanges();
            lstYazarinKitaplari.DataSource = yazar.Kitaplar.ToList();
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            Yazar yazar = (Yazar)cboYazar.SelectedItem;
            Kitap kitap = (Kitap)lstYazarinKitaplari.SelectedItem;
            if (yazar == null || kitap == null)
            {
                MessageBox.Show("Lütfen silinecek yazar ve kitabı seçiniz.");
                return;
            }
            yazar.Kitaplar.Remove(kitap);
            db.SaveChanges();
            lstYazarinKitaplari.DataSource = yazar.Kitaplar.OrderBy(x=> x.Ad).ToList();
        }

        private void cboYazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboKitap.SelectedIndex = -1;
            if (cboYazar.SelectedIndex==-1)
            {
                lstYazarinKitaplari.DataSource = null;
            }
            else
            {
            Yazar yazar = (Yazar)cboYazar.SelectedItem;
            lstYazarinKitaplari.DataSource = yazar.Kitaplar.OrderBy(x => x.Ad).ToList();
            }
        }
    }
}
