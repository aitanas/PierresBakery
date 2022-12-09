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
      return 9;
    }
  }
}