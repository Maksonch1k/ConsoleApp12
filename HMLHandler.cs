using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class HMLHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML document format...");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML document format...");
        }

        public override void Change()
        {
            Console.WriteLine("Change XML document format...");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML document format...");
        }
    }
}

