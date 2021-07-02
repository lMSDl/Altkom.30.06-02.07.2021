using ArchitecturalPatterns.Commands;
using ArchitecturalPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ArchitecturalPatterns.ViewModel
{
    public class ViewModel : NotifyPropertyChanged
    {
        private string inputValue = "Hello!";

        public ViewModel()
        {
            Model = new SomeModel();
            SaveCommand = new Command(() => InputValue != Model.Value, () => Model.Value = InputValue);
            LoadCommand = new Command(() => InputValue != Model.Value && InputValue != null, () => InputValue = Model.Value);
        }

        public string InputValue
        {
            get => inputValue;
            set
            {
                inputValue = value;
                OnPropertyChanged();
            }
        }
        public SomeModel Model { get; set; }

        public ICommand SaveCommand { get; set; }
        public ICommand LoadCommand { get; set; }
    }
}
