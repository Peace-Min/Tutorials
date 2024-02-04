using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Haley.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;

namespace QuickMVVMSetup
{
    public class MainVM : INotifyPropertyChanged
    {
        public Person TargetPerson { get; set; }
        public ObservableCollection<Person> Persons { get; set; }
        public void AddPerson(object obj)
        {
            Persons.Add(TargetPerson); //Add it to thecollection
            TargetPerson = new Person(); //resetting it.
        }
        private RelayCommand<Person> bb;

        public event PropertyChangedEventHandler PropertyChanged;

        public DelegateCommand<Person> CMDAdd
        { get; private set; }
        
      
        public DelegateCommand<Person> CMDDelete => new DelegateCommand<Person>(DeletePerson);
        //public ICommand CMDDelete => this.bb ?? (this.bb = new RelayCommand<Person>(DeletePerson));
        //public ICommand CMDDelete => new DelegateCommand<Person>(DeletePerson); 
        private void DeletePerson(Person obj)
        {
            if (obj == null) return;
            if (!Persons.Contains(obj)) return;

            Persons.Remove(obj);
        }

        public MainVM()
        {
            Persons = new ObservableCollection<Person>();
            TargetPerson = new Person();
            CMDAdd = new DelegateCommand<Person>(AddPerson);
        }

    }
}
