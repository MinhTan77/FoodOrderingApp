using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectFinal.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }

        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal Price { set; get; }

        public Guid UserId { get; set; }

        public Product Product { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
