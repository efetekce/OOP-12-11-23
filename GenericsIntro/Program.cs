﻿namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Efe");
            Console.WriteLine("Hello, World!");
        }
    }
}