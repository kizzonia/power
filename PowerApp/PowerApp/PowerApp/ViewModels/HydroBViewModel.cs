using PowerApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PowerApp.ViewModels
{
    class HydroBViewModel : BaseViewModel
    {
        private INavigation Navigation;
        public HydroBViewModel(INavigation _Navigation)
        {
            OpRecordsBCommand = new Command(OpRecordsBPage);
            SRecordsBCommand = new Command(SRecordsBPage);

            Navigation = _Navigation;
        }

        public ICommand OpRecordsBCommand { private set; get; }
        public ICommand SRecordsBCommand { private set; get; }

        public void OpRecordsBPage()
        {
            Navigation.PushAsync(new OPReports());
        }

        public void SRecordsBPage()
        {
            Navigation.PushAsync(new SReports());
        }
    }
}

