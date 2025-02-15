Weather App

Project Overview

The Weather App is a web application built with .NET Core MVC that provides real-time weather updates for users. The application fetches weather data from a third-party API and presents it in a user-friendly interface.

Features

Search Weather by City: Users can enter a city name to fetch current weather details.

Real-Time Weather Data: Retrieves live temperature, humidity, and weather conditions.

5-Day Forecast: Displays a forecast for the next five days.

Geolocation Support: Automatically detects the user's location and provides weather updates.

Unit Conversion: Allows users to switch between Celsius and Fahrenheit.

Responsive UI: Fully optimized for desktop and mobile devices.

Tech Stack

Frontend: Razor Pages, Bootstrap, JavaScript

Backend: .NET Core MVC

API Integration: OpenWeatherMap API (or any preferred weather API)

Database: SQLite / SQL Server (if needed for user preferences)

Version Control: Git, GitHub

Installation

Clone the repository:

git clone https://github.com/your-username/weather-app.git
cd weather-app

Install dependencies:

dotnet restore

Run the application:

dotnet run

Open a browser and navigate to http://localhost:5000 (or specified port).

API Configuration

To use the weather API, follow these steps:

Sign up for an API key at OpenWeatherMap.

Add the API key in the appsettings.json file:

{
  "WeatherApi": {
    "Key": "your-api-key-here"
  }
}

Contribution Guidelines

Fork the repository.

Create a new branch (feature-branch-name).

Commit your changes.

Push to your fork and submit a pull request.

License

This project is licensed under the MIT License.

