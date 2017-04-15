using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MarsColony2030.Views
{
    public class SettingsPage : ContentPage
    {
        Entry txtName, txtWeight, txtHeight, txtAge;
        Button btnSaveChanges;
        Picker genderPicker;
        Label lblGender = new Label();
        StackLayout stack = new StackLayout();
        ScrollView scroll = new ScrollView();

        public SettingsPage()
        {
            txtName = new Entry();
            txtName.Placeholder = "Name";
            txtName.Text = MainPage.user.Name;

            genderPicker = new Picker();
            genderPicker.Title = "Gender";
            genderPicker.ItemsSource = new List<string>() { "Male", "Female" };
            
            if (MainPage.user.IsMale == true)
                genderPicker.SelectedItem = "Male";
            else
                genderPicker.SelectedItem = "Female";

            txtWeight = new Entry();
            txtWeight.Placeholder = "Weight (lbs)";
            if (MainPage.user.Weight != 0)
                txtWeight.Text = (MainPage.user.Weight * 2.205).ToString();

            txtHeight = new Entry();
            txtHeight.Placeholder = "Height (in)";
            if (MainPage.user.Height != 0)
                txtHeight.Text = (MainPage.user.Height / 2.54).ToString();

            txtAge = new Entry();
            txtAge.Placeholder = "Age";
            if (MainPage.user.Age != 0)
            txtAge.Text = MainPage.user.Age.ToString();

            btnSaveChanges = new Button();
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.Clicked += BtnSaveChanges_Clicked;

            stack.Children.Add(txtName);
            stack.Children.Add(genderPicker);
            stack.Children.Add(txtWeight);
            stack.Children.Add(txtHeight);
            stack.Children.Add(txtAge);
            stack.Children.Add(btnSaveChanges);
            scroll.Content = stack;
            Content = scroll;
        }

        private void BtnSaveChanges_Clicked(object sender, EventArgs e)
        {
            MainPage.user.Name = txtName.Text;

            if (genderPicker.SelectedItem.ToString() == "Male")
                MainPage.user.IsMale = true;
            else
                MainPage.user.IsMale = false;


            var weightlbs = Convert.ToDouble(txtWeight.Text);
            MainPage.user.Weight = weightlbs / 2.205;

            var heightinches = Convert.ToDouble(txtHeight.Text);
            MainPage.user.Height = heightinches * 2.54;

            MainPage.user.Age = Convert.ToInt32(txtAge.Text);

            calculateCalories();
        }

        void calculateCalories()
        {
            double cal;
            if (MainPage.user.IsMale == true)
            {
                cal = Math.Ceiling(((10 * MainPage.user.Weight + 6.25 * MainPage.user.Height - 5 * MainPage.user.Age + 5) * 1.7247));
            }
            else
            {
                cal = Math.Ceiling(((10 * MainPage.user.Weight + 6.25 * MainPage.user.Height - 5 * MainPage.user.Age - 161) * 1.7247));
            }

            MainPage.user.TotalCalories = Convert.ToInt32(cal);
            Navigation.PopAsync();
        }
    }
}
