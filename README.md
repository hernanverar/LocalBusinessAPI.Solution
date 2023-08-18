# LocalBusiness.Solution


## By Hernan Verar

# Description 
A ASP.NET Core Web API that gets list of restaurants.  User can update,edit and delete from both Restaurants and Shops databases.  User can generate access token for already created user in the db.  Performing a POST call in either swagger or POSTMAN.

## Technologies Used
* C#
* Dot Net 6.0
* Markup
* Git
* ASP.NET MVC
* CSS
* HTML5
* Microsoft EntityFramework Core
* Swagger
* JWT

## Setup/Installation Req's:

### Set Up and Run Project
1. Clone this repo. https://github.com/hernanverar/LocalBusinessAPI.Solution.git
2. Open the terminal and navigate to this project's production directory called "Factory".
3. Complete setup/Installation instructions:
4. Clone repository to your desktop 
5. CD to the Directory: LocalBusinessApi
6. While in the current directory [LocalBusinessApi]  
7. Create appsettings.json file ![example for appsettings file](appsettings_image.png)
8. Replace the following values shown in image with: 
9. [securitykey]: your security key
10. [YOUR-DB-NAME]: database included in project
11. [YOUR-USER-HERE]: with your username
12. [YOUR-PASSWORD-HERE]: with your password
13. Create anohter file called: appsettings.Development.json ![example for appsettings development file] (appsettings_development.png) 
* Enter in command: 'dotnet ef database update'
* Add the appsettings.json and appsettings.Development.json file to .gitignore.
* To view web application. Run commands: dotnet watch run 
* Open the browser, go to https://localhost:5001
# Further Exploration:
* Open browser to launch _https://localhost:5001/swagger
* Go to User Post section, click the 'Try it Out' button. 
* Replace the strings with "admin" and "password" to generate token. 
* Copy generated token, open Postman
* Make a GET call in Postman. 
* Enter http://localhost:5000/api/Restaurants
* In the Headers options enter "Authorization" for the Key field. 
* In the value field enter: "bearer [Generated Token From Swagger]", Click Send


5. Run ```dotnet watch run``` to view the project in your web browser. Enter your computer password when prompted.


### Set up the Databases

In your terminal- in the project directory (LocalBusinessAPI.Solution/LocalBusinessApi), run ```dotnet ef database update```

# Local Business API ENDPOINTS:
* GET - http://localhost:5000/api/Restaurants/ for all the restaurants
* GET - http://localhost:5000/api/Restaurants{id} for a specific restaurant
* POST http://localhost:5000/api/Restaurants/ to create a new restaurant 
* POST http://localhost:5000/api/Restaurants/ to create a new restaurant 
* POST http://localhost:5000/api/Restaurants/ to create a new restaurant 

# Known bugs: 
  Swager not responding WIP

# License; MIT License

Copyright (c) [2023] [Hernan Verar]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NON INFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
