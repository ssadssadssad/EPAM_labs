using System;
using System.Text;

namespace NumberSystems_BasicOf.Net
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string choice;
            do
            {
                Console.Write("Введите число в десятичной системе: ");
                ulong decNum;
                while (!ulong.TryParse(Console.ReadLine(), out decNum))
                {
                    Console.Write("Неверное значение. Пожалуйста, введите целое число: ");
                }
                Console.Write("Введите основание новой системы счисления: ");

                int baseOfNewSystem;
                while (!int.TryParse(Console.ReadLine(), out baseOfNewSystem) || (2 > baseOfNewSystem || baseOfNewSystem > 20))
                {
                    Console.Write("Неверное значение. Пожалуйста, введите основание (целое число от 2 до 20) новой системы счисления: ");
                }

                string newNum;
                newNum = DecimalToAnotherSystem(decNum, baseOfNewSystem);
                Console.WriteLine("{0} => {1}", decNum, newNum);

                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.WriteLine("Для выхода введите 'q'");
                choice = Console.ReadLine();
                Console.WriteLine();
            } while (choice != "q");
            Console.ReadLine();
        }

        //static string DecimalToAnotherSystemFrom2To10(ulong decimalNumber, int baseOfNewSystem)
        //{
        //    string binaryNumber = string.Empty;
        //    while (decimalNumber > 0)
        //    {
        //        binaryNumber = (decimalNumber % baseOfNewSystem) + binaryNumber;
        //        decimalNumber /= (ulong)baseOfNewSystem;
        //    }

        //    return binaryNumber;
        //}

        static string DecimalToAnotherSystem(ulong decimalNumber, int baseOfNewSystem)
        {
            string alphabet = "ABCDEFGHIJ";
            string binaryNumber = string.Empty;
            while (decimalNumber > 0)
            {
                ulong temp = decimalNumber % (ulong)baseOfNewSystem;
                if (temp >= 10)
                {
                    binaryNumber = alphabet[(int)temp - 10] + binaryNumber;
                }
                else
                {
                    binaryNumber = temp + binaryNumber;
                }
                decimalNumber /= (ulong)baseOfNewSystem;
            }

            return binaryNumber;
        }
    }
}
