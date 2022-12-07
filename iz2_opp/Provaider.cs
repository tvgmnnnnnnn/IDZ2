using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz2_opp
{
    internal class Provaider
    {
        public static Dictionary<Client, Tarif> dict = new Dictionary<Client, Tarif>();
        public static List<Client> clients = new List<Client>();
        public static List<Tarif> tarifs = new List<Tarif>();
        public static Provaider Initial()
        {
            var res = new Provaider();
            var tarif= new Tarif();

            tarif.name = "Интернет за 300";
            tarif.group = Group.Internet;
            tarif.cost = "300";
            tarif.kode = "001";
            tarif.condition = Condition.Off;
            tarifs.Add(tarif);

            tarif.name = "Интернет за 500";
            tarif.group = Group.Internet;
            tarif.cost = "500";
            tarif.kode = "002";
            tarif.condition = Condition.On;
            tarifs.Add(tarif);

            tarif.name = "Интернет за 700";
            tarif.group = Group.Internet;
            tarif.cost = "700";
            tarif.kode = "003";
            tarif.condition = Condition.Off;
            tarifs.Add(tarif);

            tarif.name = "Связь за 200";
            tarif.group = Group.Svyaz;
            tarif.cost = "200";
            tarif.kode = "004";
            tarif.condition = Condition.On;
            tarifs.Add(tarif);

            tarif.name = "Связь за 400";
            tarif.group = Group.Svyaz;
            tarif.cost = "400";
            tarif.kode = "005";
            tarif.condition = Condition.Off;
            tarifs.Add(tarif);

            tarif.name = "Связь за 600";
            tarif.group = Group.Svyaz;
            tarif.cost = "600";
            tarif.kode = "006";
            tarif.condition = Condition.Off;
            tarifs.Add(tarif);

            return res;
        }

        public void GetBook(int kod, Client reader)
        {
            Tarif pTarif = null;
            foreach (Tarif tarif in tarifs)
            {
                if (int.Parse(tarif.kode) == kod)
                {
                    pTarif = tarif;
                }
            }
            if (pTarif != null)
            {
                if (pTarif.condition.Equals(Condition.Off))
                {
                    pTarif.condition = Condition.On;
                    dict.Add(reader, pTarif);
                    Console.WriteLine("Новый тариф подключен.");
                }
                else Console.WriteLine("Тариф уже подключен.");
            }
            else Console.WriteLine("Такого тарифа не существует.");
        }

        public void ListBooks()
        {
            if (tarifs.Count != 0)
            {
                foreach (Tarif book in tarifs)
                {
                    Console.WriteLine(book.kode + "\n" + book.name + "\n" + book.group + "\n" + book.cost + "\n" + book.condition);
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Список тарифов пуст.");
        }
    }
}
