using System.Collections.Generic;

namespace ProjectFinal.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Slug { set; get; }
        public int? ParentId { set; get; }

        public bool Status { set; get; }
        public List<Product> Products { get; set; }
    }
}
