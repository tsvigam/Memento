using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class CurrencyState
    {
        public List<Currency> Currencies { get; private set; }

        public CurrencyState()
        {
            Currencies = new List<Currency>();
        }

        public Memento CreateMoment()
        {
            return new Memento(Currencies);
        }

        public void RestoreMoment(Memento m)
        {
            this.Currencies = new List<Currency>(m.CurrencysMemento);
        }
    }
}
