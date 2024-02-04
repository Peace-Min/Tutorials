using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickMVVMSetup
{
    public class VMLocator
    {
        public VMLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainVM>();

        }

        public MainVM MainVM
        {
            get => ServiceLocator.Current.GetInstance<MainVM>();
        }
    }
}
