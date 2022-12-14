using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Loaves;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Object()
    {
      Bread challah = new Bread(3);
      Assert.AreEqual(typeof(Bread), challah.GetType());
    }

    [TestMethod]
    public void BreadConstructor_StoresUserSelection_Int()
    {
      int quantity = 3;
      Bread challah = new Bread(quantity);
      Assert.AreEqual(quantity, challah.Quantity);
    }

    [TestMethod]
    public void GetBreadPrice_ReturnPriceBasedOnQuantity_Int()
    {
      int quantity = 10;
      Bread challah = new Bread(quantity);
      int price = 35;
      Assert.AreEqual(price, challah.Price);
    }
  }
}