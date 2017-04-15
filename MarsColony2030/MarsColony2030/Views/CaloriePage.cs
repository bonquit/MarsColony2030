using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MarsColony2030.Views
{
    public class CaloriePage : ContentPage
    {
        Label lblCurrentCalories = new Label();
        Entry txtCalories = new Entry();
        Button btnAddCalories = new Button();
        StackLayout stack = new StackLayout();

        public CaloriePage()
        {
            lblCurrentCalories.Text = "Current calories for today: " + MainPage.user.CurrentCalories;
            lblCurrentCalories.FontSize = 20;
            lblCurrentCalories.TextColor = Color.Black;
            lblCurrentCalories.HorizontalOptions = LayoutOptions.CenterAndExpand;

            txtCalories.Placeholder = "Add calories";
            btnAddCalories.Text = "Add calories";
            btnAddCalories.Clicked += BtnAddCalories_Clicked;

            stack.Children.Add(lblCurrentCalories);
            stack.Children.Add(txtCalories);
            stack.Children.Add(btnAddCalories);

            Content = stack;
        }

        private void BtnAddCalories_Clicked(object sender, EventArgs e)
        {
            MainPage.user.CurrentCalories += Convert.ToInt32(txtCalories.Text);
            Navigation.PopAsync();
        }
    }
}
