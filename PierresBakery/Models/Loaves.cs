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

    public int GetBreadPrice() 
    {
      return 10;
    }
  }
}