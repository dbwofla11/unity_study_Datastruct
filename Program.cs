using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            const string CIRCLE = "\u25cf";
            const int WAIT_TICK = 1000 / 30;

            int lastTick = 0;
            while (true)
            {
                #region 프레임 관리 
                int currentTick = System.Environment.TickCount;
                if (currentTick - lastTick < WAIT_TICK)
                {
                    continue;
                }
                lastTick = currentTick;
                #endregion

                Console.SetCursorPosition(0, 0);
                
                for (int i = 0; i < 25; i++)
                {
                    for (int k = 0; k < 25; k++)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}