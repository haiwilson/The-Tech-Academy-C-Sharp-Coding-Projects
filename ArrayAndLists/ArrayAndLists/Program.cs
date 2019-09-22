using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] strArray = new string[5];
        strArray[0] = "tom";
        strArray[1] = "sher";
        strArray[2] = "connie";
        strArray[3] = "bes";
        strArray[4] = "dave";
        Console.WriteLine("select an index of an array");
        int index1 = Convert.ToInt32(Console.ReadLine());
        if (index1 > 4)
        {
            Console.WriteLine("Index out of bounds. should be less than 5");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(strArray[index1]);
            Console.ReadLine();
        }

        int[] numArray = new int[5];
        numArray[0] = 3;
        numArray[1] = 6;
        numArray[2] = 9;
        numArray[3] = 12;
        numArray[4] = 15;
        Console.WriteLine("select an index of an array");
        int index2 = Convert.ToInt32(Console.ReadLine());
        if (index2 > 4)
        {
            Console.WriteLine("Index out of bounds. should be less than 5");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(numArray[index2]);
            Console.ReadLine();
        }

        List<string> inList = new List<string>();
        inList.Add("hi");
        inList.Add("hope");
        inList.Add("you");
        inList.Add("are");
        inList.Add("having");
        inList.Add("a");
        inList.Add("good");
        inList.Add("day");
        Console.WriteLine("select an index of an array");
        int index3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(inList[index3]);
        Console.ReadLine();
    }
}

