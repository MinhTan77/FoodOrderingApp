using System.ComponentModel.DataAnnotations;

namespace ProjectFinal.Entities
{
    public class OrderDetail
    {
        public int Id { set; get; }
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal Price { set; get; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
