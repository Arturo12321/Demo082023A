using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo082023A
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ExplicitStyles();
            //MainPage = new ImplicitStyles();
            //MainPage = new GlobalStyles();
            //MainPage = new StyleInheritance();
            //MainPage = new DinamicStyles();
            MainPage = new CascadingStyleSheets();
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
