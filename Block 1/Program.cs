namespace Block_1
{
    using System.Threading;
    internal class Program

    {
        static void Main(string[] args)
        {
            int sum_turns = 1;
            Random rnd = new Random();
            int start = rnd.Next(0, 100);
            Console.WriteLine("Компьютер загадал число");
            Thread.Sleep(3000);
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Ход номер: " + Convert.ToString(sum_turns));
                // ход игрока
                Console.Write("Ваш ход, введите число от 1 до 4: ");
                int turn = Convert.ToInt32(Console.ReadLine());
                if (turn > 4 || turn < 1)
                {
                    while (turn < 1 || turn > 4)
                    {
                        Console.Write("Введите число в корректном формате: ");
                        turn = Convert.ToInt32(Console.ReadLine());
                    }
                }
                start -= turn;

                if (start == 0)
                {
                    Console.WriteLine("Вы выиграли! Начальное число пришло к нулю.");
                    break;
                }
                if (start < 0)
                {
                    Console.WriteLine("Вы проиграли :( Начальное число пришло к отрицательному значению.");
                    break;
                }
                Console.WriteLine("Игра продолжается");
                Thread.Sleep(1000);
                // ход компьютера
                Console.WriteLine("Компьютер делает ход...");
                int freezy = rnd.Next(1000, 2000);
                int comp_turn = rnd.Next(1, 4);
                start -= comp_turn;
                Thread.Sleep(freezy);
                Console.WriteLine("Компьютьер сделал ход");
                if (start == 0)
                {
                    Console.WriteLine("Компьютер выиграл, дойдя до нуля :(");
                    break;
                }
                if (start < 0)
                {
                    Console.WriteLine("Вы выиграли! У компьютера перебор");
                    break;
                }
                Console.WriteLine("Игра продолжается");
                Thread.Sleep(1500);
                sum_turns += 1;
                Console.Clear();
            }
        }
    }
}  