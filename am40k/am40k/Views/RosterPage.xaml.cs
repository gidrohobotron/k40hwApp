﻿using Xamarin.Forms;
using System.Collections.Generic;

namespace am40k
{
    public partial class RosterPage : ContentPage
    {
        List<Unit> Units = new List<Unit>();
        //MainPage MainPage = new MainPage();
        //Database Database = new Database();
        ListView RosterUnits = new ListView()
        {
           
        };

        public RosterPage()
        {
            //ROSTER UNITS LIST

            Button BackToMainPageButton = new Button()
            {
                Text = "Back to Main Page"
            };
            BackToMainPageButton.Clicked += BackToMainPageButton_Clicked;

            //Create page content
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Margin = new Thickness(20),
                    Children =
                    {
                        new Label {Text = "ROSTER YOBA!!!", FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center},
                        BackToMainPageButton,
                        RosterUnits
                    }
                }
            };
        }

        private void BackToMainPageButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}