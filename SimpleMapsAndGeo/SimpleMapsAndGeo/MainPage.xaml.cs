using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace SimpleMapsAndGeo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Task.Run(async () =>
            {
                // Getting current location
                var locator = CrossGeolocator.Current;

                var getPosition = await locator.GetPositionAsync(TimeSpan.FromSeconds(2), null, true);

                var currentPosition = new Position(getPosition.Latitude, getPosition.Longitude);

                // Declare map details
                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(currentPosition.Latitude, currentPosition.Longitude), Distance.FromMiles(1)));

                // Set pin to the location
                var setPin = new Pin
                {
                    Type = PinType.Generic,
                    Position = currentPosition,
                    Address = "Custom Pin",
                    Label = "Description of this pin"
                };

                // Now add the pin to the map
                MyMap.Pins.Add(setPin);
            });
        }
    }
}
