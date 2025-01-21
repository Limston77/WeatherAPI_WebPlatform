# Weather API Application

Это приложение разработано с использованием Blazor и предоставляет информацию о погоде и стране на основе введенного пользователем названия города. 

## Описание приложения

Приложение позволяет пользователю вводить название города и получать следующую информацию:

- Текущая температура
- Состояние погоды
- Скорость ветра
- Время в указанном городе
- Название страны
- Код страны
- Название города
- Численность населения

## Стек технологий

- **Blazor**: Используется для создания интерактивного веб-приложения.
- **HTML/CSS**: Для верстки интерфейса пользователя.
- **Bootstrap 5**: Для стилизации компонентов и адаптивного дизайна.
- **API**: Weather API и GeoNames API для получения информации о погоде и стране.

## Используемые API

### 1. Weather API
- **URL**: `https://weatherapi-production-57a3.up.railway.app/WeatherForecast/GetWeather/{cityName}`
- **Метод**: GET
- **Описание**: Используется для получения информации о погоде для указанного города.
- **Параметры**:
  - `cityName`: Название города (например, Таганрог).
- **Ответ**:
  - `Location`: Объект, содержащий:
    - `Name`: Название города.
    - `Country`: Название страны.
    - `Localtime`: Локальное время.
  - `Current`: Объект, содержащий:
    - `Temp_C`: Температура в Цельсиях.
    - `Condition`: Объект состояния,
      - `Text`: Описание состояния погоды.
    - `Wind_Kph`: Скорость ветра в километрах в час.

### 2. GeoNames API
- **URL**: `http://api.geonames.org/searchJSON?q={cityName}&username=your_username&maxRows=1`
- **Метод**: GET
- **Описание**: Используется для получения информации о стране, к которой принадлежит указанный город.
- **Параметры**:
  - `cityName`: Название города.
  - `username`: Ваше имя пользователя GeoNames.
- **Ответ**:
  - `geonames`: Массив объектов, содержащий:
    - `CountryCode`: Код страны (например, RU).
    - `CountryName`: Название страны (например, Россия).
    - `Name`: Название города.
    - `Population`: Численность населения.

### API Endpoints
### Weather API
Пример запроса: https://weatherapi-production-57a3.up.railway.app/WeatherForecast/GetWeather/{Таганрог}
```
{
  "location": {
    "name": "Таганрог",
    "localtime": "2025-01-16 11:25",
    "region": "Rostov",
    "country": "Россия"
  },
  "current": {
    "temp_C": 1.2,
    "condition": {
    "text": "Солнечно"
    },
    "wind_Kph": 13
  }
}
```

### GeoNames API
Пример запроса:http://api.geonames.org/searchJSON?q={Таганрог}&username=limston&maxRows=1
```
{
  "totalResultsCount": 13,
  "geonames": [
    {
      "adminCode1": "61",
      "lng": "38.9053",
      "geonameId": 484907,
      "toponymName": "Taganrog",
      "countryId": "2017370",
      "fcl": "P",
      "population": 279056,
      "countryCode": "RU",
      "name": "Taganrog",
      "fclName": "city, village,...",
      "adminCodes1": {
        "ISO3166_2": "ROS"
      },
      "countryName": "Russia",
      "fcodeName": "populated place",
      "adminName1": "Rostov",
      "lat": "47.23627",
      "fcode": "PPL"
    }
  ]
}
```

## Запуск через Railway
Вставить в поисковую строку:
- **URL**: http://weatherapiwebplatform-production.up.railway.app
