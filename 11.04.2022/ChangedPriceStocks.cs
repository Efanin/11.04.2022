using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._04._2022
{
    internal class ChangedPriceStocks
    {
        public Dictionary<string, int> Stocks { get; private set; } = new()
        {
            {"Apple", 0},
            {"Microsoft", 0},
            {"Google", 0},
            {"Tesla", 0},
            {"Amazon", 0},
        };
        public ChangedPriceStocks()
        {
            StartChandedPrice();
        }
        private async void StartChandedPrice()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    Stocks["Apple"] = new Random().Next(50, 200);
                    Stocks["Microsoft"] = new Random().Next(50, 200);
                    Stocks["Google"] = new Random().Next(50, 200);
                    Stocks["Tesla"] = new Random().Next(50, 200);
                    Stocks["Amazon"] = new Random().Next(50, 200);
                    Thread.Sleep(new Random().Next(1000,20000));
                }
            });
        }
        public void Show()
        {
            foreach (var Stock in Stocks)
                Console.WriteLine($"{Stock.Key}: {Stock.Value}");
        }
    }
}
