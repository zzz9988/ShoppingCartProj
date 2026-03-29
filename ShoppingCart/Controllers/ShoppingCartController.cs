using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using ShoppingCart.Extensions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly AppDbContext _context;

        public ShoppingCartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("ShoppingCart");
            return View(cart ?? new List<CartItem>());
        }

        public IActionResult AddToCart(int id)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("ShoppingCart") ?? new List<CartItem>();
            var item = cart.FirstOrDefault(p => p.Id == id);

            if (item == null)
            {
                var product = _context.Products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    cart.Add(new CartItem
                    {
                        Id = product.Id,
                        Name = product.Name,
                        // Ép kiểu từ decimal sang double
                        Price = (double)product.Price,
                        Photo = product.Photo,
                        Amount = 1
                    });
                }
            }
            else
            {
                item.Amount++;
            }

            HttpContext.Session.SetObject("ShoppingCart", cart);
            return RedirectToAction("Index", "ShoppingCart");
        }

        public IActionResult RemoveItem(int id)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("ShoppingCart");
            var item = cart.FirstOrDefault(p => p.Id == id);
            if (item != null)
            {
                cart.Remove(item);
            }
            HttpContext.Session.SetObject("ShoppingCart", cart);
            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("ShoppingCart");
            if (cart == null || cart.Count == 0)
            {
                return RedirectToAction("Index");
            }
            return View(cart);
        }

        [HttpPost]
        public IActionResult ProcessPayment(string CustomerName, string Phone, string Address)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("ShoppingCart");
            if (cart == null || cart.Count == 0)
            {
                return RedirectToAction("Index");
            }

            var newOrder = new Order()
            {
                CustomerName = CustomerName,
                Phone = Phone,
                Address = Address,
                OrderDate = DateTime.Now,
                // Ép kiểu từ double sang decimal
                TotalAmount = (decimal)cart.Sum(item => item.Money)
            };
            _context.Orders.Add(newOrder);
            _context.SaveChanges();

            foreach (var item in cart)
            {
                var orderDetail = new OrderDetail()
                {
                    OrderId = newOrder.Id,
                    ProductId = item.Id,
                    // Ép kiểu từ double sang decimal
                    Price = (decimal)item.Price,
                    Quantity = item.Amount
                };
                _context.OrderDetails.Add(orderDetail);
            }
            _context.SaveChanges();

            HttpContext.Session.Remove("ShoppingCart");

            return View("Success");
        }

        public IActionResult UpdateAmount(int ProductId, int newAmount)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("ShoppingCart");
            var item = cart.FirstOrDefault(p => p.Id == ProductId);
            if (item != null)
            {
                item.Amount = newAmount;
            }
            HttpContext.Session.SetObject("ShoppingCart", cart);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddToCartAjax(int id)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("ShoppingCart") ?? new List<CartItem>();
            var item = cart.FirstOrDefault(p => p.Id == id);

            if (item == null)
            {
                var product = _context.Products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    cart.Add(new CartItem
                    {
                        Id = product.Id,
                        Name = product.Name,
                        // Ép kiểu từ decimal sang double
                        Price = (double)product.Price,
                        Photo = product.Photo,
                        Amount = 1
                    });
                }
            }
            else
            {
                item.Amount++;
            }

            HttpContext.Session.SetObject("ShoppingCart", cart);
            return Json(new { success = true, message = "Đã thêm sản phẩm vào giỏ hàng!" });
        }
    }
}