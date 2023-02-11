using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] tokens = input.Split(" : ");
                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>() { studentName });

                }
                else
                {
                    courses[courseName].Add(studentName);
                }

                input = Console.ReadLine();
            }

            var orderedCourses = courses.OrderByDescending(n => n.Value.Count);


            foreach (var pair in orderedCourses)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");

                var orderedStudents = pair.Value.OrderBy(n => n).ToList();

                foreach (var item in orderedStudents)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
