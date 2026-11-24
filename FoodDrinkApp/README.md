# NutriBite App Source

This folder contains the .NET MAUI source code for NutriBite, a Food and Drink mobile app.

## What This App Does

- Shows a searchable food and drink catalogue.
- Displays nutrition details, allergy notes, and meal descriptions.
- Adds new records with friendly validation.
- Captures food photos with the camera.
- Gets meal location and geocoding data.
- Reads help and nutrition text aloud with text-to-speech.
- Uses vibration and haptic feedback for action confirmation.
- Shows live accelerometer readings.
- Shows live gyroscope readings.
- Detects shake gestures for mixed drinks.
- Supports dark mode, large text, semantic labels, and screen-reader announcements.

## Important Files

```text
MainPage.xaml              Food list and search UI
AddItemPage.xaml           Add form and validation UI
FoodDetailPage.xaml        Nutrition detail UI
HardwarePage.xaml          Camera, location, TTS, feedback, and sensors
SettingsPage.xaml          Theme and accessibility options
Models/FoodItem.cs         Food and drink data model
Services/FoodCatalogService.cs
Services/AccessibilityService.cs
Services/SpeechService.cs
Platforms/Android/AndroidManifest.xml
```

## Build

Open the solution from the parent folder:

```text
../FoodDrinkApp.sln
```

Or build with the .NET MAUI SDK:

```powershell
dotnet build .\FoodDrinkApp.csproj -f net9.0-windows10.0.19041.0
dotnet build .\FoodDrinkApp.csproj -f net9.0-android
```

Use Android plus Windows or an Android tablet emulator for the deployment section of the recording.
