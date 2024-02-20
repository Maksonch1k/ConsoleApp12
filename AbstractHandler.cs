using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public abstract class AbstractHandler
    {
        // Абстрактные методы работы с документом
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
}

