using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using System.Threading.Tasks;
using Xamarin.Forms;
using Phoneword.iOS;
[assembly: Dependency(typeof(PhoneDialer))]
namespace Phoneword.iOS
{
    public class PhoneDialer : IDialer
    {
        public Task<bool> DialAsync(string number)
        {
            return Task.FromResult(
                UIApplication.SharedApplication.OpenUrl(
                    new NSUrl("tel:"+number))
                );
        }
    }
}