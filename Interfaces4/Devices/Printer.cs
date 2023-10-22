using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interfaces4.Devices
{
    public class Printer: Device,IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer Processing: "+ document);


        }
        public void Print(string document) 
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
