using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sampleWebapi.Services.Interfaces;
using sampleWebapi.Models;

namespace sampleWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IOfferService _offerService;

        public ValuesController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpGet]
        [Route("GetTodaysOffers")]
        public async Task<IActionResult> GetTodaysOffers()
        {
            var offers = _offerService.GetTodayOffers();

            if (!offers.Any())
                NoContent();

            return Ok(offers);
        }


        [HttpGet]
        [Route("GetMinPriceLast3Products")]
        public async Task<IActionResult> GetProducts()
        {
            var products = _offerService.GetListOfProducts();

            if (!products.Any())
                return NoContent();

            var lowpriceProducts = (from p in products
                                    orderby p.Price ascending
                                    select p).Take(3);

            return Ok(lowpriceProducts);
        }

        [HttpGet]
        [Route("GetMinPriceLast2Products")]
        public async Task<IActionResult> GetMinPriceLastTwoProducts()
        {
            var products = _offerService.GetListOfProducts();

            if (!products.Any())
                return NoContent();

            var lowpriceProducts = (from p in products
                                    orderby p.Price ascending
                                    select p).Take(2);

            return Ok(lowpriceProducts);
        }

        [HttpPost]
        [Route("AddnewProduct")]
        public async Task<IActionResult> AddProdct([FromBody] Product product)
        {
            if (product == null)
                return BadRequest();

            _offerService.AddNewProduct(product);

            return Ok();
        }



    }
}
