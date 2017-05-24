using PowerApp.Models;
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
    public partial class OpRecords : ContentPage
    {
        public OpRecords()
        {
            InitializeComponent();
        }
        async private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OPReports());
        }
        async void OpRecordsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new OPReports() { BindingContext = e.SelectedItem as OPRecord });
            }
        }
    }
}
