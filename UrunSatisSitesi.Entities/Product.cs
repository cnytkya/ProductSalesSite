﻿using System.ComponentModel.DataAnnotations;

namespace UrunSatisSitesi.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş Geçilemez!")]
        public string Name { get; set; }
        [Display(Name = "Açıklama"), DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        [Display(Name = "Resim")]
        public string? Image { get; set; }
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
        [Display(Name = "Ürün Kodu")]
        public string? ProductCode { get; set; }
        [Display(Name = "Stok")]
        public int Stock { get; set; }
        [Display(Name = "Aktif?")]
        public bool IsActive { get; set; }
        [Display(Name = "Anasayfa?")]
        public bool IsHome { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori")]
        public virtual Category? Category { get; set; } // 1 ürünün 1 tane kategorisi olabilir (Bire Bir ilişki türü)
        [Display(Name = "Marka")]
        public int BrandId { get; set; }
        [Display(Name = "Marka")]
        public virtual Brand? Brand { get; set; } // 1 ürünün 1 tane markası olabilir (Bire Bir ilişki türü)

    }
}
