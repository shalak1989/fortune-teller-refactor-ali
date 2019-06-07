using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortune_teller_revisit
{
    public class FortuneProcessor
    {
        private Dictionary<string, string> transportationMethod = new Dictionary<string, string>()
        {
            { "red", "full-size pickup truck" }, { "orange", "motorcycle" }, { "yellow", "Jeep" },
            { "green", "Minivan" }, { "blue", "bicycle" }, { "indigo", "convertible" },
            { "violet", "four door sedan" }, { "default", "you're walking everywhere" }
        };

        public void Run(FortuneRecipient fortuneRecipient)
        {
            PopulateBasicDemographicInformation(fortuneRecipient);
            SetRetirementAge(fortuneRecipient);
            SetBirthMonth(fortuneRecipient);
            SetMoneyInBank(fortuneRecipient);
            SetTransportationChoice(fortuneRecipient);
            SetVacationHome(fortuneRecipient);
        }

        private void PopulateBasicDemographicInformation(FortuneRecipient fortuneRecipient)
        {
            Console.WriteLine("What is your name?");
            fortuneRecipient.Name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            fortuneRecipient.Age = int.Parse(Console.ReadLine());
        }

        private void SetBirthMonth(FortuneRecipient fortuneRecipient)
        {
            Console.WriteLine("In which month were you born?");
            string userMonthString = Console.ReadLine().ToLower();

            BirthMonth birthMonth;
            bool isValidBirthMonth = Enum.TryParse(userMonthString, true, out birthMonth);
            if (!isValidBirthMonth)
            {
                Console.WriteLine("Invalid month, please enter a valid birth month!\n");
                SetBirthMonth(fortuneRecipient);
            }

            fortuneRecipient.BirthMonth = birthMonth;
        }

        private void SetMoneyInBank(FortuneRecipient fortuneRecipient)
        {
            var birthMonth = (int)fortuneRecipient.BirthMonth;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                fortuneRecipient.MoneyInBank = 1800000;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                fortuneRecipient.MoneyInBank = 875000;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                fortuneRecipient.MoneyInBank = 3000000;
            }
        }

        private void SetRetirementAge(FortuneRecipient fortuneRecipient)
        {

            if (fortuneRecipient.Age % 2 == 0)
            {
                fortuneRecipient.RetirementAge = 55;
            }
            else
            {
                fortuneRecipient.RetirementAge = 48;
            }
        }

        private void SetTransportationChoice(FortuneRecipient fortuneRecipient)
        {
            Console.WriteLine("Which of these colors is your favorite? Red, orange, yellow, green, blue, indigo, or violet?");
            string faveColorValue = Console.ReadLine().ToLower();
            if (transportationMethod.ContainsKey(faveColorValue))
            {
                fortuneRecipient.Transportation = transportationMethod[faveColorValue];
            }
            else
            {
                fortuneRecipient.Transportation = transportationMethod["default"];
            }
        }

        private void SetVacationHome(FortuneRecipient fortuneRecipient)
        {
            Console.WriteLine("Finally, how many siblings do you have?");
            fortuneRecipient.NumberOfSiblings = int.Parse(Console.ReadLine());

            if (fortuneRecipient.NumberOfSiblings == 0)
            {
                fortuneRecipient.VacationHome = "Anne Arbor";
            }
            else if (fortuneRecipient.NumberOfSiblings == 1)
            {
                fortuneRecipient.VacationHome = "London";
            }
            else if (fortuneRecipient.NumberOfSiblings == 2)
            {
                fortuneRecipient.VacationHome = "Cancun";
            }
            else if (fortuneRecipient.NumberOfSiblings == 3)
            {
                fortuneRecipient.VacationHome = "Dublin";
            }
            else if (fortuneRecipient.NumberOfSiblings > 3)
            {
                fortuneRecipient.VacationHome = "Tampa";
            }
            else
            {
                fortuneRecipient.VacationHome = "Boondocks";
            }
        }
    }
}
