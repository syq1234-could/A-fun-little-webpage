# NutriBite Project Guide

## 1. Project Overview

NutriBite is a .NET MAUI Food and Drink app. It records foods, drinks, nutrition details, photos, location context, and mobile hardware signals.

This modified version improves the original starter project in these areas:

- More complete food and drink list, search, detail, and add-record flow.
- Consistent XAML card-based UI.
- Dark mode and large text mode.
- Friendly form validation and exception messages.
- Extra motion hardware demos: accelerometer, gyroscope, and shake detection.
- Existing camera, location, text-to-speech, vibration, and haptic feedback features are kept and strengthened.
- README, API guide, project guide, and English demo script are updated.

## 2. Scoring Coverage

| Scoring item | Current implementation |
|---|---|
| UI/UX and accessibility | XAML pages, consistent colors, bottom tabs, semantic labels, screen-reader announcements, dark mode, large text mode |
| Mobile hardware | Camera, Location/Geocoding, Text-to-speech, Vibration/Haptic, Accelerometer, Gyroscope, Shake |
| Functionality | List, search, detail, add form, validation, settings, hardware demos |
| Validation and error handling | Required fields, non-negative numeric checks, permission errors, unsupported hardware, network fallback |
| Code quality | Models, Services, and Pages are separated; names are clear; services are reused |
| Deployment | Android and Windows MAUI targets |
| GitHub usage | Submit to the course repository with multiple meaningful commits |

## 3. Source Structure

```text
FoodDrinkApp/
  App.xaml
  AppShell.xaml
  MainPage.xaml
  MainPage.xaml.cs
  AddItemPage.xaml
  AddItemPage.xaml.cs
  FoodDetailPage.xaml
  FoodDetailPage.xaml.cs
  HardwarePage.xaml
  HardwarePage.xaml.cs
  SettingsPage.xaml
  SettingsPage.xaml.cs
  Models/
    FoodItem.cs
  Services/
    AccessibilityService.cs
    FoodCatalogService.cs
    MockApiConfig.cs
    SpeechService.cs
  Platforms/
    Android/
      AndroidManifest.xml
```

## 4. Important Files

### MainPage

`MainPage.xaml` and `MainPage.xaml.cs` show the food and drink catalogue. The page supports search by name, category, description, and tags.

### AddItemPage

`AddItemPage.xaml` and `AddItemPage.xaml.cs` provide the add-record form. `ValidateForm` checks required fields and nutrition numbers. Error messages are friendly and do not expose technical exception text to the user.

### FoodDetailPage

`FoodDetailPage.xaml` and `FoodDetailPage.xaml.cs` show nutrition details, allergy notes, and text-to-speech reading.

### HardwarePage

`HardwarePage.xaml` and `HardwarePage.xaml.cs` demonstrate mobile hardware:

- `MediaPicker.Default.CapturePhotoAsync()` for camera capture.
- `Geolocation.Default.GetLocationAsync()` for location.
- `Geocoding.Default.GetPlacemarksAsync()` for geocoding.
- `SpeechService.SpeakAsync()` for text-to-speech.
- `Vibration.Default.Vibrate()` for vibration.
- `HapticFeedback.Default.Perform()` for haptic feedback.
- `Accelerometer.Default.ReadingChanged` for live accelerometer readings.
- `Gyroscope.Default.ReadingChanged` for live gyroscope readings.
- `Accelerometer.Default.ShakeDetected` for shake detection.

### SettingsPage

`SettingsPage.xaml` and `SettingsPage.xaml.cs` provide light mode, dark mode, system theme, and large text mode.

### AndroidManifest

`Platforms/Android/AndroidManifest.xml` includes permissions and feature declarations for camera, location, vibration, accelerometer, and gyroscope.

## 5. Build and Run

Open `FoodDrinkApp.sln` with Visual Studio 2022, or use VS Code with the .NET SDK and MAUI workload installed.

Windows build:

```powershell
dotnet build .\FoodDrinkApp\FoodDrinkApp.csproj -p:TargetFrameworks=net9.0-windows10.0.19041.0 -f net9.0-windows10.0.19041.0
```

Android build:

```powershell
$env:ANDROID_HOME="$env:LOCALAPPDATA\Android\Sdk"
$env:ANDROID_SDK_ROOT=$env:ANDROID_HOME
dotnet restore .\FoodDrinkApp\FoodDrinkApp.csproj -p:TargetFrameworks=net9.0-android
dotnet build .\FoodDrinkApp\FoodDrinkApp.csproj -f net9.0-android --no-restore
```

## 6. Demo Advice

Use `DEMO_SCRIPT.md` for the English screen recording. The suggested order is:

1. Introduce NutriBite and the Food and Drink theme.
2. Show the list, search, detail page, and add-record form.
3. Demonstrate validation with empty or invalid input.
4. Demonstrate camera, location, TTS, vibration, and haptic feedback.
5. Demonstrate accelerometer, gyroscope, and shake detection.
6. Show dark mode and large text mode.
7. Open key code files and explain structure.
8. Show Android and Windows deployment.
9. Show GitHub commits and README.

## 7. Notes

- Flash is not implemented as an independent feature in this version, so do not present it as completed in the video.
- Some emulators may not provide real gyroscope or shake signals. The app handles unsupported hardware with friendly messages.
- For a stronger hardware demo, use a real Android phone if available.
