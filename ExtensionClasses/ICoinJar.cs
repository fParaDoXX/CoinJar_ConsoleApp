using System;
using System.Collections.Generic;
using System.Text;

namespace CoinJar_ConsoleApp.ExtensionClasses
{
    interface ICoinJar
    {
        void AddCoin(ICoin coin);
        decimal GetTotalAmount();
        void Reset();
    }
}
