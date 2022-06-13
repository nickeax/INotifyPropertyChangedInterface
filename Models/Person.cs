using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChangedInterface.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string fName;
        private string lName;
        private string fullName;

        public string FName
        {
            get => fName;
            set
            {
                if (!value.Equals(fName))
                    fName = value;
                OnPropertyChanged(nameof(FullName));
                OnPropertyChanged(nameof(FName));
            }
        }
        public string LName
        {
            get => lName;
            set
            {
                if (!value.Equals(lName))
                    lName = value;
                OnPropertyChanged(nameof(FullName));
                OnPropertyChanged(nameof(lName));
            }
        }
        public string FullName
        {
            get => $"{fName} {lName}";
            set
            {
                if(fullName != value)
                fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
