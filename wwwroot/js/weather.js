document.getElementById("searchBtn").addEventListener("click", function () {
    let city = document.getElementById("cityInput").value.trim();
    let weatherCard = document.querySelector(".weather-card");

    if (!city) {
        alert("Please enter a city name.");
        return;
    }

    // Ensure weather card maintains height before API response
    weatherCard.classList.add("expanded");

    fetch(`/Weather/GetWeather?city=${city}`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
    })
    .then(response => response.json())
    .then(data => {
        if (data.city) {
            document.getElementById("weatherDisplay").innerHTML = `
                <h2>${data.city}</h2>
                <p>Temperature: ${data.temperature}°C</p>
                <p>Humidity: ${data.humidity}%</p>
                <p>Condition: ${data.condition}</p>
            `;

            // Keep the weather card height consistent
            weatherCard.style.minHeight = "200px";
        } else {
            document.getElementById("weatherDisplay").innerHTML = `<p>City not found.</p>`;
        }
    })
    .catch(error => {
        console.error("Error:", error);
        document.getElementById("weatherDisplay").innerHTML = `<p>Something went wrong. Please try again.</p>`;
    });
});


// Toggle Dark Mode
document.getElementById("toggleTheme").addEventListener("click", function () {
    document.body.classList.toggle("dark-mode");

    // Save theme preference in local storage
    let isDarkMode = document.body.classList.contains("dark-mode");
    localStorage.setItem("darkMode", isDarkMode);
});

// Apply saved theme preference on page load
window.addEventListener("load", function () {
    let savedTheme = localStorage.getItem("darkMode");
    if (savedTheme === "true") {
        document.body.classList.add("dark-mode");
    }else {
        document.body.classList.add("default-theme"); // Ensure default theme is applied
    }
});
