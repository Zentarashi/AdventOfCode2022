using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.days
{
    internal class Day2
    {
        public static dynamic GetResultPt1()
        {          
            var filename1 = "TextFile2.txt";
            using (FileStream stream = new FileStream(Stuff.path + filename1, FileMode.Open, FileAccess.Read))
            {
                var array = new List<int>();
                var tmpSum = 0;
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {

                    while (reader.Peek() != -1)
                    {
                        var tmpLine = reader.ReadLine();
                        tmpSum += getPoints(tmpLine);                    
                    }
                }
                return tmpSum;
            }
            
        }

        public static dynamic GetResultPt2()
        {          
            var filename1 = "TextFile2.txt";
            using (FileStream stream = new FileStream(Stuff.path + filename1, FileMode.Open, FileAccess.Read))
            {
                var array = new List<int>();
                var tmpSum2 = 0;
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {

                    while (reader.Peek() != -1)
                    {
                        var tmpLine = reader.ReadLine();
                        tmpSum2 += getPoints2(tmpLine);

                    }
                }
                return tmpSum2;
            }
        }
        static int getPoints(string tmpline)
        {
            switch (tmpline)
            {
                // Y PAPER  , X ROCk, Z SCISSORS 
                // A ROCK
                case "A Y":
                    return 2 + 6;
                    break;
                case "A X":
                    return 1 + 3;
                    break;
                case "A Z":
                    return 3 + 0;
                    break;
                // B Paper
                case "B Y":
                    return 2 + 3;
                    break;
                case "B X":
                    return 1 + 0;
                    break;
                case "B Z":
                    return 3 + 6;
                    break;
                // C Scissors
                case "C Y":
                    return 2 + 0;
                    break;
                case "C X":
                    return 1 + 6;
                    break;
                case "C Z":
                    return 3 + 3;
                    break;
                default: return 0;
            }
        }
        static int getPoints2(string tmpline)
        {
            switch (tmpline)
            {
                // Y DRAW PAPER 2  , X LOSE  ROCk 1, Z WIN SCISSORS 3 
                // A ROCK
                case "A Y":
                    return 1 + 3;
                    break;
                case "A X":
                    return 3 + 0;
                    break;
                case "A Z":
                    return 2 + 6;
                    break;
                // B Paper
                case "B Y":
                    return 2 + 3;
                    break;
                case "B X":
                    return 1 + 0;
                    break;
                case "B Z":
                    return 3 + 6;
                    break;
                // C Scissors
                case "C Y":
                    return 3 + 3;
                    break;
                case "C X":
                    return 2 + 0;
                    break;
                case "C Z":
                    return 1 + 6;
                    break;
                default: return 0;
            }
        }
    }
}
