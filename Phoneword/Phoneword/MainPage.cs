﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Phoneword
{
    public partial class MainPage1 : ContentPage
    {
        public MainPage1()
        {
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment =TextAlignment.Center,
                        Text ="Welcome to Xamarin.Anan!"
                    }
                }
            };
          }
    }
}
