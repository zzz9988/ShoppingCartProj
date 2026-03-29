using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //cái này để chuyển hoá thành bảng
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // hàm này để nạp dữ liệu ban đầu vào SQL
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Nhét 9 sản phẩm vào bảng Products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Balo chống gù lưng", Price = 120000, Photo = "item1.jpg" },
                new Product { Id = 2, Name = "Mũ tai bèo hươu cao cổ", Price = 320000, Photo = "item2.jpg" },
                new Product { Id = 3, Name = "Thắt lưng trẻ em", Price = 110000, Photo = "item3.jpg" },
                new Product { Id = 4, Name = "Váy hồng đính nơ trẻ em", Price = 99000, Photo = "item4.jpg" },
                new Product { Id = 5, Name = "Áo Thun Cho Bé Tay Ngắn In Nhiều Họa Tiết Xinh xắn", Price = 100000, Photo = "item5.jpg" },
                new Product { Id = 6, Name = "Quần Short Jean Cho Bé Gái In Hình Sành Điệu", Price = 120000, Photo = "item6.jpg" },
                new Product { Id = 7, Name = "Quần Short Jean Lửng Cho Bé Gái Sành Điệu", Price = 170000, Photo = "item7.jpg" },
                new Product { Id = 8, Name = "Quần Short Jean Lửng Cho Bé Gái Sành Điệu", Price = 200000, Photo = "item8.jpg" },
                new Product { Id = 9, Name = "Áo Thun Có Nón Bé Gái Tay Ngắn In Cô Bé Xinh Xắn", Price = 200000, Photo = "item9.jpg" }
            );
        }
    }
}