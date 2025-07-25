# Nepali-English Date Conversion Utility (.NET Core)

This .NET Core project provides utilities for converting dates between the Nepali (Bikram Sambat - BS) and English (Gregorian - AD) calendar systems. It also supports common date arithmetic operations such as adding days, months, and years.

## ✨ Features

- 🔄 Convert **Nepali date to English** date.
- 🔄 Convert **English date to Nepali** date.
- ➕ Add/Subtract **days**, **months**, and **years** in either calendar system.
- 📅 Display current date in both **BS** and **AD** formats.

### Convert Nepali date string to AD `DateTime`
### Convert AD `DateTime` to Nepali date string
### Add years or months to a Nepali date
### Get day or month count between two Nepali dates
### Check if a Nepali year is a leap year
### Get month info for a Nepali date
### Validate Nepali date format


## 📦 Tech Stack

- Language: C#
- Framework: .NET Core / .NET 6+
- IDE: Visual Studio 2022+
- Target Platforms: Windows, Linux (cross-platform compatible)

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (.NET Core 3.1 or later)
- Visual Studio 2022+ or Visual Studio Code

### Clone the Repository

```bash
git clone https://github.com/koolkabin/NepaliCalendarCore.git
cd nepali-date-converter
````

### Run the Application

```bash
dotnet run
```

## 🛠️ Usage

### Import the necessary classes

```csharp
using NepaliCalendar; // Assume this is your namespace
using NepaliCalendar.Utils.NepaliCalendarExtension;
```

### Convert Nepali Date to English

```csharp
var nepaliDate = "2081/04/10"; // B.S.
DateTime englishDate = nepaliDate.ToAD();
Console.WriteLine("English Date: " + englishDate.ToString("yyyy-MM-dd"));
```

### Convert English Date to Nepali

```csharp
var english = new DateTime(2025, 7, 25);
string bsDate = english.ToBS();
Console.WriteLine($"Nepali Date: {bsDate.Year}-{bsDate.Month:D2}-{bsDate.Day:D2}");
```

### Add Days, Months, and Years

```csharp
string original = "2082/04/02"; // B.S. date
string after15Days = original.AddDays(15);
string after2Months = original.AddMonths(2);
string after1Year = original.AddYears(1);

Console.WriteLine("After 15 Days: " + after15Days);
Console.WriteLine("After 2 Months: " + after2Months);
Console.WriteLine("After 1 Year: " + after1Year);
```

### Subtracting Days

```csharp
string before10Days = original.AddDays(-10);
Console.WriteLine("10 Days Ago: " + before10Days);
```

## 📚 Sample Output

```bash
Nepali: 2081-04-10
English: 2024-07-25

After Adding 15 Days:
Nepali: 2081-04-25
English: 2024-08-09
```

## 📁 Project Structure

```
/NepaliDateConverter
|-- Program.cs
|-- NepDate.cs
|-- Utils/
    |-- Converter.cs
    |-- NepaliCalendarExtension.cs
|-- README.md
```

## ✅ Tests

To run unit tests:

```bash
dotnet test
```

## 📅 Reference

* Algorithm based on Government of Nepal calendar datasets

## 👨‍💻 Author

Kabindra Bakey
Email: [koolkabin@live.com](mailto:koolkabin@live.com)
LinkedIn: [LinkedIn](https://www.linkedin.com/in/koolkabin)

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

```

---

Let me know if you'd like this tailored for a Web API, NuGet package, or console library format. If you want, I can also autogenerate it based on your `.csproj` and source code.
```
