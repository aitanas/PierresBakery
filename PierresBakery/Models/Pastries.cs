using System.Collections.Generic;
using Bakery.Prices;

namespace Bakery.Pastries
{
  public class Pastry : Pricing
  {
    public int Price;
    public int Quantity;

    public Pastry(int quantity)
    {
      Quantity = quantity;
      Price = GetTotalPrice(quantity, 1, 2);
    }
  }
}