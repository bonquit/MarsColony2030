using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MarsColony2030
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Views.MainPage mainPage = new Views.MainPage();

            ToolbarItem tool = new ToolbarItem();
            tool.Text = "Settings";

            mainPage.ToolbarItems.Add(tool);
            mainPage.Title = "Schedulamizer";

            MainPage = new NavigationPage(mainPage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
