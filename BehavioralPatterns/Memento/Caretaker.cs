using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Memento
{
    public class Caretaker<T> where T : ICloneable, IRestorable<T>, INotifyPropertyChanged
    {
        private ICollection<Memento<T>> _mementos = new List<Memento<T>>();
        private T _originator;

        public Caretaker(T originator, params Memento<T>[] mementos) : this(originator)
        {
            _mementos = mementos;
        }

        public Caretaker(T originator)
        {
            _originator = originator;
            SaveState();
            _originator.PropertyChanged += PropertyChangedHandler();
        }

        private PropertyChangedEventHandler PropertyChangedHandler()
        {
            return (sender, args) => SaveState();
        }

        public void SaveState()
        {
            Console.WriteLine("\nCaretaker: Saving state...");
            var memento = new Memento<T>((T)_originator.Clone());
            _mementos.Add(memento);
        }

        public void Undo()
        {
            if (!_mementos.Any())
                return;

            _originator.PropertyChanged -= PropertyChangedHandler();
            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine($"\nCaretaker: Restoring state from {memento.DateTime.ToShortTimeString()}...");

            //memento.Restore(_originator);
            _originator.Restore(memento.State);
            _originator.PropertyChanged += PropertyChangedHandler();
        }

        public void RestoreTo(int seconds)
        {
            var now = DateTime.Now;
            var memento = _mementos.OrderByDescending(x => x.DateTime).SkipWhile(x => (now - x.DateTime).TotalSeconds < seconds ).FirstOrDefault();
            if (memento == null)
                return;

            _originator.PropertyChanged -= PropertyChangedHandler();
            Console.WriteLine($"\nCaretaker: Restoring state from {memento.DateTime.ToShortTimeString()}...");

            //memento.Restore(_originator);
            _originator.Restore(memento.State);
            _originator.PropertyChanged += PropertyChangedHandler();
        }
    }
}
