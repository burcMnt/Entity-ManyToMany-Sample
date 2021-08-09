using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YayinciOtomasyonu.Models
{ 
    [Table("Kitaplar")]
    public class Kitap
    {
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string Ad { get; set; }
        public virtual ICollection<Yazar> Yazarlar { get; set; } = new HashSet<Yazar>();
    }
}
