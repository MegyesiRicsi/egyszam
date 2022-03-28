using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class C {
    public string nev;
    public List<int> tipp= new List<int>();
    public C(string sor)
    {
        var s = sor.Split(' ');
        nev = s[0];
        /*  elso=int.Parse(s[1]);
          masodik = int.Parse(s[2]);
          harmadik = int.Parse(s[3]);*/
        for (int i = 1; i <= 4; i++)
        {
            tipp.Add(int.Parse(s[i]));
        }
    }
}
namespace Egyszamjatek
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<C>();
            var sr = new StreamReader("egyszamjatek.txt");
            while (!sr.EndOfStream)
            {
                lista.Add(new C(sr.ReadLine()));
            }
            Console.WriteLine($"3. feladat: Játékosok száma: {lista.Count()} fő");
            Console.Write("4. feladat: Kérem be a fordulo sorszámát ");
            var be = int.Parse(Console.ReadLine());
            var atl = (from sor in lista select sor.tipp[be-1]).Average();
            Console.WriteLine($"5. feladat: A megadott forduló tippjeinek átlaga {atl:.00}");

            Console.ReadKey();
        }
    }
}
