using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3
{
    internal class Computer : ProductInfos
    {
        public string CPU {  get; set; }

        public string GPU { get; set; }

        public string RAM { get; set; }

        public void WriteInfos()
        {
            Console.WriteLine(RAM);
            Console.WriteLine(CPU);
            Console.WriteLine(GPU);
            Console.WriteLine(productname);
            Console.WriteLine(price);
            Console.WriteLine(quantity);
        }
    }
}
