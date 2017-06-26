using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student aStudent = new Student()
            {
                Name = "123",
                Phone = "0912345678",
                Address = "長庚蘊德"
            };

            Console.WriteLine(aStudent.Name);
        }
    }
}