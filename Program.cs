using System;
using System.Collections.Generic;

namespace GradeBook
{
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Emre", "Çevik", 5, 'A');
        student.PrintStudentInfo();
   
    }
}

}