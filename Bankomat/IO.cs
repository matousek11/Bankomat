using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class IO
    {
        public void MainPage()
        {
            Console.WriteLine("Vítejte u České Spořitelny");
            Console.WriteLine("--------------------------");
            Console.Write("Zadejte pin:");
            Console.ReadLine();
            Console.Clear();
        }

        public int ChooseMoney()
        {
            Console.WriteLine("Kolik si přejete vybrat?");

            int requestedMoney = int.Parse(Console.ReadLine());
            Console.WriteLine("Přejete si vybrat " + requestedMoney.ToString() + "Kč");
            return requestedMoney;
        }
    }
}
