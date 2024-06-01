Func<List<decimal>, List<decimal>> vat = price => AddVAT(price);
List<decimal> AddVAT(List<decimal> price)
{
    for (int i = 0; i < price.Count; i++)
    {
        decimal result = price[i] * 0.20m;
       price[i] = Math.Round(price[i] + result,2);
    }
    return price;
}

List<decimal> prices = Console.ReadLine().Split(", ",
    StringSplitOptions.RemoveEmptyEntries).Select(price => decimal.Parse(price)).ToList();

Console.WriteLine(string.Join(Environment.NewLine, AddVAT(prices)));