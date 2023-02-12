using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsInfo = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentsName = Console.ReadLine();
                double studentsGrade = double.Parse(Console.ReadLine());

                if (!studentsInfo.ContainsKey(studentsName))
                {
                    studentsInfo.Add(studentsName, new List<double> { studentsGrade });
                }
                else
                {
                    studentsInfo[studentsName].Add(studentsGrade);
                }

            }

            var averagGrades = new Dictionary<string, double>();
            foreach (var pair in studentsInfo)
            {
                averagGrades.Add(pair.Key, pair.Value.Average());
            }

            var orderedGrades = averagGrades.Where(n => n.Value >= 4.5).OrderByDescending(n => n.Value).ToDictionary(pair => pair.Key,
                pair => pair.Value);

            foreach (var item in orderedGrades)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
