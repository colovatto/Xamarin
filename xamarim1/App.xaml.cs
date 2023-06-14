using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarim1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new xamarim1.GerarEmail();
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
