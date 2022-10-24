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
            Console.Write("введите количество человек в очереди: ");

            int clientsCount = Convert.ToInt32(Console.ReadLine());
            Queue<int> clients = new Queue<int>(clientsCount);
            int check = 0;

            for(int i = 0; i < clientsCount; i++)
            {
                Console.Write($"Введите сумму покупики {i + 1} клиента: ");
                clients.Enqueue(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Clear();

            while(clients.Count > 0)
            {
                Console.WriteLine($"После оплаты на счет поступило {clients.Peek()} денег");

                check += clients.Dequeue();

                Console.WriteLine($"Ваш счет: {check}");
                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadLine();
        }
    }
}
