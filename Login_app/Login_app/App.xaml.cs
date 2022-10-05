using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            MainPage = new LoginUI(); 
            //MainPage = new OnBoarding(); 
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
