using CoinJar.API.Intefaces;
using CoinJar.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoinJarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinJarController : ControllerBase
    {
        private readonly ICoinJar _coinJar;
      
        public CoinJarController(ICoinJar coinJar)
        {
            _coinJar = coinJar;
        }

        [HttpGet]
        [Route("amount")]
        public IActionResult GetTotalAmount()
        {
            var totalAount = _coinJar.GetTotalAmount();
            return Ok(totalAount);
        }

        [HttpPost]
        [Route("coin")]
        public IActionResult AddCoin(Coin coin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(coin);          
            }

            _coinJar.AddCoin(coin);

            return Ok(coin);
        }

        [HttpDelete]
        [Route("reset")] 
        public IActionResult ResetCoinJar()
        {
            _coinJar.Reset();
            return Ok();
        }
    }
}
