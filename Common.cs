using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTool
{
    internal class Common
    {


        //#FC<color># = ForeColor, #BC<color># = BackColor, #I# = Inverse, #LF# = LineFeed, #R# = Reset colors, ## = #
        public void WriteFormat(string s)
        {
            bool oddRow = true;
            ConsoleColor temp;
            ConsoleColor FOrigColor = Console.ForegroundColor;
            ConsoleColor BOrigColor = Console.BackgroundColor;

            foreach (string row in s.Split("#"))
            {
                if (oddRow)
                {
                    Console.Write(row);
                }
                else
                {
                    switch (row.Substring(0, 1))
                    {
                        case "F": Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), row.Remove(0, 1), true); break;
                        case "B": Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), row.Remove(0, 1), true); break;
                        case "I": temp = Console.ForegroundColor;
                            Console.ForegroundColor = Console.BackgroundColor;
                            Console.BackgroundColor = temp;
                            break;
                        case "L": Console.WriteLine(); break;
                        case "R": Console.ResetColor(); break;
                        case "": Console.Write("#"); break;
                    }  //switch

                }  //else & if

            oddRow = !oddRow;
        }  //foreach

        Console.ForegroundColor = FOrigColor;
        Console.BackgroundColor = BOrigColor;
        }  //WriteFormat


    }  //Class
}  //namespace
