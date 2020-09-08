# .NET Core 3.1 REST API using [AdventureWorks DB 2014]


Sample implementation of a REST API using day to day concepts with .NET Core 3.1

## Implementation Details

### Entity Framework (EF)

Using EF Core 3.1.x as our Object-Relational Mapping / Persistence Framework.

In order to use Database First approach (since we are using a Sample DB) we run the following command from the AdventureWorks.Data folder

dotnet ef dbcontext -s ..\AdventureWorks.API\AdventureWorks.API.csproj scaffold Name=AdventureWorksDb Microsoft.EntityFrameworkCore.SqlServer -o Entities --context-dir Context -c AdventureWorksContext -f

dotnet ef dbcontext
-s
	By doing this we specify the start up project that will be used, this is very helpful since in a real world scenario we will separate our API from our DB project

scaffold Name=AdventureWorksDb
	This will tell ef to use Database first approach and use the Connection String "AdventureWorksDb" which lives in our start up project

Microsoft.EntityFrameworkCore.SqlServer
	This will specified EF which provider will be used
	
-o Entities
	This will specified EF the Output folder from the current location

--context-dir Context
	If we want to create your DBContext in a different folder we set this options and provided the folder name
	
-c AdventureWorksContext
	This will represent our DBContext name that will be used
	
 -f
	And by setting this option we will tell EF to generate the classes even if there is already a file in the specified output folder

![EF](/Images/EF.JPG)
![EF Output](/Images/EF_Output.JPG)

### [Repository Pattern]

Sample implementation of [Repository Pattern] defined by Mosh Hamedani

- A Repository mediates between the domain and data mapping layers, acting like an **in-memory collection** of domain objects.
- Minimizing duplicate query logic by the basic encapsulation principle.
- Promotes testability.

A change that I made for this .NET Core implementation was to take off Unit of Work, since we don't want new up anything in our application I decided to take that extra layer of complexity.

Another improvement was the fact that this new repository will be running asynchronously.

[Repository](https://github.com/sanchez-franco/AdventureWorks/blob/c2853d4ef3a9b1e77d951fc4077a9049be0ea868/AdventureWorks.Data.Repository/Repository.cs#L9)

![Repository Pattern](/Images/Repository_Pattern.JPG)

**NOTE: A current issue that I encounter using EF is the [N + 1 Problem]. Please make sure when you create your queries to address this issue.** 

![N + 1 Problem](/Images/N+1.JPG)

### Using [AutoMapper] to return map our DB entities to our model

AutoMapper will solve the fact of manually mapping classes that are very similar to each other, and having an specific location of these configurations that we can reuse.

We do it by a couple of simple steps:

- First thing we do is creating a new class that inherits from AutoMapper.Profile, this class will contain our mappings configurations that our application will use.
![AutoMapper Profile](/Images/AutoMapper_Profile.JPG)

- After that we will go to our API Configure Services and we add automapper by using the extension method and providing the assembly that contains our mapping profiles.
![AutoMapper Configuration](/Images/AutoMapper_Configuration.JPG)

### Dependency Injection Pattern (DI)

- By definition, Dependency Injection (DI) is an object-oriented programming design pattern that allows us to develop loosely coupled code.
- This is accomplished by the Inversion of Control principle (IoC), the flow depends on the defined abstractions to be implemented that is built up during program execution.
- We use out of the box containers in our Web API project to configure this as follows.

![DI](/Images/DI.JPG)

### JWT Authentication

Sample implementation of [ASP.NET Core 3.1 API - JWT Authentication with Refresh Tokens] by Jason Watmore

Screenshots to call our Web API using [Postman]

- Authenticating to our API and validating the user with our DB.

*Success*
![JWT Token](/Images/Auth_Success.JPG)

*Failure*
![Get Token](/Images/Auth_Failure.JPG)

- Using our token to call crud methods in our Web API.

![CrudMethods](/Images/Crud_Methods.JPG)

![Use Token](/Images/Use_Token.JPG)

- Using configure services to make all controllers protected

![Auth Filter](/Images/Auth_Filter.JPG)

### API Versioning

Since the nature of the development and business change, versioning in an API is a MUST in every single case.

![API Versioning](/Images/API_Versioning.JPG)

We need to make sure we never break any integrations to our APIs and in order to do this we can implement versioning in a couple of simple steps:

Specifying a default version even if the user doesn't do it it's always a good practice, we can accomplish this by setting the following flags
![API Default Versioning](/Images/API_Default_Versioning.JPG)

As you can see the user didn't specify any version and he still able to consume your API
![API V1](/Images/API_V1.JPG)

As and example on how we can change behaviors with the same endpoint with different version we can compare both results using different versions
![API V2](/Images/API_V2.JPG)

We can also specifies how the user will need to supply the version number in their request
![API Versioning Methods](/Images/API_Versioning_Methods.JPG)

A way to set which controllers and/or methods has which versions we will be using the conventions options

Please noticed that in this same conventions I specified the Get method that the user will get for Version 1.0 and 2.0
![API Versioning Conventions](/Images/API_Versioning_Conventions.JPG)

### Unit Testing

- I've created a small Unit Test project to check our validation process on the Authentication Service and the Person Service.
- There are a bunch of frameworks to do this, currently I use [Moq] to be able to Mock our abstractions and using xUnit as the test framework.
- All of this can be accomplished since we used abstractions in our N-Tier Application, which made our code not tightly coupled.
- One big improvement from my previous implementation was to add negative tests as well.

![Unit Test](/Images/Unit_Test.JPG)
![Test Results](/Images/Test_Results.JPG)

[AutoMapper]: https://automapper.org
[Moq]: https://github.com/moq/moq4
[Postman]: https://learning.getpostman.com/docs/postman/sending_api_requests/authorization
[Repository Pattern]: https://programmingwithmosh.com
[AdventureWorks DB 2014]: https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks
[N + 1 Problem]: http://blogs.microsoft.co.il/gilf/2010/08/18/select-n1-problem-how-to-decrease-your-orm-performance
[ASP.NET Core 3.1 API - JWT Authentication with Refresh Tokens]: https://jasonwatmore.com/post/2020/05/25/aspnet-core-3-api-jwt-authentication-with-refresh-tokens#refresh-token-cs