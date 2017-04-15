using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MarsColony2030.Views
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Home Page" }
                }
            };
        }
    }
}
