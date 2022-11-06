using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new Page1();
            //MainPage = new FlyoutPage1();
            //MainPage = new NavigationPage( new NavigationDemo() );
            //MainPage = new TabbedPage1();
            MainPage = new CarouselDemo();
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
