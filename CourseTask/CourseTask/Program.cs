using System;

namespace CourseTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group
            {
                Type = "Programming"
            };

            Group group2 = new Group
            {
                Type = "Design"
            };

            Group group3 = new Group
            {
                Type = "System"
            };

            Course course1 = new Course();
            course1.AddGroup(group1);
            course1.AddGroup(group2);
            course1.AddGroup(group3);

            foreach (var item in course1.GetAllGroupsByType("Programming"))
            {
                Console.WriteLine(item.No);
            }

        }
    }
}
