using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Currency
    {
        public string Name { get; set; }
        public float Value { get; set; }

        public Currency(string n, float v)
        {
            this.Name = n;
            this.Value = v;
        }
    }
}
