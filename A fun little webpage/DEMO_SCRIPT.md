# NutriBite Demo Script

This script is designed for a 10-15 minute English screen recording.

## 1. Introduction

Hello, this is my final Food and Drink mobile application. The app is called NutriBite. It is built with .NET MAUI and it helps users record foods, drinks, nutrition details, photos, locations, and motion-based context.

## 2. UI, UX, and Accessibility

The interface uses XAML pages with a consistent color system, readable cards, bottom navigation, and clear touch targets. The design supports dark mode and a large text option. I also added semantic descriptions and screen-reader announcements, following WCAG ideas such as readable contrast, predictable navigation, and accessible feedback.

## 3. Food and Drink Features

On the main page, I can search food and drink records by name, category, description, or tags. Each card shows calories and macronutrients. The detail page shows the full nutrition summary and allergy note. The add page validates the required fields before saving.

## 4. Validation and Error Handling

Here I intentionally leave the name empty and press save. The app shows a friendly message instead of crashing. If I type an invalid nutrition number, the app asks for a valid non-negative number. Hardware permission and device errors are also caught and displayed as user-friendly messages.

## 5. Hardware Demonstration

The hardware page demonstrates several mobile hardware features. The camera captures a food photo. Location and geocoding show the meal place and coordinates. Text-to-speech reads the help text aloud. Vibration and haptic feedback confirm important actions.

I also added three motion features. The accelerometer displays live X, Y, and Z readings and generates a food or drink movement insight. The gyroscope shows angular movement when I rotate the device. Shake detection marks a drink as mixed and updates a counter, which is useful for smoothies, protein shakes, and bottled drinks.

## 6. Code Quality

The code is separated into pages, models, and services. `FoodItem` stores the data model. `FoodCatalogService` handles the data source and fallback logic. `AccessibilityService` centralizes font scaling. `HardwarePage` contains hardware calls with try-catch blocks so the app can handle permission or device failures.

## 7. Deployment

The project targets Android and Windows through .NET MAUI. In this recording I show the app running on Android and then on another device target such as Windows or an Android tablet emulator.

## 8. GitHub and README

The repository includes a README that explains the app features, hardware coverage, build commands, and recording checklist. The commit history records the development process with meaningful messages.
