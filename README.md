# LocalBusiness.Solution


## By Hernan Verar

# Description 
A ASP.NET Core Web API that gets list of restaurant and shops.  User can update,edit and delete from both Restaurants and Shops databases.  User can generate access token for already created user in the db.  Performing a POST call in either swagger or POSTMAN.

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
1. Clone this repo. https://github.com/hernanverar/Dr_SillyStringz-s.Solution.git
2. Open the terminal and navigate to this project's production directory called "Factory".
3. Within the production directory "LocalBusinesApi", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

5. Run ```dotnet watch run``` to view the project in your web browser. Enter your computer password when prompted.


### Set up the Databases

In your terminal- in the project directory (LocalBusinessAPI.Solution/LocalBusinessApi), run ```dotnet ef database update```





# License; MIT License

Copyright (c) [2023] [Hernan Verar]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NON INFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.