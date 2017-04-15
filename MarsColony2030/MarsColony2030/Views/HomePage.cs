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

        Label lblCurrentCalories = new Label();
        Entry txtCalories = new Entry();
        Button btnAddCalories = new Button();

        public HomePage()
        {
            lblName.Text = "Hello " + MainPage.user.Name + "!";
            lblName.TextColor = Color.Black;
            lblName.FontSize = 22;
            lblName.HorizontalOptions = LayoutOptions.Center;

            calorieCell.Tapped += CalorieCell_Tapped;
            calorieCell.Text = "Calories for today: " + MainPage.user.CurrentCalories + " out of " + MainPage.user.TotalCalories;

            table.Root = new TableRoot
            {
                new TableSection
                {
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
        }

        private void BtnAddCalories_Clicked(object sender, EventArgs e)
        {
            MainPage.user.CurrentCalories += Convert.ToInt32(txtCalories.Text);
            Navigation.PopAsync();
        }
    }
}
