# NutriBite

NutriBite is a customized .NET MAUI Food and Drink mobile app. It records food and drink items, nutrition notes, photos, locations, and motion-based context.

This version has been modified from the starter project with a clearer UI style, stronger validation, accessibility options, extra hardware demonstrations, and updated project documentation.

## Main Features

- Searchable food and drink catalogue.
- Nutrition cards and detail pages.
- Add-record form with friendly validation.
- Camera capture for food photos.
- Location and geocoding for meal context.
- Text-to-speech help narration.
- Vibration and haptic feedback.
- Live accelerometer readings.
- Live gyroscope readings.
- Shake detection for mixed drinks.
- Dark mode, large text, semantic labels, and screen-reader announcements.

## Hardware Covered

The hardware demo page covers these scoring items:

- Camera
- Location / Geocoding
- Text-to-speech
- Vibration / Haptic feedback
- Accelerometer
- Gyroscope
- Shake detection

The page includes live labels and counters so each feature can be clearly shown in the screen recording.

## Project Structure

```text
FoodDrinkApp.sln
FoodDrinkApp/
  MainPage.xaml
  AddItemPage.xaml
  FoodDetailPage.xaml
  HardwarePage.xaml
  SettingsPage.xaml
  Models/
  Services/
  Platforms/
DEMO_SCRIPT.md
mockapi-config-guide.md
project-guide.md
```

## Build Requirements

- Windows 10 or Windows 11
- .NET 9 SDK
- .NET MAUI workload
- Android SDK for Android builds
- VS Code with C# / C# Dev Kit, or Visual Studio 2022

## Build Commands

Windows:

```powershell
dotnet build .\FoodDrinkApp\FoodDrinkApp.csproj -p:TargetFrameworks=net9.0-windows10.0.19041.0 -f net9.0-windows10.0.19041.0
```

Android:

```powershell
$env:ANDROID_HOME="$env:LOCALAPPDATA\Android\Sdk"
$env:ANDROID_SDK_ROOT=$env:ANDROID_HOME
dotnet restore .\FoodDrinkApp\FoodDrinkApp.csproj -p:TargetFrameworks=net9.0-android
dotnet build .\FoodDrinkApp\FoodDrinkApp.csproj -f net9.0-android --no-restore
```

Build output is redirected by `Directory.Build.props` to:

```text
C:\MauiBuild\FoodDrinkApp\
```

## Recording Checklist

1. Introduce the Food and Drink theme and NutriBite concept.
2. Show the food list, search, detail page, and add-record flow.
3. Enter invalid form data and show friendly validation messages.
4. Demonstrate camera, location, TTS, vibration, haptic feedback, accelerometer, gyroscope, and shake detection.
5. Show dark mode, large text, semantic labels, and screen-reader-friendly UI choices.
6. Open key code files: XAML pages, services, validation code, and Android permissions.
7. Run on Android and Windows or an Android tablet emulator.
8. Show GitHub commit history and this README.
