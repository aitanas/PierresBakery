using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Pastries;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Object()
    {
      Pastry croissant = new Pastry();
      Assert.AreEqual(typeof(Pastry), croissant.GetType());
    }

    [TestMethod]
    public void PastryConstructor_StoresUserSelection_Int()
    {
      int quantity = 5;
      Pastry croissant = new Pastry(5);
      Assert.AreEqual(quantity, croissant.Quantity);
    }
  }
}