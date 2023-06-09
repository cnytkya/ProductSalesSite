﻿using UrunSatisSitesi.Entities;

namespace UrunSatisSitesi.WebUI.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public HomePageViewModel()
        {
            Sliders = new List<Slider>();
            Products = new List<Product>();
        }
    }
}
