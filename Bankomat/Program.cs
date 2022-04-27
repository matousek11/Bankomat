using System;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            IO io = new IO();
            io.MainPage();
            int requestedMoney = io.ChooseMoney();
            ATMLogic atmLogic = new ATMLogic();
            atmLogic.ATMInit(requestedMoney);
        }
    }
}
