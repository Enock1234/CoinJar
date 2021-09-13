using CoinJar.API.Intefaces;
using System.ComponentModel.DataAnnotations;

namespace CoinJar.API.Models
{
    public class Coin : ICoin
    {
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public decimal Volume { get; set; }
    }
}
