using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class ATMLogic
    {
        private List<BankNoteModel> BankNoteVariants { get; set; }
        public void ATMInit(int requestedMoney)
        {
            Random random = new Random();
            GenerateBankNotes(random);
            Console.WriteLine(ReturnBankNoteVariants(requestedMoney).ToString());

        }

        private void GenerateBankNotes(Random random)
        {
            AddBankNote(1, "Sto korun", 100, random.Next(20));
            AddBankNote(2, "Dvě stě korun", 200, random.Next(20));
            AddBankNote(3, "Pět set korun", 500, random.Next(20));
            AddBankNote(4, "Tisíc korun", 1000, random.Next(20));
            AddBankNote(5, "Dva tisíce korun", 2000, random.Next(20));
            AddBankNote(6, "Pět tisíc korun", 5000, random.Next(20));
        }

        private void AddBankNote(int id, string name, int value, int number)
        {
            BankNoteVariants.Add(
                    new BankNoteModel()
                    {
                        Id = id,
                        Name = name,
                        Value = value,
                        Number = number
                    }
                );
        }

        public int ReturnBankNoteVariants(int requestedMoney)
        {
            for (int i = 6; i > 0; i--)
            {
                int result = ReturnNumberOfBankNotes(requestedMoney, BankNoteVariants.Find(x => x.Id == i).Value;
                if (1 <= result)
                {
                    int moreMoneyToReturn = requestedMoney - result * BankNoteVariants.Find(x => x.Id == 6).Value;
                    if(moreMoneyToReturn > 0)
                    {

                    }
                }
            }

            
            return 0;
        }

        private int ReturnNumberOfBankNotes(int divide, int divider)
        {
            float result = divide / divider;
            return (int)Math.Floor(result);
        }
    }
}
