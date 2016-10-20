using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLib
{
    public class NumbersManager
    {
        public int GetNumber(string message)
        {
            bool isInputGood = false;
            int inputInt = 0;
            do
            {
                Console.Write(message);
                string inputStr = Console.ReadLine();
                try
                {
                    inputInt = int.Parse(inputStr);
                    isInputGood = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("'{0}' is not a valid number.", inputStr);
                }
            } while (!isInputGood);

            return inputInt;
        }

        public int GetNonZeroNumber(string message)
        {
            bool isInputGood = false;
            int inputInt = 0;
            do
            {
                Console.Write(message);
                string inputStr = Console.ReadLine();
                try
                {
                    inputInt = int.Parse(inputStr);
                    if (inputInt == 0)
                        throw new Exception("ZERO");

                    isInputGood = true;
                }
                catch (Exception exception)
                {
                    if (exception.Message == "ZERO")
                    {
                        Console.WriteLine("'0' is not a valid input");
                    }
                    else
                    {
                        Console.WriteLine("'{0}' is not a valid number.", inputStr);
                    }
                }
            } while (!isInputGood);

            return inputInt;
        }
    }
}
