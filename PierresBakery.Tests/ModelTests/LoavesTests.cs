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
      Bread challah = new Bread();
      Assert.AreEqual(typeof(Bread), challah.GetType());
    }

    public void BreadConstructor_ReturnsUserSelection_Int()
    {
      int quantity = 3;
      Bread challah = new Bread(quantity);
      Assert.AreEqual(quantity, challah.Quantity);
    }
  }
}