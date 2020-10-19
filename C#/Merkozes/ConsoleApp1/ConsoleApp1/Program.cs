using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();
            //Számolás
            Console.WriteLine("Hány fociklub szerepel a listában");
            Console.WriteLine(ctx.FociKlubok.Count());
            //Szűrés
            Console.WriteLine("Hány jobb rúgólábas szerepel a listában");
            Console.WriteLine(ctx.Focistak.Where(x => x.Jobblabas == true).Count());

            //Összegzés
            Console.WriteLine("Összesen hány millió a klubbok költségvetése?");
            Console.WriteLine(ctx.FociKlubok.Sum(x=> x.Koltsegvetes));

            //átlag
            Console.WriteLine("Hány cm az átlag focista ?");
            Console.WriteLine(ctx.Focistak.Average(x => x.Magassag));

            //Maximum
            Console.WriteLine("Hány cm a legmagasabb focista ?\nMelyik a legnagyobb mezszám ?");
            Console.WriteLine(ctx.Focistak.Max(x => x.Magassag));
            Console.WriteLine(ctx.Focistak.Max(x=> x.MezSzam));

            //Szűrés iterálás
            Console.WriteLine("Mely focisták magassága kisebb, mint 180cm?\nKi(k)é a legnagyobb mezszám ? ");
            var alacsonyak = ctx.Focistak.Where(x => x.Magassag < 180).ToList();
            //ToList == Foreach miatt kell
            alacsonyak.ForEach(x => Console.WriteLine(x.Nev));

            //Sorbarendezés
            Console.WriteLine("Rendezze mezszámok szerint a focistákat!");
            var mezlista = ctx.Focistak.OrderBy(x => x.MezSzam).ToList();
            mezlista.ForEach(x => Console.WriteLine(x.Nev +" - "+ x.MezSzam));

            //Csökkenő
            Console.WriteLine("Rendezze csökkenő sorrendbe, költségvetés szerint a klubbokat!");
            var koltseglista = ctx.FociKlubok.OrderByDescending(x => x.Koltsegvetes).ToList();
            koltseglista.ForEach(x => Console.WriteLine(x.Nev+"-"+x.Koltsegvetes));

            //Csoportosítás
            Console.WriteLine("Csoportosítsa a focistákat klubbok alapján és számolja meg a tagokat!\nCsoportosítsa rúgóláb alapján a játékosokat és számolja meg őket!");
            var labcsoplis = ctx.Focistak.GroupBy(x => x.Jobblabas).ToList();
            labcsoplis.ForEach(x => Console.WriteLine((x.Key ? "Jobb" : "Bal") +" db: "+x.Count()));

            //Kiválasztás
            Console.WriteLine("Írja ki a páros mezszámokat");
            var paros = ctx.Focistak.Where(x => x.MezSzam % 2 == 0).OrderBy(x => x.MezSzam).Select(x => x.MezSzam).ToList();
            paros.ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}