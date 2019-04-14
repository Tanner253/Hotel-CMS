

# ***Async Inn
---------------------------------
---------------------------------

# Project = AsyncInn
---------------------------------
## We are deployed on Azure!

https://asyncinnt253.azurewebsites.net

---------------------------------
## Web Application

The web application consists of a frontend written in Razor views, HTML, CSS,
Bootstrap. The backend was written in C# using ASP.NET Core 2, Entity Framework Core, and the MVC framework.

This application allows you to seamlisly navigate the website withought any issues andselect hotels based on amenities 
room availability, price, and much more! these hotels allow the user to save their input and changes to the webpage
you should use this application bevause it allows the manager of a hotel to efficiently and easily manage 
their hotel.

---------------------------------

## Tools Used
Microsoft Visual Studio Community 2017 (Version 15.5.7)

- C#
- ASP.Net Core
- Entity Framework
- MVC
- xUnit
- Bootstrap
- Azure

---------------------------------

## Recent Updates

#### V 1.0
Deployment

## Getting Started

Clone this repository to your local machine.
```
$ git clone https://github.com/YourRepo/AsyncInn.git
```
Once downloaded, you can either use the dotnet CLI utilities or Visual Studio 2017 (or greater) to build the web application. The solution file is located in the AmandaFE subdirectory at the root of the repository.
```
cd YourRepo/YourProject
dotnet build
```
The dotnet tools will automatically restore any NuGet dependencies. Before running the application, the provided code-first migration will need to be applied to the SQL server of your choice configured in the /AmandaFE/AmandaFE/appsettings.json file. This requires the Microsoft.EntityFrameworkCore.Tools NuGet package and can be run from the NuGet Package Manager Console:
```
Update-Database
```
Once the database has been created, the application can be run. Options for running and debugging the application using IIS Express or Kestrel are provided within Visual Studio. From the command line, the following will start an instance of the Kestrel server to host the application:
```
cd YourRepo/YourProject
dotnet run
```
Unit testing is included in the AmandaFE/FrontendTesting project using the xUnit test framework. Tests have been provided for models, view models, controllers, and utility classes for the application.

---------------------------------

## Usage

### Overview of Recent Posts
![Overview of Recent Posts](https://via.placeholder.com/500x250)

### Creating a Post
![Post Creation](https://via.placeholder.com/500x250)

### Enriching a Post
![Enriching Post](https://via.placeholder.com/500x250)

### Viewing Post Details
![Details of Post](https://via.placeholder.com/500x250)

---------------------------
## Data Flow (Frontend, Backend, REST API)
***[Add a clean and clear explanation of what the data flow is. Walk me through it.]***
![Data Flow Diagram](/assets/img/Flowchart.png)

---------------------------
## Data Model

### Overall Project Schema
***[Add a description of your DB schema. Explain the relationships to me.]***
![Database Schema](/assets/img/ERD.png)

---------------------------
## Model Properties and Requirements

### Blog

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| Amenity | string | YES |
| HotelID | int| YES |
| HotelRoom | hotelroomID | yes |
| RoomID | int | yes |
| Room Layout | enum | YES |
| Name | string(s) | Yes |
| Room number | ints | Yes |
| Date | date/time object | YES |


---------------------------

## Change Log
1.0 Deploys site

------------------------------

## Authors
Tanner Percival

------------------------------
