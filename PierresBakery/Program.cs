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
      Console.WriteLine("Honey Challah...................$5/loaf");
      Console.WriteLine("Swiss Roll......................$5/loaf");
      Console.WriteLine("Daily Special: Buy 2 loaves, get 1 free!");
      Console.WriteLine("• • •");
      Console.WriteLine("Cheese Danish...................$2/each");
      Console.WriteLine("Morning Bun.....................$2/each");
      Console.WriteLine("Daily Special: Buy 2 pastries, get 1 50% off!");
      Console.WriteLine("• • •");
      Console.WriteLine("Would you like to purchase any baked goods today? (Y/N)");
      string userResponse = Console.ReadLine();
      userResponse.ToUpper();

      if (userResponse.Contains("Y"))
      {
        BreadOrder();
        PastryOrder();
      }
      else if (userResponse.Contains("N"))
      {
        Console.WriteLine("Thank you for stopping by! Please come again soon!");
      }
      else
      {
        Console.WriteLine("Sorry, invalid response.");  
      }
    }
      public static int BreadOrder()
      {
        Dictionary<string, int> menu = new Dictionary<string, int>
        {
          {"reg", 5}, {"disc", 0}
        };

        Console.WriteLine("What kind of bread would you like today? Please select your bread using the corresponding numbers on the left.");
        Console.WriteLine("(0) No bread for me, thanks!");
        Console.WriteLine("(1) Honey Challah...................$5/loaf");
        Console.WriteLine("(2) Swiss Roll......................$5/loaf");
        Console.WriteLine("Daily Special: Buy 2 loaves, get 1 free!");
        string breadSelection = Console.ReadLine();
        if (int.Parse(breadSelection) > 0)
        {
          Console.WriteLine("How much bread would you like?");
          string strBreadQuantity = Console.ReadLine();
          int breadQuantity = int.Parse(strBreadQuantity);
          return breadQuantity;
        }
        else
        { 
          return 0;
        }
      }

      public static int PastryOrder()
      {
        Dictionary<string, int> menu = new Dictionary<string, int>
        {
          {"reg", 2}, {"disc", 1}
        };
        Console.WriteLine("What kind of pastry would you like today? Please select your bread using the corresponding numbers on the left.");
        Console.WriteLine("(0) No pastries for me, thanks!");
        Console.WriteLine("(1) Cheese Danish...................$2/each");
        Console.WriteLine("(2) Morning Bun.....................$2/each");
        Console.WriteLine("Daily Special: Buy 2 pastries, get 1 50% off!");
        string pastrySelection = Console.ReadLine();
        if (int.Parse(pastrySelection) > 0)
        {
          Console.WriteLine("How many pastries would you like?");
          string strPastryQuantity = Console.ReadLine();
          int pastryQuantity = int.Parse(strPastryQuantity);
          Pastry pastryOrder = new Pastry(pastryQuantity);
          int pastryPrice = pastryOrder.GetTotalPrice(pastryQuantity, menu["disc"], menu["reg"]);
          return pastryQuantity;
        }
        else
        {
          return 0;
        }
      }
    
      public static void OrderTotal(int breadPrice, int pastryPrice)
      {
        int breadPrice = BreadOrder();
        int pastryPrice = PastryOrder();
          Bread breadOrder = new Bread(breadQuantity);
          int breadPrice = breadOrder.GetTotalPrice(breadQuantity, menu["disc"], menu["reg"]);
          Console.WriteLine("Your bread total is ${0}.", breadPrice);
        int subtotal = breadPrice + pastryPrice;
        Console.WriteLine("Your final total is ${0}.", subtotal);
        Console.WriteLine("Thank you for stopping by! Please come again soon!");
      }
      }
  }


