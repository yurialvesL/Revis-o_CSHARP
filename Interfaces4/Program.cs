﻿using Interfaces4.Devices;
using System;


namespace Interfaces4
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Printer p =  new Printer() { SerialNumber = 1080};
            p.ProcessDoc("My letter");
            p.Print("My letter");


            Scanner s = new Scanner() { SerialNumber = 2003};
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());


            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My Dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}