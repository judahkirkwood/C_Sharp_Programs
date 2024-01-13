using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            // (To "comment out" code, highlight and press CTRL+K+C)
            // (To remove comments, highlight "commented code" and press CTRL+K+U)
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is yout favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = true;
            byte hoursWorked = 45;
            sbyte currentTemperature = -13;
            char questionMark = '\u2103';
            decimal moneyInBank = 124000.5m;
            double heightInCentimeters = 211.30202092;
            float secondsLeft = 2.62f;
            short temperatureOnMars = -342;
            string myName = "Judah";

            int currentAge = 38;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();





            Console.WriteLine(questionMark);
            Console.ReadLine();
        }
    }
}
