using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_ListBox_Binding
{
    internal class Student : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                OnPropertiChanged();
                OnPropertiChanged(nameof(FullInfo));
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set 
            { 
                age = value;
                OnPropertiChanged();
                OnPropertiChanged(nameof(FullInfo));
            }
        }
        public string FullInfo => Name + " : " + Age;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertiChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {            
            return $"{Name} : {Age}";
        }
    }
}
