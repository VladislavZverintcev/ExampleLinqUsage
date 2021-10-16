using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLinqUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<string>
            {
                "FirstString",
                "SecondString",
                "ThridString",
                "FourthString",
                "FifthString",
            };
            var list2 = new List<string>
            {
                "1", "2", "3", "4", "5"
            };
            //Union
            //var outputList = list1.Union(list2);
            //GetWriteListToConsole(outputList.ToList());

            //Skip
            //var outputList = list1.Skip(1);
            //GetWriteListToConsole(outputList.ToList());

            //Distinct (remove equals objects in collection, will be stay only first entry)
            //var outputList = list1.Distinct();
            //GetWriteListToConsole(outputList.ToList());

            //Reverse
            //var outputList = list1.Reverse<string>();
            //GetWriteListToConsole(outputList.ToList());

            //Where
            //var outputList = list1.Where(x => x.Contains('o'));
            //GetWriteListToConsole(outputList.ToList());

            //Select
            //exm1
            //var outputList = list1.Select(x => '☻' + x);
            //GetWriteListToConsole(outputList.ToList());
            //exm2
            //int i = 0;
            //var outputList = list1.Select(x => $"{i++}" + x);
            //GetWriteListToConsole(outputList.ToList());

            //OrderBy
            //exm1
            //var outputList = list1.OrderBy(x => x);
            //GetWriteListToConsole(outputList.ToList());
            //exm2 (If elements contains 'o' they insert to list's begin,
            //after that others elements will be sorted normally)
            //var outputList = list1.OrderBy(x => !x.Contains('o')).ThenBy(x => x);
            //GetWriteListToConsole(outputList.ToList());

            //OrderByDescending (Invert Order)
            //var outputList = list1.OrderByDescending(x => x);
            //GetWriteListToConsole(outputList.ToList());

            //GroupBy
            //exm (Get elements of collection if they entry more than once)
            //var outputList = list1.GroupBy(x => x).Where(x => x.Count() > 1).Select( x => x.Key);
            //GetWriteListToConsole(outputList.ToList());

            //AsParallel
            //exm1 foreach
            //list1.AsParallel().ForAll(x => System.Windows.Forms.MessageBox.Show(x));
            //exm2 for range
            //Enumerable.Range(0, 3).AsParallel().ForAll(x => System.Windows.Forms.MessageBox.Show(list1[x]));

            //Aggregate (get the first longest element in collection relative to "SixthString", if not returns SixthString
            //var outputString = list1.Aggregate("SixthString", (x, y) => y.Length > x.Length ? y : x);
            //Console.WriteLine(outputString);
            Console.ReadKey();

            
        }
        static void GetWriteListToConsole(List<string> inputList)
        {
            Console.Write(string.Join(Environment.NewLine, inputList));
        }
    }
}
