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

## Установка

1. Клонируйте репозиторий:
   ```bash
   git clone https://github.com/ваш_пользователь/ваш_репозиторий.git


