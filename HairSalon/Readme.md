# _Hair Salon Management_

#### _Epicodus Project May 29, 2020_

#### By _**Julia Seidman**_


## Description

_A project to introduce MySQL in integration with the .NET Core framework with ASP.NET CORE MVC and MSBuild through a mock website for a hair salon to manage stylists and client relationships. This lesson serves as a reference for configuring, building, and launching web applications in C# with a SQL database backend. Dynamic sites using forms and views are explored with a web utility allowing users to add new stylists and clients to the hair salon's book of business._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. Run the commands dotnet restore, dotnet build, and dotnet run to download dependencies, build the configuration, and run the program in your local browser.

## Known Bugs

There are no known bugs at the time of this update.

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue] here on GitHub._

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MySQL
* MSBuild
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Site allows salon owner to see a list of all stylists** | User Input: "View Stylists" | Output: "Your Stylists: Sam, Sammy, Sampson" |
| **Site allows salon owner to select a stylist and see details, including a list of clients** | User Input: "Sandy" | Output: Sandy Simpson: Monday, Tuesday, Wednesday, Saturday, Sunday, Clients: Peter Piper, Paul Santos, Mary Lamb|
| **Form allows salon owner create new stylists** | User Input:"Cindy, Thursday, Friday, Saturday" | Output: "Cindy works on Thursday, Friday and Saturday"|
| **Form allows salon owner to add new clients with a specific stylist** | User Input: Uri LeHaire, 425-222-2255, Cindy | Output: "Uri LeHaire's stylist is Cindy |


### License
This software is licensed under the MIT license.

Copyright (c) 2020 **_Julia Seidman_**