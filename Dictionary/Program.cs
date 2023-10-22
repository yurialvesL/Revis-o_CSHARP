﻿using System;
using System.Collections.Generic;



namespace Dictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);
            cookies.Remove("email");
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no email key");

            }
            Console.WriteLine($"Size:{cookies.Count}");
            Console.WriteLine("All coookies:");
            foreach(KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine(item.Key +": "+item.Value);
            }
        }
    }
}