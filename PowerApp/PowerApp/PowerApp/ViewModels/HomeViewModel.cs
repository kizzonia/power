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
    class HomeViewModel : BaseViewModel
    {
        private INavigation Navigation;
        public HomeViewModel(INavigation _Navigation)
        {
            HydroACommand = new Command(HydroAPage);
            HydroBCommand = new Command(HydroBPage);

            Navigation = _Navigation;
        }

        public ICommand HydroACommand { private set; get; }
        public ICommand HydroBCommand { private set; get; }

        public void HydroAPage()
        {
            Navigation.PushAsync(new HydroA());
        }

        public void HydroBPage()
        {
            Navigation.PushAsync(new HydroB());
        }

    }
}
