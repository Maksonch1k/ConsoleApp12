using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class TXTHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT document format...");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT document format...");
        }

        public override void Change()
        {
            Console.WriteLine("Change TXT document format...");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT document format...");
        }
    }
}

