
// using System;
// using System.Linq;

// namespace backend.Models
// {
//     public static class DbInitializer
//     {
//         public static void Initialize(SchoolContext context)
//         {
//             // context.Database.EnsureCreated();

//             // Look for any students.
//             if (context.Students.Any())
//             {
//                 return;   // DB has been seeded
//             }

//             var students = new Student[]
//             {
//             new Student{StudentName="Carson",DateOfBirth=DateTime.Parse("2005-09-01")},
//             new Student{StudentName="Meredith",DateOfBirth=DateTime.Parse("2002-09-01")},
//             new Student{StudentName="Arturo",DateOfBirth=DateTime.Parse("2003-09-01")},
//             new Student{StudentName="Gytis",DateOfBirth=DateTime.Parse("2002-09-01")},
//             new Student{StudentName="Yan",DateOfBirth=DateTime.Parse("2002-09-01")},
//             new Student{StudentName="Peggy",DateOfBirth=DateTime.Parse("2001-09-01")},
//             new Student{StudentName="Laura",DateOfBirth=DateTime.Parse("2003-09-01")},
//             new Student{StudentName="Nino",DateOfBirth=DateTime.Parse("2005-09-01")}
//             };
//             foreach (Student s in students)
//             {
//                 context.Students.Add(s);
//             }
//             context.SaveChanges();

//             var courses = new Grade[]
//             {
//             new Grade{GradeId=1050,GradeName="Chemistry",GradeSection="3"},
//             new Grade{GradeId=4022,GradeName="Microeconomics",GradeSection="3"},
//             new Grade{GradeId=4041,GradeName="Macroeconomics",GradeSection="3"},
//             new Grade{GradeId=1045,GradeName="Calculus",GradeSection="4"},
//             new Grade{GradeId=3141,GradeName="Trigonometry",GradeSection="4"},
//             new Grade{GradeId=2021,GradeName="Composition",GradeSection="3"},
//             new Grade{GradeId=2042,GradeName="Literature",GradeSection="4"}
//             };
//             foreach (Grade c in courses)
//             {
//                 context.Grades.Add(c);
//             }
//             context.SaveChanges();
//         }
//     }
// }