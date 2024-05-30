using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Regex
{
    internal class Furniture
    {
        static void Main(string[] args)
        {
            List<string> furnitureBought = new List<string>();
            decimal totalMoneySpended = 0;

            string regex = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match furnitureInfo = Regex.Match(input, regex);

                if (furnitureInfo.Success)
                {
                    string furnitureName =
                        furnitureInfo.Groups["name"].Value;
                    decimal price =
                        decimal.Parse(furnitureInfo.Groups["price"].Value);
                    int quantity =
                        int.Parse(furnitureInfo.Groups["quantity"].Value);

                    furnitureBought.Add(furnitureName);
                    totalMoneySpended += price * quantity;
                }
            }

            PrintOutput(furnitureBought, totalMoneySpended);
        }

         protected static void PrintOutput(List<string> furnitures, decimal moneySpend)
        {
            Console.WriteLine("Bought furniture:");

            foreach (var furnitureName in furnitures)
            {
                Console.WriteLine(furnitureName);
            }

            Console.WriteLine($"Total money spend: {moneySpend:f2}");
        }
    }
}
   
