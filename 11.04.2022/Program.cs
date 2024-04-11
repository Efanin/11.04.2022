
using _11._04._2022;

Profile profile = new("Igor", 500);
while (true)
{
    Console.WriteLine(@"
    1. Show price stocks
    2. Buy stocks
    3. Sell stocks
    4. Show portfolio
");
    switch (Console.ReadLine())
    {
        case "1":
            profile.PriceStocks.Show();
            break;
        case "2":
            BuyStocks();
            break;
        case "3":
            SellStocks();
            break;
        case "4":
            profile.ShowStocks();
            break;
        default:
            break;
    }
}

void BuyStocks()
{
    Console.WriteLine(@"
    1. Apple
    2. Microsoft
    3. Google
    4. Tesla
    5. Amazon
");
    switch (Console.ReadLine())
    {
        case "1":
            profile.BuyStock("Apple");
            break;
        case "2":
            profile.BuyStock("Microsoft");
            break;
        case "3":
            profile.BuyStock("Google");
            break;
        case "4":
            profile.BuyStock("Tesla");
            break;
        case "5":
            profile.BuyStock("Amazon");
            break;
        default:
            break;
    }
}
void SellStocks()
{
    Console.WriteLine(@"
    1. Apple
    2. Microsoft
    3. Google
    4. Tesla
    5. Amazon
");
    switch (Console.ReadLine())
    {
        case "1":
            profile.SellStocks("Apple");
            break;
        case "2":
            profile.SellStocks("Microsoft");
            break;
        case "3":
            profile.SellStocks("Google");
            break;
        case "4":
            profile.SellStocks("Tesla");
            break;
        case "5":
            profile.SellStocks("Amazon");
            break;
        default:
            break;
    }
}