using PowerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PowerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HydroB : ContentPage
    {
        public HydroB()
        {
            InitializeComponent();
            BindingContext = new HydroBViewModel(this.Navigation);
        }
    }
}
