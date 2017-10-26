using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace SimpleMapsAndGeo.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            global::Xamarin.FormsMaps.Init("hK24egEkYCnINavlO25O~V2FUhVpB9_rMic5luUrrmQ~AiGzgFc1KZbLqqGlbDbEBiFhOhDoPbpKJsQZdfbG3AeHA1Au7LFhtBVri6lSmyWL");
            LoadApplication(new SimpleMapsAndGeo.App());
        }
    }
}
