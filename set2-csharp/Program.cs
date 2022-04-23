using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> students = new HashSet<int>();

            char letter = 'A'; 
            for (int i = 0; i < 3; i++)
            {
                Console.Write("How many students for Course " + letter + " : " );
                int count = int.Parse( Console.ReadLine());
                for (int j = 0; j < count; j++)
                {
                    int aux = int.Parse(Console.ReadLine());
                    students.Add(aux);
                }

                letter++;
                
            }
            Console.WriteLine("Total Students : " +  students.Count);
            
            Console.ReadKey();
        }
    }
}
