using Bakery.Prices;

namespace Bakery.Loaves
{
  public class Bread : Pricing
  {
    public int Quantity;
    public int Price;
    public Bread(int quantity)
    {
      Quantity = quantity;
      Price = GetTotalPrice(quantity, 0, 5);
    }
  }
}
