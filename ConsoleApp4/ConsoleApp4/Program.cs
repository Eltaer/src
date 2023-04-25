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
}

