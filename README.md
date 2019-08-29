# Project

### By Jessica Munoz, Joseph Tubridy, Saswati Patra

#### _A web application to connect to LibraryApi and record authors and. - August 29th, 2019_

---

## Description

Library API with many-to-many relationship between author and book. This website connects to the LibraryMvc but you can view full CRUD functionality on the swagger UI listed below as well.

## Technologies Used

- C#
- .NET
- EntityFrameworkCore
- MySQL
- MySQLWorkBench
- MySqlConnector
- Razor
- Swagger with Swashbuckle

## Installation

- Install .NET locally if it isn't already installed
- Open the terminal, clone down this repository.
- Via the terminal, navigate to the project folder LibraryApi
  - Enter the command: dotnet restore
  - Enter the command: dotnet ef database update
  - Enter the command: dotnet run
- To review the API documentation:
  - Browse to http://localhost:5000/swagger/v1/swagger.json
- To utilize the CRUD functionality:
  - Browse to http://localhost:5000/swagger

## Specs

| Behaviors                              |                                                                  Input                                                                   |                       Output                       |
| -------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------: | :------------------------------------------------: |
| User can add a new author or book.         |                                 User clicks "POST" and "Try it out", edits fields and clicks "Execute".                                  |             New author or book is created.             |
| User can read all authors or books.        |                                             User clicks "GET", "Try it out", and "Execute".                                              |            All authors or books are listed.            |
| User can read a specific author or book.   |            User clicks "GET/ ... /{id}", "Try it out", enters the id of a previously created book or author and clicks "Execute".            | The author or book associated with that id is listed.  |
| User can update a specific author or book. | User clicks "PUT/ ... /{id}", "Try it out", enters the id of a previously created book or author, edits the properties and clicks "Execute". | The author or book associated with that id is updated. |
| User can delete a specific author or book. |          User clicks "DELETE/ ... /{id}", "Try it out", enters the id of a previously created book or author and clicks "Execute".           | The author or book associated with that id is deleted. |
---



## Known Bugs

- No known bugs at this time.

## Support and contact details

_Please contact Jessica, Joseph or Saswati with questions and comments._

### License

_GNU GPLv3_

Copyright (c) 2019 **_Jessica Munoz_**