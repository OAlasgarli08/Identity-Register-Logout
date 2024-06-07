﻿namespace Shofy.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }


    }
}
