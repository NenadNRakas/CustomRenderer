using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace CustomRenderer
{
    //internal class HybridWebViewPageCS {    }
    public class HybridWebViewPageCS : ContentPage
    {
        public HybridWebViewPageCS()
        {
            var hybridWebView = new HybridWebView
            {
                Uri = "index.html"
            };
            hybridWebView.RegisterAction(data => DisplayAlert("Alert", "Hello " + data, "OK"));
            Padding = new Thickness(0, 40, 0, 0);
            Content = hybridWebView;
        }
    }
}
