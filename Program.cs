using System;
using dz_Cs_2.NewFolder.exercise1;
using dz_Cs_2.NewFolder.exercise2;
using dz_Cs_2.HW2;


namespace dz_Cs_2;
class Program
{
    static void Main()
    {
        #region HW 22.11.2025 - 29.11.2025 (folder HW1)
        Skripka s = new Skripka();
        Trombon t = new Trombon();
        Ukulele u = new Ukulele();
        Violonchel v = new Violonchel();
        s.Show(); 
        s.Sound(); 
        s.Desc(); 
        s.History();
        t.Show(); 
        t.Sound(); 
        t.Desc(); 
        t.History();
        u.Show(); 
        u.Sound(); 
        u.Desc(); 
        u.History();
        v.Show(); 
        v.Sound(); 
        v.Desc(); 
        v.History();
        Course c1 = new Course("Програмування", 40);
        OnlineCourse c2 = new OnlineCourse("C#", 25, "IT Step");
        Console.WriteLine(c1);
        Console.WriteLine(c2);
        #endregion
        #region HW 23.11.2025 - 30.11.2025 (folder HW2)
        Money a = new Money(10, 50);
        Money b = new Money(3, 80);
        while (true)
        {
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Sub");
            Console.WriteLine("3 - Mul");
            Console.WriteLine("4 - Div");
            Console.WriteLine("5 - Inc");
            Console.WriteLine("6 - Dec");
            Console.WriteLine("7 - Compare");
            Console.WriteLine("0 - Exit");
            string? c = Console.ReadLine();
            try
            {
                if (c == "1") Console.WriteLine($"a + b = {a + b}");
                else if (c == "2") Console.WriteLine($"a - b = { a - b}");
                else if (c == "3") Console.WriteLine($"a * 2 = {a * 2}");
                else if (c == "4") Console.WriteLine($"a / 2 = {a / 2}");
                else if (c == "5") { a++; Console.WriteLine($"A = {a}"); }
                else if (c == "6") { a--; Console.WriteLine($"A = {a}"); }
                else if (c == "7")
                {
                    Console.WriteLine("a < b " + (a < b));
                    Console.WriteLine("a > b " + (a > b));
                    Console.WriteLine("a == b " + (a == b));
                }
                else if (c == "0") break;
            }
            catch (BankruptException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        #endregion
    }
}
