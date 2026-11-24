# mockapi.io Configuration Guide

NutriBite can use two data sources:

- mockapi.io REST API, if configured.
- Local fallback data in `FoodCatalogService.cs`, if the API is not configured or the network is unavailable.

This fallback keeps the app usable during demos and prevents network failure from breaking the presentation.

## 1. Create A Resource

1. Open `https://mockapi.io`.
2. Create or open a project.
3. Add a resource named:

```text
foods
```

4. Add these fields:

| Field | Type | Meaning |
|---|---|---|
| name | String | Food or drink name |
| category | String | Category, such as Breakfast, Lunch, Drink |
| description | String | Description, ingredients, or flavour |
| calories | Number | Calories |
| protein | Number | Protein grams |
| carbs | Number | Carbohydrate grams |
| fat | Number | Fat grams |
| allergyNote | String | Allergy or dietary note |
| tags | String | Search tags |

The `id` field is generated automatically by mockapi.io.

## 2. Example Data

```json
{
  "name": "Berry Yogurt Bowl",
  "category": "Breakfast",
  "description": "Greek yogurt with mixed berries, oats, and honey.",
  "calories": 340,
  "protein": 24,
  "carbs": 42,
  "fat": 8,
  "allergyNote": "Contains dairy and gluten.",
  "tags": "healthy breakfast yogurt berries"
}
```

```json
{
  "name": "Iced Matcha Latte",
  "category": "Drink",
  "description": "Matcha, milk, and ice with a lower-sugar option.",
  "calories": 180,
  "protein": 8,
  "carbs": 22,
  "fat": 6,
  "allergyNote": "Contains dairy unless plant-based milk is selected.",
  "tags": "drink caffeine matcha latte"
}
```

## 3. Configure The API URL

mockapi.io will generate an endpoint similar to:

```text
https://682xxxx.mockapi.io/api/v1/foods
```

Open:

```text
FoodDrinkApp/Services/MockApiConfig.cs
```

Change `EndpointUrl` to your endpoint:

```csharp
public const string EndpointUrl = "https://682xxxx.mockapi.io/api/v1/foods";
```

After configuration:

- The main page loads food data from mockapi.io.
- The add page posts new records to mockapi.io.
- The detail page loads a record by id.
- If the network fails, the app uses local fallback data.

## 4. Demo Explanation

Suggested explanation:

> The app can load food and drink data from mockapi.io through `FoodCatalogService`. If the network is unavailable, it falls back to local data, so the demo remains stable and the user still sees friendly behaviour instead of a crash.
