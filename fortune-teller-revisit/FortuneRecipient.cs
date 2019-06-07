using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortune_teller_revisit
{
    public class FortuneRecipient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public BirthMonth BirthMonth { get; set; }
        public int RetirementAge { get; set; }
        public float MoneyInBank { get; set; }
        public string VacationHome { get; set; }
        public string Transportation { get; set; }
        public int NumberOfSiblings { get; set; }
        public void DisplayFortune()
        {
            Console.WriteLine($"{Name} will retire at {RetirementAge} with {MoneyInBank.ToString("C")}, " +
            $"a vacation home in {VacationHome}, and a {Transportation}");
        }
    }
}
