using System.Collections.Generic;

namespace Bakery.Loaves
{
  public class Bread
  {
    public int Quantity;
    public int Price;
    public Bread(int quantity)
    {
      Quantity = quantity;
      Price = GetBreadPrice(quantity);
    }

    public int GetBreadPrice(int quantity) 
    {
      List<int> price = new List<int> {};
      int totalPrice = 0;
      for (int i = 1; i <= quantity; i++)
      {
        if (i % 3 == 0)
        {
          price.Add(0);
        }
        else
        {
          price.Add(5);
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