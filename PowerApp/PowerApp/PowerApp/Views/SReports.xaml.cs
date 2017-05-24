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
    public partial class SReports : ContentPage
    {
        public SReports()
        {
            InitializeComponent();
            InitializeComponent();
            HourPicker.Items.Add("Hour 0 to 1");
            HourPicker.Items.Add("Hour 1 to 2");
            HourPicker.Items.Add("Hour 2 to 3");
            HourPicker.Items.Add("Hour 3 to 4");
            HourPicker.Items.Add("Hour 4 to 5");
            HourPicker.Items.Add("Hour 5 to 6");
            HourPicker.Items.Add("Hour 6 to 7");
            HourPicker.Items.Add("Hour 7 to 8");
            HourPicker.Items.Add("Hour 8 to 9");
            HourPicker.Items.Add("Hour 9 to 10");
            HourPicker.Items.Add("Hour 10 to 11");
            HourPicker.Items.Add("Hour 11 to 12");
            HourPicker.Items.Add("Hour 12 to 13");
            HourPicker.Items.Add("Hour 13 to 14");
            HourPicker.Items.Add("Hour 14 to 15");
            HourPicker.Items.Add("Hour 15 to 16");
            HourPicker.Items.Add("Hour 16 to 17");
            HourPicker.Items.Add("Hour 17 to 18");
            HourPicker.Items.Add("Hour 18 to 19");
            HourPicker.Items.Add("Hour 19 to 20");
            HourPicker.Items.Add("Hour 20 to 21");
            HourPicker.Items.Add("Hour 21 to 22");
            HourPicker.Items.Add("Hour 22 to 23");
            HourPicker.Items.Add("Hour 23 to 24");

            //TimeFrames.Add(new Time { TimeFrame = "Hour 0 to 1" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 1 to 2" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 2 to 3" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 3 to 4" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 4 to 5" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 5 to 6" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 6 to 7" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 7 to 8" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 8 to 9" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 9 to 10" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 10 to 11" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 11 to 12" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 12 to 13" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 13 to 14" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 14 to 15" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 15 to 16" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 16 to 17" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 17 to 18" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 18 to 19" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 19 to 20" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 20 to 21" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 21 to 22" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 22 to 23" });
            //TimeFrames.Add(new Time { TimeFrame = "Hour 23 to 24" });
            //listView.ItemsSource = TimeFrames;


        }

     

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Successful", "Data as Been Uploaded Successfully", "Ok");
        }
        async void OnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
