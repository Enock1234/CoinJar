using CoinJar.API.Intefaces;
using CoinJar.API.Respository;
using CoinJar.Domain.Exceptions;

namespace CoinJar.API
{
    /// <summary>
    /// The CoinJar class is implemented as a singleton class
    /// </summary>
    public sealed class CoinJar : ICoinJar
    {
        private readonly CoinJarRepository coinJarRepository;
        private const decimal COIN_JAR_MAX_VOLUME = 42;

        public CoinJar()
        {
            coinJarRepository = CoinJarRepository.Instance;
        }
       
        public void AddCoin(ICoin coin)
        {
            var currentVolumeOfCoins = coinJarRepository.GetTotalVolume();

            if (currentVolumeOfCoins == COIN_JAR_MAX_VOLUME)
            {
                throw new CoinJarFullException();
            }

            if (currentVolumeOfCoins + coin.Volume > COIN_JAR_MAX_VOLUME)
            {
                throw new NotEnoughSpaceException();
            }

            coinJarRepository.AddCoin(coin);
        }

        public decimal GetTotalAmount()
        {
            return coinJarRepository.GetTotalAmount();
        }

        public void Reset()
        {
            coinJarRepository.Reset();
        }
    }
}
