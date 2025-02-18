# Weather App

## Project Overview

The Weather App is a web application built with .NET Core MVC that provides real-time weather updates for users. The application fetches weather data from a third-party API and presents it in a user-friendly interface.

## Features

- **Search Weather by City:** Users can enter a city name to fetch current weather details.
- **Real-Time Weather Data:** Retrieves live temperature, humidity, and weather conditions.
- **Geolocation Support:** Automatically detects the user's location and provides weather updates.
- **Unit Conversion:** Allows users to switch between Celsius and Fahrenheit.
- **Responsive UI:** Fully optimized for desktop and mobile devices.

## Tech Stack

- **Frontend:** Razor Pages, Bootstrap, JavaScript
- **Backend:** .NET Core MVC
- **API Integration:** OpenWeatherMap API (or any preferred weather API)
- **Version Control:** Git, GitHub

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/john-rashin/WeatherApp-MVC.git
    cd weather-app
    ```

2. Install dependencies:
    ```sh
    dotnet restore
    ```

3. Run the application:
    ```sh
    dotnet run
    ```

4. Open a browser and navigate to `http://localhost:5058` (or specified port).

## API Configuration

To use the weather API, follow these steps:

1. Sign up for an API key at OpenWeatherMap.
2. Add the API key in the [appsettings.json](http://_vscodecontentref_/1) file:
    ```json
    {
      "WeatherApi": {
        "Key": "your-api-key-here"
      }
    }
    ```

## Contribution Guidelines

1. Fork the repository.
2. Create a new branch (`feature-branch-name`).
3. Commit your changes.
4. Push to your fork and submit a pull request.

## License

This project is licensed under the MIT License.