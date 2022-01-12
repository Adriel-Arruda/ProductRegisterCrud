using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductRegisterCrud.Models
{
    [Table("Product")]
    public class Product
    {
        [Display(Name ="Id")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        [Column("ProductName")]
        public string ProductName{ get; set; }

        [Display(Name = "Amount")]
        [Column("ProductAmount")]
        public int ProductAmount { get; set; }
    }
}
