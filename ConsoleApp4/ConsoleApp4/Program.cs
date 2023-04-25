using System;
using System.IO;
using System.Linq;

public class Course
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int PreparationTime { get; set; }
}

public class CoursesControl
{
    private readonly Course[] courses;

    public CoursesControl(Course[] courses)
    {
        this.courses = courses;
    }

    public void SortCourses()
    {
        Array.Sort(courses, (c1, c2) =>
        {
            int comparison = c1.PreparationTime.CompareTo(c2.PreparationTime);
            if (comparison == 0)
            {
                comparison = c1.Price.CompareTo(c2.Price);
            }
            return comparison;
        });
    }

    public void SaveCoursesToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Course course in courses)
            {
                writer.WriteLine($"{course.Name},{course.Price},{course.PreparationTime}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number of courses:");
            int numberOfCourses = int.Parse(Console.ReadLine());

            Course[] courses = new Course[numberOfCourses];
            for (int i = 0; i < numberOfCourses; i++)
            {
                Console.WriteLine($"Enter details for course {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.Write("Preparation Time (in minutes): ");
                int preparationTime = int.Parse(Console.ReadLine());

                courses[i] = new Course { Name = name, Price = price, PreparationTime = preparationTime };
            }

            Console.WriteLine("Enter file name to save courses:");
            string fileName = Console.ReadLine();

            CoursesControl control = new CoursesControl(courses);

            control.SortCourses();
            control.SaveCoursesToFile(fileName);

            Console.WriteLine("Courses sorted and saved to file successfully!");
            Console.ReadLine();
        }


    }
}

