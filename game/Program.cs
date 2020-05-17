using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicGame Lg = new LogicGame();
            Console.WriteLine($"сгенерированно число {Lg.Number.Length}");
            while (true)
            {
                Console.WriteLine("Введите ответ");
                Lg.Answer = Console.ReadLine();
                
                string ans = Lg.CheckAnswer();
                if (ans == "ok")
                {
                    Console.WriteLine($"Количество быков {Lg.Compare().Item1}, Количество коров {Lg.Compare().Item2}");
                    if (Lg.IsEndGame())
                    {
                        Console.WriteLine("Угадали");
                        break;
                    }


                }
                else
                {
                    Console.WriteLine(ans);
                }
            }

            
            
        }
        // использовать logic game and generate number не копируя их в проект winform  только вызовы методов
    }
}
