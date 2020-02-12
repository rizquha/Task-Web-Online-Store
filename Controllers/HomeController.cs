using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PagedList;
using Task_Web_Product.Models;

namespace Task_Web_Product.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppDbContext _AppDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _AppDbContext = appDbContext;
        }

        public IActionResult Login(string username, string password)
        {
            var items = from item in _AppDbContext.users select new { uname1 = item.Username, pass1 = item.Password, status = item.status };
            foreach (var item in items)
            {
                if (username == item.uname1)
                {
                    if (password == item.pass1)
                    {
                        // ViewBag.status=item.status;
                        return RedirectToAction("IndexAdmin", "Home");
                        // if(item.status=="user")
                        // {
                        //     return RedirectToAction("Index","Home");
                        // }
                        // else
                        // {
                        //     return RedirectToAction("IndexAdmin","Home");
                        // }
                    }
                    else
                    {
                        ViewBag.error = "Invalid Password";
                    }
                }
                else
                {
                    ViewBag.error = "invalid Username";
                }

            }
            return View();
        }
        public IActionResult AddItems(string title, string rate, string price, string description, string image)
        {
            Items item = new Items
            {
                title = title,
                rate = Convert.ToInt32(rate),
                price = Convert.ToInt32(price),
                desc = description,
                image = image,
                total_item_in_cart = 0,
                CartsId = 1
            };
            _AppDbContext.Add(item);
            _AppDbContext.SaveChanges();
            return View("AddItems");
        }
        public IActionResult IndexAdmin()
        {
            var items = from item in _AppDbContext.items select item;
            ViewBag.items = items;
            return View("IndexAdmin");
        }

        public IActionResult Index()
        {
            var items = from item in _AppDbContext.items where item.rate >= 8 select item;
            ViewBag.items = items;
            return View();
        }

        public IActionResult Item(int Sort, int? page, int PerPage)
        {
            ViewBag.PerPage = PerPage;
            var items = from x in _AppDbContext.items select x;
            ViewBag.items = items;
           if (PerPage != 0)
            {
                var item = from l in _AppDbContext.items select l;
                var pager = new Pager(item.Count(), page, PerPage);
                var viewModel = new IndexViewModel
                {
                    Item = item.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                    Pager = pager
                };
                return View(viewModel);
            }
            else
            {
                var item = from l in _AppDbContext.items select l;
                var pager = new Pager(item.Count(), page);
                var viewModel = new IndexViewModel
                {
                    Item = item.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                    Pager = pager
                };
                return View(viewModel);
            }
            // var items = from x in _AppDbContext.items select x;
            // ViewBag.items = items;
            // return View();
        }
        public IActionResult Detail(int id)
        {
            var items = from item in _AppDbContext.items where item.id == id select item;
            ViewBag.items = items;
            return View("Detail");
        }
        public IActionResult Cart(int id)
        {
            var display = from x in _AppDbContext.carts from y in x.Items where y.CartsId == 1 && y.total_item_in_cart > 0 select y;
            ViewBag.items = display;
            return View("Cart");
        }
        public IActionResult Add(int id)
        {
            var findCarts = _AppDbContext.carts.Find(1);
            var findItem = _AppDbContext.items.Find(id);
            if (!_AppDbContext.carts.Any())
            {
                Carts cart = new Carts();
                _AppDbContext.carts.Add(cart);
                _AppDbContext.SaveChanges();
            }

            findItem.total_item_in_cart += 1;
            findItem.CartsId = findCarts.id;
            _AppDbContext.Add(findItem);
            _AppDbContext.Attach(findItem);
            _AppDbContext.SaveChanges();

            var display = from x in _AppDbContext.carts from y in x.Items where y.CartsId == 1 && y.total_item_in_cart > 0 select y;
            ViewBag.items = display;
            return RedirectToAction("Cart", "Home");
        }
        public IActionResult Update(int id, int val)
        {
            var item = _AppDbContext.items.Find(id);
            item.total_item_in_cart = val;
            _AppDbContext.Add(item);
            _AppDbContext.Attach(item);
            _AppDbContext.SaveChanges();
            var display = from x in _AppDbContext.carts from y in x.Items where y.CartsId == 1 && y.total_item_in_cart > 0 select y;
            ViewBag.items = display;
            return RedirectToAction("Cart", "Home");
        }
        public IActionResult Remove(int id)
        {
            var item = _AppDbContext.items.Find(id);
            item.total_item_in_cart = 0;
            _AppDbContext.Add(item);
            _AppDbContext.Attach(item);
            _AppDbContext.SaveChanges();
            return RedirectToAction("Cart", "Home");
        }
        public IActionResult Edit(int id, string title, int rate, int price, string description, string image)
        {
            var data = _AppDbContext.items.Find(id);
            data.title = title;
            data.rate = rate;
            data.price = price;
            data.desc = description;
            data.image = image;
            _AppDbContext.SaveChanges();
            return RedirectToAction("IndexHome", "Home");
        }
        public IActionResult Checkout(int sum)
        {
            var cart = _AppDbContext.carts.Find(1);
            cart.totalPrice = sum;
            _AppDbContext.Add(cart);
            _AppDbContext.Attach(cart);
            _AppDbContext.SaveChanges();
            return View("Checkout");
        }
        public IActionResult Delete(int id)
        {
            var Delete = _AppDbContext.items.Find(id);
            _AppDbContext.items.Remove(Delete);
            _AppDbContext.SaveChanges();
            return RedirectToAction("IndexAdmin", "Home");
        }
        public IActionResult SearchSort(string str, string sort1, string sort2)
        {
            if (str != null)
            {
                var items = from i in _AppDbContext.items where (i.title.Contains(str) || i.desc.Contains(str)) select i;
                if (sort1 == "pilihan1")
                {
                    if (sort2 == "pilihan1")
                    {
                        var x = items.OrderBy(x => x.title);
                        ViewBag.items = x;

                    }
                    else
                    {
                        var x = items.OrderBy(x => x.price);
                        ViewBag.items = x;

                    }
                }
                else
                {
                    if (sort2 == "pilihan1")
                    {
                        var x = items.OrderByDescending(x => x.title);
                        ViewBag.items = x;

                    }
                    else
                    {
                        var x = items.OrderByDescending(x => x.price);
                        ViewBag.items = x;

                    }
                }
            }
            else
            {
                var items = from i in _AppDbContext.items select i;
                if (sort1 == "pilihan1")
                {
                    if (sort2 == "pilihan1")
                    {
                        var x = items.OrderBy(x => x.title);
                        ViewBag.items = x;

                    }
                    else
                    {
                        var x = items.OrderBy(x => x.price);
                        ViewBag.items = x;

                    }
                }
                else
                {
                    if (sort2 == "pilihan1")
                    {
                        var x = items.OrderByDescending(x => x.title);
                        ViewBag.items = x;

                    }
                    else
                    {
                        var x = items.OrderByDescending(x => x.price);
                        ViewBag.items = x;

                    }
                }
            }
            return View("Item");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
