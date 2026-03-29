//using Microsoft.AspNetCore.Mvc;
//using ShoppingCart.Models;
//using System.Collections.Generic;
//// delete
//namespace ShoppingCart.Controllers
//{
//    public class CartController : Controller
//    {
//        private static List<CartItem> cartItems = new List<CartItem>();

//        public IActionResult Index()
//        {
//            return View(cartItems); 
//        }

//        public IActionResult AddToCart(int id, string name, double price, string photo)
//        {
//            var cartItem = cartItems.Find(item => item.Id == id);
//            if (cartItem == null)
//            {
//                cartItems.Add(new CartItem { Id = id, Name = name, Price = price, Photo = photo, Amount = 1 });
//            }
//            else
//            {
//                cartItem.Amount++;
//            }

//            return RedirectToAction("Index");
//        }

//        public IActionResult RemoveFromCart(int id)
//        {
//            var cartItem = cartItems.Find(item => item.Id == id);
//            if (cartItem != null)
//            {
//                cartItems.Remove(cartItem);
//            }

//            return RedirectToAction("Index");
//        }
//    }
//}
