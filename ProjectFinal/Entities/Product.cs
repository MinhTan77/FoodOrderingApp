using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectFinal.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Slug { set; get; }
        public string? UrlImage { set; get; }
        public string Description { set; get; }

        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal Price { set; get; }
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal? OriginalPrice { set; get; }

        public string Details { set; get; }
        public int Quantity { set; get; }

        public bool? ProductStatus { get; set; }

        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public Guid CreatedBy { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateUpdated { set; get; }
        public int Status { set; get; }


        public int? CategoryId { set; get; }
        // FK
        public List<OrderDetail> OrderDetails { get; set; }

        public List<Cart> Carts { get; set; }

        public Category Category { get; set; }
    }
}
