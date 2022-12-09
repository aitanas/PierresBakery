namespace Bakery.Loaves
{
  public class Bread
  {
    public int Quantity;
    public int Price;
    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public int GetBreadPrice(int quantity) 
    {
      int price = 0;
      for (int i = 1; i <= quantity; i++)
      {
        price += 5;
        if (quantity % 3 == 0)
        {
          price -= 5;
        }
      }
      return price;
    }
  }
}