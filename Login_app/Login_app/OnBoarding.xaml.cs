using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnBoarding : ContentPage
    {
        public OnBoarding()
        {
            InitializeComponent();
        }

        //private async void Button_Clicked(object sender,EventArgs e)
        //{
        //    await Navigation.PushAsync(new LoginUI());
        //}

    }
}