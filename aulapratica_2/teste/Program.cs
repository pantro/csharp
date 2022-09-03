var stock = new Stock { CurrentPrice = 50, SharesOwned = 100 };

Console.WriteLine(stock.Worth);           // 5000

public class Stock
{
  decimal currentPrice;           // Atributo privado
  public decimal CurrentPrice     // Propriedade pública
  {
    get { return currentPrice; } set { currentPrice = value; }
  }

  decimal sharesOwned;           // Atributo privado
  public decimal SharesOwned     // Propriedade pública
  {
    get { return sharesOwned; } set { sharesOwned = value; }
  }

  public decimal Worth          // Propriedade calculada
  {
    get { return currentPrice * sharesOwned; }
  }
}