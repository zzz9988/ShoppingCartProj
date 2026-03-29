using System.ComponentModel.DataAnnotations;
// bảng quản lí sản phẩm
namespace ShoppingCart.Models
{
    public class Product
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [MaxLength(200)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [MaxLength(255)]
        public string Photo { get; set; }
    }
}