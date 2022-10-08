using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allorders, ShopCart shopCart)
        {
            this.allOrders = allorders;
            this.shopCart = shopCart;
        }
        public IActionResult Checkout() {

            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if(shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас должны быть товары!");
            }

            if (ModelState.IsValid)
            {
                allOrders.CreateOrders(order);
                return RedirectToAction("Complete");

            }
            return View();
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    } 


    
    
                 
}
