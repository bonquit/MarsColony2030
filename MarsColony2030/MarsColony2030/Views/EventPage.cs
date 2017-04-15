using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MarsColony2030.Views
{
    public class EventPage : ContentPage
    {
        public EventPage(string text)
        {
            Content = new StackLayout
            {
                Children = {
                    new Label
                    {
                        FontSize = 25,
                        TextColor = Color.Black,
                        Text = text
                    }
                }
            };
        }
    }
}
