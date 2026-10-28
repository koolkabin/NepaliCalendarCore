# NepaliCalendarCore

**AD ↔ BS (Bikram Sambat) date conversion for .NET**, with month info, BS date arithmetic and Nepali number-to-words.

[![NuGet](https://img.shields.io/nuget/v/NepaliCalendarCore.svg)](https://www.nuget.org/packages/NepaliCalendarCore)
[![Downloads](https://img.shields.io/nuget/dt/NepaliCalendarCore.svg)](https://www.nuget.org/packages/NepaliCalendarCore)
[![Build](https://github.com/koolkabin/NepaliCalendarCore/actions/workflows/dotnet.yml/badge.svg)](https://github.com/koolkabin/NepaliCalendarCore/actions)
[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

---

## Features

- 🔄 Convert **AD → BS** and **BS → AD**, in both directions
- 📅 Get the **current Nepali date** in one line
- 🗓️ **Month info**: start date, end date, total days, with `NextMonth()` / `PrevMonth()` navigation
- ➕ **BS date arithmetic**: add months or years, count days or months between two BS dates
- ✅ **Validation**: check BS date format and leap years
- 🔤 **Number to words** in Nepali Unicode (useful for cheques, invoices and vouchers)
- 🧩 **Extension methods** (`DateTime.ToBS()`, `string.ToAD()` and more) for short, readable code
- No external dependencies

## Installation

```bash
dotnet add package NepaliCalendarCore
```

Or with the Package Manager Console:

```powershell
Install-Package NepaliCalendarCore
```

Or add it directly to your `.csproj`:

```xml
<PackageReference Include="NepaliCalendarCore" Version="1.4.0" />
```

> **Supported frameworks:** see the [NuGet page](https://www.nuget.org/packages/NepaliCalendarCore) for the current target frameworks.
<!-- TODO (author): after multi-targeting, update this line, e.g. ".NET Standard 2.0 and .NET 8.0 (works with .NET Framework 4.6.1+, .NET Core 2.0+ and .NET 5+)". -->

## Quick start

```csharp
using NepaliCalendar;
using NepaliCalendar.Utils.NepaliCalendarExtension; // extension methods

// 1. Current Nepali date
Console.WriteLine($"Today: {DateTime.Now} is {NepaliCalendar.Convert.Now} in BS");

// 2. AD -> BS
DateTime ad = DateTime.Now.AddMonths(-1);
Console.WriteLine(NepaliCalendar.Convert.ToNepali(ad));

// 3. BS -> AD
string bs = "2078-04-01";
DateTime converted = NepaliCalendar.Convert.ToEnglish(bs);
Console.WriteLine($"{bs} BS = {converted:yyyy-MM-dd} AD");

// 4. The same thing with extension methods
string bsDate  = DateTime.Now.ToBS();
DateTime adDate = bs.ToAD();
```

## Date format

BS dates are handled as strings in `YYYY-MM-DD` form, for example `2078-04-01`.

<!-- TODO (author): confirm which separators are accepted (the old README used "2078-04-01", the NuGet README used "2081/04/10"). State here whether both "-" and "/" work and whether single-digit months/days like "2078-4-1" are accepted. -->

## Supported date range

<!-- TODO (author): fill in from your data table. -->
The library uses a lookup table of BS month lengths covering **BS `____` to `____`** (AD `____` to `____`).

Dates outside this range are **`____`** (for example: rejected by `BSIsValid()` / throw an exception / return null).

> BS month lengths vary from year to year and have no exact formula, which is why every BS library depends on such a table.

## Usage

### Core conversion

| Method | Description |
|---|---|
| `Convert.Now` | Current date in BS |
| `Convert.ToNepali(DateTime)` | Convert an AD date to BS |
| `Convert.ToEnglish(string)` | Convert a BS date string (`"2078-04-01"`) to an AD `DateTime` |

### Extension methods

Namespace: `NepaliCalendar.Utils.NepaliCalendarExtension`

| Method | Example | Description |
|---|---|---|
| `ToAD()` | `NepaliCalendar.Convert.Now.ToAD()` | BS date to AD |
| `ToBS()` | `DateTime.Now.ToBS()` | AD date to BS |
| `BSAddMonths(n)` | `Convert.Now.BSAddMonths(5)` | Add months to a BS date |
| `BSAddYears(n)` | `Convert.Now.BSAddYears(5)` | Add years to a BS date |
| `BSDayCountAfterMonths(n)` | `Convert.Now.BSDayCountAfterMonths(5)` | Days from this date to the date `n` months later |
| `BSDayCountAfterYears(n)` | `Convert.Now.BSDayCountAfterYears(5)` | Days from this date to the date `n` years later |
| `BSDayCount(other)` | `Convert.Now.BSDayCount(Convert.Now.BSAddMonths(3))` | Number of days between two BS dates |
| `BSMonthCount(other)` | `Convert.Now.BSMonthCount(Convert.Now.BSAddMonths(3))` | Number of months between two BS dates |
| `IsLeapYear()` | `Convert.Now.IsLeapYear()` | Whether the BS year is a leap year |
| `BSMonthInfo()` | `Convert.Now.BSMonthInfo()` | `MonthInfo` for the month of a BS date |
| `BSIsValid()` | `"2078-13-40".BSIsValid()` | Whether a BS date string is valid |

```csharp
var today = NepaliCalendar.Convert.Now;

var afterThreeMonths = today.BSAddMonths(3);
int days   = today.BSDayCount(afterThreeMonths);
int months = today.BSMonthCount(afterThreeMonths);

bool valid = "2081-04-10".BSIsValid();
bool leap  = today.IsLeapYear();
```

### Month info

`MonthInfo` describes a single BS month and lets you walk forward and backward through months.

```csharp
MonthInfo m = new MonthInfo(NepaliCalendar.Convert.Now);

PrintMonthInfo(m);              // current month
PrintMonthInfo(m.PrevMonth());  // previous month
PrintMonthInfo(m.NextMonth());  // next month

static void PrintMonthInfo(MonthInfo m)
{
    Console.WriteLine($"Month Info: {m}");
    Console.WriteLine($"Total Days: {m.days}  End Date (BS): {m.EndDateNep}");
    Console.WriteLine($"Start (AD): {m.StartDate}  End (AD): {m.EndDate}");
}
```

| Member | Description |
|---|---|
| `days` | Total days in the month |
| `StartDate` / `EndDate` | First and last day of the month, in AD |
| `EndDateNep` | Last day of the month, in BS |
| `PrevMonth()` / `NextMonth()` | `MonthInfo` for the previous or next month |

This is handy for building a Nepali calendar grid, monthly reports and fiscal-period filters.

### Number to words (Nepali Unicode)

<!-- TODO (author): replace with the real class/method names and verified output. Suggested format below. -->

```csharp
// TODO: replace with the actual API
// string words = NepaliCalendar.<ClassName>.<MethodName>(12345);
// Console.WriteLine(words);   // expected output: ____
```

## Common use cases

- **Accounting and billing**: BS dates on invoices, ledgers and VAT reports; fiscal-year filtering
- **HR and payroll**: monthly salary cycles, joining dates, leave and tax periods
- **Banking and loans**: tenure, maturity date and day-count interest in Nepali months and years
- **Schools and hospitals**: admission, exam, appointment and birth/death records
- **Government and legal systems**: forms, permits, land and court documents
- **Calendar and event apps**: month grids, reminders and navigation
- **Reports and exports**: BS dates and amount-in-words on PDFs, cheques and vouchers

A typical pattern is to **store AD in the database and display BS in the UI**:

```csharp
// saving
DateTime toStore = userEnteredBs.ToAD();

// showing
string toShow = dbValue.ToBS();
```

## Running the tests

```bash
git clone https://github.com/koolkabin/NepaliCalendarCore.git
cd NepaliCalendarCore
dotnet test
```

The solution contains three projects:

| Project | Purpose |
|---|---|
| `BasicNepaliCalendar` | The library itself |
| `NUnitTestProj` | NUnit tests |
| `Examples` | Runnable console examples (`dotnet run --project Examples`) |

## Contributing

Bug reports and pull requests are welcome, especially:

- Corrections to month-length data (please include a source, such as the official government calendar)
- Support for more years
- Additional formatting options (Nepali month and weekday names, Nepali numerals)

Please open an [issue](https://github.com/koolkabin/NepaliCalendarCore/issues) first for larger changes.

## Changelog

See [GitHub Releases](https://github.com/koolkabin/NepaliCalendarCore/releases) for version history.

## Author

**Kabindra Bakey** ([@koolkabin](https://github.com/koolkabin))
Email: koolkabin@live.com

## License

Released under the [MIT License](LICENSE).
