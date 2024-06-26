﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Mori.Memento
{
    class ConcreteMemento : IMemento
    {
        public string State { get; }
        public Font Font { get; }
        public Color ForeColor { get; }

        public ConcreteMemento(string state, Font font, Color foreColor)
        {
            State = state;
            Font = font;
            ForeColor = foreColor;
        }
    }
}