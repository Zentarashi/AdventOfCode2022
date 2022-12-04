using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.days
{
    internal class Day4
    {
        private static string filename1 = "TextFile4.txt";
        public static dynamic GetResultPt1()
        {
            var tmpSum = 0;
            foreach (string line in File.ReadLines(Stuff.path+filename1)) {
                var firstElveSectionsStart = int.Parse(line.Split(",")[0].Split("-")[0]);
                var firstElveSectionsEnd = int.Parse(line.Split(",")[0].Split("-")[1]);
                var secondElveSectionsStart = int.Parse(line.Split(",")[1].Split("-")[0]);
                var secondElveSectionsEnd = int.Parse(line.Split(",")[1].Split("-")[1]);
                if((firstElveSectionsStart <= secondElveSectionsStart && firstElveSectionsEnd >= secondElveSectionsEnd)
                    || (secondElveSectionsStart <= firstElveSectionsStart && secondElveSectionsEnd >= firstElveSectionsEnd))
                {
                    tmpSum++;
                }
            }
            return tmpSum;
        }
        
        public static dynamic GetResultPt2()
        {
            var tmpSum = 0;
            foreach (string line in File.ReadLines(Stuff.path + filename1))
            {
                var firstElveSectionsStart = int.Parse(line.Split(",")[0].Split("-")[0]);
                var firstElveSectionsEnd = int.Parse(line.Split(",")[0].Split("-")[1]);
                var secondElveSectionsStart = int.Parse(line.Split(",")[1].Split("-")[0]);
                var secondElveSectionsEnd = int.Parse(line.Split(",")[1].Split("-")[1]); 
                if (
                    Enumerable.Range(firstElveSectionsStart, firstElveSectionsEnd-firstElveSectionsStart+1).Contains(secondElveSectionsStart)
                    || Enumerable.Range(firstElveSectionsStart,firstElveSectionsEnd-firstElveSectionsStart+1).Contains(secondElveSectionsEnd)
                    || Enumerable.Range(secondElveSectionsStart, secondElveSectionsEnd-secondElveSectionsStart+1).Contains(firstElveSectionsStart)
                    || Enumerable.Range(secondElveSectionsStart, secondElveSectionsEnd-secondElveSectionsStart+1).Contains(firstElveSectionsEnd)
                    )
                {
                    tmpSum++;
                }

            }
            return tmpSum;
        }
    }
}
