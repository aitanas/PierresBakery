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
  }
}