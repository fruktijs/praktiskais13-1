using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktiskais13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet rindu skaitu:");
            int rindas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet kolonnu skaitu:");
            int kolonnas = int.Parse(Console.ReadLine());

            // Izveido divdimensiju masīvu
            int[,] masivs = new int[rindas, kolonnas];

            // Aizpilda masīvu ar gadījuma skaitļiem robežās no 1 līdz 100
            Random rand = new Random();
            for (int i = 0; i < rindas; i++)
            {
                for (int j = 0; j < kolonnas; j++)
                {
                    masivs[i, j] = rand.Next(1, 101);
                }
            }

            // Izvada masīvu uz ekrāna
            Console.WriteLine("Ievadītais masīvs:");
            IzvaditMasivu(masivs);

            // Aprēķina un izvada pāra skaitļu procentuālo daudzumu
            double paruSkaitluProcenti = AprekinatParuSkaitluProcentus(masivs);
            Console.WriteLine($"Pāra skaitļu procenti: {paruSkaitluProcenti}%");

            // Pieskaita 1 visiem masīva elementiem ar pāra vērtību
            PieskaititVieninuParajiem(masivs);

            // Izvada jauno masīvu uz ekrāna
            Console.WriteLine("Jaunais masīvs ar pieskaitītajiem vieniniekiem:");
            IzvaditMasivu(masivs);
        }

        static void IzvaditMasivu(int[,] masivs)
        {
            int rindas = masivs.GetLength(0);
            int kolonnas = masivs.GetLength(1);

            for (int i = 0; i < rindas; i++)
            {
                for (int j = 0; j < kolonnas; j++)
                {
                    Console.Write($"{masivs[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        static double AprekinatParuSkaitluProcentus(int[,] masivs)
        {
            int paruSkaitlis = 0;

            int rindas = masivs.GetLength(0);
            int kolonnas = masivs.GetLength(1);

            for (int i = 0; i < rindas; i++)
            {
                for (int j = 0; j < kolonnas; j++)
                {
                    if (masivs[i, j] % 2 == 0)
                    {
                        paruSkaitlis++;
                    }
                }
            }

            double kopaisElementuSkaits = rindas * kolonnas;
            double procenti = (paruSkaitlis / kopaisElementuSkaits) * 100;

            return procenti;
        }

        static void PieskaititVieninuParajiem(int[,] masivs)
        {
            int rindas = masivs.GetLength(0);
            int kolonnas = masivs.GetLength(1);

            for (int i = 0; i < rindas; i++)
            {
                for (int j = 0; j < kolonnas; j++)
                {
                    if (masivs[i, j] % 2 == 0)
                    {
                        masivs[i, j]++;
                    }
                }
            }
        }
    }
}
