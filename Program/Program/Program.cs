using System;
using System.Threading;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Приветсвуем Вас в нашем казино. Как Вас зовут?");
            string Gamer_Name = Console.ReadLine();
            string Anew = "да";
            string Card;
            int PlusPoint;

            while (Anew.Equals("Да", StringComparison.InvariantCultureIgnoreCase)) 
            {                
                var Gamer = new Gamer();
                Gamer.Name = Gamer_Name;
                Thread.Sleep(3000);
                Console.WriteLine(Gamer.Greeting(Gamer_Name));
                var Croupier = new Croupier();
                Croupier.Name = "Крупье";
                var Deck = new DeckOfCards();
                Thread.Sleep(3000); 
                Console.WriteLine($"{Croupier.Name} берет 2 карты");
                for (int i = 0; i<=1; i++)
                {
                    Card=Deck.getCard();                    
                    PlusPoint = Deck.getPlusPoint(Card);
                    Croupier.ListOfCard.Add(Card);
                    Croupier.UpdatePoint(PlusPoint);
                }
                Console.WriteLine($"У {Croupier.Name} есть карта {Croupier.ListOfCard[1]}");
                Thread.Sleep(3000);
                Console.WriteLine($"{Gamer.Name} берет 2 карты");
                Thread.Sleep(3000);
                for (int i = 0; i <= 1; i++)
                {
                    Card = Deck.getCard();
                    PlusPoint = Deck.getPlusPoint(Card);
                    Gamer.ListOfCard.Add(Card);
                    Gamer.UpdatePoint(PlusPoint);
                }
                Console.WriteLine($"У тебя карты: {string.Join(',', Gamer.ListOfCard)}. Это {Gamer.Points} очков");
                Console.WriteLine("Берете еще?");
                string AnswerOnQuestion = Console.ReadLine();
                while (AnswerOnQuestion.Equals("да", StringComparison.InvariantCultureIgnoreCase))
                {
                    Card = Deck.getCard();
                    PlusPoint = Deck.getPlusPoint(Card);
                    Gamer.ListOfCard.Add(Card);
                    Gamer.UpdatePoint(PlusPoint);
                    Console.WriteLine($"Вы взяли {Card}. Всего {Gamer.Points} очков");
                    Thread.Sleep(2);
                    Console.WriteLine("Берете еще?");
                    AnswerOnQuestion = Console.ReadLine();
                }
                Thread.Sleep(3000);
                Console.WriteLine($"У тебя карты: {string.Join(',', Gamer.ListOfCard)}. Это {Gamer.Points} очков");
                Thread.Sleep(3000);
                if (Gamer.Points <= 21)
                {
                    Console.WriteLine($"Теперь очередь {Croupier.Name}");
                    while (Croupier.Points < 17)
                    {
                        Console.WriteLine("Крупье берет карту");
                        Card = Deck.getCard();
                        PlusPoint = Deck.getPlusPoint(Card);
                        Croupier.ListOfCard.Add(Card);
                        Croupier.UpdatePoint(PlusPoint);
                    }
                    Thread.Sleep(3000);
                    Console.WriteLine($"Итак, карты {Croupier.Name}: {string.Join(',', Croupier.ListOfCard)}. Это {Croupier.Points} очков.");
                    Thread.Sleep(3000);
                    Console.WriteLine($"У {Gamer.Name}: {string.Join(',', Gamer.ListOfCard)}. Это {Gamer.Points} очков.");
                    Thread.Sleep(3000);
                    if (Gamer.Points > Croupier.Points || Croupier.Points>21)
                    {
                        Console.WriteLine("Поздравляю, Вы выиграли");
                    }
                    if (Gamer.Points < Croupier.Points && Croupier.Points<=21)
                    {
                        Console.WriteLine("Ай, Вы проиграли");
                    }
                    if (Gamer.Points == Croupier.Points)
                    {
                        Console.WriteLine("Ничья");
                    }
                }
                if(Gamer.Points>21)
                {
                    Console.WriteLine($"У вас {Gamer.Points} очков, это перебор");
                }



                
                Console.WriteLine("Начать заново?");
                Anew = Console.ReadLine();

            }
            Console.WriteLine("Спасибо за игру");



        }
    }
}
