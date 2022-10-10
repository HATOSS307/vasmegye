using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vasmegye
{
    class Program
    {
        static void CdvEll()
        {

        }
        
        static void Main(string[] args)
        {
            string[] tablazat = File.ReadAllLines(@"C:\Users\cisco\source\repos\vasmegye\vasmegye\vas.txt");
            string[,] tablazat2d = new string[tablazat.Length, 3];
            int lines = tablazat.Length ;
            for (int i = 0; i < tablazat.Length; i++)
            {
                string[] holder = tablazat[i].Split('-');
                for (int j = 0; j < holder.Length; j++)
                {
                    tablazat2d[i, j] = holder[j];
                    Console.WriteLine(tablazat2d[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
