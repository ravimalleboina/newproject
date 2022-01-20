using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sampleWebapi.Models;

namespace sampleWebapi.Services.Interfaces
{
    public interface IOfferService
    {
        List<Offer> GetTodayOffers();
        List<Product> GetListOfProducts();
        void AddNewProduct(Product product);
    }
}
