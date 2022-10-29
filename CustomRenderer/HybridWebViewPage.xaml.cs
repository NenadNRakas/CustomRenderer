using System;
using System.Collections.Generic;
using System.Text;
using CustomRenderer;
using Xamarin.Forms;
namespace CustomRenderer
{
    public partial class HybridWebViewPage : ContentPage
    {
        /*private void InitializeComponenet()
        {
            throw new NotImplementedException();
        }*/
        public HybridWebViewPage()
        {
            InitializeComponent();
            hybridWebView.RegisterAction(data => DisplayAlert("Alert", "Hello " + data, "OK"));
        }
    }
}
