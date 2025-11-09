using System;
namespace dz_Cs_2;
class Program
{
    static void Main(string[] args)
    {
        //1
        Console.Write("Enter expression : ");
        string expr = Console.ReadLine();
        int sum = 0;
        int num = 0;
        char op = Convert.ToChar(Console.ReadLine());
        for (int i = 0; i < expr.Length; i++)
        {
            char c = expr[i];
            if (c >= '0' && c <= '9')
            {
                num = num * 10 + (c - '0');
            }
            if (c == '+' || c == '-' || i == expr.Length - 1)
            {
                if (i == expr.Length - 1 && c >= '0' && c <= '9')
                {
                    //num = num * 10 + (c - '0');
                }
                if (op == '+') sum += num;
                else if (op == '-') sum -= num;
                num = 0;
                op = c;
            }
        }
        Console.WriteLine("Result : " + sum);
        Console.WriteLine();

        //2
        string text = Console.ReadLine();
        int key = 111;
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if (c >= 'A' && c <= 'Z')
                c = (char)((c - 'A' + key) % 26 + 'A');
            else if (c >= 'a' && c <= 'z')
                c = (char)((c - 'a' + key) % 26 + 'a');
            result += c;
        }
        Console.WriteLine("Encrypted text: " + result);
        //3
        Console.WriteLine("Enter text:");
        string textToCheck = Console.ReadLine();
        Console.Write("Invalid word: ");
        string bad = Console.ReadLine();
        int count = 0;
        string res = "";
        int i2 = 0;
        while (i2 < textToCheck.Length)
        {
            bool found = true;
            if (i2 + bad.Length <= textToCheck.Length)
            {
                for (int j = 0; j < bad.Length; j++)
                {
                    if (textToCheck[i2 + j] != bad[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    for (int j = 0; j < bad.Length; j++)
                        res += '*';
                    i2 += bad.Length;
                    count++;
                    continue;
                }
            }
            res += textToCheck[i2];
            i2++;
        }
        Console.WriteLine();
        Console.WriteLine("Result:");
        Console.WriteLine(res);
        Console.WriteLine("Statistics: " + count + " replacements of the word \"" + bad + "\".");
    }
}
