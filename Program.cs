using System;
using System.Collections.Generic;
using System.Text;

namespace QuestOfX
{
    class Program
    {
        static List<string[]> questRoom = new List<string[]>(); // komnata dla X
        static bool gameOver = false; // false - konec igri
        static string xman = "X"; // rosomaha
        static string wall = "█"; 
        static string goal = "?"; // final
        static string floor = " "; // pol komnati
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            questRoom.Add(new string[] { "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█" });
            questRoom.Add(new string[] { "█", "█", " ", " ", " ", " ", "█", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ", "█", " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█" });
            questRoom.Add(new string[] { "█", " ", "█", " ", " ", "█", " ", " ", " ", "█", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", "█", " ", " ", "█", " ", " ", "█", " ", " ", " ", "█", " ", "F", "i", "n", "d", " ", "█" });
            questRoom.Add(new string[] { "█", " ", "█", " ", " ", "█", "█", " ", " ", " ", "█", " ", "█", " ", "█", "█", " ", " ", "█", " ", " ", " ", "█", " ", "█", " ", " ", " ", "█", " ", "█", "█", " ", "█", " ", "L", "o", "o", "t", " ", "█" });
            questRoom.Add(new string[] { "█", " ", " ", " ", "█", " ", " ", "█", "█", "█", "█", " ", " ", "█", " ", " ", "█", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", "█", " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█" });
            questRoom.Add(new string[] { "█", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", "█", " ", " ", "█", "█", "█", "█", " ", "█", " ", " ", " ", "█", " ", "█", " ", "█", " ", "█", "█", "█", "█", "█", "█", "█", "█" });
            questRoom.Add(new string[] { "█", " ", "█", "█", " ", "█", "█", "█", " ", " ", " ", "█", " ", " ", "?", "█", " ", " ", " ", "█", " ", "█", "█", "█", "█", " ", "█", "█", " ", "█", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", "█" });
            questRoom.Add(new string[] { "█", " ", " ", "█", " ", " ", " ", "█", "█", "█", " ", " ", "█", "█", "█", "█", " ", "█", " ", "█", " ", "█", " ", " ", " ", " ", "█", "█", "█", " ", "█", " ", " ", " ", "█", " ", "█", "█", " ", " ", "█" });
            questRoom.Add(new string[] { "█", "█", " ", " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█", " ", " ", "█", " ", "█", " ", "█", " ", "█", " ", "█", " ", " ", "█", " ", " ", "█", " ", "█", "█", " ", " ", "█", " ", " ", "█" });
            questRoom.Add(new string[] { "█", " ", "█", " ", " ", " ", "█", " ", "█", "█", "█", " ", " ", "█", "█", " ", "█", "█", "█", " ", " ", "█", "█", " ", " ", " ", "█", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ", "█", " ", "█", "█" });
            questRoom.Add(new string[] { "█", " ", "█", " ", " ", "█", " ", " ", "█", " ", "█", " ", "█", " ", " ", " ", " ", "█", " ", " ", " ", "█", " ", " ", " ", " ", "█", " ", "█", "█", " ", "█", "█", " ", " ", " ", "█", " ", "█", " ", "█" });
            questRoom.Add(new string[] { "█", " ", "█", " ", " ", "█", " ", " ", "█", " ", "█", " ", "█", " ", "█", " ", " ", "█", "█", " ", " ", "█", "█", " ", "█", "█", " ", " ", "█", " ", "█", " ", " ", "█", " ", "█", " ", " ", "█", " ", "█" });
            questRoom.Add(new string[] { "█", " ", "█", " ", " ", " ", "█", " ", "█", " ", "█", " ", " ", " ", "█", "█", " ", "█", " ", "█", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", " ", "█", " ", " ", "█", " ", " ", " ", " ", " ", "█" });
            questRoom.Add(new string[] { "█", " ", " ", " ", "█", " ", " ", "█", "█", " ", "█", "█", "█", "█", " ", "█", " ", "█", " ", "█", " ", " ", " ", " ", " ", " ", " ", "█", "█", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", "█" });
            questRoom.Add(new string[] { "█", " ", " ", "█", " ", "█", " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", "█", " ", " ", " ", "█", " ", " ", "█", " ", "█", " ", "█", " ", "█", "█", " ", " ", " ", "█" });
            questRoom.Add(new string[] { "█", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ", "█", " ", " ", "█", " ", " ", "█", " ", " ", "█", " ", "█", " ", " ", " ", " ", " ", " ", " ", "█", "█", " ", "█", " ", "█", "█" });
            questRoom.Add(new string[] { "█", "█", " ", " ", " ", "█", " ", "█", " ", "█", "█", "█", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ", "█", " ", "█", " ", " ", "█", " ", " ", "█", " ", " ", " ", " ", "█", " ", "█", " ", " ", "█" });
            questRoom.Add(new string[] { "█", " ", "█", " ", "█", " ", "█", " ", " ", "█", " ", "█", " ", " ", "█", " ", " ", "█", " ", " ", "█", " ", "█", " ", " ", "█", "█", "█", " ", " ", " ", "█", " ", " ", " ", "█", " ", " ", "█", " ", "█" });
            questRoom.Add(new string[] { "█", " ", "█", " ", "█", " ", " ", " ", "█", " ", " ", "█", "█", " ", " ", "█", " ", " ", "█", " ", "█", " ", " ", " ", "█", " ", " ", "█", " ", " ", " ", " ", "█", " ", " ", "█", " ", "█", "█", " ", "█" });
            questRoom.Add(new string[] { "█", "█", "█", " ", "█", " ", "█", "█", " ", " ", " ", "█", " ", "█", " ", " ", "█", "█", "█", " ", " ", " ", " ", "█", " ", " ", " ", " ", "█", " ", "█", " ", " ", "█", " ", " ", " ", "█", " ", " ", "█" });
            questRoom.Add(new string[] { "█", " ", " ", "█", " ", " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", "█", " ", " ", "█", "█", " ", " ", " ", "█", "█", " ", " ", " ", " ", " ", " ", " ", "█" });
            questRoom.Add(new string[] { "█", " ", " ", " ", " ", "█", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█", " ", " ", "X", " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", "█", " ", " ", " ", " ", " ", " ", " ", "█" });
            questRoom.Add(new string[] { "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█" });
            render();
            while (gameOver==false)
            {
                var arrowKey = Console.ReadKey();
                moveXman(arrowKey);
                render();
            }
            
        }
        static void theEnd()
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("   T H E   E N D ?");
            Console.ReadKey();
            gameOver = true;            
        }
        static void render()
        {
            Console.Clear();
            for (int pixelLine = 0; pixelLine < questRoom.Count; pixelLine++)
            {
                Console.WriteLine(string.Join("", questRoom[pixelLine]));
            }
        } // render

        static void moveXman(ConsoleKeyInfo arrowKey)
        {
            for (int pixelLineCounter = questRoom.Count - 1; pixelLineCounter >= 0; pixelLineCounter--)
            {
                for (int pixel = 0; pixel < questRoom[pixelLineCounter].Length; pixel++)
                {
                    if (questRoom[pixelLineCounter][pixel] == xman)
                    {
                        if (arrowKey.Key == ConsoleKey.UpArrow)
                        {
                            if ((pixelLineCounter - 1) >= 0 && questRoom[pixelLineCounter-1][pixel] == floor)
                            {
                                questRoom[pixelLineCounter][pixel] = floor;
                                questRoom[pixelLineCounter - 1][pixel] = xman;
                                return;
                            }
                            else if ((pixelLineCounter - 1) >= 0 && questRoom[pixelLineCounter - 1][pixel] == goal)
                            {
                                questRoom[pixelLineCounter][pixel] = floor;
                                questRoom[pixelLineCounter - 1][pixel] = xman;
                                theEnd();
                                return;
                            }
                        }
                        else if (arrowKey.Key == ConsoleKey.DownArrow)
                        {
                            if ((pixelLineCounter+1) <= (questRoom.Count-1) && questRoom[pixelLineCounter+1][pixel] == floor)
                            {
                                questRoom[pixelLineCounter][pixel] = floor;
                                questRoom[pixelLineCounter + 1][pixel] = xman;
                                return;
                            }
                            else if ((pixelLineCounter + 1) <= (questRoom.Count - 1) && questRoom[pixelLineCounter + 1][pixel] == goal)
                            {
                                questRoom[pixelLineCounter][pixel] = floor;
                                questRoom[pixelLineCounter + 1][pixel] = xman;
                                theEnd();
                                return;
                            }
                        }
                        else if (arrowKey.Key == ConsoleKey.LeftArrow)
                        {
                            if ((pixel - 1) >= 0 && (questRoom[pixelLineCounter][pixel - 1] == floor))
                            {
                                questRoom[pixelLineCounter][pixel] = floor;
                                questRoom[pixelLineCounter][pixel - 1] = xman;
                                return;
                            }
                            else if ((pixel - 1) >= 0 && (questRoom[pixelLineCounter][pixel - 1] == goal))
                            {
                                questRoom[pixelLineCounter][pixel] = floor;
                                questRoom[pixelLineCounter][pixel - 1] = xman;
                                theEnd();
                                return;
                            }
                        }
                        else if (arrowKey.Key == ConsoleKey.RightArrow)
                        {
                            if (((pixel + 1) <= questRoom[pixelLineCounter].Length - 1) && (questRoom[pixelLineCounter][pixel + 1] == floor))
                            {
                                questRoom[pixelLineCounter][pixel] = floor;
                                questRoom[pixelLineCounter][pixel + 1] = xman;
                                return;
                            }
                            else if (((pixel + 1) <= questRoom[pixelLineCounter].Length - 1) && (questRoom[pixelLineCounter][pixel + 1] == goal))
                            {
                                questRoom[pixelLineCounter][pixel] = floor;
                                questRoom[pixelLineCounter][pixel + 1] = xman;
                                theEnd();
                                return;
                            }
                        }
                    }
                } // for po stroke
            } // for po liniyam

        }
    }
}
