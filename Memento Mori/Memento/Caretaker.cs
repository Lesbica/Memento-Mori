using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Mori.Memento
{
    class Caretaker
    {
        private List<Memento> _mementos = new List<Memento>();

        public void Backup(Memento memento)
        {
            _mementos.Add(memento);
        }

        public Memento Undo()
        {
            if (_mementos.Count == 0)
                return null;

            var lastIndex = _mementos.Count - 1;
            var lastMemento = _mementos[lastIndex];
            return lastMemento;
        }

        public string ShowHistory()
        {
            string history = "";
            foreach (var memento in _mementos)
            {
                history += memento.State + memento.Font + memento.ForeColor + "\n";
            }
            return history;
        }
    }
}
