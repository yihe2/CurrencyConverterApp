# Currency Converter App

## Overview

Currency Converter App is an ASP.NET Core web application that simulates basic banking operations, including balance inquiries, deposits, and withdrawals, with support for multiple currencies. The application converts foreign currency amounts to CAD (Canadian Dollar) using predefined exchange rates.

## Features

- **Currency Conversion:** Automatic conversion of USD, MXN, and EUR to CAD.
- **Persistent Balance:** Account balance is saved to a file and maintained across sessions.
- **Simple UI:** A user-friendly web interface to interact with the account.

## Technologies Used

- **ASP.NET Core:** Backend framework for handling requests and rendering Razor Pages.
- **Razor Pages:** Used to create the UI and handle user interactions.
- **C#:** The primary programming language for the application logic.
- **GitHub:** Source control and project hosting.

## Prerequisites

Before you begin, ensure you have the following installed:

- **.NET SDK:** .NET 6.0 or later is recommended.
- **Git:** For version control and cloning the repository.
- **Visual Studio 2022 or Visual Studio Code:** An IDE or text editor to work with the project.

## Getting Started

Follow these steps to set up and run the project on your local machine.

### 1. Clone the Repository

```bash
git clone https://github.com/yihe2/CurrencyConverterApp.git
cd CurrencyConverterApp
```

### 2. Restore Dependencies

Navigate to the project directory and restore the NuGet packages:

```bash
dotnet restore
```

### 3. Build the Project

Build the project to ensure everything is set up correctly:
```bash
dotnet build
```

### 4. Run the Application

You can run the application using the following command:
```bash
dotnet run --launch-profile "https"
```
Alternatively, you can use Visual Studio or Visual Studio Code to launch the project with the appropriate profile.

### 5. Access the Application

Once the application is running, you can access it in your browser at:
* HTTPS: https://localhost:7258
* HTTP: http://localhost:5177

## Configuration

### Exchange Rates

The exchange rates are predefined within the application and are stored in the ATM class:

* 1 USD = 2 CAD
* 1 MXN = 0.1 CAD
* 1 EUR = 4 CAD

You can modify these rates by editing the exchangeRates dictionary in the ATM.cs file.

### Persistent Storage
The balance is saved to a file named `balance.txt` in the `wwwroot` directory. This file ensures that the balance is maintained across sessions.

## License
This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for more information.

## Contributors
- [Yihe Wang](https://github.com/yihe2)
