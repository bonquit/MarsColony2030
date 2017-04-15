using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MarsColony2030.Views
{
    public class SchedulePage : ContentPage
    {
        List<string> scheduleList = new List<string>()
        {
            "06:00 AM - Crew wake.  Clean up, eat, read news and messages",
            "07:30 AM - Morning Daily Planning Conference (DPC)",
            "07:55 AM - Work prep, review procedures and gather stowage",
            "08:15 AM - Crew available work time",
            "01:00 PM - Lunch",
            "02:00 PM - Crew available work time",
            "06:15 PM - Evening work prep, review procedures and timeline for next day.",
            "07:05 PM - Evening DPC.  Discuss comments/questions about the day executed.  Brief highlight for changes to tomorrow's plan (if required).",
            "07:30 PM - Dinner, relax, email, organize images for downlink, watch a movie, look at Earth! ",
            "09:30 PM - Crew Sleep (8.5 hrs)"
        };
        ListView list = new ListView();
        StackLayout stack = new StackLayout();
        ScrollView scroll = new ScrollView();

        public SchedulePage()
        {
            list.ItemsSource = scheduleList;
            list.ItemTapped += List_ItemTapped;
            scroll.Content = list;
            Content = scroll;
        }

        private void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item.ToString();
            EventPage eventPage = new EventPage(selectedItem);
            eventPage.Title = selectedItem;
            Navigation.PushAsync(eventPage);
        }
    }
}
