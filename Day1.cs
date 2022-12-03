using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.days
{
    internal class Day1
    {
        
        public static dynamic GetResultPt1()
        {
            var filename1 = "TextFile1.txt";
            using (FileStream stream = new FileStream(Stuff.path + filename1, FileMode.Open, FileAccess.Read))
            {
                var array = new List<int>();
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    var tmpSum = 0;
                    while (reader.Peek() != -1)
                    {
                        var tmpLine = reader.ReadLine();
                        if (tmpLine != "")
                        {
                            tmpSum += int.Parse(tmpLine);
                        }
                        else
                        {
                            array.Add(tmpSum);
                            tmpSum = 0;
                        }

                    }
                }
                array.Sort();
                var greatestNumber = array.Last();
                var lastIndex = array.LastIndexOf(greatestNumber);
                var sumThreeElvesCalories = array.Last() + array[lastIndex - 1] + array[lastIndex - 2];            
                return greatestNumber;
            }
        }
        public static dynamic GetResultPt2()
        {        
            var filename1 = "TextFile1.txt";
            using (FileStream stream = new FileStream(Stuff.path + filename1, FileMode.Open, FileAccess.Read))
            {
                var array = new List<int>();
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    var tmpSum = 0;
                    while (reader.Peek() != -1)
                    {
                        var tmpLine = reader.ReadLine();
                        if (tmpLine != "")
                        {
                            tmpSum += int.Parse(tmpLine);
                        }
                        else
                        {
                            array.Add(tmpSum);
                            tmpSum = 0;
                        }

                    }
                }
                array.Sort();
                var greatestNumber = array.Last();
                var lastIndex = array.LastIndexOf(greatestNumber);
                var sumThreeElvesCalories = array.Last() + array[lastIndex - 1] + array[lastIndex - 2];              
                return sumThreeElvesCalories;
            }
        }
    }
}
