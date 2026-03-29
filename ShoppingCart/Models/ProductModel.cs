//using System.Collections.Generic;
//using System.Linq;

//namespace ShoppingCart.Models
//{
//    public class ProductModel
//    {
//        private List<CartItem> products;

//        // Constructor khởi tạo danh sách sản phẩm
//        public ProductModel()
//        {
//            this.products = new List<CartItem>()
//            {
//                new CartItem {
//                    Id = 1,
//                    Name = "Balo chống gù lưng",
//                    Price = 120000,
//                    Photo = "item1.jpg"
//                },
//                new CartItem {
//                    Id = 2,
//                    Name = "Mũ tai bèo hươu cao cổ",
//                    Price = 320000,
//                    Photo = "item2.jpg"
//                },
//                new CartItem {
//                    Id = 3,
//                    Name = "Thắt lưng trẻ em",
//                    Price = 110000,
//                    Photo = "item3.jpg"
//                },
//                new CartItem {
//                    Id = 4,
//                    Name = "Váy hồng đính nơ trẻ em",
//                    Price = 99000,
//                    Photo = "item4.jpg"
//                },
//                new CartItem {
//                    Id = 5,
//                    Name = "Áo Thun Cho Bé Tay Ngắn In Nhiều Họa Tiết Xinh xắn",
//                    Price = 100000,
//                    Photo = "item5.jpg"
//                },
//                new CartItem {
//                    Id = 6,
//                    Name = "Quần Short Jean Cho Bé Gái In Hình Sành Điệu",
//                    Price = 120000,
//                    Photo = "item6.jpg"
//                },
//                new CartItem {
//                    Id = 7,
//                    Name = "Quần Short Jean Lửng Cho Bé Gái Sành Điệu",
//                    Price = 170000,
//                    Photo = "item7.jpg"
//                },
//                new CartItem {
//                    Id = 8,
//                    Name = "Quần Short Jean Lửng Cho Bé Gái Sành Điệu",
//                    Price = 200000,
//                    Photo = "item8.jpg"
//                },
//                new CartItem {
//                    Id = 9,
//                    Name = "Áo Thun Có Nón Bé Gái Tay Ngắn In Cô Bé Xinh Xắn",
//                    Price = 200000,
//                    Photo = "item9.jpg"
//                },
//            };
//        }

//        // Phương thức trả về tất cả sản phẩm
//        public List<CartItem> FindAll()
//        {
//            return this.products;
//        }

//        // Phương thức tìm sản phẩm theo ID
//        public CartItem FindProduct(int id)
//        {
//            return this.products.Single(p => p.Id.Equals(id));
//        }
//    }
//}
