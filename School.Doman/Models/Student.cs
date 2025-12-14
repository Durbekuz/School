using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Doman.Models;

public class Student
{
    public Student(string firstName,string lastName,int age,int id)
    {
       FirstName = firstName;
       LastName = lastName;
        FullName = $"{firstName} {lastName}";
        Age = age;
        StudentId = id;
    }
    
    public string FullName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int StudentId { get; set;
}
