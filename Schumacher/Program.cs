using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Schumacher
{
    
    class Program
    {
        static List<Eredmenyek> lista = new List<Eredmenyek>();
        //static List<string> hibaTipus = new List<string>();
        static void beolvas()
        {
            foreach (var item in File.ReadAllLines("schumacher.csv", Encoding.UTF8).Skip(1))
            {
                Eredmenyek seged = new Eredmenyek(item);
                lista.Add(seged);
            }
        }

        static void feladat3()
        {
            Console.WriteLine($"3. feladat: Az állomány {lista.Count} sort tartalmaz.");

        }

        static void feladat4()
        {
            Console.WriteLine("4. feladat. A Magyar Nagydíj helyezései:");
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Grandprix.Split(' ')[0] == "Hungarian" && lista[i].Position > 0)
                {
                    Console.WriteLine($"\t{lista[i].Datum} : {lista[i].Position}. hely");
                }
            }
        }

        static void feladat5()
        {
            List<string> hibaOka = new List<string>();
            
            
            Console.WriteLine("5. feladat: Hibastatisztika:");

            foreach (Eredmenyek item in lista)
            {
                if (!hibaOka.Contains(item.Status))
                { 
                    hibaOka.Add(item.Status); 
                }
            }
            int[] hibaDB = new int[hibaOka.Count];
            foreach (Eredmenyek item in lista)
            {
                for (int i = 0; i < hibaOka.Count; i++)
                {
                    if(item.Status == hibaOka[i])
                    {
                        hibaDB[i]++;
                    }
                }
            }

            for (int i = 0; i < hibaOka.Count; i++)
            {
                if(hibaOka[i] != "Finished" && hibaDB[i] > 2)
                { 
                Console.WriteLine("\t{0} : {1} db", hibaOka[i], hibaDB[i]);
                }
            }
            
        }

        static void Main(string[] args)
        {
            beolvas();
            feladat3();
            feladat4();
            feladat5();
            
            Console.ReadKey();
        }
    }
}
