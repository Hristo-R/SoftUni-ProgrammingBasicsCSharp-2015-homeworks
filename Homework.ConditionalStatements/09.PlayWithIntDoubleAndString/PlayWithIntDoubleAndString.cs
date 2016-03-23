﻿using System;

class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Please enter a int: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine(i + 1);
                    break;
            case "2":
                Console.Write("Please enter a double: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine(d + 1);
                    break;
            case "3":
                Console.WriteLine("Please enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                    break;
            default:
                Console.WriteLine("Wrong choice"); break;
        }
    }
}