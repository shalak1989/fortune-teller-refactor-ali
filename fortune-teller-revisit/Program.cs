using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortune_teller_revisit
{
    class Program
    {
        static void Main(string[] args)
        {
            var fortuneReceipient = new FortuneRecipient();
            var process = new FortuneProcessor();
            process.Run(fortuneReceipient);
            fortuneReceipient.DisplayFortune();
            Console.WriteLine("Hit any key to close");
            Console.ReadKey();
        }
    }
}
