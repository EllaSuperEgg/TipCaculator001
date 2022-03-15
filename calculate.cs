using System;
using System.Collections.Generic;
using System.Text;

namespace TipCaculator001
{
    class Calculate
    {
        public Calculate()
        {
            DisplayText();
        }

        void DisplayText()
        {
            Console.WriteLine("What was the total of your bill?");
            string input = Console.ReadLine();
            double billTotal = Convert.ToDouble(input);

            Console.Clear();
            Console.WriteLine("How much do you want to pay for the tips");
            Console.WriteLine("1)15%");
            Console.WriteLine("2)20%");
            Console.WriteLine("3)30%");
            input = Console.ReadLine();
            double choice = Convert.ToDouble(input);
            Console.Clear();
            Tip(billTotal, choice);
        }

        private void Tip(double billTotal, double choice)
        {
            double tipAmount=0;
            switch (choice)
            {
                case 1:
                    tipAmount = .15;
                    break;
                case 2:
                    tipAmount = .20;
                    break;
                case 3:
                    tipAmount = .30;
                    break;

            }

            double finalTip = billTotal * tipAmount;
            double finalBillTotal = billTotal + finalTip;

            Print(finalTip, finalBillTotal);
        }

        private void Print(double finalTip,double finalBillTotal)
        {
            Console.WriteLine("Your tip choice is  " + finalTip);
            Console.WriteLine("Your final bill total is  " + finalBillTotal);
            Console.WriteLine("Please press Enter to calculate again...");
            Console.ReadKey();
            Console.Clear();
            DisplayText();


        }
    }
}
