using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNKO
{
    class Program
    {
        static List<int> ElsoszamList;
        static List<int> MasodikszamList;
        static List<int> KozosList;
        static void Main(string[] args)
        {
            //LKKT();
            //LNKO();
            //HarommalOszthato();
            Fibonacci();
           Console.ReadKey();
        }

        private static void Fibonacci()
        {
            Console.Write("Adja meg a Fibonacci sorozat hány elemét szeretné kiszámolni: ");
            int N = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c;
            for (int i = 0; i < N; i++)
            {
               
                c = a;
                a = b;
                b = c + b;
                Console.WriteLine("{0}. Fibonacci elem: {1}", i+1,c);
            }
         
        }

        private static void LNKO()
        {
            Console.Write("Kérem adjon meg egy számot: ");
            int ElsoSzam = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------\n");
            Console.Write("Kérem adjon meg egy számot: ");
            int MasodikSzam = int.Parse(Console.ReadLine());
            int ciklusvege = 0;
            if (ElsoSzam < MasodikSzam)
            {
                ciklusvege = MasodikSzam;
            }
            else
            {
                ciklusvege = ElsoSzam;
            }
            Console.WriteLine("\n\tciklus vége: {0}\n", ciklusvege);
            int LNKO = 0;
            for (int i = 1; i <=ciklusvege; i++)
            {
                if(ElsoSzam%i==0 && MasodikSzam%i==0)
                {
                    LNKO = i;
                }
            }
            Console.WriteLine("A két szám legnagyobb közös osztója: {0}", LNKO);
        }

        private static void HarommalOszthato()
        {
            Console.Write("Határozza meg meddig szeretné tudni a hárommal osztható számok számosságát: ");
            int N = int.Parse(Console.ReadLine());
           // Console.WriteLine("Határozza meg hány hárommal osztható szám van 10-ig");
            int Szam = 0;
            int db = 0;
            for (int i = 1; i <=N; i++)
            {
                
                Szam = i;
                if (Szam % 3 == 0)
                {
                    if(Szam % 3 == 0)
                    {
                        db++;
                    }
                    Console.WriteLine("\t{1}.\t Hárommal osztható szám: {0}", Szam, db);
                   
                }
               
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nHárommal osztható számok számossága: {0}", db);
        }

        private static void LKKT()
        {
            Console.Write("Kérem adjon meg egy számot: ");
            int ElsoSzam = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------\n");
            Console.Write("Kérem adjon meg egy számot: ");
            int MasodikSzam = int.Parse(Console.ReadLine());
            int ciklusvege=0;
            if(ElsoSzam<MasodikSzam)
            {
                ciklusvege = MasodikSzam;
            }
            else
            {
                ciklusvege = ElsoSzam;
            }
            Console.WriteLine("\n\tciklus vége: {0}\n", ciklusvege);
            ElsoszamList = new List<int>();
            MasodikszamList = new List<int>();
            int ElsoTobbszoros=0;
            int MasodikTobbszoros=0;
            
            for (int i = 1; i <= ciklusvege; i++)
            {
                ElsoTobbszoros = ElsoSzam * i;
                ElsoszamList.Add(ElsoTobbszoros);
               
               
            }
            for (int k = 1; k <= ciklusvege; k++)
            {
                MasodikTobbszoros = MasodikSzam * k;
                MasodikszamList.Add(MasodikTobbszoros);
            }
            KozosList = new List<int>();
            foreach (var e in ElsoszamList)
            {
                
                foreach (var m in MasodikszamList)
                {
                    if(e==m)
                    {
                        KozosList.Add(e); 
                    }
                }
                
            }
            int LKKT = int.MaxValue;
            foreach (var k in KozosList)
            {
                if(k<LKKT)
                {
                    LKKT = k;
                }
            }
            Console.WriteLine("A legkisebb közös többszörös: {0}", LKKT);
        }
    }
}
