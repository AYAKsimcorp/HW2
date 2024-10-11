using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        enum TransactionType { Buy, Sell }
        static void Main(string[] args)
        {

            Console.WriteLine("Input the nominal of the trade:");
            string userInput = Console.ReadLine();
            int nominal = Int32.Parse(userInput);

            Console.WriteLine("Input the trade price:");
            userInput = Console.ReadLine();
            decimal tradePrice = Decimal.Parse(userInput);

            Console.WriteLine("Input the transaction type (Buy or Sell):");
            userInput = Console.ReadLine();
            TransactionType trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            int sign = (trcType == TransactionType.Buy) ? 1 : -1;

            decimal currentValue = sign * nominal * tradePrice;

            Console.WriteLine($"The current value of the transaction is: {currentValue:C}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
