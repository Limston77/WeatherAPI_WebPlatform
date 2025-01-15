WeatherApi
Приложение представляет собой API для получения данных о погоде в городе с использованием ASP.NET Core. Оно включает контроллер для обработки запросов и сервис для обращения к внешнему API, предоставляющему информацию о погоде. API позволяет пользователям запрашивать текущую погоду по названию города. Используя контроллеры, сервисы и модели, приложение организует процесс получения и обработки данных, что делает его легко расширяемым и управляемым.

Request (запрос)
GET [https://crack-dashing-pangolin.ngrok-free.app/WeatherForecast/GetWeather/{city}]

Описание

Эндпоинт для проверки запроса на получение информации о погоде. Пользователь вводит название города вместо параметра "city", а API возвращает получает и десириализирует данные нужном образом.

Структура приложения
Контроллер (WeatherForecastController):
Управляет HTTP-запросами.
Имеет метод GetCurrentWeatherInTown, который принимает название города в виде параметра.
Создает экземпляр HttpClient для выполнения запросов к внешнему API погоды.
Модель данных (WeatherData):
Описание структуры получаемых данных о погоде.
Включает классы Location, CurrentWeather и Condition, отражающие местоположение и текущие погодные условия.
Сервис (WeatherSerevice):
Содержит метод GetDailyWeather, который асинхронно запрашивает данные о погоде для заданного города.
Генерирует URL для запроса, основываясь на имени города и API-ключе.
Обрабатывает ответ от API и возвращает объект WeatherData.
Конфигурация приложения (Program.cs):
Настройка приложения и регистрация сервисов.
Подробное описание работы метода GetCurrentWeatherInTown
При получении запроса с названием города:

Проверяет наличие имени города. Если нет — возвращает код 400 Bad Request.
Вызывает сервис WeatherSerevice.GetDailyWeather с указанным городом.
Если результат не найден, возвращает код 404 Not Found.
В случае успешного получения данных, возвращает их с кодом 200 OK.
Обрабатывает возможные исключения и возвращает код 500 Internal Server Error в случае ошибки.
Обработка данных в WeatherSerevice
Метод GetDailyWeather:

Формирует URL для запроса с использованием переданного названия города.
Выполняет асинхронный запрос к внешнему API.
Проверяет успешность ответа и десериализует JSON в объект WeatherData.
Если данные не были успешно обработаны, возвращает null.
Модели данных
WeatherData: Корневая модель, содержащая информацию о местоположении и текущей погоде.
Location: Содержит имя, местное время, регион и страну.
CurrentWeather: Включает температуру, скорость ветра и описание погодных условий.
Condition: Подробности о текущих условиях погоды.
Пример
Запрос: GET [https://crack-dashing-pangolin.ngrok-free.app/WeatherForecast/GetWeather/{Таганрог}]

Ответ:

{

"location": {
    "name": "Таганрог",
    "localtime": "2024-12-17 00:05",
    "region": "Rostov",
    "country": "Россия"
},
"current": {
    "temp_C": 4.2,
    "condition": {
        "text": "Местами дождь"
    },
    "wind_Kph": 38.9
}
}
