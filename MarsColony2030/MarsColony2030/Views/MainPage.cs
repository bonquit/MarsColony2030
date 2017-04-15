using MarsColony2030.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MarsColony2030.Views
{
    public class MainPage : TabbedPage
    {
        public static User user = new User();
        public MainPage()
        {

            HomePage homePage = new HomePage();
            homePage.Title = "Diet";

            SchedulePage schedulePage = new SchedulePage();
            schedulePage.Title = "Schedule";

            TravelPage travelPage = new TravelPage();
            travelPage.Title = "Travel";

            Children.Add(homePage);
            Children.Add(schedulePage);
            Children.Add(travelPage);
        }
    }
}
