using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Memento
    {
        public List<Currency> CurrencysMemento { get; private set; }

        public Memento()
        {
            CurrencysMemento = new List<Currency>();
        }

        public Memento(List<Currency> v)
        {
            this.CurrencysMemento = new List<Currency>(v);
        }
    }
}
