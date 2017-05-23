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
    class HydroAViewModel : BaseViewModel
    {
        private INavigation Navigation;
        public HydroAViewModel(INavigation _Navigation)
        {
            OpRecordsCommand = new Command(OpRecordsPage);
            SRecordsCommand = new Command(SRecordsPage);

            Navigation = _Navigation;
        }

        public ICommand OpRecordsCommand { private set; get; }
        public ICommand SRecordsCommand { private set; get; }

        public void OpRecordsPage()
        {
            Navigation.PushAsync(new OpRecords());
        }

        public void SRecordsPage()
        {
            Navigation.PushAsync(new SRecords());
        }
    }
}
