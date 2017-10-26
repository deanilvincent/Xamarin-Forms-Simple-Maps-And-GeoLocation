# Xamarin-Forms-Simple-Maps-And-GeoLocation

This repository is intended for source code demo purposes. This repo contains Cross Platform Xamarin Project that shows current geolocation, custom pin and maps. 

## Setup
Android:

Generate Api Key: https://console.cloud.google.com
1. Go to Android Project
2. Expand the Properties and look for AndroidManifest.xml
3. Paste this code with your key inside the '<application android:label="ProjectName.Android">...</application>
```
<meta-data android:name="com.google.android.geo.API_KEY" android:value="AIzaSyAYj8b5gi1G1o1BVfyhkJNXLGx0_3ELMgw"/>
```

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

UWP:

Generate Api Key: https://www.bingmapsportal.com/Application
```
hK24egEkYCnINavlO25O~V2FUhVpB9_rMic5luUrrmQ~AiGzgFc1KZbLqqGlbDbEBiFhOhDoPbpKJsQZdfbG3AeHA1Au7LFhtBVri6lSmyWL
```
