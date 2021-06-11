using System;
using System.Collections.Generic;
using System.Text;

namespace CoinJar_ConsoleApp.ExtensionClasses
{
    class Coin : ICoin 
    {
        public decimal Amount { get; set; }
        public decimal Volume { get ; set; }
    } 
 
}
