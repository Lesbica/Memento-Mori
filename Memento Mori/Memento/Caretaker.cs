using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Mori.Memento
{
    class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        public void Backup(IMemento memento)
        {
            _mementos.Add(memento);
        }

        public IMemento Undo()
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
