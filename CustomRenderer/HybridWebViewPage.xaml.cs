using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
#if __ANDROID__
using Android.Graphics;
#endif
#if WINDOWS_UWP
using Windows.Storage.Streams;
using Windows.Graphics.Imaging;
using System.Runtime.InteropServices.WindowsRuntime;
#endif
namespace CustomRenderer
{
    class Threded : ContentPage
    {
        private void Thred() 
        {
            var hybridWebView = new HybridWebView
            {
                Uri = "index.html"
            };
            hybridWebView.RegisterAction(data => DisplayAlert("Alert", "Hello " + data, "OK"));
        } 
    }
    public partial class HybridWebViewPage : ContentPage
    {
        public HybridWebViewPage()
        {
            InitializeComponent();
            //Task.Delay(TimeSpan.FromSeconds(3.3f));
            //hybridWebView.RegisterAction(data => DisplayAlert("Alert", "Hello " + data, "OK"));
            //var hybridWebView = new HybridWebView { Uri = "index.html" };
            //hybridWebView.RegisterAction(data => DisplayAlert("Alert", "Hello " + data, "OK"));
            if (Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Minor >= 0 && Environment.OSVersion.Version.Build >= 19041)
            {
                hybridWebView.RegisterAction(data => DisplayAlert("Alert", "Hello " + data, "OK"));
            }
            else
            {
                Threded thr = new Threded();
            }
        }
    }
}
