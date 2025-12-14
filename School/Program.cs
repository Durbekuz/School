// See https://aka.ms/new-console-template for more information
using School.Doman.Models;



Student add  = new Student("Akbar","Aliyev", 15, 8543875);
Console.WriteLine($"Fullname : {add.FullName}");
Console.WriteLine($"Name : {add.FirstName}");
Console.WriteLine($"Lastname : { add.LastName}");
Console.WriteLine($"Age : {add.StudentId}");
Console.WriteLine($"ID : {add.Age}");


Teacher adds = new Teacher("Lola", "Aliyeva", 43, 9574873);
Console.WriteLine($"Fullname : {adds.FullName2}");
Console.WriteLine($"Name : {adds.FirstName2}");
Console.WriteLine($"Lastname : {adds.LastName2}");
Console.WriteLine($"ID : {adds.Age}");
Console.WriteLine($"Age : {adds.TeacherId}");
