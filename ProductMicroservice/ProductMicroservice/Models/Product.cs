﻿namespace ProductMicroservice.Models.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string CategoryId { get; set; }
    }
}
