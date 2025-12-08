using System;
using System.Collections.Generic;
using System.Linq;
//Було трохи складно, адже ми не проходили LINQ, але я зробив з ним, бо це дуже зручно,ну прям дуууже зручно
namespace dz_Cs_2;
class Program
{
    public static T FindMedian<T>(IEnumerable<T> collection) where T : IComparable<T>
    {
        var sortedList = collection.OrderBy(item => item).ToList();
        int count = sortedList.Count;
        if (count % 2 == 1)
        {
            return sortedList[count / 2];
        }
        else
        {
            if(typeof(T) == typeof(int))
            {
                int avgSum = Convert.ToInt32(sortedList[(count / 2) - 1]) + Convert.ToInt32(sortedList[count / 2]);
                return (T)Convert.ChangeType(avgSum / 2, typeof(T));
            }
            else if(typeof(T) == typeof(string))
            {
                string? first = sortedList[(count / 2) - 1].ToString();
                string? second = sortedList[count / 2].ToString();
                //return (T)Convert.ChangeType(first + " " + second, typeof(T));//я повертаю два але можно тільки один із них
                return sortedList[count / 2];//якщо треба тільки один
            }
            else
            {
                throw new InvalidOperationException("Unsupported type for median calculation:)");
            }

        }
    }
    static void Main()
    {
        Console.WriteLine(FindMedian(new List<int> { 5, 2, 9, 1, 6 }));
        Console.WriteLine(FindMedian(new List<int> { 4, 1, 7, 9, 3, 8 }));

        Console.WriteLine(FindMedian(new List<string>
        { "apple", "banana", "cherry", "date", "fig" }));

        Console.WriteLine(FindMedian(new List<string>
        { "apple", "banana", "cherry", "date" }));
    }

}
