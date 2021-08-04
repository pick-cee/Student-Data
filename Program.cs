using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, course, matric;
            int level, op;

            Console.WriteLine("What Operation would you like to perform? \n1. Add Student Data. \n2. View Student Data." +
                "\n3. Check By Matric Number. \n4. Exit the Program");
            op = Convert.ToInt32(Console.ReadLine());
            
            StudentInfo si = new StudentInfo();

            while (true)
            {
                switch (op)
                {
                    case 1:
                        Console.Write("Enter Your Name: ");
                        name = Console.ReadLine();

                        Console.Write("Enter Your Matric Number: ");
                        matric = Console.ReadLine();

                        Console.Write("Enter Your Level: ");
                        level = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Your Course of Study: ");
                        course = Console.ReadLine();

                        var newData = new Data(name, matric, level, course);
                        si.AddData(newData);
                        break;
                    case 2:
                        si.DisplayAllData();
                        break;
                    case 3:
                        Console.Write("What is the Matric Number? ");
                        var num = Console.ReadLine();
                        si.DisplayByMatric(num);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid Operation Selected, Try Again!!");
                        break;
                }
                Console.WriteLine("What Operation would you like to perform? \n1. Add Student Data. \n2. View Student Data." +
              "\n3. Check By Matric Number. \n4. Exit the Program");
                op = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
