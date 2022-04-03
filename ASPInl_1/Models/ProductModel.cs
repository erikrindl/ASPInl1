using System.ComponentModel.DataAnnotations;

namespace ASPMVC.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
