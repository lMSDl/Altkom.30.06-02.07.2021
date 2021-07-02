using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Memento
{
    public class Person : ICloneable, IRestorable<Person>, INotifyPropertyChanged
    {
        private string name;
        private int editCounter;

        public string Name
        {
            get => name; set
            {
                name = value;
                editCounter++;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }

        public int EditCounter { get => editCounter; }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address)Address.Clone();
            return clone;
        }

        public void Restore(Person state)
        {
            GetType().GetProperties().Where(x => x.CanWrite).Where(x => x.CanRead)
                .ToList().ForEach(x => x.SetValue(this, x.GetValue(state)));
            editCounter = state.editCounter;
        }
    }
}
