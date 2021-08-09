using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YayinciOtomasyonu.Models
{
    public class ProjeContext : DbContext
    {
        public ProjeContext() :base("name=ProjeContext")
        {

        }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }


    }
}
