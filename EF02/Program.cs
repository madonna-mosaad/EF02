using EF02.Contexts;
using EF02.Entities;

namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using DepartmentDbContext dbContext = new DepartmentDbContext();
            #region Add
            //Topic topic = new Topic()
            //{
            //    Name = "Test"
            //};
            //Course course = new Course()
            //{
            //    Name = "A",
            //    Description = "B",
            //    Duration = 4,

            //};
            //Instructor instructor = new Instructor()
            //{
            //    Name = "A",
            //    Address = "ca",
            //    Salary = 2000,
            //    Bouns = 300,
            //    HourRate = 2
            //};
            //Department department = new Department()
            //{
            //    Name = "A",
            //    HiringDate = DateTime.Now,
            //};
            //Student student = new Student()
            //{
            //    FName= "A",
            //    LName= "A",
            //    Address= "A",
            //    Age = 30,

            //};
            //dbContext.Add(topic);
            //dbContext.Add(course);
            //dbContext.Add(instructor);
            //dbContext.Add(department);
            //dbContext.Add(student);
            //Console.WriteLine(dbContext.Entry(student));
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(student)); 
            #endregion
            #region Update&Delete
            //Course course1 = (from C in dbContext.Set<Course>()
            //                 where C.Name == "A"
            //                 select C).First();
            //course1.Top_Id = 40;
            //Console.WriteLine(dbContext.Entry(course1));
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(course1));
            //dbContext.Remove(course1);
            //Console.WriteLine(dbContext.Entry(course1));
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(course1)); 
            #endregion

        }
    }
}
