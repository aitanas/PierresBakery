using System.Collections.Generic;

namespace Bakery.Prices
{
  public class Pricing
  {
    public int GetTotalPrice(int quantity, int discCost, int regCost)
    {
      List<int> bakeryReceipt = new List<int> {};
      int totalPrice = 0;
      for (int i = 1; i <= quantity; i++)
      {
        if (i % 3 == 0)
        {
          bakeryReceipt.Add(discCost);
        }
        else
        {
          bakeryReceipt.Add(regCost);
        }
      }

      for (int j = 0; j < bakeryReceipt.Count; j++)
      {
        totalPrice += bakeryReceipt[j];
      }
      return totalPrice;
    }
  }
}