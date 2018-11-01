using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyNetCoreMVC.Models;

namespace MyNetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly DatabaseContext _context;

        public ProductController(DatabaseContext context)
        {
            _context = context;
            if (_context.TbProducts.Count() == 0)
            {
                _context.TbProducts.Add(new Product()
                {
                    name = "San Pham 1",
                    price = 1000
                });
                _context.TbProducts.Add(new Product()
                {
                    name = "San Pham 2",
                    price = 2000
                });
                _context.SaveChanges();
            }
        }
        public IActionResult GetList()
        {
            return View(_context.TbProducts.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update(long id)
        {
            var product = _context.TbProducts.Find(id);
            return View(product);
        }
        public IActionResult Delete(long id)
        {
            var product = _context.TbProducts.Find(id);
            return View(product);
        }
        public IActionResult UpdateProduct(Product product)
        {
            var item = _context.TbProducts.Find(product.id);
            item.name = product.name;
            item.price = product.price;
            _context.TbProducts.Update(item);
            _context.SaveChanges();
            TempData["nontification"] = "Update success!";
            return new RedirectResult("/");
        }
        public IActionResult AddProduct(Product product)
        {
            _context.TbProducts.Add(product);
            _context.SaveChanges();
            TempData["nontification"] = "Create success!";
            return new RedirectResult("/");
        }
        public IActionResult DeleteProduct(long id)
        {
            var item = _context.TbProducts.Find(id);
            _context.TbProducts.Remove(item);
            _context.SaveChanges();
            TempData["nontification"] = "Delete success!";
            return new RedirectResult("/");
        }
    }
}