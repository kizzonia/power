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
    public partial class SRecords : ContentPage
    {
        public SRecords()
        {
            InitializeComponent();
        }
        async private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SReports());
        }
        async void SRecordsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new SReports() { BindingContext = e.SelectedItem as Settlement_Record});
            }
        }
    }
}
