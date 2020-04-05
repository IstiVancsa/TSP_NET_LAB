using CodeFirstEF;
using CodeFirstEF.DBContexts;
using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeFirstEf
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Scenariu1
            SelfReference selfReference = new SelfReference()
            {
                Name = "test name"
            };

            InsertElement(selfReference);
            PrintElements();
            PrintElementById(1);
            Console.WriteLine("Is the output correct? Y/N");
            var answer = Console.ReadLine();
            #endregion
            #region Scenariu2
            InsertProducts();
            PrintProducts();

            Console.WriteLine("Is the output correct? Y/N");
            answer = Console.ReadLine();
            #endregion
            #region Scenariu3
            AddPhotograph();
            PrintPhotographs();

            Console.WriteLine("Is the output correct? Y/N");
            answer = Console.ReadLine();
            #endregion
            #region Scenariu4
            AddBusinesses();
            PrintBusinesses();

            Console.WriteLine("Is the output correct? Y/N");
            answer = Console.ReadLine();
            #endregion
            #region Scenariu5
            AddEmployees();
            PrintEmployees();

            Console.WriteLine("Is the output correct? Y/N");
            answer = Console.ReadLine();
            #endregion
        }

        private static void PrintEmployees()
        {
            using (var context = new Scenariu5DBContext())
{
                Console.WriteLine("--- All Employees ---");
                foreach (var emp in context.Employees)
                {
                    bool fullTime = emp is HourlyEmployee ? false : true;
                    Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                    fullTime ? "Full Time" : "Hourly");
                }
                Console.WriteLine("--- Full Time ---");
                foreach (var fte in context.Employees.OfType<FullTimeEmployee>())
                {
                    Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
                }
                Console.WriteLine("--- Hourly ---");
                foreach (var hourly in context.Employees.OfType<HourlyEmployee>())
                {
                    Console.WriteLine("{0} {1}", hourly.FirstName,
                    hourly.LastName);
                }
            }
        }

        private static void AddEmployees()
        {
            using (var context = new Scenariu5DBContext())
{
                var fte = new FullTimeEmployee { FirstName = "Jane", LastName = "Doe", Salary = 71500M };
                context.Employees.Add(fte);
                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary = 62500M
                };
                context.Employees.Add(fte);
                var hourly = new HourlyEmployee { FirstName = "Tom", LastName = "Jones", Wage = 8.75M };
                context.Employees.Add(hourly);
                context.SaveChanges();
            }
        }

        private static void PrintBusinesses()
        {
            using (var context = new Scenariu4DBContext())
{
                Console.WriteLine("\n--- All Businesses ---");
                foreach (var b in context.Businesses)
                {
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                }
                Console.WriteLine("\n--- Retail Businesses ---");
                foreach (var r in context.Businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    Console.WriteLine("{0}", r.Address);
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                }
                Console.WriteLine("\n--- eCommerce Businesses ---");
                foreach (var e in context.Businesses.OfType<eCommerce>())
                {
                    Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", e.URL);
                }
            }
        }

        private static void AddBusinesses()
        {
            using (var context = new Scenariu4DBContext())
            {
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenseNumber = "100x1"
                };
                context.Businesses.Add(business);
                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenseNumber = "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX",
                    ZIPCode = "76106"
                };
                context.Businesses.Add(retail);
                var web = new eCommerce
                {
                    Name = "BuyNow.com",
                    LicenseNumber = "300AB",
                    URL = "www.buynow.com"
                };
                context.Businesses.Add(web);
                context.SaveChanges();
            }
        }

        private static void PrintPhotographs()
        {
            using (var context = new Scenariu3DBContext())
            {
                foreach (var photo in context.Photographs)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                    photo.Title, photo.ThumbnailBits.Length);
                    // explicitly load the "expensive" entity,
                    //Eager loading
                    context.Entry(photo)
                    .Reference(p => p.PhotographFullImage).Load();
                    Console.WriteLine("Full Image Size: {0} bytes",
                    photo.PhotographFullImage.HighResolutionBits.Length);
                }
            }
        }
        private static void AddPhotograph()
        {
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new Scenariu3DBContext())
            {
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage { HighResolutionBits = fullBits };
                photo.PhotographFullImage = fullImage;
                context.Photographs.Add(photo);
                context.SaveChanges();
            }
        }
        private static void PrintProducts()
        {
            using (var context = new Scenariu2DBContext())
            {
                foreach (var p in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                    p.Price.ToString("C"), p.ImageURL);
                }
            }
        }
        private static void InsertProducts()
        {
            using (var context = new Scenariu2DBContext())
            {
                if (context.Products.Count() == 0)
                {
                    var product = new Product
                    {
                        SKU = 147,
                        Description = "Expandable Hydration Pack",
                        Price = 19.97M,
                        ImageURL = "/pack147.jpg"
                    };
                    context.Products.Add(product);
                    product = new Product
                    {
                        SKU = 178,
                        Description = "Rugged Ranger Duffel Bag",
                        Price = 39.97M,
                        ImageURL = "/pack178.jpg"
                    };
                    context.Products.Add(product);
                    product = new Product
                    {
                        SKU = 186,
                        Description = "Range Field Pack",
                        Price = 98.97M,
                        ImageURL = "/noimage.jp"
                    };
                    context.Products.Add(product);
                    product = new Product
                    {
                        SKU = 202,
                        Description = "Small Deployment Back Pack",
                        Price = 29.97M,
                        ImageURL = "/pack202.jpg"
                    };
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
        }
        private static async void PrintElementById(int id)
        {
            ModelSelfReferences modelSelfReferences = new ModelSelfReferences();

            var item = await modelSelfReferences.GetDataById(x => x.SelfReferenceId == id);
            Console.WriteLine(item.SelfReferenceId + " " + item.Name);
        }
        private static async void InsertElement(SelfReference selfReference)
        {
            ModelSelfReferences modelSelfReferences = new ModelSelfReferences();

            await modelSelfReferences.InsertItem(selfReference);
        }
        public static async void PrintElements()
        {
            ModelSelfReferences modelSelfReferences = new ModelSelfReferences();

            var items = await modelSelfReferences.GetAllData();
            foreach (var item in items)
            {
                Console.WriteLine(item.SelfReferenceId + " " + item.Name);
            }
        }
    }
}
