using System;
using System.Collections.Generic;
using System.Text;

namespace CoinJar_ConsoleApp.ExtensionClasses
{
    interface ICoin
    {
        decimal Amount { get; set; }
        decimal Volume { get; set; }
    }
}
