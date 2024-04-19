using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavSorusu11C.Models
{
    public class Fabrika
    {
        public static List<Kategori> Kategoriler { get; set; } = new List<Kategori>()
        {
            new Kategori{ Id=1, Ad="Spor", Renk="success"},
            new Kategori{ Id=2, Ad="Müzik", Renk="dark"},
            new Kategori{ Id=3, Ad="Ekonomi", Renk="danger"},
            new Kategori{ Id=4, Ad="Bilişim", Renk="warning"},
            new Kategori{ Id=5, Ad="Etkinlik", Renk="secondary"},
        };
        public static List<Haber> Haberler { get; set; } = new List<Haber>()
        {
            new Haber{ Id=1000, Baslik="Fenerbahçe Kongreye Gitti", 
                Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos est odio corrupti doloribus reprehenderit beatae, aut facilis veritatis! Inventore, modi",
                KategoriId=1, Tarih=DateTime.Now.AddDays(-6), Resim="img3.jpg"
            },new Haber{ Id=1001, Baslik="Keman Çalmak", 
                Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos est odio corrupti doloribus reprehenderit beatae, aut facilis veritatis! Inventore, modi",
                KategoriId=2, Tarih=DateTime.Now.AddDays(-20), Resim="img2.jpg"
            },new Haber{ Id=1002, Baslik="Dolar Biriktirmek", 
                Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos est odio corrupti doloribus reprehenderit beatae, aut facilis veritatis! Inventore, modi",
                KategoriId=3, Tarih=DateTime.Now.AddDays(-30), Resim="img4.jpg"
            },new Haber{ Id=1003, Baslik="Nvidia Altın Çağında", 
                Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos est odio corrupti doloribus reprehenderit beatae, aut facilis veritatis! Inventore, modi",
                KategoriId=4, Tarih=DateTime.Now.AddDays(-3), Resim="img6.jpeg"
            },new Haber{ Id=1004, Baslik="Altın Revaçta", 
                Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos est odio corrupti doloribus reprehenderit beatae, aut facilis veritatis! Inventore, modi",
                KategoriId=3, Tarih=DateTime.Now.AddDays(-5), Resim="img8.jpg"
            },new Haber{ Id=1005, Baslik="Müzik Bibotify", 
                Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos est odio corrupti doloribus reprehenderit beatae, aut facilis veritatis! Inventore, modi",
                KategoriId=2, Tarih=DateTime.Now.AddDays(-5), Resim="img7.jpg"
            },new Haber{ Id=1006, Baslik="23 Nisan Etkinlikleri",
                Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos est odio corrupti doloribus reprehenderit beatae, aut facilis veritatis! Inventore, modi",
                KategoriId=5, Tarih=DateTime.Now.AddDays(-10), Resim="img5.jpg"
            },
        };
    }
}
