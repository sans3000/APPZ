using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Singleton ===");
            var db = DatabaseManager.Instance;
            db.Connect();

            Console.WriteLine("\n=== Prototype ===");
            var original = new StudentGrade { Subject = "Math", Grade = 92 };
            var copy = (StudentGrade)original.Clone();
            Console.WriteLine($"Cloned Grade: {copy.Subject} - {copy.Grade}");

            Console.WriteLine("\n=== Factory Method ===");
            GradeCreator creator = new NumericGradeCreator();
            Grade grade = creator.CreateGrade();
            grade.Display();

            Console.WriteLine("\n=== Abstract Factory ===");
            IUserFactory studentFactory = new StudentFactory();
            var user = studentFactory.CreateUser();
            var access = studentFactory.CreateAccess();
            user.ShowRole();
            access.ShowAccessLevel();

            Console.WriteLine("\n=== Builder ===");
            IReportBuilder builder = new StudentReportBuilder();
            var director = new ReportDirector();
            director.Construct(builder);
            var report = builder.GetReport();
            Console.WriteLine($"{report.Header}\n{report.Content}");

            Console.WriteLine("\n=== Object Pool ===");
            var pool = new ConnectionPool(2);
            var conn1 = pool.GetConnection();
            conn1.Use();
            var conn2 = pool.GetConnection();
            conn2.Use();
            pool.ReleaseConnection(conn1);
            var conn3 = pool.GetConnection();
            conn3.Use();
        }
    }
}
