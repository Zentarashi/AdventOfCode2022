using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.days
{
    internal class Day3
    {
        public static dynamic GetResultPt1()
        {
            Console.WriteLine("Advent of code Day 3");
            var filename3 = "TextFile3.txt";
            using (FileStream stream = new FileStream(Stuff.path + filename3, FileMode.Open, FileAccess.Read))
            {
                var letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    var tmpSum = 0;
                    while (reader.Peek() != -1)
                    {
                        var tmpLine = reader.ReadLine();
                        var charLength = tmpLine.Length / 2;
                        var firstHalf = tmpLine.Substring(0, charLength).ToCharArray(); ;
                        var secondHalf = tmpLine.Substring(charLength).ToCharArray();
                        var matches = new List<char>();
                        for (int i = 0; i < charLength; i++)
                        {
                            if (secondHalf.Contains(firstHalf[i]) && !matches.Contains(firstHalf[i]))
                            {
                                matches.Add(firstHalf[i]);
                                tmpSum += letters.ToList().IndexOf(firstHalf[i]) + 1;
                            }
                        }
                    }                   
                    return tmpSum;
                }

            }
        }
        public static dynamic GetResultPt2()
        {
            var filename3 = "TextFile3.txt";
            using (FileStream stream = new FileStream(Stuff.path + filename3, FileMode.Open, FileAccess.Read))
            {
                var letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    var tmpSum = 0;
                    while (reader.Peek() != -1)
                    {
                        var tmpLine = reader.ReadLine().ToCharArray();
                        var tmpLine2 = reader.ReadLine().ToCharArray();
                        var tmpLine3 = reader.ReadLine().ToCharArray();
                        var matches = new List<char>();


                        for (int i = 0; i < tmpLine.Length; i++)
                        {
                            if (tmpLine2.Contains(tmpLine[i]) && tmpLine3.Contains(tmpLine[i]) && !matches.Contains(tmpLine[i]))
                            {
                                matches.Add(tmpLine[i]);
                                tmpSum += letters.ToList().IndexOf(tmpLine[i]) + 1;
                            }
                        }


                    }
                    return tmpSum;
                }
            }
        }
    }
}
