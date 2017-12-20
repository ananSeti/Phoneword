using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword
{
    
    public partial class MainPage : ContentPage
	{
        Entry phoneNumberText;
        Button translateButton;
        Button callButton;
        string translateNumber;
        public MainPage()
		{
            this.Padding = new Thickness(20, 20, 20, 20);
            StackLayout panel = new StackLayout
            {
                Spacing =15
            };
            panel.Children.Add(new Label
            {
                Text = "Enter a phone number",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            });
            panel.Children.Add(phoneNumberText = new Entry
            {
                Text = "1-885-XAMARIN",
            });
            panel.Children.Add(translateButton = new Button {
            Text ="Translate"
            });
            panel.Children.Add(callButton = new Button {
                Text="Call",
                IsEnabled =false,
            });

            translateButton.Clicked += OnTranslate;
            callButton.Clicked += OnCall;
            this.Content = panel;
        }

        async void OnCall(object sender, EventArgs e)
        {
           if(await this.DisplayAlert("Dial a Number","Would you like to call" +
               translateNumber + "?","Yes","No"))
            {
                //TODO
            }
        }

        private void OnTranslate(object sender, EventArgs e)
        {
            string enterNumber = phoneNumberText.Text;
            translateNumber = Phoneword.PhonewordTranslator.ToNumber(enterNumber);
            if (!string.IsNullOrEmpty(translateNumber))
            {
                // TODO
                callButton.IsEnabled = true;
                callButton.Text = "Call" + translateNumber;
            }
            else {
                //TODO
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }
        }
    }
}
