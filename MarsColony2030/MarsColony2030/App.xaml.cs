using MarsColony2030.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MarsColony2030
{
    public partial class App : Application
    {
        Views.MainPage mainPage = new Views.MainPage();
        public App()
        {
            InitializeComponent();

            

            ToolbarItem tool = new ToolbarItem();
            tool.Text = "Settings";
            tool.Clicked += Tool_Clicked;

            mainPage.ToolbarItems.Add(tool);
            mainPage.Title = "Schedulamizer";

            MainPage = new NavigationPage(mainPage);
        }

        private void Tool_Clicked(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage();
            settingsPage.Title = "Configure your profile";
            mainPage.Navigation.PushAsync(settingsPage);
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
