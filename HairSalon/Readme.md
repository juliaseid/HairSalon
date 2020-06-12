# _Hair Salon Management_

#### _Epicodus Project May 29, 2020_

#### By _**Julia Seidman**_


## Description

_A project to introduce MySQL in integration with the .NET Core framework with ASP.NET CORE MVC and MSBuild through a mock website for a hair salon to manage stylists and client relationships. This lesson serves as a reference for configuring, building, and launching web applications in C# with a SQL database backend. Dynamic sites using forms and views are explored with a web utility allowing users to add new stylists and clients to the hair salon's book of business._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Install MySQL on your computer if you do not already have it.
3. Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
4. In your terminal, navigate to the project directory and run the commands dotnet restore and dotnet build to download dependencies and build the configuration.
5. To create the MySQL database and appropriate tables, log in to your MySQL installation through your terminal.
6. Enter the following command:
    ```CREATE database julia_seidman```
7. If you want to upload the database from your cloned repository into MySQL, use the following command:
    ```mysql -u root -p [julia_seidman] < *filepath to where you saved database julia_seidman```
8. Otherwise, you can create the tables directly.  Enter the following sequence of MySQL commands:
    ```USE julia_seidman```
    ```ADD TABLE clients (ClientId INT NOT NULL AUTO_INCREMENT, FirstName VARCHAR(255), LastName VARCHAR(255) NOT NULL, Phone VARCHAR(255) NOT NULL, StylistId INT NOT NULL, Birthday DATETIME, ClientSince DATETIME, PRIMARY KEY (ClientId));```
    ```ADD TABLE stylists (StylistId INT NOT NULL AUTO_INCREMENT, Name VARCHAR(255) NOT NULL, Days VARCHAR(255), Monday TINYINT(1), Tuesday TINYINT(1), Wednesday TINYINT(1), Thursday TINYINT(1), Friday TINYINT(1), Saturday TINYINT(1), Sunday TINYINT(1), PRIMARY KEY(StylistId) );```
8. The application was created with MySQL login information in an appsettings.json file that was not uploaded to GitHub for security reasons.  To run the application locally, you will need to create your own appsettings.json file in the project root directory, following this format:
```{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=YOUR PORT NUMBER HERE;database=DATABASE NAME AS YOU SAVED IT;uid=YOUR USER ID HERE;pwd=YOUR PASSWORD HERE;"
  }
}
```
9. To launch the application in your browser, from the project directory in your terminal, enter ```dotnet run``` and open a browser page at localhost:5000.

## Known Bugs

There are no known bugs at the time of this update.

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue] here on GitHub._

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MySQL
* Entity Framework
* MSBuild
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Site allows salon owner to see a list of all stylists** | User Input: "View Stylists" | Output: "Your Stylists: Sam, Sammy, Sampson" |
| **Site allows salon owner to select a stylist and see details, including a list of clients** | User Input: "Sandy" | Output: Sandy Simpson: Monday, Tuesday, Wednesday, Saturday, Sunday, Clients: Peter Piper, Paul Santos, Mary Lamb|
| **Form allows salon owner create new stylists** | User Input:"Cindy, Thursday, Friday, Saturday" | Output: "Cindy works on Thursday, Friday and Saturday"|
| **Form allows salon owner to add new clients with a specific stylist** | User Input: Uri LeHaire, 425-222-2255, Cindy | Output: "Uri LeHaire's stylist is Cindy |
| **Site displays clients in order by length of relationship with salon when viewing all clients | User Input: "See All Clients" | Client list ordered by length of client relationship |



### License
This software is licensed under the MIT license.

Copyright (c) 2020 **_Julia Seidman_**