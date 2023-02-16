using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_aukcyjny

{
    internal class Cards
    {
        public string CardName { get; set; }
        public int CardNumber { get; set; }
        public decimal CardMoney { get; set; }

        public Cards(string CardName, int CardNumber, decimal CardMoney)
        {
            this.CardName = CardName;
            this.CardNumber = CardNumber;
            this.CardMoney = CardMoney;
        }


    }
}



