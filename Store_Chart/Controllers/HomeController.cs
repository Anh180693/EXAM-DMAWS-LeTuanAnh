using Microsoft.AspNetCore.Mvc;
using Store_Chart.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System;

namespace Store_Chart.Controllers
{
    public class HomeController : Controller
    {
        private readonly Dbcontext _context;

        public HomeController(Dbcontext context)
        {
            _context = context;
        }

        public IActionResult
        Index()
        {
            var orderData = GetOrderDataByMonth();
            return View(orderData);
        }

        private List<OrderChartData> GetOrderDataByMonth()
        {
            var orders = _context.OrderTbls.ToList();
            var orderData = orders.GroupBy(order => order.OrderDelivery.Month)
                                   .Select(group => new OrderChartData
                                   {
                                       Month = group.Key,
                                       TotalQuantity = group.Sum(order => order.ItemQty)
                                   })
                                   .ToList();
            return orderData;
        }
    }
}