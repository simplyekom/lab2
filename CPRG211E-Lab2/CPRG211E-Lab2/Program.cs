using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPRG211E_Lab2.Entities;

namespace CPRG211E_Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "employees.txt";

            string[] lines;

            lines = File.ReadAllLines(path);

            List<Employee> employees = new List<Employee>();

            foreach (string line in lines)
            {
                string[] parts;

                parts = line.Split(':');

                string id = parts[0];
                string name = parts[1];

                string firstDigit;
                firstDigit = id.Substring(0,1);

                /*if (firstDigit == "0" || firstDigit == "1"|| firstDigit == "2"|| firstDigit =="3"||firstDigit == "4" )
                {

                }*/

                int firstDigitNum = int.Parse(firstDigit);

                if (firstDigitNum >= 0 && firstDigitNum <= 4 )
                {
                    //Salaried
                    double salary = double.Parse(parts[6]);

                    Salaried salaried;
                    salaried = new Salaried(id, name, salary);

                    employees.Add(salaried);
                }

                else if (firstDigitNum >= 5 && firstDigitNum <= 7) 
                {
                    //Part Time
                }
                else if (firstDigitNum >= 8 && firstDigitNum <= 9) 
                {
                    //Wage
                }
            }
        }
    }
}
