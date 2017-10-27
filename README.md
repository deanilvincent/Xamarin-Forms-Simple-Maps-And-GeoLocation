# Xamarin-Forms-Simple-Maps-And-GeoLocation

This repository is intended for source code purposes. This repo contains Simple Cross Platform Xamarin Project that shows current geolocation, custom pin and maps. 

## Setup
Android:

Generate Api Key: https://console.cloud.google.com
1. Go to Android Project
2. Expand the Properties and look for AndroidManifest.xml
3. Paste this code with your key inside the '<application android:label="ProjectName.Android">...</application>
```
<meta-data android:name="com.google.android.geo.API_KEY" android:value="AIzaSyAYj8b5gi1G1o1BVfyhkJNXLGx0_3ELMgw"/>
```
4. Go to "Android Properties" and choose "Android Manifest"
5. Check the following:
    - ACCESS_COARSE_LOCATION
    - ACCESS_FINE_LOCATION
    - ACCESS_LOCATION_EXTRA_COMMANDS
    - ACCESS_MOCK_LOCATION
    - ACCESS_NETWORK_STATE
    - ACCESS_WIFI_STATE
    - INTERNET
6. Go to MainActivity.cs and paste this above the "LoadApplication(new App());"
```
global::Xamarin.FormsMaps.Init(this, bundle);
```

Running Google Maps in Android Emulator requires "Google Play Services." Download Gapps Zip file here http://www.teamandroid.com/gapps/ and drag-and-drop to your running android emulator: 

iOS:
1. Go to iOS Project
2. Locate the Info.plist and right click then choose "Open With"...
3. Choose editor type
4. Paste this code below <dict>
```
<key>NSLocationAlwaysUsageDescription</key>
    <string>Can we use your location</string>
<key>NSLocationWhenInUseUsageDescription</key>
    <string>We are using your location</string>
```
5. Go to AppDelegate.cs and paste this above LoadApplication(new App());
```
global::Xamarin.FormsMaps.Init();  
```
UWP:

Generate Api Key: https://www.bingmapsportal.com/Application
1. Go to UWP Project
2. Paste this inside the constructor of MainPage.xaml.cs
Usage:
```
// Bing Map Api Key
global::Xamarin.FormsMaps.Init("hK24egEkYCnINavlO25O~V2FUhVpB9_rMic5luUrrmQ~AiGzgFc1KZbLqqGlbDbEBiFhOhDoPbpKJsQZdfbG3AeHA1Au7LFhtBVri6lSmyWL");

// hK24egEkYCnINavlO25O~V2FUhVpB9_rMic5luUrrmQ~AiGzgFc1KZbLqqGlbDbEBiFhOhDoPbpKJsQZdfbG3AeHA1Au7LFhtBVri6lSmyWL is the generated api key
```
3. Locate and click the Package.appxmanifest file and choose "Capabilities"
4. Check the following:
    - Internet 
    - Location
