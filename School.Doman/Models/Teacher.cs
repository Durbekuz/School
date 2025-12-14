using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Doman.Models;
public class Teacher
{
     public Teacher(string firstName, string lastName,int age,int id)
     {
        FirstName2 = firstName;
        LastName2 = lastName;
        FullName2 = $"{firstName} {lastName}";
        Age = age;
        TeacherId = id;
     }
    
    public string FullName2 { get; set; }
    public string FirstName2 { get; set; }
    public string LastName2 { get; set; }
    public int Age { get; set; }
    public  object TeacherId { get; set; }

}