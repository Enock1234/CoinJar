using CoinJar.API.Intefaces;
using System.Collections.Generic;
using System.Linq;

namespace CoinJar.API.Respository
{
    public class CoinJarRepository
    {
        private readonly List<ICoin> Coins = new List<ICoin>();
        private decimal counter = 0M;
        private static CoinJarRepository instance = null;

        private CoinJarRepository()
        {
        }

        public static CoinJarRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CoinJarRepository();
                }
                return instance;
            }
        }

        public void AddCoin(ICoin coin)
        {
            counter += coin.Amount;
            Coins.Add(coin);
        }

        public decimal GetTotalAmount()
        {
            return counter;
        }

        public void Reset()
        {
            counter = 0M;
            Coins.Clear();
        }

        public decimal GetTotalVolume()
        {
            return Coins.Sum(x => x.Volume);
        }
    }
}
