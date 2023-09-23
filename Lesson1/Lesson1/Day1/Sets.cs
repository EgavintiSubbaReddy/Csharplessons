/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day1
{
    internal class Sets
    {
        public static void SetStringDemo()
        {
            HashSet<String> stringSet = new HashSet<String>();
            stringSet.Add("Chennai");
            stringSet.Add("Salem");
            stringSet.Add("Erode");
            stringSet.Add("Tirupur");
            stringSet.Add("Kovai");
            stringSet.Add("Chennai");
            stringSet.Add("Trichy");
            stringSet.Add("Madurai");
            stringSet.Add("Nellai");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add(null);
            stringSet.Add(null);
            Console.WriteLine($"Count:{stringSet.Count}");
            foreach (var item in stringSet)
            {
                if (item != null)
                    Console.WriteLine(item);
                else
                    Console.WriteLine("NULL");
            }



        }
    }
  */