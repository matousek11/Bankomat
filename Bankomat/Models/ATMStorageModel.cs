using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class ATMStorageModel
    {
        public BankNoteModel OneHundredBankNote { get; set; }
        public BankNoteModel TwoHundredBankNote { get; set; }
        public BankNoteModel FiveHundredBankNote { get; set; }
        public BankNoteModel OneThousandBankNote { get; set; }
        public BankNoteModel TwoThousandBankNote { get; set; }
        public BankNoteModel FiveThousandBankNote { get; set; }
    }
}
