using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AirHockey
{
    class AirHockey
    {
        static int firstPlayerPossitionX;
        static int firstPlayerPossitionY;
        static int secondPlayerPossitionX;
        static int secondPlayerPossitionY;
        static int firstPlayerPadSize = 6;
        static int secondPlayerPadSize = 6;
        static int ballPossitionX;
        static int ballPossitionY;
        static bool ballMovementTop = false;
        static bool ballMovementFront = false;
        static int firstPlayerScore = 0;
        static int secondPlayerScore = 0;
        static Random randomGenerator = new Random();



        static void Main()
        {
            SettingWindowSizes();
            PrintingDefaultPossition();

            while (true)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyinfo = Console.ReadKey();
                    if (keyinfo.Key == ConsoleKey.UpArrow)
                    {
                        MovingFirstPlayerUp();
                    }
                    if (keyinfo.Key == ConsoleKey.DownArrow)
                    {
                        MovingFirstPlayerDown();
                    }
                }
                MovingSecondPlayer();
                MovingBall();
                PrintingBoard();
                Thread.Sleep(60);
                Console.Clear();
            }
        }

        private static void MovingBall()
        {
            if (ballPossitionX == 3)
            {
                if (ballPossitionY >= firstPlayerPossitionY && ballPossitionY <= firstPlayerPossitionY + firstPlayerPadSize)
                {
                    ballMovementFront = true;
                }
                else
                {
                    secondPlayerScore++;
                    PrintingDefaultPossition();
                }
            }
            if (ballPossitionX == Console.WindowWidth - 3)
            {
                if (ballPossitionY > secondPlayerPossitionY && ballPossitionY < secondPlayerPossitionY + secondPlayerPadSize)
                {
                    ballMovementFront = false;
                }
                else
                {
                    firstPlayerScore++;
                    ballMovementFront = false;
                }
            }
            if (ballPossitionY == 0)
            {
                ballMovementTop = false;
            }
            if (ballPossitionY == Console.WindowHeight - 1)
            {
                ballMovementTop = true;
            }
            if (ballMovementFront)
            {
                ballPossitionX++;
            }
            else
            {
                ballPossitionX--;
            }
            if (ballMovementTop)
            {
                ballPossitionY--;
            }
            else
            {
                ballPossitionY++;
            }
        }

        private static void MovingSecondPlayer()
        {
            int random = randomGenerator.Next(0, 101);

            if (random > 20)
            {
                if (ballMovementTop == true && secondPlayerPossitionY > 0)
                {
                    secondPlayerPossitionY--;
                }
                if (ballMovementTop == false && secondPlayerPossitionY < Console.WindowHeight - secondPlayerPadSize)
                {
                    secondPlayerPossitionY++;
                }
            }
            else if (random < 10 && secondPlayerPossitionY > 0)
            {
                secondPlayerPossitionY--;
            }
        }

        private static void PrintingBoard()
        {
            PrintingBall();
            PrintingFirstPlayer();
            PrintingSecondPlayer();
            PrintingScore();
        }

        private static void MovingFirstPlayerDown()
        {
            if (firstPlayerPossitionY < Console.WindowHeight - firstPlayerPadSize)
            {
                firstPlayerPossitionY++;
            }
        }

        private static void MovingFirstPlayerUp()
        {
            if (firstPlayerPossitionY > 0)
            {
                firstPlayerPossitionY--;
            }
        }

        private static void PrintingScore()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, 0);
            Console.Write("{0} - {1}", firstPlayerScore, secondPlayerScore);

        }

        private static void PrintingBall()
        {
            PrintingSymbol(ballPossitionX, ballPossitionY, '@');
        }

        private static void PrintingSecondPlayer()
        {
            for (int i = 0; i < secondPlayerPadSize; i++)
            {
                PrintingSymbol(secondPlayerPossitionX, secondPlayerPossitionY + i, '|');
                PrintingSymbol(secondPlayerPossitionX - 1, secondPlayerPossitionY + i, '|');
            }
        }

        private static void PrintingDefaultPossition()
        {
            firstPlayerPossitionX = 0;
            firstPlayerPossitionY = Console.WindowHeight / 2 - firstPlayerPadSize / 2;
            secondPlayerPossitionX = Console.WindowWidth - 1;
            secondPlayerPossitionY = Console.WindowHeight / 2 - secondPlayerPadSize / 2;
            ballPossitionX = Console.WindowWidth / 2;
            ballPossitionY = Console.WindowHeight / 2;
            PrintingFirstPlayer();
            PrintingSecondPlayer();
            PrintingBall();
            PrintingScore();
        }

        private static void PrintingFirstPlayer()
        {

            for (int i = 0; i < firstPlayerPadSize; i++)
            {

                PrintingSymbol(firstPlayerPossitionX, firstPlayerPossitionY + i, '|');
                PrintingSymbol(firstPlayerPossitionX + 1, firstPlayerPossitionY + i, '|');
            }

        }
        private static void PrintingSymbol(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        private static void SettingWindowSizes()
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }
    }
}
