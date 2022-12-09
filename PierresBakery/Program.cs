using System;
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
      userResponse.ToUpper();
      int breadCost = 5;
      int breadDiscCost = 0;
      int pastryCost = 2;
      int pastryDiscCost = 1;

      if (userResponse.Contains("Y"))
      {
        Console.WriteLine("How many loaves of bread would you like?");
        string strBreadQuantity = Console.ReadLine();
        int breadQuantity = int.Parse(strBreadQuantity);
        Bread breadOrder = new Bread(breadQuantity);
        int breadPrice = breadOrder.GetTotalPrice(breadQuantity, breadDiscCost, breadCost);
        Console.WriteLine("Your bread total is ${0}.", breadPrice);
        
        Console.WriteLine("How many pastries would you like?");
        string strPastryQuantity = Console.ReadLine();
        int pastryQuantity = int.Parse(strPastryQuantity);
        Pastry pastryOrder = new Pastry(pastryQuantity);
        int pastryPrice = pastryOrder.GetTotalPrice(pastryQuantity, pastryDiscCost, pastryCost);
        Console.WriteLine("Your pastry total is ${0}.", pastryPrice);

        int subtotal = breadPrice + pastryPrice;
        Console.WriteLine("Your final total is ${0}.", subtotal);
        Console.WriteLine("Thank you for stopping by! Please come again soon!");
      }
      else if (userResponse.Contains("N"))
      {
        Console.WriteLine("Thank you for stopping by! Please come again soon!");
      }
      else
      {
        Console.WriteLine("Sorry, what was that? Please try again!");
        Main();
      }
      }

    }

  }