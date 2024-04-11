using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._04._2022
{
    internal class Profile(string Name, int Money) : ProfileData(Name,Money)
    {
        public ChangedPriceStocks PriceStocks { get; private set; } = new();
        public Portfolio Portfolio { get; private set; } = new();

        public void BuyStock(string Stocks)
        {
            if (Money >= PriceStocks.Stocks[Stocks])
            {
                Money -= PriceStocks.Stocks[Stocks];
                Portfolio.Stocks[Stocks]++;
            }
        }
        public void SellStocks(string Stocks)
        {
            if(Portfolio.Stocks[Stocks]>0)
            {
                Money += PriceStocks.Stocks[Stocks];
                Portfolio.Stocks[Stocks]--;
            }
        }
        public void ShowStocks()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Money: {Money}");
            foreach (var Stock in Portfolio.Stocks)
                Console.WriteLine($"{Stock.Key}: {Stock.Value}");
        }
    }
}
