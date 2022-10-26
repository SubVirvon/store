using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clientsCount = CheckInput("введите количество человек в очереди: "); 
            Queue<int> clients = new Queue<int>(clientsCount);
            int totalCost = 0;

            for(int i = 0; i < clientsCount; i++)
            {
                clients.Enqueue(CheckInput($"Введите сумму покупики {i + 1} клиента: "));
            }

            int clientsCounter = 0;

            Console.Clear();

            while(clients.Count > 0)
            {
                clientsCounter++;

                Console.WriteLine($"После оплаты {clientsCounter} клиента, на счет поступило {clients.Peek()} денег");

                totalCost += clients.Dequeue();

                Console.WriteLine($"Ваш счет: {totalCost}");
                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadLine();
        }

        static int CheckInput(string expectedAction)
        {
            string input;
            bool isCorrect = false;
            int result = 0;
            string errorMessage = "Некоректный ввод";

            while (isCorrect == false)
            {
                Console.Write(expectedAction);

                input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }

            return result;
        }
    }
}
