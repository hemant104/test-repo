using System;  
namespace CSharpPattern
{  
    class Student  
    {  
        public string Name { get; set; } = "Abhay Jain";  
    }  
    class PatternMatching  
    {  
        public static void Main(string[] args)  
        {  
            Student student = new Student();  
            if(student is Student)  
            {  
                Console.WriteLine(student.Name);  
            }  
        }  
    }  
}  
