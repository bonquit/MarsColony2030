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
        ImageCell earthCell = new ImageCell();
        ImageCell marsCell = new ImageCell();
        ImageCell calorieCell = new ImageCell();

        Label lblCurrentCalories = new Label();
        Entry txtCalories = new Entry();
        Button btnAddCalories = new Button();

        public HomePage()
        {
            lblName.Text = "Hello " + MainPage.user.Name + "!";
            lblName.TextColor = Color.Black;
            lblName.FontSize = 22;
            lblName.HorizontalOptions = LayoutOptions.Center;

            calorieCell.ImageSource = "Calories.png";
            calorieCell.Tapped += CalorieCell_Tapped;
            calorieCell.Text = "Calories for today: " + MainPage.user.CurrentCalories + " out of " + MainPage.user.TotalCalories;

            earthCell.ImageSource = "Earth.png";
            earthCell.Text = "Earth Weight: " + (MainPage.user.Weight * 2.205) + " lbs";

            marsCell.ImageSource = "icon.png";
            marsCell.Text = "Mars Weight: " + Math.Ceiling(((Math.Ceiling(MainPage.user.Weight * 2.205) / 9.81) * 3.711)) + " lbs";

            table.Root = new TableRoot
            {
                new TableSection
                {
                    earthCell,
                    marsCell,
                    calorieCell
                }
            };

            lblCurrentCalories.Text = "Current calories for today: " + MainPage.user.CurrentCalories;
            lblCurrentCalories.FontSize = 20;
            lblCurrentCalories.TextColor = Color.Black;
            lblCurrentCalories.HorizontalOptions = LayoutOptions.CenterAndExpand;

            txtCalories.Placeholder = "Add calories";
            btnAddCalories.Text = "Add calories";
            btnAddCalories.Clicked += BtnAddCalories_Clicked;

            stack.Children.Add(lblName);
            stack.Children.Add(table);
            stack.Children.Add(lblCurrentCalories);
            stack.Children.Add(txtCalories);
            stack.Children.Add(btnAddCalories);

            Content = stack;
        }

        private void CalorieCell_Tapped(object sender, EventArgs e)
        {
            //CaloriePage caloriePage = new CaloriePage();
            //caloriePage.Title = "Calories";
            //Navigation.PushAsync(caloriePage);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lblName.Text = "Hello " + MainPage.user.Name + "!";
            calorieCell.Text = "Calories: " + MainPage.user.CurrentCalories + " out of " + MainPage.user.TotalCalories;
            earthCell.Text = "Earth Weight: " + (MainPage.user.Weight * 2.205) + " lbs";
            marsCell.Text = "Mars Weight: " + Math.Ceiling(((Math.Ceiling(MainPage.user.Weight * 2.205) / 9.81) * 3.711)) + " lbs";
        }

        private void BtnAddCalories_Clicked(object sender, EventArgs e)
        {
            MainPage.user.CurrentCalories += Convert.ToInt32(txtCalories.Text);
            calorieCell.Text = "Calories: " + MainPage.user.CurrentCalories + " out of " + MainPage.user.TotalCalories;
            Navigation.PopAsync();
        }
    }
}
