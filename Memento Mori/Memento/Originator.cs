using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Mori.Memento
{
    class Originator
    {
        public string State { get; set; }
        public Font Font { get; set; }
        public Color ForeColor { get; set; }

        public Originator(string state)
        {
            State = state;
            Font = SystemFonts.DefaultFont;
            ForeColor = SystemColors.ControlText;
            Console.WriteLine("Початковий стан редактора: " + state);
        }

        public Memento Save()
        {
            return new Memento(State, Font, ForeColor);
        }

        public void Restore(Memento memento)
        {
            State = memento.State;
            Font = memento.Font;
            ForeColor = memento.ForeColor;
            Console.WriteLine($"Стан відновлено до: {State}");
        }


    }
}
