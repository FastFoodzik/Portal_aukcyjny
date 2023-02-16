using Portal_aukcyjny;
using System.Diagnostics;
using System.Xml.Linq;

var message = new Message();

message.DisplayWelcomeScreen();

var poczatek = Console.ReadLine();

var portal = new Portal();


List<Item> przedmioty = new List<Item>(); 
Item a = new Item(1, "Iphone 12 Pro", "elektronika", 4600, "tak");
Item b = new Item(2, "Konsola PlayStation 5", "elektronika", 2899, "nie");
Item c = new Item(3, "Bluza Adidas Męska Szara", "odzież", 249, "tak");
Item d = new Item(4, "Spodnie Wrangler Arizona", "odzież", 1890, "nie");
Item e = new Item(5, "Basen ogrodowy Premium", "dom i ogród", 1199, "nie");
Item f = new Item(6, "Krzesło skandynawska granatowe", "dom i ogród", 88, "nie");

przedmioty.Add(a);
przedmioty.Add(b);
przedmioty.Add(c);
przedmioty.Add(d);
przedmioty.Add(e);
przedmioty.Add(f);


List<Cards> cards = new List<Cards>();
Cards g = new Cards("Visa", 0001, 100);
Cards h = new Cards("Mastercard", 0002, 10000);
Cards i = new Cards("American Express", 0003, 3000);
Cards j = new Cards("Diners Club", 0004, 1000);

cards.Add(g);
cards.Add(h);
cards.Add(i);
cards.Add(j);





if (poczatek == "1")
{
    message.DisplayItems();
    portal.ShowItems(przedmioty);
    
    int przedmiot_id = message.ItemNumber();
    Item szukany_przedmiot = portal.CheckItemNumber(przedmioty, przedmiot_id);
    

    
    int karta_id = message.CardNumber();
    Cards szukana_karta = portal.CheckCardNumber(cards, karta_id);
    

    if(szukana_karta.CardMoney >= szukany_przedmiot.Price)
    {
        message.Bought(szukany_przedmiot.Name, szukany_przedmiot.Price, szukana_karta.CardName, szukana_karta.CardNumber);

    }

    else
    {
        message.Failure();
        return;
    }


}
    
    

else if (poczatek == "2")
{
    string nazwa = message.AddName();
    string kategoria = message.AddCategory();
    decimal cena = message.AddPrice();
    string wyrozniony = message.PrimeOrNot();

    Item k = new Item(7, nazwa, kategoria, cena, wyrozniony);
    
    przedmioty.Add(k);

    portal.ShowItems(przedmioty);
    Console.ForegroundColor= ConsoleColor.White;
}

else
{
    message.EndOfProgramBeforeEvenStart();
}








