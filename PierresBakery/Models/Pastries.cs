using Bakery.Prices;

namespace Bakery.Pastries
{
  public class Pastry : Pricing
  {
    public int Quantity;
    public int Price;
    public Pastry(int quantity)
    {
      Quantity = quantity;
      Price = GetTotalPrice(quantity, 1, 2);
    }
  }
}