# CoinPrice

🇮🇷 [نسخه فارسی](./README.fa.md)

Project code named **CoinPrice** is an [ASP.NET MVC](https://docs.microsoft.com/en-us/asp/asp/mvc/overview) application that shows live and updated prices of digital currencies and cryptocurrencies in both USD and IRR Rial.

the project was created to help users in Iran and elsewhere to monitor their holdings and investments.

## Features 

The application is built using the classic [MVC architecture](https://docs.microsoft.com/en-us/asp/aspnet/mvc/overview) with Entity Framework for data management.

- • *HomeController*\n  - Main entry point for the web application.  \n  - Retrieves crypto and foreign currency prices from database or external API.

- • *IranArzTbl*)  \n  - Database table model that stores local currency and exchange rates.

- • *ViewModel*  \n  - Used to transfer complex data from models to the URL and views.

- • *Views*  \n  - Razor views for showing prices and currency information.

- • *Scripts/Content*)  \n  - Custom JS and CSS for ui elements.

## Setup

Test the project you need:
1
 Start Visual Studio with the [ASP.NET development workload](https://visualstudio.microsoft.com/vs/).  \n2  Open the *CoinPrice.sln* solution file.  \n3  Build and run the project:

``bash
msbuild //build
msran  //run
```

## Support

- [ASP.NET MVC Guide](https://docs.microsoft.com/en-us/asp/aspnet/mvc/overview?view=aspmvc)  \n- [Entity Framework (EF)](https://docs.microsoft.com/en-us/ef/efx)

## Screenshots

### Home Page

[homepage screenshot](./docs/images/homepage.png)

CoinPrice home page with crypto prices and foreign currency exchange data.  


## License

This project is not currently licensed.