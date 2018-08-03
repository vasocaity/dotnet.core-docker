using System;

namespace dotnetdocker.Models
{
public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public DateTime? DateOfBirth { get; set; }
        
    public Grade Grade { get; set; }
}
}