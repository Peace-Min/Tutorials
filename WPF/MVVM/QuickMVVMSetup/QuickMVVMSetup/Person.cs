using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight;
using CommonServiceLocator;
using PropertyChanged;
namespace QuickMVVMSetup
{
    public class Person : INotifyPropertyChanged
    {
        public string FName { get; set; }
        public string LName
        { get; set; }

        public string Age { get; set; }

        public Person() { }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
