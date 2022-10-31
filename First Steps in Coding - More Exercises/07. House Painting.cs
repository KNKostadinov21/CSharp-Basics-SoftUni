using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());//височина на къщата
            double y = double.Parse(Console.ReadLine());//дължина на страничната стена
            double h = double.Parse(Console.ReadLine());//височина на триъгълната стена на покрива
            double litresGreenPaint;
            double sumGreenPaint;
            double litresRedPaint;
            double sumRedPaint;
            double stranichniSteni = (2 * x * y) - (2 * 2.25);
            double zadnaIPrednaStena = (2 * x * x) - (2 * 1.2);
            litresGreenPaint = stranichniSteni + zadnaIPrednaStena;
            sumGreenPaint = litresGreenPaint / 3.4;
            double pravougulniciNaPokriva = 2 * (x * y);
            double triugulniciNaPokriva = 2 * (x * h / 2);
            litresRedPaint = pravougulniciNaPokriva + triugulniciNaPokriva;
            sumRedPaint = litresRedPaint / 4.3;
            Console.WriteLine($"{sumGreenPaint:F2}");
            Console.WriteLine($"{sumRedPaint:F2}");
        }
    }
}