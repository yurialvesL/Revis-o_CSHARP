﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces4.Devices
{
    public class Scanner : Device,IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);

        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
