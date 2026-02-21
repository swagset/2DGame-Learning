namespace Game2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Game();
        }
    }
    public class Game
    {
        private int[] Player = { 3, 7 };
        private bool isStarted = true;
        private char[,] map = new char[8, 16];
        private char PlayerIcon = '&';
        private char MapIcon = '*';
        public Game()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = MapIcon;
                }
            }
            map[Player[0], Player[1]] = PlayerIcon;
            while (isStarted)
            {
                UpdateMap();
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.W:
                        Move("Up");
                        break;
                    case ConsoleKey.A:
                        Move("Left");
                        break;
                    case ConsoleKey.S:
                        Move("Down");
                        break;
                    case ConsoleKey.D:
                        Move("Right");
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("Game over!");
                        isStarted = false;
                        break;
                }
            }
        }
        private void UpdateMap()
        {
            Console.Clear();
            Console.WriteLine("==Hello, gamer!==");
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
        private void Move(string Direction)
        {
            if (Direction == "Left")
            {
                if (Player[1] == 0)
                {
                    map[Player[0], Player[1]] = MapIcon;
                    map[Player[0], map.GetLength(1) - 1] = PlayerIcon;
                    Player[1] = map.GetLength(1) - 1;
                }
                else
                {
                    map[Player[0], Player[1]] = MapIcon;
                    map[Player[0], --Player[1]] = PlayerIcon;

                }
            }
            else if (Direction == "Right")
            {
                if (Player[1] == map.GetLength(1) - 1)
                {
                    map[Player[0], Player[1]] = MapIcon;
                    map[Player[0], 0] = PlayerIcon;
                    Player[1] = 0;
                }
                else
                {
                    map[Player[0], Player[1]] = MapIcon;
                    map[Player[0], ++Player[1]] = PlayerIcon;

                }
            }
            else if (Direction == "Up")
            {
                if (Player[0] == 0)
                {
                    map[Player[0], Player[1]] = MapIcon;
                    map[map.GetLength(0) - 1, Player[1]] = PlayerIcon;
                    Player[0] = map.GetLength(0) - 1;
                }
                else
                {
                    map[Player[0], Player[1]] = MapIcon;
                    map[--Player[0], Player[1]] = PlayerIcon;

                }
            }
            else if (Direction == "Down")
            {
                if (Player[0] == map.GetLength(0) - 1)
                {
                    map[Player[0], Player[1]] = MapIcon;
                    map[0, Player[1]] = PlayerIcon;
                    Player[0] = 0;
                }
                else
                {
                    map[Player[0], Player[1]] = MapIcon;
                    map[++Player[0], Player[1]] = PlayerIcon;

                }
            }
        }



    }
}
