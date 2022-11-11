using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            CreateResultList(list1, list2);

        }

        static void CreateResultList(List<int> list1, List<int> list2)
        {                             
            List<int> resultList = new List<int>();
            int biggerList = Math.Max(list1.Count, list2.Count);

            for (int i = 0; i < biggerList; i++)
            {
                if (list1.Count > i)
                {
                resultList.Add(list1[i]);
                }
                if (list2.Count > i)
                {
                resultList.Add(list2[i]);
                }                            
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
