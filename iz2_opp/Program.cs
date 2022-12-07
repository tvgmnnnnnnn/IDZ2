using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz2_opp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Provaider pro = new Provaider();
            Provaider.Initial();
            Console.WriteLine("Провайдер готов к работе.");
            Console.Write("Идентефикация клиента :");
            string fio = Console.ReadLine();
            Console.Write("Введите личный номер :");
            string ticket = Console.ReadLine();
            Client client = new Client(fio, ticket);

            Console.WriteLine("Уважаемый " + client.fio + ", выберите действие:\n" +
                "1-Вывод списка тарифов\n" +
                "2-Запрос тарифа\n" +
                "0-Выход");
            int doIt = int.MaxValue;
            while (doIt > 0)
            {
                Console.Write("Ваш выбор :");
                doIt = int.Parse(Console.ReadLine());
                switch (doIt)
                {
                    case 1:
                        pro.ListBooks();
                        break;
                    case 2:
                        Console.Write("Введите номер тарифа :");
                        int kode = int.Parse(Console.ReadLine());
                        pro.GetBook(kode, client);
                        break;
                    case 0:
                        doIt = 0;
                        break;
                    default: break;

                }
            }
            Console.ReadLine();
        }
    }
}
