using System.ComponentModel.DataAnnotations;

namespace ProjectFinal.Models
{
    public class UpdateProductViewModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string? UrlImage { set; get; }
        public string? Description { set; get; }
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal Price { set; get; }
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal? OriginalPrice { set; get; }

        public string Details { set; get; }
        public int Quantity { set; get; }

        public int Stock { set; get; }


        public int? CategoryId { set; get; }
    }
}
