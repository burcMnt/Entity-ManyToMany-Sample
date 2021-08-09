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
    public partial class Form1 : Form
    {
        ProjeContext db = new ProjeContext();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnYeniYazarEkle_Click(object sender, EventArgs e)
        {
            YazarEkle yazarForm = new YazarEkle();
            yazarForm.ShowDialog();
        }

        private void btnYeniKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapForm = new KitapEkle();
            kitapForm.ShowDialog();
        }

        private void btnKitapYazariAta_Click(object sender, EventArgs e)
        {
            YazarVeKitaplar yazarKitap = new YazarVeKitaplar();
            yazarKitap.ShowDialog();
        }
    }
}
