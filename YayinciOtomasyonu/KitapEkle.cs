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
    public partial class KitapEkle : Form
    {
        ProjeContext db = new ProjeContext();
        public KitapEkle()
        {
            InitializeComponent();
            KitaplariListele();
            kitapFormuResetle();
        }

        private void kitapFormuResetle()
        {
            txtKitapAd.Clear();
        }

        private void KitaplariListele()
        {
            dgvKitaplar.DataSource = db.Kitaplar.ToList();
            dgvKitaplar.Columns[2].Visible = false;
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string ad = txtKitapAd.Text.Trim();
            if (ad == "")
            {
                MessageBox.Show("Lütfen kitap adı alanını doldurun.");
                return;
            }

            db.Kitaplar.Add(new Kitap()
            {
                Ad = ad,

            });
            db.SaveChanges();
            KitaplariListele();
            kitapFormuResetle();
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek kitap adını seçiniz.");
                return;
            }
            Kitap kitap = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;
            db.Kitaplar.Remove(kitap);

            db.SaveChanges();
            KitaplariListele();
        }
    }
}
