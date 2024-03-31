using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Mori.Memento
{
    interface IMemento
    {
        string State { get; }
        Font Font { get; }
        Color ForeColor { get; }
    }
}
