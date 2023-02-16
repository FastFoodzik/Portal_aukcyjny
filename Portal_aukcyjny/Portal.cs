using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Portal_aukcyjny
{
    internal class Portal
    {

     
        public void ShowItems(List<Item> przedmioty)
        {

            int i = 1;
            foreach (Item item in przedmioty)
            {
                

                if (item.isprime == "tak")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine(i + "." + item.Name + "  |  " + item.Category + "  |  " + item.Price + "  PLN");



                i++;
                

                
            }
        }




       public Item CheckItemNumber(List<Item> przedmioty, int item_id)
        {
            foreach (Item id in przedmioty)
            {
                if (item_id == id.Id)
                {
                    return id;
                    
                }

                
            }

            return null;

        }

        public Cards CheckCardNumber(List<Cards> karty, int card_id)
        {
            foreach (Cards id in karty)
            {
                if (card_id == id.CardNumber)
                {
                    
                    return id;

                }


            }

            return null;

        }

    }
    
}
