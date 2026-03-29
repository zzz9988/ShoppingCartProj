using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// tạo bảng chi tiết đơn hàng của khách
namespace ShoppingCart.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        // Khóa ngoại liên kết với bảng Order
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        // Lưu ID của sản phẩm khách mua
        public int ProductId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}