using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MarsColony2030.Views
{
    public class TravelPage : ContentPage
    {
        ProgressBar distProgress = new ProgressBar();
        StackLayout distStack = new StackLayout();
        Label lblEarth = new Label(), lblMars = new Label();

        StackLayout stack = new StackLayout();
        ScrollView scroll = new ScrollView();
        TableView table = new TableView();

        ImageCell distanceCell = new ImageCell();
        ImageCell speedCell = new ImageCell();
        ImageCell timeCell = new ImageCell();
        ImageCell temperatureCell = new ImageCell();
        ImageCell fuelCell = new ImageCell();

        public TravelPage()
        {
            lblEarth.Text = "Earth";
            distProgress.Progress = 0.4;
            lblMars.Text = "Mars";

            distStack.Orientation = StackOrientation.Horizontal;
            distStack.HorizontalOptions = LayoutOptions.CenterAndExpand;
            distStack.Children.Add(lblEarth);
            distStack.Children.Add(distProgress);
            distStack.Children.Add(lblMars);

            distanceCell.Text = "Distance to Mars: 54,000,000 km";
            speedCell.Text = "Travel speed: 25,000 km/hr";
            timeCell.Text = "Time to Mars: 3000 hrs";
            temperatureCell.Text = "Spacecraft temp: 72 F";
            fuelCell.Text = "Fuel: 90%";

            table.Root = new TableRoot
            {
                new TableSection
                {
                    distanceCell,
                    speedCell,
                    timeCell,
                    temperatureCell,
                    fuelCell
                }
            };

            stack.Children.Add(distStack);
            stack.Children.Add(table);
            scroll.Content = stack;
            Content = scroll;
        }
    }
}
