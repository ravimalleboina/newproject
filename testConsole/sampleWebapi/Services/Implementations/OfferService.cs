using sampleWebapi.Models;
using sampleWebapi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleWebapi.Services.Implementations
{
    public class OfferService : IOfferService
    {
        private readonly List<Product> _inventory;
        public OfferService()
        {
            _inventory = GetListOfProducts();
        }

        public List<Offer> GetTodayOffers()
        {
            var offers = new List<Offer>();
            offers.Add(new Offer("ComboPackage1",
                new List<Product> {
                new Product("a", 50,"a desc"),
                new Product("b", 51,"b desc"),
                new Product("c", 52,"c desc")
                }));

            offers.Add(new Offer("ComboPackage2",
                new List<Product> {
                new Product("d", 53,"d desc"),
                new Product("e", 54,"e desc"),
                new Product("f", 55,"f desc")
                }));

            offers.Add(new Offer("ComboPackage3",
                new List<Product> {
                new Product("g", 56,"g desc"),
                new Product("h", 57,"h desc"),
                new Product("i", 58,"i desc")
                }));

            return offers;
        }


        public List<Product> GetListOfProducts()
        {
            var products = new List<Product>();

            products.Add(new Product("P1", 1000, "P1 desc"));
            products.Add(new Product("P2", 200, "P2 desc"));
            products.Add(new Product("P3", 400, "P3 desc"));
            products.Add(new Product("P4", 700, "P4 desc"));
            products.Add(new Product("P5", 600, "P5 desc"));
            products.Add(new Product("P6", 800, "P6 desc"));

            return products;
        }

        public void AddNewProduct(Product product)
        {
            _inventory.Add(product);
        }
    }
}
