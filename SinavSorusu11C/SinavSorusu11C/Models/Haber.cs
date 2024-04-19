using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavSorusu11C.Models
{
    public class Haber
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public DateTime Tarih { get; set; }

    }
}
