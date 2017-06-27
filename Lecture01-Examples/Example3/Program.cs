using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example1;

namespace Example3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student();
            student.IsHappy = true;

            if (student.IsHappy)
            {
                Console.WriteLine("開心");
            }
            else
            {
                Console.WriteLine("不開心");
            }
        }
    }
}