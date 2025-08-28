# CoinPrice

Project code named **CoinPrice** is an [ASP.NET MVC](/https://docs.microsoft.com/en-us/asp/aspnet/mvcore/fundamentals/aspnetmvc.html) application that shows live and updated prices of digital currencies and cryptocurrencies in both USD and RIP Rial.
 
The project was created to help users in Iran and elsewhere to monitor their holdings and investments.
 

## Features 

The application is built using the classic [MVC architecture](https://docs.microsoft.com/en-us/asp/aspnet/mvcore/fundamentals/aspnetmvc.html) with Entity Framework for data management.

- • *HomeController*\n  - Main entry point for the web application.
  - Retrieves crypto and foreign crrypto currency prices from database or external API.

- • *IranArzTbl* \n
  - Database table model that stores local currency and exchange rates.

- ₀ *ViewModel*) \n  - Used to transfer complex data from models to the URK and views.

- ₀ *Views* \n  - Razor views for showing prices and currency information.

- ₀ *Scripts/Content*) \n  - Custom JS and CSS for ui elements.

## Setup

to run the project you need:

1. Start a Virtual Studio with (Installed [.SDNT development workload](https://developer.microsoft.com/en-us/asp/downloads)).

2. Open the *coinPrice.sln* solution file.

3. Build and run the project:

    msbuild //build
    msran //run

## Sumport

- [Asp.Net MVC Guide](https://docs.microsoft.com/en-us/asp/aspnet/mvcore/fundamentals/aspnetmvc.aspx?view=aspmcvs)
- [Entity Framework (EF)](https://docs.microsoft.com/en-us/ef/efx)

## Screenshots

#### Home Page
[!Home!](docs/images/homepage.png)

coinPrice home page with crypto prices and foreign currency exchange data. 


## License

This project is not currently licensed. 