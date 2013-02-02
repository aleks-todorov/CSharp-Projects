using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingRocks
{
    class FallingRocks
    {
        static Random randomGenerator = new Random();
        static List<Obstacle> obstacles = new List<Obstacle>();
        static bool isFull = false;
        static int dwarfPossitionX = Console.WindowWidth / 2 - 1;
        static int dwarfPossitionY = Console.WindowHeight - 1;
        static int dwarfLenght = 3;
        static int lifes = 10;
        static int score = 0;
        static string[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
        static string colorName = "White";

        static void Main()
        {
            SettingConsoleSize();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyinfo = Console.ReadKey();
                    if (keyinfo.Key == ConsoleKey.LeftArrow)
                    {
                        MoveDwarfLeft();
                    }
                    if (keyinfo.Key == ConsoleKey.RightArrow)
                    {
                        MoveDwarfRight();
                    }
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(false);
                    }
                }
                GeneratingFirsRowObstacles();
                MovingObstaclesDown();
                DrawingScreen();
                Thread.Sleep(150);
                Console.Clear();
            }
        }

        private static void MoveDwarfRight()
        {
            if (dwarfPossitionX + dwarfLenght < Console.WindowWidth - 1)
            {
                dwarfPossitionX++;
            }
        }

        private static void MoveDwarfLeft()
        {
            if (dwarfPossitionX > 0)
            {
                dwarfPossitionX--;
            }
        }

        private static void DrawingScreen()
        {
            DrawingObstacles();
            DrawingDwarf();
            DrawingScore();
        }

        private static void DrawingDwarf()
        {
            Console.SetCursorPosition(dwarfPossitionX, dwarfPossitionY);
            Console.Write("(");
            Console.Write("o");
            Console.Write(")");
        }

        private static void MovingObstaclesDown()
        {
            foreach (var obstacle in obstacles)
            {
                obstacle.PossitionY++;
                if (obstacle.PossitionY == Console.WindowHeight - 1)
                {
                    obstacle.PossitionY = 1;
                    isFull = true;
                    obstacle.Symbol = GeneratingSymbols();

                    int lenght = GeneratingLenght();
                    if (obstacle.PossitionX + lenght < Console.WindowWidth)
                    {
                        obstacle.Lenght = lenght;
                    }
                    if (dwarfPossitionX == obstacle.PossitionX || dwarfPossitionX == obstacle.PossitionX + obstacle.Lenght || dwarfPossitionX + dwarfLenght == obstacle.PossitionX || dwarfPossitionX + dwarfLenght == obstacle.PossitionX + obstacle.Lenght || dwarfPossitionX + 1 == obstacle.PossitionX)
                    {
                        lifes--;
                        if (lifes > 0)
                        {
                            YouAreDeadMessage();
                        }
                        if (lifes == 0)
                        {
                            SetNewGame();
                        }
                    }
                    score++;
                }
            }
        }

        private static void SetNewGame()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
            Console.Write("Game Over!!!\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 8, Console.WindowHeight / 2 + 1);
            Console.WriteLine("Your score was {0} ", score);
            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 + 2);
            Console.WriteLine("Please insert a coin to continue...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private static void YouAreDeadMessage()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, 0);
            Console.Write("You are dead!!!");
        }

        private static void DrawingScore()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 + 15, 0);
            Console.Write("Lifes:{0}  Score: {1}", lifes, score);
        }

        private static void DrawingObstacles()
        {
            foreach (var obstacle in obstacles)
            {

                ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), obstacle.Color);
                Console.ForegroundColor = color;
                for (int i = 0; i < obstacle.Lenght; i++)
                {
                    Console.SetCursorPosition(obstacle.PossitionX + i, obstacle.PossitionY);
                    Console.Write(obstacle.Symbol);
                }
                Console.ResetColor();
            }
        }

        private static void GeneratingFirsRowObstacles()
        {
            if (isFull != true)
            {
                int possitionX = 0;
                possitionX = randomGenerator.Next(possitionX, possitionX + 50);
                int lenght = GeneratingLenght();
                for (int i = 0; i < 3; i++)
                {
                    if (possitionX + lenght < Console.WindowWidth)
                    {
                        GenerateObstacle(possitionX, lenght);
                        possitionX = possitionX + lenght + randomGenerator.Next(10, 40);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void GenerateObstacle(int possitionX, int lenght)
        {
            char symbol = GeneratingSymbols();
            colorName = GeneratingColour();
            int possitionY = 1;
            obstacles.Add(new Obstacle(symbol, lenght, possitionX, possitionY, colorName));
        }

        private static int GeneratingLenght()
        {
            int lenght = randomGenerator.Next(1, 3);
            return lenght;
        }

        private static char GeneratingSymbols()
        {
            char[] symbolArray = { '@', '#', '%', '&', '*', '?' };
            int possition = randomGenerator.Next(0, symbolArray.Length);
            char symbol = symbolArray[possition];
            return symbol;
        }

        private static string GeneratingColour()
        {
            int colorPossition = randomGenerator.Next(0, colorNames.Length);
            string color = colorNames[colorPossition];

            if (color != "black")
            {
                return color;
            }
            return "white";
        }

        private static void SettingConsoleSize()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.BufferWidth;
            Console.CursorVisible = false;
        }
    }
    class Obstacle
    {
        private char symbol;
        private int lenght;
        private int possitionX;
        private int possitionY;
        private string color;

        public char Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }
        public int Lenght
        {
            get { return this.lenght; }
            set { this.lenght = value; }
        }
        public int PossitionX
        {
            get { return this.possitionX; }
            set { this.possitionX = value; }
        }
        public int PossitionY
        {
            get { return this.possitionY; }
            set { this.possitionY = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Obstacle(char symbol, int lenght, int possitionX, int possitionY)
        {
            this.symbol = symbol;
            this.lenght = lenght;
            this.possitionX = possitionX;
            this.possitionY = possitionY;
        }

        public Obstacle(char symbol, int lenght, int possitionX, int possitionY, string color)
        {
            this.symbol = symbol;
            this.lenght = lenght;
            this.possitionX = possitionX;
            this.possitionY = possitionY;
            this.color = color;
        }
    }
}
