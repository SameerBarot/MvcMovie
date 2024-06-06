2024-05-16 
Sameerkkumar Barot

1331 UTC

Web app create w/ VS2022 .NET'/
No auth........
SSL cert SH-1

1335 UTC
Ran the program, confiremed that web page open properly without any error.
https://localhost:7134/

I just go Views>Home>index.cshtml and change header welcome with "MvcMovies"
and ran program in 3 differnt browsers Chrome,Firefox and Ms edge.
Completed part 1

1349 UTC
 
Completed part 2
after successfully ran part 1 and moving forward to Add controllers MvcMovies>Controllers>MvcMovies.cs

	//What is Controllers ?
		Classes that:
		Handle browser requests.
		Retrieve model data.
		Call view templates that return a response.
	i Create new controller "MvcMovie.cs"
	add namespace MvcMovie.controller
	and i used public method in controller because it can handle incoming HTTP and HTTPS request.I tried other method like Private and Projected that are not meant to handle HTTP requests. 
    from online resources private and projected methods are used for internal logic and helper functions.

	I Created two public string "Index" and "welcome"
	and ran URL:https://localhost:7134/HelloWorld/welcome
	and make sure confirm again 

1430 UTC

	Now i tried to modify a code and pass some parameter information from the URl
	i created Public string Welcome and add 2 parameters
		string "name"
		integer "numTimes"
	and this time i used HtmlEncoder to encode protentially dangerous characters in user input,avoid XSS attacks and Java code injections.
	
1443 UTC

	now i ran a code and it did not work, i got some error	
	i checked again code
	i found that i could run "https://localhost:7134/HelloWorld/welcome" this url properly but with parameters i got some error.
	and i solve that error that was spelling mistake of URL and i could ran following url
	"https://localhost:7134/HelloWorld/welcome?name=Sam&numtimes=4"
	and got output. further more i tried different values for name and numtimes in URL

1445 UTC
	completed part 2.
	Break time.

1502 UTC
	i just started Part 3 that edit views part.

1526 UTC
	i do some modifications and add title "this is our Movie app"
1530 UTC
	Right-click on the Views folder, and then Add > New Folder and name the folder HelloWorld.

Right-click on the Views/MvcMovies folder, and then Add > New Item.
Views/Shared/_Layout.cshtml
Open the Views/Shared/_Layout.cshtml file.
In the Add New Item - MvcMovie dialog:
	I tried to change layout of web page
	add header "h2"
	create _Layout.cshtml
2024-21-05
	1536 UTC
	did some changes in _Layout.cshtml
		Three occurrences of MvcMovie to Movie App.
	The anchor element <a class="navbar-brand" asp-area="" asp-controller="Home" asp-action="Index">MvcMovie</a> to <a class="navbar-brand" asp-controller="MvcMovies" asp-action="Index">Movie App</a>.
	 ran code and go on this url "https://localhost:7134/HelloWorld"
	 successfully ran that url and diskplay content.

	 1541 UTC
	 Passing Data from the Controller to the View;
	 In HelloWorldController.cs, change the Welcome method to add a Message and NumTimes value to the ViewData dictionary.
	 The ViewData dictionary is a dynamic object, which means any type can be used. The ViewData object has no defined properties until something is added

	 1548 UTC
	 i created Welcome.cshtml.Edit code and change some data in Homecontroller.cs and try to ran web page but i cannot open. i found http erro 404 

	 1851 UTC
	 i change a color of nav-bar and change font color.
	 try to add some new feature like search and add new css for new look	

	 1948 UTC 
	 Passing Data from the Controller to the View
	 to solve error move Welcome.cs file to view/shared folder
	 and successfully ran following URL:
	 https://localhost:7134/HelloWorld/Welcome?name=Rick&numtimes=4
	  and print "Welcome
				Hello Rick
				Hello Rick
				Hello Rick
				Hello Rick" this.
	successfully completed part 3.

2024-05-23 1225 UTC
	start part 4 to create model.

	1244 UTC
	Add a data model
	create Movie.cs and movie class contain ID	field,which is required	the database for primary key.
	update Model/Movies.cs
	
	1350 UTC
	i Complete the Add MVC Controller with views, using Entity Framework dialog
	In the Model class drop down, I selected Movie (MvcMovie.Models)
	in database type i selected SQL server and created MovieController.cs

	1420 UTC
		
	from tools > NuGet Package manager > Package Manager Console
	i ran command Add-Migration InitialCreate for  Generates a Migrations/{timestamp}_InitialCreate.cs migration file.
	The InitialCreate argument is the migration name. Any name can be used, but by convention, a name is selected that describes the migration. Because this is the first migration, the generated class contains code to create the database schema. The database schema is based on the model specified in the MvcMovieContext class.
	i ran command Update-Database for  Updates the database to the latest migration, which the previous command created.
	This command runs the Up method in the Migrations/{time-stamp}_InitialCreate.cs file, which creates the database.

	1430 UTC 

	 i Examined the generated database context class and registration
	 i Scaffolding created the Data/MvcMovieContext.cs database context class
	 The database context is derived from Microsoft.EntityFrameworkCore.DbContext and specifies the entities to include in the data model.
	
	
	1518 UTC
	
	Migration time: 2024-05-23 1226 UTC
	Migration File:20240523181226_InitialCreate

	2024-05-30 1320 UTC
	
	i tried to Add rating colomn in table and rating.
	I tried to Add search option.

	1340 UTC
	Created new migration file (20240530151239_Rating.cs) for Rating feature and add it.
	bind with front end and add check it in database rating colomn was their or not.
	successfully add search and rating feature in site.

	if i searched by name  something it showed in url
	URL:https://localhost:7134/Movies?genre=&search=spider
	Search by filter URL:https://localhost:7134/Movies?genre=action&search=
	https://localhost:7134/Movies?genre=action&search=superman

	i tried all three type of filter and search and it worked fine.

	1350 UTC 
	i deleted all old movie list and add new movies and add rating and check filter feature and it was working properly.
	
	1420 UTC
	In the MVC Movie App, I added validation rules to the Movie model using the `DataAnnotations` namespace. These rules are applied declaratively to class properties:

	- `Required` and `MinimumLength` attributes ensure that properties have values, but do not prevent white space.
	- `RegularExpression` limits input characters. For "Genre", only letters are allowed with the first letter uppercase, while "Rating" requires an uppercase initial but allows special characters and numbers.
	- `Range` constrains numeric values within specified limits.
	- `StringLength` sets maximum and optionally minimum lengths for string properties.
	- `DataType` is used for formatting but not validation.

Value types like `decimal`, `int`, `float`, and `DateTime` are inherently required. These validation rules, enforced by ASP.NET Core, enhance app robustness by preventing invalid data from entering the database.
	
	1440 UTC 
	i successfully add new feature that is validation of entries from form.
	