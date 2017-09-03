using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Anketa
{
    class Program
    {
        
        static Dictionary<int, string> ReadToFile()
        {
            Dictionary<int, string> personF = new Dictionary<int, string>();
            using (StreamReader sr = new StreamReader(@"D:\\Temp\\name.txt"))
            {
                String[] linePerson;
                while (!sr.EndOfStream)
                {
                    linePerson = sr.ReadLine().Split();
                    personF.Add(Convert.ToInt32(linePerson[2]), linePerson[0] +' '+ linePerson[1]);
                }
            }
             return personF;
        }
        static void Main(string[] args)
        {
            Console.Title = "Поиск людей по телефону";
            Dictionary<int, string> personF = ReadToFile();
            Console.WriteLine("Выберите действие:");
            int namberPhone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("По номеру {0} найден такой чел:{1}", namberPhone, personF[namberPhone]);
            Console.ReadKey();
        }
    }
}
