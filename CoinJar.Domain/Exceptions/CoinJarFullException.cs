using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.Domain.Exceptions
{
    public class CoinJarFullException : Exception
    {
        public CoinJarFullException():base("Coin Jar is already full")
        {
                
        }
    }
}
