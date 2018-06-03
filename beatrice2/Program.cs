using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beatrice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite Beatričės sugalvotą skaičių");
            int sugalvotas = Convert.ToInt32(Console.ReadLine());
            int sugalvotas2 = sugalvotas;
            int nulis = 0;
            int vienas = 0;
            int du = 0;
            int trys = 0;
            int keturi = 0;
            int penki = 0;
            int sesi = 0;
            int septyni = 0;
            int astuoni = 0;
            int devyni = 0;
            int suma = 0;
            int x = 0;
            int kartai = 0;
            if (sugalvotas == 0)
            {
                Console.WriteLine("insomnia");
            }
            while (suma < 55)
            {
                x = x + sugalvotas;
                int skaicius = x;
                while (skaicius > 0)
                {
                    int liekana = skaicius % 10;
                    if (liekana == 0)
                    {
                        nulis = liekana + 10;
                    }
                    if (liekana == 1)
                    {
                        vienas = liekana;
                    }
                    if (liekana == 2)
                    {
                        du = liekana;
                    }
                    if (liekana == 3)
                    {
                        trys = liekana;
                    }
                    if (liekana == 4)
                    {
                        keturi = liekana;
                    }
                    if (liekana == 5)
                    {
                        penki = liekana;
                    }
                    if (liekana == 6)
                    {
                        sesi = liekana;
                    }
                    if (liekana == 7)
                    {
                        septyni = liekana;
                    }
                    if (liekana == 8)
                    {
                        astuoni = liekana;
                    }
                    if (liekana == 9)
                    {
                        devyni = liekana;
                    }

                    skaicius = skaicius / 10;
                }
                if (nulis + vienas + du + trys + keturi + penki + sesi + septyni + astuoni + devyni == 55)
                {
                    Console.WriteLine("Beatričė užmigs, kai pasakys {0} - {1}x{2}", x, kartai + 1, sugalvotas);
                    break;
                }
                kartai++;
            }
            for (int i = 0; i < sugalvotas2; i++)
            {
                Console.WriteLine("iveskite {0} skaiciu", i + 1);
                int ivestas = Convert.ToInt32(Console.ReadLine());
                int nulis0 = 0;
                int vienas0 = 0;
                int du0 = 0;
                int trys0 = 0;
                int keturi0 = 0;
                int penki0 = 0;
                int sesi0 = 0;
                int septyni0 = 0;
                int astuoni0 = 0;
                int devyni0 = 0;
                int suma0 = 0;
                int x0 = 0;
                int kartai0 = 0;
                if (ivestas == 0)
                {
                    Console.WriteLine("insomnia");
                }
                else
                {

               
                while (suma0 < 55)
                {
                    x0 = x0 + ivestas;
                    int skaicius0 = x0;
                    while (skaicius0 > 0)
                    {
                        int liekana = skaicius0 % 10;
                        if (liekana == 0)
                        {
                            nulis0 = liekana + 10;
                        }
                        if (liekana == 1)
                        {
                            vienas0 = liekana;
                        }
                        if (liekana == 2)
                        {
                            du0 = liekana;
                        }
                        if (liekana == 3)
                        {
                            trys0 = liekana;
                        }
                        if (liekana == 4)
                        {
                            keturi0 = liekana;
                        }
                        if (liekana == 5)
                        {
                            penki0 = liekana;
                        }
                        if (liekana == 6)
                        {
                            sesi0 = liekana;
                        }
                        if (liekana == 7)
                        {
                            septyni0 = liekana;
                        }
                        if (liekana == 8)
                        {
                            astuoni0 = liekana;
                        }
                        if (liekana == 9)
                        {
                            devyni0 = liekana;
                        }

                        skaicius0 = skaicius0 / 10;
                    }
                    if (nulis0 + vienas0 + du0 + trys0 + keturi0 + penki0 + sesi0 + septyni0 + astuoni0 + devyni0 == 55)
                    {
                        Console.WriteLine("Beatričė užmigs, kai pasakys {0} - {1}x{2}", x0, kartai0 + 1, ivestas);
                        break;
                    }

                    kartai0++;
                }
                }

            }
            Console.ReadKey();
        }
    }
}
