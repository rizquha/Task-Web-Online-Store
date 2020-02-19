using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using MimeKit;
using PagedList;
using Stripe;
using MailKit.Net.Smtp;
using Task_Web_Product.Models;

namespace Task_Web_Product.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppDbContext _AppDbContext;
        public IConfiguration Configuration;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext, IConfiguration configuration)
        {
            _logger = logger;
            _AppDbContext = appDbContext;
            Configuration = configuration;
        }

        public IActionResult Login(string username, string password)
        {
            IActionResult response = Unauthorized();
            
            var user = AuthenticatedUser (username, password);
            if (user != null) {
                var token = GenerateJwtToken (user);
                HttpContext.Session.SetString ("JWTToken", token);
                var get = HttpContext.Session.GetString ("JWTToken");
                var cek = from x in _AppDbContext.users select x;
                foreach (var item in cek) {
                    if (item.Username == username && item.Password == password) {
                        return RedirectToAction ("IndexAdmin", "Home");
                    }
                }
                return RedirectToAction ("IndexAdmin", "Home");
            }
            return View();
        }

        private string GenerateJwtToken(User user)
        {
            var secuityKey = new SymmetricSecurityKey (Encoding.UTF8.GetBytes (Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials (secuityKey, SecurityAlgorithms.HmacSha256);

            var claims = new [] {
                new Claim (JwtRegisteredClaimNames.Sub, Convert.ToString (user.Username)),
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid ().ToString ())
            };

            var token = new JwtSecurityToken (
                issuer: Configuration["Jwt:Issuer"],
                audience : Configuration["Jwt:Audience"],
                claims,
                expires : DateTime.Now.AddMinutes (2000),
                signingCredentials : credentials);
            var encodedToken = new JwtSecurityTokenHandler ().WriteToken (token);
            return encodedToken;
        }

        private User AuthenticatedUser(string username, string password)
        {
            User user = null;
            var get = from i in _AppDbContext.users select i;
            foreach (var i in get) {
                if (i.Username == username && i.Password == password) {
                    user = new User {
                    Username = username,
                    Password = password,
                    };
                }
            }
            return user;
        }

        [Authorize]
        public IActionResult IndexAdmin(int? page, int PerPage,string sort1, string sort2, string str="")
        {
            var token = HttpContext.Session.GetString ("JWTToken");
            var jwtSec = new JwtSecurityTokenHandler ();
            var securityToken = jwtSec.ReadToken (token) as JwtSecurityToken;
            var sub = securityToken?.Claims.First (Claim => Claim.Type == "sub").Value;

            if(PerPage==0)
            {
                PerPage=5;
            }
            ViewBag.PerPage = PerPage;
            ViewBag.Search = str;
            ViewBag.Sort1 = sort1;
            ViewBag.Sort2 = sort2;
            

            if (!String.IsNullOrEmpty(str) || !String.IsNullOrWhiteSpace(str))
            {
                var item = from i in _AppDbContext.items where (i.title.Contains(str) || i.desc.Contains(str)) select i;
                if (sort1 == "pilihan1")
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderBy(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {
                            var x = item.OrderBy(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                }
                else
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderByDescending(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {

                            var x = item.OrderByDescending(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);

                    }
                }
            }
            else
            {
                var item = from i in _AppDbContext.items select i;
                if (sort1 == "pilihan1")
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderBy(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {

                            var x = item.OrderBy(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);

                    }
                }
                else
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderByDescending(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {

                            var x = item.OrderByDescending(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                }
            }
        }
        public IActionResult SaveChanges(int id, string title, int rate, int price, string description, string image)
        {

            var findId = _AppDbContext.items.Find(id);
            findId.title = title;
            findId.rate = rate;
            findId.price = price;
            findId.desc = description;
            findId.image = image;
            _AppDbContext.Add(findId);
            _AppDbContext.Attach(findId);
            _AppDbContext.SaveChanges();
            return RedirectToAction("IndexAdmin","Home");
        }

        public IActionResult Index(int? page, int PerPage,string sort1, string sort2, string str="")
        {
            if(PerPage==0)
            {
                PerPage=5;
            }
            ViewBag.PerPage = PerPage;
            ViewBag.Search = str;
            ViewBag.Sort1 = sort1;
            ViewBag.Sort2 = sort2;
            

            if (!String.IsNullOrEmpty(str) || !String.IsNullOrWhiteSpace(str))
            {
                var item = from i in _AppDbContext.items where ((i.title.Contains(str) || i.desc.Contains(str))&& i.rate>7) select i;
                if (sort1 == "pilihan1")
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderBy(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {
                            var x = item.OrderBy(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                }
                else
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderByDescending(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {

                            var x = item.OrderByDescending(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);

                    }
                }
            }
            else
            {
                var item = from i in _AppDbContext.items where i.rate>7 select i;
                if (sort1 == "pilihan1")
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderBy(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {

                            var x = item.OrderBy(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);

                    }
                }
                else
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderByDescending(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {

                            var x = item.OrderByDescending(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                }
            }
        }
        public IActionResult AddItems(string title, string rate, string price, string description, string image)
        {
            if (title != null && rate != null && price != null && description != null && image != null)
            {
                Items item = new Items
                {
                    title = title,
                    rate = Convert.ToInt32(rate),
                    price = Convert.ToInt32(price),
                    desc = description,
                    image = image,
                    total_item_in_cart = 0,
                    CartsId = null
                };
                _AppDbContext.Add(item);
                _AppDbContext.SaveChanges();
            }
            return View();
        }

        public IActionResult Item(int? page, int PerPage,string sort1, string sort2, string str="")
        {
            if(PerPage==0)
            {
                PerPage=5;
            }
            ViewBag.PerPage = PerPage;
            ViewBag.Search = str;
            ViewBag.Sort1 = sort1;
            ViewBag.Sort2 = sort2;
            

            if (!String.IsNullOrEmpty(str) || !String.IsNullOrWhiteSpace(str))
            {
                var item = from i in _AppDbContext.items where (i.title.Contains(str) || i.desc.Contains(str)) select i;
                if (sort1 == "pilihan1")
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderBy(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {
                            var x = item.OrderBy(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                }
                else
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderByDescending(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {

                            var x = item.OrderByDescending(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);

                    }
                }
            }
            else
            {
                var item = from i in _AppDbContext.items select i;
                if (sort1 == "pilihan1")
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderBy(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {

                            var x = item.OrderBy(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);

                    }
                }
                else
                {
                    if (sort2 == "pilihan1")
                    {
                            var x = item.OrderByDescending(x => x.title);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                    else
                    {

                            var x = item.OrderByDescending(x => x.price);
                            var pager = new Pager(x.Count(), page, PerPage);

                            var viewModel = new IndexViewModel
                            {
                                Item = x.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                                Pager = pager
                            };
                            return View(viewModel);
                    }
                }
            }
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
        public IActionResult FormCheckout(int sum)
        {
            ViewBag.sum = sum;
            var cart = _AppDbContext.carts.Find(1);
            cart.totalPrice = sum;
            _AppDbContext.Add(cart);
            _AppDbContext.Attach(cart);
            _AppDbContext.SaveChanges();

            var item = from items in _AppDbContext.items where items.CartsId == 1 && items.total_item_in_cart > 0 select items;
            ViewBag.itemOut = item;
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            var Delete = _AppDbContext.items.Find(id);
            _AppDbContext.items.Remove(Delete);
            _AppDbContext.SaveChanges();
            return RedirectToAction("IndexAdmin", "Home");
        }
        public IActionResult ExportTransactions()
        {
            var comlumHeadrs = new string[]
            {
                "Id",
                "First Name",
                "Last Name",
                "Email",
                "Phone Number",
                "Shipping Address",
                "Regency",
                "Zip",
                "Province",
                "Total Price"
            };
            var items = (from item in _AppDbContext.purchases
                         select new object[]
                         {
                                       item.id,
                                       $"{item.firstName}",
                                       $"{item.lastName}",
                                       $"{item.email}",
                                       $"{item.phoneNumber}",
                                       $"{item.shippingAddress}",
                                       $"{item.Regency}",
                                       item.Zip,
                                       $"{item.Province}",
                                       item.totalPrice
                         }).ToList();

            var itemcsv = new StringBuilder();
            items.ForEach(line =>
                {
                    itemcsv.AppendLine(string.Join(",", line));
                });

            byte[] buffer = Encoding.ASCII.GetBytes($"{string.Join(",", comlumHeadrs)}\r\n{itemcsv.ToString()}");
            return File(buffer, "text/csv", $"Item.csv");
        }

        public IActionResult Export()
        {
            var comlumHeadrs = new string[]
            {
                "Id",
                "Title",
                "Rate",
                "Price",
                "Description"
            };
            var items = (from item in _AppDbContext.items
                         select new object[]
                         {
                                       item.id,
                                       $"{item.title}",
                                        item.rate,
                                       item.price,
                                       $"{item.desc}",
                         }).ToList();

            var itemcsv = new StringBuilder();
            items.ForEach(line =>
                {
                    itemcsv.AppendLine(string.Join(",", line));
                });

            byte[] buffer = Encoding.ASCII.GetBytes($"{string.Join(",", comlumHeadrs)}\r\n{itemcsv.ToString()}");
            return File(buffer, "text/csv", $"Item.csv");
        }

        [Authorize]
        public IActionResult Transactions()
        {
            var token = HttpContext.Session.GetString ("JWTToken");
            var jwtSec = new JwtSecurityTokenHandler ();
            var securityToken = jwtSec.ReadToken (token) as JwtSecurityToken;
            var sub = securityToken?.Claims.First (Claim => Claim.Type == "sub").Value;

            var display = from i in _AppDbContext.purchases select i;
            ViewBag.display = display;
            return View();
        }
        public IActionResult Import([FromForm(Name = "file")] IFormFile file)
        {
            string filePath = string.Empty;
            if (file != null)
            {
                try
                {
                    string fileExtension = Path.GetExtension(file.FileName);
                    if (fileExtension != ".csv")
                    {
                        ViewBag.Message = "Please select the csv file";
                        return RedirectToAction("IndexAdmin", "Home");
                    }
                    using (var reader = new StreamReader(file.OpenReadStream()))
                    {
                        string[] header = reader.ReadLine().Split(',');
                        while (!reader.EndOfStream)
                        {
                            string[] rows = reader.ReadLine().Split(',');
                            Items item = new Items()
                            {
                                title = rows[0].ToString(),
                                rate = Int32.Parse(rows[1].ToString()),
                                price = Int32.Parse(rows[2].ToString()),
                                desc = rows[3].ToString(),
                                image = rows[4].ToString(),
                                CartsId = null,
                                total_item_in_cart = 0
                            };
                            _AppDbContext.items.Add(item);
                        }
                        _AppDbContext.SaveChanges();
                    }
                    return RedirectToAction("IndexAdmin", "Home");
                }
                catch (Exception e)
                {
                    ViewBag.Message = e.Message;
                }
            }
            return RedirectToAction("IndexAdmin", "Home");
        }
        public IActionResult Charge(string firstName, string lastName, string email, string phoneNumber, string shippingAddress, string Province, string Regency, int Zip)
        {
            var price = from a in _AppDbContext.carts where a.id==1 select a.totalPrice;
            var total =0;
            foreach(var i in price)
            {
                total = i;
            }
            
            Purchase purchase = new Purchase
            {
                firstName = firstName,
                lastName = lastName,
                email = email,
                phoneNumber = phoneNumber,
                shippingAddress = shippingAddress,
                Province = Province,
                Regency = Regency,
                Zip = Zip,
                CartsId = 1,
                totalPrice = total
            };
            _AppDbContext.Add(purchase);
            _AppDbContext.SaveChanges();
            var y = from i in _AppDbContext.carts where i.id == 1 select i.totalPrice;
            ViewBag.total = y;
            return View("Purchase");
        }
        public IActionResult Send(Purchase email)
        {
            var message = new MimeMessage();
            var user = (from i in _AppDbContext.purchases.OrderBy(x=>x.id) select i).LastOrDefault();
            var nama = user.firstName+" "+user.lastName;
            var emailAddress = user.email;
            var amount = user.totalPrice;
            message.From.Add(new MailboxAddress("Essence","essence@essence.com"));
            message.To.Add(new MailboxAddress(nama,emailAddress));
            message.Subject ="Your Purchase";
            message.Body = new TextPart("Plain")
            {
                Text = @"Dear "+nama+","+"\nThank You For Your Purchasing. \n"+"Your Total Amount is : Rp. "+amount
            };

            using(var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s,c,h,e) => true;
				client.Connect ("smtp.mailtrap.io", 587, false);
				client.Authenticate ("785fd04dea6d9c", "6057ae43ba12a4");
				client.Send (message);
				client.Disconnect (true);
            }
            return RedirectToAction("Checkout","Home");

            
        }

        public IActionResult Purchase(string stripeEmail, string stripeToken)
        {
            var customer = new CustomerService();
            var charges = new ChargeService();
            var customers = customer.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });
            var x = from i in _AppDbContext.carts select i;
            foreach (var i in x)
            {
                var charge = charges.Create(new ChargeCreateOptions
                {
                    Amount = i.totalPrice,
                    Description = "Test Payment",
                    Currency = "idr",
                    Customer = customers.Id
                });
                if (charge.Status == "succeeded")
                {
                    string BalanceTransactionId = charge.BalanceTransactionId;
                    return RedirectToAction("Send", "Home");  
                }
            }
            return View();
        }
        [Authorize]
        public IActionResult Logout () {
            HttpContext.Session.Remove ("JWTToken");
            return RedirectToAction ("Login","Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
