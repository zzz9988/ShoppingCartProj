using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
        //bảng dùng để lưu thông tin chung của khách
namespace ShoppingCart.Models
{
    public class Order
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        [MaxLength(100)]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string Address { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public decimal TotalAmount { get; set; }

        // Mối quan hệ: 1 Đơn hàng (Order) sẽ có nhiều Chi tiết đơn hàng (OrderDetails)
        public List<OrderDetail> OrderDetails { get; set; }
    }
}