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
        Label lblName = new Label();
        StackLayout stack = new StackLayout();
        ScrollView scroll = new ScrollView();
        TableView table = new TableView();
        ImageCell calorieCell = new ImageCell();

        public HomePage()
        {
            lblName.Text = "Hello " + MainPage.user.Name + "!";
            lblName.TextColor = Color.Black;
            lblName.HorizontalOptions = LayoutOptions.Center;

            
            calorieCell.Text = "Calories: " + MainPage.user.CurrentCalories + " out of " + MainPage.user.TotalCalories;

            table.Root = new TableRoot
            {
                new TableSection
                {
                    calorieCell
                }
            };

            stack.Children.Add(lblName);
            stack.Children.Add(table);
            scroll.Content = stack;

            Content = scroll;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lblName.Text = "Hello " + MainPage.user.Name + "!";
            calorieCell.Text = "Calories: " + MainPage.user.CurrentCalories + " out of " + MainPage.user.TotalCalories;
        }
    }
}
