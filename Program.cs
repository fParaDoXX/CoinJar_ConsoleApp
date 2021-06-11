using CoinJar_ConsoleApp.ExtensionClasses;
using System;

namespace CoinJar_ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Coin Penny = new Coin { Amount = 1, Volume = 1 };
            Coin Nickel = new Coin { Amount = (decimal)1.5, Volume = (decimal)1.5 };
            Coin Dime = new Coin { Amount = (decimal)3.5, Volume = (decimal)3.5 };
            Coin quarter = new Coin { Amount = (decimal)5.5, Volume = (decimal)5.5 };

            Coin[] coins = { Penny, Nickel, Dime, quarter };
            string[] coinNames = { "Penny", "Nickel", "Dime", "Quarter" };

            CoinJar coinJar = new CoinJar();
            do
            {
              
                int UserSelectedValue;
                Coin SelectedCoin;
                Console.WriteLine("**********************************************************************************\n");
                Console.WriteLine("Please select a coin to add to the piggy bank.");
                Console.WriteLine("Please type the number of the coin you want to add only. ");

                Console.WriteLine("\n");
                Console.WriteLine("**********************************************************************************\n");

                for (int i = 0; i < coins.Length; i++)
                {
                    Console.WriteLine("{0}: {1} , Amount Value ${2}, Volume of Coin {3} fluid ounces", i.ToString(), coinNames[i], coins[i].Amount.ToString(), coins[i].Volume.ToString());
                }
                Console.WriteLine("\n");
                Console.WriteLine("**********************************************************************************\n");
                Console.WriteLine("If you want to view the current total of the piggy bank please press 8");
                Console.WriteLine("Or press 9 to reset the piggy bank.");
                Console.WriteLine("\n");
                Console.WriteLine("**********************************************************************************\n");
                try
                {
                    UserSelectedValue = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    if (UserSelectedValue == 8)
                    {
                        Console.WriteLine("**********************************************************************************\n");
                        Console.WriteLine("The Current Amount inside the piggy bank is : ${0}",coinJar.GetTotalAmount().ToString());
                        Console.WriteLine("\n");
                        Console.WriteLine("**********************************************************************************\n");
                    }
                    else if (UserSelectedValue == 9)
                    {
                        Console.WriteLine("**********************************************************************************\n");
                        Console.WriteLine("Piggy bank has been emptied. The Total Amount inside the piggy bank was {0} \n", coinJar.GetTotalAmount().ToString());
                        coinJar.Reset();
                        Console.WriteLine("**********************************************************************************\n");

                    }
                    else if (UserSelectedValue > 3 || UserSelectedValue < 0)
                    {
                        Console.WriteLine("**********************************************************************************\n");
                        Console.WriteLine("That is not a valid selection");
                        Console.WriteLine("**********************************************************************************\n");
                    }
                    else
                    {
                        SelectedCoin = coins[UserSelectedValue];
                        coinJar.AddCoin(SelectedCoin);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("**********************************************************************************\n");
                    Console.WriteLine("Please only type the number for the coin you want to insert");
                    Console.WriteLine("**********************************************************************************\n");
                }



            } while (true);


        }
    }



    class CoinJar : ICoinJar
    {

        private decimal TotalAmount;
        private decimal TotalVolume;
        public void AddCoin(ICoin coin)
        {
            if (TotalVolume + coin.Volume > 42)
            {

                Console.WriteLine("Piggy bank doens't have the space for this coin.\n");
                Console.WriteLine("Piggy bank's current Volume is {0} fluid ounces.  \n", TotalVolume);
            }
            else
            {
                TotalAmount += coin.Amount;
                TotalVolume += coin.Volume;

                Console.WriteLine("Piggy bank's current Volume is {0} fluid ounces.  \n", TotalVolume);
            }
        }

        public decimal GetTotalAmount()
        {
            return TotalAmount;
        }

        public void Reset()
        {
            TotalAmount = 0;
            TotalVolume = 0;
        }
    }
}
