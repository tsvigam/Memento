using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class MementoHistory
    {
        public Stack<Memento> History { get; private set; }

        public MementoHistory()
        {
            History = new Stack<Memento>();
        }
    }
}
