using System.Collections.Generic;

namespace Bakery.Pastries
{
  public class Pastry
  {
    public int Price;
    public int Quantity;

    public Pastry(int quantity)
    {
      Quantity = quantity;
      Price = GetPastryPrice(quantity);
    }

    public int GetPastryPrice(int quantity)
    {
      List<int> price = new List<int> {};
      int totalPrice = 0;
      for (int i = 1; i <= quantity; i++)
      {
        if (i % 3 == 0)
        {
          price.Add(1);
        }
        else
        {
          price.Add(2);
        }
      }

      for (int j = 0; j < price.Count; j++)
      {
        totalPrice += price[j];
      }
      return totalPrice;
    }
  }
}