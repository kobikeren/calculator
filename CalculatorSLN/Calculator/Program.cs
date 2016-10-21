using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationLib;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {            
            NumbersManager nm = new NumbersManager();
            char selection;
            int firstNumber, secondNumber;
            do
            {
                Console.Write(
                    "Please select [a]dd, [s]ubtract, [m]ultiply, [d]ivide, [e]xit: ");
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (selection)
                {
                    case 'a':
                        firstNumber = nm.GetNumber("Please enter first number: ");
                        secondNumber = nm.GetNumber("Please enter second number: ");
                        Console.WriteLine("{0} + {1} = {2}",
                            firstNumber, secondNumber, firstNumber + secondNumber);
                        break;
                    case 's':
                        firstNumber = nm.GetNumber("Please enter first number: ");
                        secondNumber = nm.GetNumber("Please enter second number: ");
                        Console.WriteLine("{0} - {1} = {2}",
                            firstNumber, secondNumber, firstNumber - secondNumber);
                        break;
                    case 'm':
                        firstNumber = nm.GetNumber("Please enter first number: ");
                        secondNumber = nm.GetNumber("Please enter second number: ");
                        Console.WriteLine("{0} * {1} = {2}",
                            firstNumber, secondNumber, firstNumber * secondNumber);
                        break;
                    case 'd':
                        firstNumber = nm.GetNumber("Please enter first number: ");
                        secondNumber = nm.GetNonZeroNumber("Please enter second number: ");
                        Console.WriteLine("{0} / {1} = {2}",
                            firstNumber, secondNumber, firstNumber / secondNumber);
                        break;
                    case 'e':
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (selection != 'e');

            Console.WriteLine();
            Console.WriteLine("Goodbye....");



            Console.ReadKey();
        }
    }
}
