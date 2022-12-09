using System;
using System.Collections.Generic;
using Bakery.Loaves;
using Bakery.Pastries;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("• • • • •");
      Console.WriteLine("TODAY'S MENU");
      Console.WriteLine("• • • • •");
      Console.WriteLine("Loaf of Bread.........................$5/each");
      Console.WriteLine("Daily Special: Buy 2 loaves, get 1 free!");
      Console.WriteLine("• • •");
      Console.WriteLine("Pastry................................$2/each");
      Console.WriteLine("Daily Special: Buy 2 pastries, get 1 50% off!");
      Console.WriteLine("• • •");
      Console.WriteLine("Would you like to purchase any baked goods today? (Y/N)");
      string userResponse = Console.ReadLine();
      

    }

  }

}